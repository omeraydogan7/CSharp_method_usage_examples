using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50_Ornek_Proje
{
    class Program
    {
        static void Main(string[] args)
        {
            //Yapici_Yikici_Metot();
            //Deconstruct_Metot();
            //  StatikKullanimi();
            gonder();

            Console.ReadKey();
        }
        static void Yapici_Yikici_Metot()
        {
            int sayi = 1;
            while (sayi <= 100)
            {
                new _1_10_Proje(sayi++);
            }
            GC.Collect();
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            //_1_10_Proje m = new _1_10_Proje();
        }

        static void Deconstruct_Metot()
        {
            Person person = new Person
            {
                Name = "Ömer",
                LastName = "Aydoğan",
                Age = 31
            };
            var (name, surname, age) = person;
            new Person();
        }

        static void StatikKullanimi()
        {
            var datebase1 = Datebase.getInstance;
            var datebase2 = Datebase.getInstance;
            var datebase3 = Datebase.getInstance;
            // satırı kopyalama işlem ctrl + E + V satırı hem kopylar hemde yapıştırır...
        }
       static void gonder()
        {
            Console.WriteLine("oku");
        }


    }
}
