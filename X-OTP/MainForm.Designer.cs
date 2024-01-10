using OtpNet;

namespace XOTP
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            OtpInput otpInput1 = new OtpInput();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            timer1 = new System.Windows.Forms.Timer(components);
            toolTip1 = new ToolTip(components);
            flowLayoutPanel_otp_list = new FlowLayoutPanel();
            button_add = new Button();
            detailControl_otp = new DetailControl();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            // 
            // flowLayoutPanel_otp_list
            // 
            flowLayoutPanel_otp_list.Anchor = AnchorStyles.None;
            flowLayoutPanel_otp_list.AutoScroll = true;
            flowLayoutPanel_otp_list.BackColor = Color.Transparent;
            flowLayoutPanel_otp_list.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel_otp_list.Location = new Point(12, 22);
            flowLayoutPanel_otp_list.Name = "flowLayoutPanel_otp_list";
            flowLayoutPanel_otp_list.Size = new Size(247, 602);
            flowLayoutPanel_otp_list.TabIndex = 14;
            flowLayoutPanel_otp_list.WrapContents = false;
            // 
            // button_add
            // 
            button_add.Location = new Point(12, 637);
            button_add.Name = "button_add";
            button_add.Size = new Size(247, 55);
            button_add.TabIndex = 18;
            button_add.Text = "新增";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // detailControl_otp
            // 
            otpInput1.Corp = "发行方";
            otpInput1.Id = Guid.NewGuid().ToString();
            otpInput1.OtpHashMode = OtpNet.OtpHashMode.Sha1;
            otpInput1.SecretKey = "";
            otpInput1.Step = 30;
            otpInput1.Username = "用户名";
            detailControl_otp.CurrentItem = otpInput1;
            detailControl_otp.Location = new Point(281, 12);
            detailControl_otp.Name = "detailControl_otp";
            detailControl_otp.Size = new Size(557, 704);
            detailControl_otp.TabIndex = 19;
            detailControl_otp.Save += detailControl_otp_Save;
            detailControl_otp.Delete += detailControl_otp_Delete;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 719);
            Controls.Add(detailControl_otp);
            Controls.Add(button_add);
            Controls.Add(flowLayoutPanel_otp_list);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "X-OTP";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private ToolTip toolTip1;
        private FlowLayoutPanel flowLayoutPanel_otp_list;
        private Button button_add;
        private DetailControl detailControl_otp;
    }
}
