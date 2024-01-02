using OtpNet;

namespace XOTP
{
    public partial class OtpItemControl : UserControl
    {
        public Color BottomBorderColor = Color.Black;
        public OtpInput OtpInput { get; set; }
        public string Id { get; set; }

        public string Corp
        {
            get
            {
                return label_Corp.Text;
            }
            set
            {
                label_Corp.Text = value;
            }
        }
        public string Username
        {
            get
            {
                return label_Username.Text;
            }
            set
            {
                label_Username.Text = value;
            }
        }

        public string Catpcha
        {
            get
            {
                return label_Captcha.Text;
            }
            set
            {
                label_Captcha.Text = value;
            }
        }

        public OtpItemControl(OtpInput otpInput)
        {
            OtpInput = otpInput;
            InitializeComponent();
            this.Paint += UserControl_Paint;

            label_Corp.Text = OtpInput.Corp;
            label_Username.Text = OtpInput.Username;
            RefreshOtp();
        }

        private void UserControl_Paint(object sender, PaintEventArgs e)
        {
            // 获取绘图对象
            Graphics g = e.Graphics;

            // 设置边框颜色和宽度
            Pen borderPen = new Pen(Color.Black, 1);

            // 获取用户控件的边界
            Rectangle borderRectangle = this.ClientRectangle;

            g.DrawLine(new Pen(BottomBorderColor, 1), borderRectangle.Left, borderRectangle.Bottom - 1, borderRectangle.Right, borderRectangle.Bottom - 1);

            g.DrawLine(borderPen, borderRectangle.Left, borderRectangle.Top, borderRectangle.Right, borderRectangle.Top);

            g.DrawLine(borderPen, borderRectangle.Left, borderRectangle.Top, borderRectangle.Left, borderRectangle.Bottom);
            g.DrawLine(borderPen, borderRectangle.Right - 1, borderRectangle.Top, borderRectangle.Right - 1, borderRectangle.Bottom);

            // 释放资源
            borderPen.Dispose();
        }
        private void OtpItemControl_Load(object sender, EventArgs e)
        {
            Margin = new Padding(0);
            progressBar_otp.Margin = new Padding(1, 0, 0, 1);
            progressBar_otp.Width = this.ClientSize.Width - 1;
        }

        private void RefreshOtp()
        {

            if (string.IsNullOrWhiteSpace(OtpInput.SecretKey) || OtpInput.Step <= 0)
            {
                return;
            }
            try
            {
                OtpOutput otpOutput = DetailControl.GetTotp(OtpInput);
                label_Captcha.Text = otpOutput.Code;
                progressBar_otp.Maximum = OtpInput.Step;
                progressBar_otp.Value = otpOutput.RemainingSeconds;
            }
            catch (Exception ex)
            {
                label_Captcha.Text = "999999";
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            RefreshOtp();
        }

        private void label_Captcha_Click(object sender, EventArgs e)
        {

            Clipboard.SetText(label_Captcha.Text);
            MessageBox.Show("复制成功");
        }
    }
}
