using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hashing
{
    public class SHA1Hashing : IHashing
    {
        public string HashSalt(string formValue, string saltKey)
        {
            throw new NotImplementedException();
        }

        public string HashValue(string formValue)
        {
            //Using closes when the code has been execuded
            //Using SHA1 base class to create an instance of the Algorhythm
            using (SHA1 sha1Hashing = SHA1.Create())
            {
                byte[] stringConvertedToBytes = Encoding.UTF8.GetBytes(formValue);
                var result = sha1Hashing.ComputeHash(stringConvertedToBytes);

                StringBuilder sb = new StringBuilder();
                foreach (byte b in result)
                {
                    sb.Append(b.ToString("x2"));
                }

                return sb.ToString();
            }
        }
    }
}
