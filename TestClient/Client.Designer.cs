namespace TestClient
{
    partial class Client
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
            this.btnStart = new System.Windows.Forms.Button();
            this.textLog = new System.Windows.Forms.TextBox();
            this.textMsg = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textServer
            // 
            this.textServer.Location = new System.Drawing.Point(35, 45);
            this.textServer.Name = "textServer";
            this.textServer.Size = new System.Drawing.Size(168, 21);
            this.textServer.TabIndex = 0;
            this.textServer.Text = "192.168.180.49";
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(229, 45);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(41, 21);
            this.textPort.TabIndex = 1;
            this.textPort.Text = "50090";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(307, 39);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(72, 30);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "连接";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // textLog
            // 
            this.textLog.Location = new System.Drawing.Point(35, 89);
            this.textLog.Multiline = true;
            this.textLog.Name = "textLog";
            this.textLog.Size = new System.Drawing.Size(344, 155);
            this.textLog.TabIndex = 3;
            // 
            // textMsg
            // 
            this.textMsg.Location = new System.Drawing.Point(35, 263);
            this.textMsg.Multiline = true;
            this.textMsg.Name = "textMsg";
            this.textMsg.Size = new System.Drawing.Size(344, 142);
            this.textMsg.TabIndex = 4;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(307, 438);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 5;
            this.buttonSend.Text = "发送消息";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 497);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textMsg);
            this.Controls.Add(this.textLog);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.textServer);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textServer;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox textLog;
        private System.Windows.Forms.TextBox textMsg;
        private System.Windows.Forms.Button buttonSend;
    }
}

