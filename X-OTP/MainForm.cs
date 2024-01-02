using OtpNet;
using System.Diagnostics;
using System.Reflection;

namespace XOTP
{
    public partial class MainForm : Form
    {
        private string Title = "X-OTP";
        private Version CurrentVersion;
        private static Dictionary<string, OtpInput> otpInputs = new Dictionary<string, OtpInput>();


        private readonly string configPath = Directory.GetCurrentDirectory() + "/config.bin";
        public MainForm()
        {

            Assembly assembly = Assembly.GetExecutingAssembly();

            CurrentVersion = assembly.GetName().Version;

            Text = $"{Title} v{CurrentVersion.Major}.{CurrentVersion.Minor}";

            LoadConfig();
            InitializeComponent();
            if (otpInputs.Count > 0)
            {
                detailControl_otp.CurrentItem = otpInputs.First().Value;
            }


        }
        private void MainForm_Load(object sender, EventArgs e)
        {

            RenderOtpItem();

            new Thread(async () =>
            {
                string cachePath = Directory.GetCurrentDirectory() + "/version.cache";
                try
                {
                    if (File.Exists(cachePath))
                    {
                        string cacheText = await File.ReadAllTextAsync(cachePath);
                        if (DateTime.TryParse(cacheText, out DateTime cacheDateTime) && cacheDateTime.Date == DateTime.Today.Date)
                        {
                            return;
                        }
                    }

                    UpdaterOutput updaterOutput = await Updater.Run();
                    File.WriteAllText(cachePath, DateTime.Now.ToString());

                    if (updaterOutput.Version is not null && !CurrentVersion.Equals(updaterOutput.Version))
                    {
                        Invoke(() =>
                        {
                            DialogResult result = MessageBox.Show($"发现更新\n当前版本：v{CurrentVersion}\n" +
                                $"最新版本：v{updaterOutput.Version}", "立即更新", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                            if (result == DialogResult.OK)
                            {
                                Process.Start("explorer.exe", updaterOutput.HtmlUrl);
                            }
                        });

                    }
                }
                finally
                {
                    File.WriteAllText(cachePath, DateTime.Now.ToString());
                }

            }).Start();

        }
        private void LoadConfig()
        {
            try
            {
                var data = Array.Empty<byte>();
                if (Path.Exists(configPath))
                {
                    data = File.ReadAllBytes(configPath);
                }

                otpInputs = Config.Decrypt<Dictionary<string, OtpInput>>(data) ?? otpInputs;
            }
            catch (Exception)
            {

            }

        }
        private void SaveConfig()
        {
            File.WriteAllBytes(
                configPath,
                Config.Encrypt(otpInputs)
            );

        }

        private void RenderOtpItem()
        {

            flowLayoutPanel_otp_list.Controls.Clear();
            foreach (var otpInput in otpInputs)
            {

                var otpItemControl = new OtpItemControl(otpInput.Value);

                if (otpItemControl.OtpInput == detailControl_otp.CurrentItem)
                {
                    otpItemControl.BackColor = Color.FromArgb(225, 225, 225);
                }

                otpItemControl.MouseClick += (sender, e) =>
                {
                    detailControl_otp.CurrentItem = otpInput.Value;
                    foreach (OtpItemControl item in flowLayoutPanel_otp_list.Controls)
                    {
                        if (item.OtpInput == detailControl_otp.CurrentItem)
                        {
                            item.BackColor = Color.FromArgb(225, 225, 225);
                        }
                        else
                        {
                            item.BackColor = Color.Transparent;
                        }
                    }
                };
                flowLayoutPanel_otp_list.Controls.Add(otpItemControl);
                for (int i = 0; i < flowLayoutPanel_otp_list.Controls.Count; i++)
                {
                    var item = (OtpItemControl)flowLayoutPanel_otp_list.Controls[i];

                    item.Width = flowLayoutPanel_otp_list.ClientSize.Width;
                    if (i != flowLayoutPanel_otp_list.Controls.Count - 1)
                    {
                        item.BottomBorderColor = Color.Transparent;
                    }
                }
            }
        }
        private void button_add_Click(object sender, EventArgs e)
        {
            var input = new OtpInput
            {

                Id = Guid.NewGuid().ToString(),
                Corp = "发行方",
                Username = "用户名",
                OtpHashMode = OtpHashMode.Sha1,
                SecretKey = "",
                Step = 120,
            };
            otpInputs.Add(input.Id, input);
            SaveConfig();
            RenderOtpItem();
        }

        private void detailControl_otp_Save(OtpInput currentItem)
        {

            otpInputs[currentItem.Id] = currentItem;

            SaveConfig();
            MessageBox.Show("保存成功");
            RenderOtpItem();
        }

        private void detailControl_otp_Delete(OtpInput currentItem)
        {
            otpInputs.Remove(currentItem.Id);

            if (otpInputs.Count > 0)
            {
                detailControl_otp.CurrentItem = otpInputs.First().Value;
            }
            SaveConfig();
            MessageBox.Show("删除成功");
            RenderOtpItem();
        }
    }
}
