using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Xml;

namespace Server
{
    public partial class Form1 : Form
    {
        TcpListener server = null; // 서버
        bool server_on = false;
        TcpClient clientSocket = null; // 소켓
        static int counter = 0; // 사용자 수
        string date; // 날짜
        // 각 클라이언트마다 리스트에 추가
        public Dictionary<TcpClient, string> clientList = new Dictionary<TcpClient, string>();

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            IPAddressTxtbox.Text = GetLocalIP();
        }

        private void InitSocket()
        {
            try{
                server = new TcpListener(IPAddress.Any, Convert.ToInt32(PortNumTxtbox.Text)); // 서버 접속 IP, 포트
                clientSocket = default(TcpClient); // 소켓 설정
                server.Start(); // 서버 시작
                server_on = true;
                DisplayText(">> Server Started");
    
                while (true)
                {
                   try
                   {
                        counter++; // Client 수 중가
                        clientSocket = server.AcceptTcpClient(); // client 소켓 접속 허용

                        NetworkStream stream = clientSocket.GetStream();
                        byte[] buffer = new byte[1024]; // 버퍼
                        int bytes = stream.Read(buffer, 0, buffer.Length);
                        string user_name = Encoding.Unicode.GetString(buffer, 0, bytes);
                        user_name = user_name.Substring(0, user_name.IndexOf("$")); // client 사용자명

                        string message = "OK";
                        if (clientList.ContainsValue(user_name))
                        { 
                            message = "Overlap";
                            buffer = Encoding.Unicode.GetBytes(message);

                            stream.Write(buffer, 0, buffer.Length); // 버퍼 쓰기
                            stream.Flush();
                            buffer = null;
                            counter--;

                            continue;
                        }
                        else
                        {
                            buffer = Encoding.Unicode.GetBytes(message);
                            stream.Write(buffer, 0, buffer.Length); // 버퍼 쓰기
                            stream.Flush();
                        }

                        DisplayText(">> Accept connection from client");
                        clientList.Add(clientSocket, user_name); // client 리스트에 추가
                        /*
                        string message2 = "OK";
                        buffer = Encoding.Unicode.GetBytes(message2);

                        stream.Write(buffer, 0, buffer.Length); // 버퍼 쓰기
                        stream.Flush();
                        buffer = null;
                        */
                        SendMessageAll(user_name + "님이 입장하였습니다", "", false); // 모든 client에게 메세지 전송
                        handleClient h_client = new handleClient(); // 클라이언트 추가
                        h_client.OnReceived += new handleClient.MessageDisplayHandler(OnReceived);
                         h_client.OnDisconnected += new handleClient.DisconnectedHandler(h_client_OnDisconnected);
                        h_client.startClient(clientSocket, clientList);

                        // 두 개의 thread의 충돌을 피하기 위해서 Invoke 사용해서 cross thread 호출 처리
                        this.Invoke(new Action(delegate () { listBoxClient.Items.Add(user_name); }));
                    }
                    catch (SocketException) { break; }
                    catch (Exception) { break; }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("포트번호가 올바르지 않습니다");
            }
            catch (SocketException)
            {
                MessageBox.Show("서버가 이미 실행중입니다");
            }
        }

        void h_client_OnDisconnected(TcpClient clientSocket) // client 접속 해제 핸들러
        {
            if (clientList.ContainsKey(clientSocket))
            {
                clientList.TryGetValue(clientSocket, out string user_name);
                this.Invoke(new Action(delegate () { listBoxClient.Items.Remove(user_name); }));

                try
                {
                    NetworkStream stream = clientSocket.GetStream();
                    byte[] buffer = null;

                    string message = "clientEnd";
                    buffer = Encoding.Unicode.GetBytes(message);

                    stream.Write(buffer, 0, buffer.Length); // 버퍼 쓰기
                    stream.Flush();

                    clientSocket.Close();
                    clientList.Remove(clientSocket);

                    counter--;
                }
                catch
                {
                    MessageBox.Show("클라이언트 없음");
                }
            }
        }

        private void OnReceived(string message, string user_name) // client로부터 받은 데이터
        {
            if (message.Equals("leaveChat"))
            {
                string displayMessage = "leave user : " + user_name + "\n";
                DisplayText(displayMessage); // Server단에 출력
                SendMessageAll("leaveChat", user_name, true); // 모든 Client에게 전송
                clientSocket = clientList.FirstOrDefault(x => x.Value == user_name).Key;
                h_client_OnDisconnected(clientSocket);
            }
            else
            {
                string displayMessage = user_name + " : " + message + "\n";
                DisplayText(displayMessage); // Server단에 출력
                SendMessageAll(message, user_name, true); // 모든 Client에게 전송
            }
        }
        
        public void SendMessageAll(string message, string user_name, bool flag)
        {
            foreach (var pair in clientList)
            {
                date = DateTime.Now.ToString("yyyy.MM.dd. HH:mm:ss"); // 현재 날짜 받기

                TcpClient client = pair.Key as TcpClient;
                NetworkStream stream = client.GetStream();
                byte[] buffer = null;

                if (flag)
                {
                    if (message.Equals("leaveChat"))
                        buffer = Encoding.Unicode.GetBytes(user_name + " 님이 대화방을 나갔습니다");
                    else if (message.Equals("ServerEnd"))
                        buffer = Encoding.Unicode.GetBytes(message);
                    else
                        buffer = Encoding.Unicode.GetBytes("[" + date + "] " + user_name + " : " + message);
                }
                else
                {
                    buffer = Encoding.Unicode.GetBytes(message);
                }

                stream.Write(buffer, 0, buffer.Length); // 버퍼 쓰기
                stream.Flush();
            }
        }

        private void DisplayText(string text) // Server 화면에 출력
        {
            if (textBox1.InvokeRequired)
            {
                textBox1.BeginInvoke(new MethodInvoker(delegate { textBox1.AppendText(text + Environment.NewLine); }));
            }
            else
                textBox1.AppendText(text + Environment.NewLine);
        }

        private void btnServerOn_Click(object sender, EventArgs e)
        {
            // thread 생성
            Thread t = new Thread(InitSocket);
            t.IsBackground = true;
            t.Start();
        }

        private void btnServerOff_Click(object sender, EventArgs e)
        {
            try
            {
                SendMessageAll("ServerEnd", "Server", true);
                foreach (KeyValuePair<TcpClient, string> items in clientList)
                {
                    //items.Key.Close();
                }
                counter = 0;
                listBoxClient.Items.Clear();
                clientList.Clear();
                //clientSocket.Close(); // client 소켓 닫기
                if (!server_on)
                    MessageBox.Show("서버가 실행중이 아닙니다");
                else
                {
                    server.Stop(); // 서버 종료
                    server_on = false;
                    DisplayText(">> Server End");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("서버가 실행중이 아닙니다");
            }
        }
        
        private void btnDisconnectClient_Click(object sender, EventArgs e)
        {
            // ListBox에서 변경된 item값 읽어서 Key값 찾기
            try
            {
                clientSocket = clientList.FirstOrDefault(x => x.Value == this.listBoxClient.SelectedItem.ToString()).Key;
                h_client_OnDisconnected(clientSocket);
            }
            catch
            {
                MessageBox.Show("선택된 client가 없음");
            }
        }

        public string GetLocalIP()
        {
            string localIP = "Not available, please check your network seetings!";
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    localIP = ip.ToString();
                    break;
                }
            }
            return localIP;
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            if (PortNumTxtbox.Text == null)
            {
                MessageBox.Show("포트번호가 올바르지 않습니다");
            }
            else
            {
                using (XmlWriter wr = XmlWriter.Create(@"C:\Users\park\source\repos\Client\file.xml"))
                {
                    wr.WriteStartDocument();
                    wr.WriteStartElement("Connect");

                    wr.WriteAttributeString("port", PortNumTxtbox.Text);
                    wr.WriteAttributeString("IP", GetLocalIP());
                    wr.WriteEndElement();
                    wr.WriteEndDocument();
                }
            }
        }

        private void PortNumTxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자와 백스페이스를 제외한 나머지를 바로 처리
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                MessageBox.Show("숫자만 입력하세요");
                e.Handled = true;
            }
            this.PortNumTxtbox.MaxLength = 4;
        }
    }
}
