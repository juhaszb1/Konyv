using Osztaly_Konyv.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly_Konyv
{
    internal class Program
    {
        public static int beolvasottAdat = 0;
        static void Main(string[] args)
        {
            //Konyv osztály
            //isbnSzam
            //szerzo_k
            //muCime
            //kiadasiEv
            //nyelv
            //enciklopedia - bool
            //eBook - char i/n

            List<string> hibasAdatok = new List<string>();
            List<Konyv> books = new List<Konyv>();
            try
            {
                try
                {
                    Console.Write("Adja meg az isbnszámot: ");
                    int isbnszamhossz = int.Parse(Console.ReadLine());
                    if (isbnszamhossz.ToString().Length == 10 || isbnszamhossz.ToString().Length == 13)
                    {
                        books.Add(new Konyv(isbnSzam:isbnszamhossz.ToString(), "Kelemen Ádám", "A gyengék elhullanak!", 2023, "Magyar", true, 'i'));
                    }
                    foreach (Konyv v in books)
                    {
                        Console.WriteLine(v);
                    }
                }
                catch (KonyvException e)
                {
                    hibasAdatok.Add($"{e.HibasAdat}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(books.Count);

            /*for (int i = 0; i < 1000000; i++)
            {
                Konyv book = new Konyv("0-306-40615-2", "Kelemen Ádám", "A gyengék elhullanak!", 2023, "Magyar", true, 'i');
                Console.WriteLine(i);
            }*/

            Console.ReadKey();
        }
    }
}
