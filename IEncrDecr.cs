using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShyfryLab
{
    interface IEncrDecr
    {
        string Encrypt(string text);
        string Decrypt(string text);
    }
}
