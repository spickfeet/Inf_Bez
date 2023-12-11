using System.Security.Cryptography;
using System.Text;

namespace Inf_Bez
{
    internal class HashCodeConvertor
    {
        public static string ConvertToHashCode(string password)
        {
            byte[] messageBytes = Encoding.UTF8.GetBytes(password);
            byte[] hashValue = SHA256.HashData(messageBytes);
            return Convert.ToHexString(hashValue);
        }
    }
}
