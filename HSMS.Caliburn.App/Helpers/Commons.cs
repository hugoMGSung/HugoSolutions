using System.Security.Cryptography;
using System.Text;
using HSMS.Caliburn.App.Models;

namespace HSMS.Caliburn.App.Helpers
{
    public class Commons
    {
        public static readonly string CONNSTR = 
            "Data Source=localhost;Initial Catalog=HSMS;Persist Security Info=True;User ID=hsms_sa;Password=hsms_p@ssw0rd";

        public static string GetMd5Hash(MD5 md5Hash, string input)
        {
            // Convert the input string to a byte array and compute the hash. 
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            // Create a new Stringbuilder to collect the bytes 
            // and create a string. 
            StringBuilder sBuilder = new StringBuilder();
            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            // Return the hexadecimal string. 
            return sBuilder.ToString();
        }
    }

    public static class CurrentUser
    {
        public static SystemUser CUser { get; set; }

        public static void SignIn(string name, string pwd, int idx)
        {
            CUser.Name = name;
            CUser.Pwd = pwd;
            CUser.CollegeIdx = idx;
        }

        public static void SignOff()
        {
            CUser = null;
        }

    }
}
