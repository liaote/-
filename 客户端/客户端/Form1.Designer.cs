namespace 客户端
{
    partial class Form1
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
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtEnter = new System.Windows.Forms.TextBox();
            this.btnConnet = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbXian = new System.Windows.Forms.TextBox();
            this.txtMing = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEnter.Location = new System.Drawing.Point(362, 395);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(102, 46);
            this.btnEnter.TabIndex = 15;
            this.btnEnter.Text = "发送";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtEnter
            // 
            this.txtEnter.BackColor = System.Drawing.SystemColors.Window;
            this.txtEnter.Location = new System.Drawing.Point(9, 395);
            this.txtEnter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEnter.Multiline = true;
            this.txtEnter.Name = "txtEnter";
            this.txtEnter.Size = new System.Drawing.Size(342, 47);
            this.txtEnter.TabIndex = 14;
            this.txtEnter.WordWrap = false;
            // 
            // btnConnet
            // 
            this.btnConnet.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnConnet.Location = new System.Drawing.Point(396, 11);
            this.btnConnet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConnet.Name = "btnConnet";
            this.btnConnet.Size = new System.Drawing.Size(68, 21);
            this.btnConnet.TabIndex = 13;
            this.btnConnet.Text = "连接服务器";
            this.btnConnet.UseVisualStyleBackColor = true;
            this.btnConnet.Click += new System.EventHandler(this.btnConnet_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(220, 10);
            this.txtPort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(81, 21);
            this.txtPort.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "端口:";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(62, 10);
            this.txtIP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(112, 21);
            this.txtIP.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "IP地址：";
            // 
            // lbXian
            // 
            this.lbXian.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lbXian.Location = new System.Drawing.Point(9, 37);
            this.lbXian.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbXian.Multiline = true;
            this.lbXian.Name = "lbXian";
            this.lbXian.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lbXian.Size = new System.Drawing.Size(456, 343);
            this.lbXian.TabIndex = 18;
            this.lbXian.WordWrap = false;
            // 
            // txtMing
            // 
            this.txtMing.Location = new System.Drawing.Point(345, 10);
            this.txtMing.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMing.Name = "txtMing";
            this.txtMing.Size = new System.Drawing.Size(48, 21);
            this.txtMing.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 20;
            this.label3.Text = "名字:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(473, 453);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMing);
            this.Controls.Add(this.lbXian);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtEnter);
            this.Controls.Add(this.btnConnet);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "客户端";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtEnter;
        private System.Windows.Forms.Button btnConnet;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lbXian;
        private System.Windows.Forms.TextBox txtMing;
        private System.Windows.Forms.Label label3;
    }
}

