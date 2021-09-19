namespace Server
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnServerOn = new System.Windows.Forms.Button();
            this.btnServerOff = new System.Windows.Forms.Button();
            this.listBoxClient = new System.Windows.Forms.ListBox();
            this.btnDisconnectClient = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PortNumTxtbox = new System.Windows.Forms.TextBox();
            this.btnXml = new System.Windows.Forms.Button();
            this.IPAddressTxtbox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(10, 79);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(448, 263);
            this.textBox1.TabIndex = 0;
            // 
            // btnServerOn
            // 
            this.btnServerOn.Location = new System.Drawing.Point(476, 21);
            this.btnServerOn.Name = "btnServerOn";
            this.btnServerOn.Size = new System.Drawing.Size(97, 23);
            this.btnServerOn.TabIndex = 1;
            this.btnServerOn.Text = "Server ON";
            this.btnServerOn.UseVisualStyleBackColor = true;
            this.btnServerOn.Click += new System.EventHandler(this.btnServerOn_Click);
            // 
            // btnServerOff
            // 
            this.btnServerOff.Location = new System.Drawing.Point(579, 21);
            this.btnServerOff.Name = "btnServerOff";
            this.btnServerOff.Size = new System.Drawing.Size(97, 23);
            this.btnServerOff.TabIndex = 2;
            this.btnServerOff.Text = "Server OFF";
            this.btnServerOff.UseVisualStyleBackColor = true;
            this.btnServerOff.Click += new System.EventHandler(this.btnServerOff_Click);
            // 
            // listBoxClient
            // 
            this.listBoxClient.FormattingEnabled = true;
            this.listBoxClient.ItemHeight = 12;
            this.listBoxClient.Location = new System.Drawing.Point(476, 79);
            this.listBoxClient.Name = "listBoxClient";
            this.listBoxClient.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxClient.Size = new System.Drawing.Size(200, 220);
            this.listBoxClient.TabIndex = 4;
            // 
            // btnDisconnectClient
            // 
            this.btnDisconnectClient.Location = new System.Drawing.Point(476, 319);
            this.btnDisconnectClient.Name = "btnDisconnectClient";
            this.btnDisconnectClient.Size = new System.Drawing.Size(200, 23);
            this.btnDisconnectClient.TabIndex = 5;
            this.btnDisconnectClient.Text = "Disconnect Client";
            this.btnDisconnectClient.UseVisualStyleBackColor = true;
            this.btnDisconnectClient.Click += new System.EventHandler(this.btnDisconnectClient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "PORT";
            // 
            // PortNumTxtbox
            // 
            this.PortNumTxtbox.Location = new System.Drawing.Point(308, 21);
            this.PortNumTxtbox.Name = "PortNumTxtbox";
            this.PortNumTxtbox.Size = new System.Drawing.Size(150, 21);
            this.PortNumTxtbox.TabIndex = 9;
            this.PortNumTxtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PortNumTxtbox_KeyPress);
            // 
            // btnXml
            // 
            this.btnXml.Location = new System.Drawing.Point(476, 50);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(200, 23);
            this.btnXml.TabIndex = 10;
            this.btnXml.Text = "make XML";
            this.btnXml.UseVisualStyleBackColor = true;
            this.btnXml.Click += new System.EventHandler(this.btnXml_Click);
            // 
            // IPAddressTxtbox
            // 
            this.IPAddressTxtbox.BackColor = System.Drawing.SystemColors.Window;
            this.IPAddressTxtbox.Location = new System.Drawing.Point(67, 21);
            this.IPAddressTxtbox.Name = "IPAddressTxtbox";
            this.IPAddressTxtbox.ReadOnly = true;
            this.IPAddressTxtbox.Size = new System.Drawing.Size(152, 21);
            this.IPAddressTxtbox.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 360);
            this.Controls.Add(this.IPAddressTxtbox);
            this.Controls.Add(this.btnXml);
            this.Controls.Add(this.PortNumTxtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDisconnectClient);
            this.Controls.Add(this.listBoxClient);
            this.Controls.Add(this.btnServerOff);
            this.Controls.Add(this.btnServerOn);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnServerOn;
        private System.Windows.Forms.Button btnServerOff;
        private System.Windows.Forms.ListBox listBoxClient;
        private System.Windows.Forms.Button btnDisconnectClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PortNumTxtbox;
        private System.Windows.Forms.Button btnXml;
        private System.Windows.Forms.MaskedTextBox IPAddressTxtbox;
    }
}

