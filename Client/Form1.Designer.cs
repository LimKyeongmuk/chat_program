namespace Client
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSendText = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.textBoxNickName = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PortNumTxtbox = new System.Windows.Forms.TextBox();
            this.btnXml = new System.Windows.Forms.Button();
            this.MIPAddressTxtbox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnSendText
            // 
            this.btnSendText.Location = new System.Drawing.Point(336, 314);
            this.btnSendText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSendText.Name = "btnSendText";
            this.btnSendText.Size = new System.Drawing.Size(127, 18);
            this.btnSendText.TabIndex = 0;
            this.btnSendText.Text = "send Message";
            this.btnSendText.UseVisualStyleBackColor = true;
            this.btnSendText.Click += new System.EventHandler(this.btnSendText_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(35, 143);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(428, 153);
            this.textBox1.TabIndex = 1;
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(35, 311);
            this.textBoxMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(281, 21);
            this.textBoxMessage.TabIndex = 2;
            this.textBoxMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMessage_KeyUp);
            // 
            // textBoxNickName
            // 
            this.textBoxNickName.Location = new System.Drawing.Point(130, 74);
            this.textBoxNickName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNickName.Name = "textBoxNickName";
            this.textBoxNickName.Size = new System.Drawing.Size(155, 21);
            this.textBoxNickName.TabIndex = 3;
            this.textBoxNickName.TextChanged += new System.EventHandler(this.textBoxNickName_TextChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(304, 73);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(159, 18);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "connect to Server";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chat Name";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(304, 97);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(159, 18);
            this.btnDisconnect.TabIndex = 6;
            this.btnDisconnect.Text = "disconnect to Server";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "PORT";
            // 
            // PortNumTxtbox
            // 
            this.PortNumTxtbox.Location = new System.Drawing.Point(314, 30);
            this.PortNumTxtbox.Name = "PortNumTxtbox";
            this.PortNumTxtbox.Size = new System.Drawing.Size(149, 21);
            this.PortNumTxtbox.TabIndex = 10;
            this.PortNumTxtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PortNumTxtbox_KeyPress);
            // 
            // btnXml
            // 
            this.btnXml.Location = new System.Drawing.Point(304, 120);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(159, 18);
            this.btnXml.TabIndex = 11;
            this.btnXml.Text = "read XML";
            this.btnXml.UseVisualStyleBackColor = true;
            this.btnXml.Click += new System.EventHandler(this.btnXml_Click);
            // 
            // MIPAddressTxtbox
            // 
            this.MIPAddressTxtbox.Location = new System.Drawing.Point(84, 30);
            this.MIPAddressTxtbox.Mask = "000.000.000.000";
            this.MIPAddressTxtbox.Name = "MIPAddressTxtbox";
            this.MIPAddressTxtbox.Size = new System.Drawing.Size(136, 21);
            this.MIPAddressTxtbox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 353);
            this.Controls.Add(this.MIPAddressTxtbox);
            this.Controls.Add(this.btnXml);
            this.Controls.Add(this.PortNumTxtbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.textBoxNickName);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSendText);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.TextBox textBoxNickName;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PortNumTxtbox;
        private System.Windows.Forms.Button btnXml;
        private System.Windows.Forms.MaskedTextBox MIPAddressTxtbox;
    }
}

