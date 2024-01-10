using OtpNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace XOTP
{
    public partial class DetailControl : UserControl
    {

        public event Action<OtpInput> Save;
        public event Action<OtpInput> Delete;
        public DetailControl()
        {
            InitializeComponent();

            comboBox_OtpHashMode.Items.AddRange(new string[]
            {
                nameof(OtpHashMode.Sha1),
                nameof(OtpHashMode.Sha256),
                nameof(OtpHashMode.Sha512),
            });
            comboBox_OtpHashMode.SelectedIndex = 0;
            RefreshOtp();

        }


        private OtpInput _currentItem = new OtpInput
        {
            Id = Guid.NewGuid().ToString(),
            SecretKey = "",
            Step = 30,
            OtpHashMode = OtpHashMode.Sha1,
        };
        public OtpInput CurrentItem
        {
            get { return _currentItem; }
            set
            {
                _currentItem = value;
                textBox_Corp.Text = CurrentItem.Corp;
                textBox_Username.Text = CurrentItem.Username;
                textBox_secret_key.Text = CurrentItem.SecretKey;
                numericUpDown_step.Text = CurrentItem.Step.ToString();
                comboBox_OtpHashMode.SelectedItem = CurrentItem.OtpHashMode.ToString();

            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            CurrentItem.Username = textBox_Username.Text;
            CurrentItem.Corp = textBox_Corp.Text;
            CurrentItem.SecretKey = textBox_secret_key.Text;
            CurrentItem.Step = Convert.ToInt32(numericUpDown_step.Value);
            CurrentItem.OtpHashMode = (OtpHashMode)Enum.Parse(typeof(OtpHashMode), comboBox_OtpHashMode.SelectedItem.ToString());
            Save(CurrentItem);
        }
        private void button_copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(label_CaptchaOutput.Text);
            button_copy.Text = "已复制";
        }


        private void button_copy_MouseLeave(object sender, EventArgs e)
        {
            button_copy.Text = "复制";
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            Delete(CurrentItem);
        }
        public static OtpOutput GetTotp(OtpInput otpInput)
        {
            byte[] base32Bytes = Base32Encoding.ToBytes(otpInput.SecretKey);
            var totp = new Totp(base32Bytes, otpInput.Step, otpInput.OtpHashMode);
            return new OtpOutput
            {
                Code = totp.ComputeTotp(),
                RemainingSeconds = totp.RemainingSeconds(),
            };
        }
        private void RefreshOtp()
        {

            if (string.IsNullOrWhiteSpace(CurrentItem.SecretKey) || CurrentItem.Step <= 0)
            {
                return;
            }
            try
            {
                OtpOutput otpOutput = DetailControl.GetTotp(CurrentItem);
                label_CaptchaOutput.Text = otpOutput.Code;
                label_timeOutput.Text = otpOutput.RemainingSeconds.ToString();
            }
            catch (Exception ex)
            {
                label_CaptchaOutput.Text = "999999";
            }
        }
        private void timer_Otp_Tick(object sender, EventArgs e)
        {
            RefreshOtp();
        }


        private void textBox_secret_key_Enter(object sender, EventArgs e)
        {
            textBox_secret_key.PasswordChar = '\0';
        }

        private void textBox_secret_key_Leave(object sender, EventArgs e)
        {

            textBox_secret_key.PasswordChar = '*';
        }

    }
}
