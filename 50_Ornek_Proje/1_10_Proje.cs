using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50_Ornek_Proje
{
    public class _1_10_Proje
    {
        int no;

        public _1_10_Proje(int no)
        {
            // bu bir yapıcı metottur...
            this.no = no;
            Console.WriteLine($"{no}. nesnesi oluşturuldu.");

        }
        ~_1_10_Proje()
        {
            // bu bir yıkıcı metottur...
            Console.WriteLine($"{no}. nesnesi imha edildi...");
        }

    }

    public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        //geriye değer döndürmeyecek deconstruct olarak bildirilmeli ve out keywordu ile değerleri dışarı taşımalı
        // bu fonksiyon tuble olarak geriye döner
        public void Deconstruct(out string adi, out string soyadi, out int yasi)//buradaki maksat out keywordu
        {
            adi = Name;
            soyadi = LastName;
            yasi = Age;
        }

    }

    class Datebase
    {
        Datebase()
        {
            //bu bir private yapıcı metottur
            Console.WriteLine("private olan yapıcı metota eriştik...");
        }
        static Datebase datebasefild; // bu bir field dır
        static public Datebase getInstance
        {

            get
            {
                Console.WriteLine(datebasefild);
                return datebasefild;
            }

        }
        static Datebase()
        {
            datebasefild = new Datebase();
            Console.WriteLine(datebasefild);
        }

    }


}
