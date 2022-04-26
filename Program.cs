using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace usingBlok
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Unesite ime: ");
            string ime= Console.ReadLine();

            Console.Write("Unesite prezime: ");
            string prezime = Console.ReadLine();

            Console.WriteLine("\n-----------------Upisivanje podataka u datoteku...");

            using (StreamWriter sw = new StreamWriter(@"c:/prviDir/mojaDatoteka.txt"))
            {
                sw.WriteLine("Ime: {0}", ime);
                sw.WriteLine("Prezime: {0}",prezime);

            }

            Console.WriteLine("\n-------Upisano!");

            //čitanje podataka iz datoteke

            Console.WriteLine("\n-----------------Čitanje podataka iz datoteke...");

            using(StreamReader sr = new StreamReader(@"c:/prviDir/mojaDatoteka.txt"))
            {
                while (!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }




            Console.ReadKey();
                

        }
    }
}
