using OtpNet;

namespace XOTP
{
    public class OtpInput
    {
        public string Id { get; set; }
        public string SecretKey { get; set; }

        public int Step { get; set; }

        public string Username { get; set; }
        private string corp;
        public string Corp { get; set; }

        private OtpHashMode otpHashMode;
        public OtpHashMode OtpHashMode { get; set; }

    }
    public class OtpOutput
    {
        public required string Code { get; set; }

        public required int RemainingSeconds { get; set; }
    }
}
