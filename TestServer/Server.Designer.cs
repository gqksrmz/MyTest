namespace TestServer
{
    partial class Server
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textServer = new System.Windows.Forms.TextBox();
            this.textPort = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textLog = new System.Windows.Forms.TextBox();
            this.textMsg = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.combUsers = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textServer
            // 
            this.textServer.Location = new System.Drawing.Point(36, 49);
            this.textServer.Name = "textServer";
            this.textServer.Size = new System.Drawing.Size(100, 21);
            this.textServer.TabIndex = 0;
            this.textServer.Text = " 192.168.180.49";
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(171, 49);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(50, 21);
            this.textPort.TabIndex = 1;
            this.textPort.Text = "50090";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(285, 46);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "开始监听";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // textLog
            // 
            this.textLog.Location = new System.Drawing.Point(37, 107);
            this.textLog.Multiline = true;
            this.textLog.Name = "textLog";
            this.textLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textLog.Size = new System.Drawing.Size(434, 144);
            this.textLog.TabIndex = 3;
            // 
            // textMsg
            // 
            this.textMsg.Location = new System.Drawing.Point(41, 269);
            this.textMsg.Multiline = true;
            this.textMsg.Name = "textMsg";
            this.textMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textMsg.Size = new System.Drawing.Size(430, 149);
            this.textMsg.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(41, 461);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(289, 21);
            this.textBox5.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(351, 461);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "选择";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(455, 461);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "发送文件";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(351, 499);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 8;
            this.buttonSend.Text = "发送消息";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(455, 499);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "震动";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // combUsers
            // 
            this.combUsers.FormattingEnabled = true;
            this.combUsers.Location = new System.Drawing.Point(394, 46);
            this.combUsers.Name = "combUsers";
            this.combUsers.Size = new System.Drawing.Size(121, 20);
            this.combUsers.TabIndex = 10;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 534);
            this.Controls.Add(this.combUsers);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textMsg);
            this.Controls.Add(this.textLog);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.textServer);
            this.Name = "Server";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textServer;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textLog;
        private System.Windows.Forms.TextBox textMsg;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox combUsers;
    }
}

