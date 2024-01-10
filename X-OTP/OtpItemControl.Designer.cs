namespace XOTP
{
    partial class OtpItemControl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label_Corp = new Label();
            label_Username = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            progressBar_otp = new ProgressBar();
            label_Captcha = new Label();
            SuspendLayout();
            // 
            // label_Corp
            // 
            label_Corp.AutoSize = true;
            label_Corp.Location = new Point(17, 15);
            label_Corp.Name = "label_Corp";
            label_Corp.Size = new Size(54, 20);
            label_Corp.TabIndex = 0;
            label_Corp.Text = "发行方";
            // 
            // label_Username
            // 
            label_Username.AutoSize = true;
            label_Username.Font = new Font("Microsoft YaHei UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label_Username.Location = new Point(17, 47);
            label_Username.Name = "label_Username";
            label_Username.Size = new Size(44, 17);
            label_Username.TabIndex = 2;
            label_Username.Text = "用户名";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // progressBar_otp
            // 
            progressBar_otp.Anchor = AnchorStyles.None;
            progressBar_otp.Cursor = Cursors.Hand;
            progressBar_otp.Location = new Point(0, 140);
            progressBar_otp.Maximum = 30;
            progressBar_otp.Name = "progressBar_otp";
            progressBar_otp.Size = new Size(211, 2);
            progressBar_otp.Step = 1;
            progressBar_otp.TabIndex = 3;
            // 
            // label_Captcha
            // 
            label_Captcha.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label_Captcha.BorderStyle = BorderStyle.FixedSingle;
            label_Captcha.Font = new Font("Microsoft YaHei UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label_Captcha.Location = new Point(17, 75);
            label_Captcha.Name = "label_Captcha";
            label_Captcha.Size = new Size(181, 50);
            label_Captcha.TabIndex = 6;
            label_Captcha.Text = "999999";
            label_Captcha.TextAlign = ContentAlignment.MiddleCenter;
            label_Captcha.Click += label_Captcha_Click;
            // 
            // OtpItemControl
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label_Captcha);
            Controls.Add(progressBar_otp);
            Controls.Add(label_Username);
            Controls.Add(label_Corp);
            Cursor = Cursors.Hand;
            Name = "OtpItemControl";
            Size = new Size(222, 150);
            Load += OtpItemControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Corp;
        private Label label_Username;
        private System.Windows.Forms.Timer timer1;
        private ProgressBar progressBar_otp;
        private Label label_Captcha;
    }
}
