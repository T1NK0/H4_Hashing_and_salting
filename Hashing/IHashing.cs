using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashing
{
    public interface IHashing
    {
        string HashValue(string formValue);
        string HashSalt(string formValue, string saltKey);
        //bool CheckAuthenticity(byte[] mes, byte[] mac, byte[] ke);
    }
}
