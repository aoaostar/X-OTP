using System.Diagnostics;
using System.Text;
using System.Text.Json;

namespace XOTP
{
    public class Config
    {
        private static readonly byte encryptionKey = 0b10101010;

        public static byte[] Encrypt<T>(T input)
        {
            var data = JsonSerializer.Serialize(input);
            byte[] bytes = Encoding.UTF8.GetBytes(data);

            // 使用异或运算进行加密
            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = (byte)(bytes[i] ^ encryptionKey);
            }

            return bytes;
        }

        public static T? Decrypt<T>(byte[] input)
        {
            try
            {
                if (input == null)
                {
                    return default; // 返回默认值，表示解密失败
                }

                // 使用异或运算进行解密
                for (int i = 0; i < input.Length; i++)
                {
                    input[i] = (byte)(input[i] ^ encryptionKey);
                }

                var data = Encoding.UTF8.GetString(input);
                return JsonSerializer.Deserialize<T>(data);
            }
            catch (Exception ex)
            {
                // 处理异常
                Trace.TraceError("Decryption Error: " + ex.Message);
                return default; // 返回默认值，表示解密失败
            }
        }
    }

}
