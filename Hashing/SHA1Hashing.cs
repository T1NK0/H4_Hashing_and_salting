using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hashing
{
    public class Hashings : IHashing
    {
        public string SHA1HashValue(string formValue)
        {
            //Using closes when the code has been execuded
            //Using SHA1 base class to create an instance of the Algorhythm
            using (SHA1 sha1Hashing = SHA1.Create())
            {
                byte[] stringConvertedToBytes = Encoding.UTF8.GetBytes(formValue);
                byte[] result = sha1Hashing.ComputeHash(stringConvertedToBytes);

                Console.WriteLine(BitConverter.ToString(result));

                return MyStringBuilder(result);
            }
        }        
        
        public string SHA256HashValue(string formValue)
        {
            //Using closes when the code has been execuded
            //Using SHA1 base class to create an instance of the Algorhythm
            using (SHA256 sha1Hashing = SHA256.Create())
            {
                byte[] stringConvertedToBytes = Encoding.UTF8.GetBytes(formValue);
                byte[] result = sha1Hashing.ComputeHash(stringConvertedToBytes);

                Console.WriteLine(BitConverter.ToString(result));

                return MyStringBuilder(result);
            }
        }        
        
        public string MD5HashValue(string formValue)
        {
            //Using closes when the code has been execuded
            //Using SHA1 base class to create an instance of the Algorhythm
            using (MD5 sha1Hashing = MD5.Create())
            {
                byte[] stringConvertedToBytes = Encoding.UTF8.GetBytes(formValue);
                byte[] result = sha1Hashing.ComputeHash(stringConvertedToBytes);

                Console.WriteLine(BitConverter.ToString(result));

                return MyStringBuilder(result);
            }
        }

        public string MyStringBuilder(byte[] input)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in input)
            {
                //ToString("x2") is to format hexadecimal to text.
                sb.Append(b.ToString("x2"));
            }

            return sb.ToString();
        }
    }
}
