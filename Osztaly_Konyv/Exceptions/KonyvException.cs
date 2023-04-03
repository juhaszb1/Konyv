using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly_Konyv.Exceptions
{
    internal class KonyvException:Exception
    {
        string hibasAdat;
        public string HibasAdat
        {
            get { return hibasAdat;}
            set { hibasAdat = value;}
        }

        public KonyvException(string hibasAdat)
        {
            HibasAdat = hibasAdat;
        }
    }
}
