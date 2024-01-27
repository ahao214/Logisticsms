using System;
using System.Security.Cryptography;
using System.Text;

namespace Logisticsms.DAL.Helper
{
    internal class MDFiveHelper
    {
        public static string GetMDFive(string password)
        {
            byte[] result = Encoding.Default.GetBytes(password);
            MD5 mdFive = new MD5CryptoServiceProvider();
            byte[] output = mdFive.ComputeHash(result);
            password = BitConverter.ToString(output).Replace("-", "");
            return password;
        }
    }
}
