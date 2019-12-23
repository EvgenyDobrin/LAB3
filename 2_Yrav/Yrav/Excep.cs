using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yrav
{
    class Excep : Exception
    {
        string e = "";
        public string Excepen(bool fa, bool fb, bool fc, string messange)
        {
            if (!fa)
            {
                e += " A";
            }
            if (!fb)
            {
                e += " B";
            }
            if (!fc)
            {
                e += " C";
            }
            return e = messange + e;
        }
    }
}
