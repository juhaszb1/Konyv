using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly_Konyv
{
    internal class Konyv
    {
        string isbnSzam;
        string szerzo_K;
        string muCime;
        int kiadasiEv;
        string nyelv;
        bool enciklopedia;
        char eBook;

        public string IsbnSzam
        {
            get { return isbnSzam; }
            set 
            {
                if (value.Length != 10 && value.Length != 13)
                {
                    //throw Osztaly_Konyv.Exceptions.KonyvException(value.Length);
                }
                isbnSzam = value;

            }
        }

        public string Szerzo_K
        {
            get { return szerzo_K; }
            set { szerzo_K = value; }
        }

        public string MuCime
        {
            get { return muCime; }
            set { muCime = value; }
        }

        public int KiadasiEv
        {
            get { return kiadasiEv; }
            set { kiadasiEv = value; }
        }

        public string Nyelv
        {
            get { return nyelv; } 
            set { nyelv= value; }
        }

        public bool Enciklopedia
        {
            get { return enciklopedia; }
            set { enciklopedia = value; }
        }

        public char Ebook
        {
            get { return eBook; }
            set { eBook = value; }
        }

        public Konyv(string isbnSzam, string szerzo_K, string muCime, int kiadasiEv, string nyelv, bool enciklopedia, char eBook)
        {
            IsbnSzam = isbnSzam;
            Szerzo_K = szerzo_K;
            MuCime = muCime;
            KiadasiEv = kiadasiEv;
            Nyelv = nyelv;
            Enciklopedia = enciklopedia;
            Ebook = eBook;
        }

        ~Konyv()
        {
            Console.WriteLine("A destruktor tette a dolgát....");
        }

        public override string ToString()
        {
            return $"{isbnSzam.Substring(0,1)}-{isbnSzam.Substring(1,3)}-{isbnSzam.Substring(4,5)}-{isbnSzam.Substring(10,1)};{szerzo_K};{muCime};{kiadasiEv};{nyelv};{(enciklopedia ? "Igen":"Nem")};{(eBook == 'i' ? "Igen":"Nem")}";
        }
    }
}
