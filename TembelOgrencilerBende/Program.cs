using System;

namespace TembelOgrencilerBende
{
    class Program
    {
        static void Main(string[] args)
        {
            // klavyeden 2 sayı girilecek ve bu sayıların 1 toplama 2 çıkarma 3 çarpma 4 bölme işlemleri yapılacak tebmbel öprencilere anlat....
            //1 toplma işlemi yapıyoruz...


            // int toplam = s1 + s2;
            //int sayi_1, sayi_2;

            //Console.WriteLine("lütfen tembel öğrenci sayı gir");
            //int sayi_1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("hadi bakalım 2 sayıyı giriniz:::");
            //int sayi_2 = Convert.ToInt32(Console.ReadLine());

            // toplma işlemi yapıyoruz tembel öğrenciler
            // Toplama(sayi_1, sayi_2);

            //Console.WriteLine(Cikarma(sayi_1, sayi_2));

            // Bolme();
            //Console.WriteLine(dl);

            Console.WriteLine(Carpma(3,5));
            Console.WriteLine(Bolme());
            Console.ReadLine();
        }
        /// <summary>
        /// parameter almayan ve gerieye değer döndüren
        /// </summary>
        /// <returns></returns>
        static double Bolme()//
        {
            double sayi1, sayi2;
            Console.Write("1.sayıyı girininz tembeller: ");
            sayi1 = double.Parse(Console.ReadLine());

            Console.Write("2. sayyı giriniz zeynep hanım: ");
            sayi2 = Convert.ToDouble(Console.ReadLine());

            var sonuc = sayi1 / sayi2;
            return sonuc;
        }
        /// <summary>
        /// parametre alan ve geriye değer döndüren 
        /// </summary>
        /// <param name="sayi1"></param>
        /// <param name="sayi2"></param>
        /// <returns></returns>
        static int Cikarma(int sayi1, int sayi2)//
        {
            int cikar = sayi1 - sayi2;
            return cikar;
        }
        static int Carpma(int s1,int s2)
        {
            int carpma = s1 * s2;
            return carpma;
        }

        static void Toplama(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sayıların toplamı: " + toplam);
        }

    }
}
