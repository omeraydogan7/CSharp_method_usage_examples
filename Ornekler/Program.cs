using System;

namespace Ornekler
{
    class Program
    {
        static void Main(string[] args)
        {
            ilk10ile20Soru();


            Console.ReadKey();
        }
        static void ilk10ile20Soru()
        {
            // BsayiKsayi();
            // BooleanMetot();
            // Soru1();
            // bool sonuc = BooleSoru2();
            //  yaz(25 + 6568 + 7848 - 898+"jajsfsjaj"+'a'+3.54);
            // KullaniciBilgileri();
            //login();
        }
        static string Ekranoku()
        {
            string oku = Console.ReadLine();
            return oku;
        }
        static void Ekranayaz(string yaz)
        {
            Console.WriteLine(yaz);
        }
        static bool konrtol()
        {
            string kk = "omer";
            string sif = "abc";
            Ekranayaz("kullanıcı adını yaz");
            string use = Ekranoku();
            Ekranayaz("şifre yaz");
            string pas = Ekranoku();
            bool durum = kk == use && sif == pas;
            if (durum)
            {
                Console.WriteLine("giriş başarılı");
            }
            else
            {
                Ekranayaz("giriş hatalı...");
            }
            return false;
        }
        static void login()
        {
            konrtol();
        }
        static void ilk10Soru()
        {
            //IndirimliUrun();
            //  HarfBill();
            //  IkiSayiCarp();
            // MagazaOdeme();
            // castkullanımı();
            // Sorular();
            //SinavDegerleri();
            // KiloIndex();
            // AskerlikBasvuru();
            // SayiAraligi();
        }
        static void KullaniciBilgileri()
        {
            Console.Write("Kullanıcı Adı: ");
            string kullaniciAdi = Console.ReadLine();
            Console.Write("Şifre: ");
            string sifre = Console.ReadLine();

            // Kullanıcı adı ve şifreyi kontrol etmek için metodu çağırıyoruz
            KullaniciGirisKontrol(kullaniciAdi, sifre);
            // Metottan geriye değer dönmediği için burada devam ediyoruz.
            Console.WriteLine("Program sonlandı.");
        }
        static void KullaniciGirisKontrol(string kullaniciAdi, string sifre)
        {
            // Kullanıcı adı ve şifreyi kontrol etmek için burada uygun bir kontrol yapabilirsiniz.
            // Örneğin, sabit bir kullanıcı adı ve şifreyle karşılaştırarak doğrulama yapabilirsiniz.

            if (kullaniciAdi == "istanbulEgitimAkademi" && sifre == "123_abc")
            {
                Console.WriteLine("Giriş başarılı.");
            }
            else
            {
                Console.WriteLine("Kullanıcı adı veya şifre hatalı.");
            }
        }
        static void yaz(object metin)
        {
            Console.WriteLine(metin);
        }
        static bool BooleSoru2()
        {
            bool soru;
            soru = (("delete" == "remove" && '!' != '?' || ("adana" == "Ankara")) && (true != false && '%' == '/'));
            return soru;

        }
        private static void Karsilastirma()
        {
            bool durum = "omer" == "OMER";
            Console.WriteLine("sonuc : " + durum);
            durum = 'a' > 'A';
            Console.WriteLine("sonuc : " + durum);

            durum = 12 < 23 ? 23 > 12 : 12 > 12 ? 34 > 34 : 123 > 1;
            Console.WriteLine("Sonuç : " + durum);
        }
        static void Soru1()
        {
            bool sonuc = (0 >= 0 || "c" == "C")
                &&

                ((10 >= 8 & 'a' != 5) || (DateTime.Now.Year == 2023 || "Mart" != "Temmuz"));

            Console.WriteLine(sonuc);
        }
        private static void BooleanMetot()
        {  //Bir ürünün stokta bulunup bulunmadığını kontrol eden bir boolean ifadeyi şu şekilde yazabiliriz:
            // Örnek olarak bir ürünün stok durumunu temsil eden değişkeni düşünelim:
            // // Bir boolean ifadeyle stok durumunu kontrol edelim:
            // Eğer stokAdedi 0'dan büyükse (yani stokta ürün varsa), stoktaVarMi true olacak.
            // Eğer stokAdedi 0 veya daha küçükse (yani stokta ürün yoksa), stoktaVarMi false olacak.

            int telefon, bilgisayar, kulaklık;
            Console.Write("Telefon stok adedini giriniz: ");
            telefon = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bilgisayar stok adedini giriniz: ");
            bilgisayar = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kulaklık stok adedini giriniz: ");
            kulaklık = Convert.ToInt32(Console.ReadLine());
            bool stok = telefon < 5 && telefon > 0;
            if (stok)
            {
                Console.WriteLine($"Telefon Stok 5'den az");
            }
            else
            {
                Console.WriteLine($"Telefon Stok 5'den fazla");
            }
            stok = bilgisayar < 5 && bilgisayar > 0;
            if (stok)
            {
                Console.WriteLine("Bilgisayar Stok 5'den az");
            }
            else
            {
                Console.WriteLine($"Bilgisayar Stok 5'den fazla");
            }
            stok = kulaklık < 5 && kulaklık > 0;
            if (stok)
            {
                Console.WriteLine("Kulaklık Stok 5'den az");
            }
            else
            {
                Console.WriteLine($"Kulaklık Stok 5'den fazla");
            }

        }
        private static void BsayiKsayi()
        {
            Console.WriteLine("Lütfen üç adet sayı girin:");
            Console.Write("1. Sayı: ");//2                          5
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayı: ");//3                          7
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("3. Sayı: ");//4                          9
            int sayi3 = Convert.ToInt32(Console.ReadLine());

            int bSayi = sayi1;//ilk tanım değeri veriliyor //2-3-4
            int kSayi = sayi1; //ilk tanım değeri veriliyor//2
                               //---------------------------------------------------------
                               //  if (sayi2 > bSayi) { bSayi = sayi2; }
            bool durum = sayi2 > bSayi;
            if (durum == true)
            {
                bSayi = sayi2;
            }
            ////--------------------------------------------
            //  if (sayi3 > bSayi) { bSayi = sayi3; }
            durum = sayi3 > bSayi;
            if (durum == true)
            {
                bSayi = sayi3;
            }

            // buraya kadar en büyük sayıyı buluyoruz 
            //---------------------------------------------------------------
            if (sayi2 < kSayi) { kSayi = sayi2; }
            if (sayi3 < kSayi) { kSayi = sayi3; }
            // buraya kadar da en küçük sayıyı buluyoruz

            Console.WriteLine("En Büyük Sayı: " + bSayi);
            Console.WriteLine("En Küçük Sayı: " + kSayi);
        }
        private static void SayiAraligi()
        {
            Random rdm = new Random();
            int rastgele = rdm.Next(0, 500);

            if (rastgele >= 0 && rastgele <= 50)
            {
                Console.WriteLine("Sayı 0 ile 50 arasındadır. " + rastgele);
            }
            else if (rastgele >= 51 && rastgele <= 100)
            {
                Console.WriteLine("Sayı 51 ile 100 arasındadır. " + rastgele);
            }
            else if (rastgele >= 101 && rastgele <= 200)
            {
                Console.WriteLine("Sayı 101 ile 200 arasındadır.  " + rastgele);
            }
            else
            {
                Console.WriteLine("Sayı 200'den büyüktür. " + rastgele);
            }
        }
        private static void AskerlikBasvuru()
        {
            char cins, as_du;
            byte yas;
            Console.WriteLine("İşe başvuranın cinsiyeti");
            Console.Write("Erkekler için 'e' bayanlar için 'b' tıklarıyınız: ");
            cins = char.Parse(Console.ReadLine());
            if (cins == 'e' || cins == 'E')
            {
                Console.WriteLine("Askerlik durumunu giriniz?");
                Console.WriteLine("yaptı ise: 'e' yapmadı ise 'h'");
                as_du = char.Parse(Console.ReadLine());
                if (as_du == 'e' || as_du == 'E')
                {
                    Console.Write("yaşınızı: ");
                    yas = byte.Parse(Console.ReadLine());
                    if (yas <= 30)
                    {
                        Console.WriteLine("işe alındınız");
                    }
                    else
                    { Console.WriteLine("31 yaşınsan küçükler işe alınacaktır..."); }
                }
                else
                { Console.WriteLine("Askerliğini yapmış personel işe alınacaktır..."); }
            }
            else
            { Console.WriteLine("boşuna deneme seni işe almayacaklardır....:):)"); }
        }
        private static void indirimHesapla()
        {
            Console.Write("Toplam tutarınızı girin: ");
            double toplamTutar = double.Parse(Console.ReadLine());
            double indirimli = 0;
            if (toplamTutar > 0 && toplamTutar <= 100)
            {
                indirimli = toplamTutar - (toplamTutar * 0.05);
                Console.WriteLine($"Toplam tutar: {toplamTutar} indirimli tutarı: {indirimli}");// %5 indirim
            }
            else if (toplamTutar > 100 && toplamTutar <= 500)
            {
                indirimli = toplamTutar - (toplamTutar * 0.10);
                Console.WriteLine($"Toplam tutar: {toplamTutar} indirimli tutarı: {indirimli}");// %10 indirim
            }
            else
            {
                indirimli = toplamTutar - (toplamTutar * 0.15);
                Console.WriteLine($"Toplam tutar: {toplamTutar} indirimli tutarı: {indirimli}");// %15 indirim
            }
        }
        static void KiloIndex()
        {
            float kilo, boy, vki;
            Console.Write("boy :");
            boy = float.Parse(Console.ReadLine());
            Console.Write("kilo :");
            kilo = float.Parse(Console.ReadLine());
            vki = kilo / (boy * boy);
            if (vki <= 18)
            {
                Console.WriteLine("Zayıf: " + vki);
            }
            else if (vki > 18 && vki < 25)
            {
                Console.WriteLine("Normal: " + vki);
            }
            else if (vki >= 25 && vki < 30)
            {
                Console.WriteLine("Kilolu: " + vki);
            }
            else if (vki >= 30 && vki < 35)
            {
                Console.WriteLine("Obez: " + vki);
            }
            else
            {
                Console.WriteLine("Ciddi Obez: " + vki);
            }
        }
        static void IndirimliUrun()
        {
            //Klavyeden iki ürünün fiyatı girildiğinde toplam fiyat 200 TL’den fazla ise, 2.üründen %25 indirim yaparak ödenecek tutarı gösteren uygulamayı yapalım.
            double urun1, urun2, toplam;
            Console.WriteLine("1.ürün fiyatını giriniz");
            Console.Write("1. ürün :  ");
            urun1 = double.Parse(Console.ReadLine());
            Console.WriteLine("2.ürün fiyatını giriniz");
            Console.Write("2. ürün :  ");
            urun2 = double.Parse(Console.ReadLine());

            toplam = urun1 + urun2;
            if (toplam >= 200)
            {
                urun2 = urun2 - urun2 * 0.25;
                toplam = urun1 + urun2;
                Console.WriteLine($"Urunun toplam fiyatı: {toplam}");
            }
            else
            {
                Console.WriteLine($"Urün fiyat toplamı: {toplam}");
            }


        }
        static void IkiSayiCarp()
        {
            Console.Write("1.sayıyı giriniz? : ");
            double sayi1 = double.Parse(Console.ReadLine());
            Console.Write("2.sayıyı giriniz? : ");
            double sayi2 = double.Parse(Console.ReadLine());
            Console.WriteLine("sonuc: " + Carp(sayi1, sayi2));

        }
        static double Carp(double sayi1, double sayi2)//sayı1=1 sayı2 = 10
        {
            double sonuc;
            if (sayi1 == 0 || sayi2 == 0)
            {
                sonuc = 0;
            }
            else if (sayi1 == 1)
            {
                sonuc = sayi2;//sonuc= s
            }
            else
            {
                sonuc = sayi2 + Carp(sayi1 - 1, sayi2);
            }

            return sonuc;
        }
        static void HarfBill()
        {//girilen harfin büyük veya küçük olduğunu bulan algoritma
            char klm;
            Console.WriteLine("Bir harfe basınız...");
            klm = char.Parse(Console.ReadLine());//string
            if (klm >= 'A' && klm <= 'Z')//şart bloğu
            {
                Console.WriteLine("girilen harfi büyüktür");
            }
            else
            {
                Console.WriteLine("girilen harf küçüktür");
            }
        }
        static void DegerAl()
        {
            Console.WriteLine("haftanın gününü giriniz");
            byte gun = byte.Parse(Console.ReadLine());
            if (!(gun <= 1 && gun <= 7))
            {
                Console.WriteLine("Lütfen haftanın gününü giriniz?");
            }
            else
            {
                if (gun >= 1 && gun <= 5)
                {
                    Console.WriteLine($"{gun}. gün hafta içidir...");
                }
                else
                {
                    Console.WriteLine($"{gun}. gün hafta sonudur...");
                }
            }

        }
        static void MagazaOdeme()
        {
            Console.Write("Toplam Ödeme fiyatını giriniz: ");
            double toplamOdemem = double.Parse(Console.ReadLine());

            double odenecekTutar = 0;

            if (toplamOdemem >= 30)
            {
                odenecekTutar = 0;
                Console.WriteLine("kargo bedavaaaaaa");
                Console.WriteLine("Toplmam ödenecek tutar: " + toplamOdemem);
            }

            else if (toplamOdemem > 0 && toplamOdemem <= 30)
            {
                odenecekTutar = 6;
                Console.WriteLine("kargo bedeli " + odenecekTutar);
            }
            else
            {
                Console.WriteLine("Lütfen ürün fiyatı giriniz?");
            }

        }
        static void castkullanımı()
        {
            double pi;
            pi = 3.14;
            Console.WriteLine(pi); //ekran çıkışı 3.14 olur
            pi = 2344;

            string baskent = "Ankara";
            Console.WriteLine(baskent);

            //const double pi = 3.14;





        }
        static void SinavDegerleri()
        {

            //değişkenleri tanımladık
            double vize1, vize2, final = 0;

            Console.Write("Vize 1 notunu giriniz? : ");
            vize1 = double.Parse(Console.ReadLine());

            Console.Write("Vize 2 notunu giriniz? : ");
            vize2 = double.Parse(Console.ReadLine());

            Console.Write("Final notunu giriniz? : ");
            final = double.Parse(Console.ReadLine());

            Sinav(vize1, vize2, final);
        }
        static void Sinav(double vize1 = 0, double vize2 = 0, double final = 0)// metot imzasını
                                                                               //metot parametre almıyor ve geriye değper dönmüyor //metot imzasında 4 özellik 
        {
            #region ornek sorunun tanımı
            /* 
            1. erişim belirleyici
            2. geri dönüş değeri
            3. metot ismi
            4. parameteresi 
        */


            /* 0 ile 100 arasında not değerleri girilecek farklı bir değer girildiğinde hata verecek 
             * 60 üzeri geçti altı kaldı
             1.başla
             2. klavyeden vize notu al
             3. klavyeden final notunu al
             4. vize ve final notlarını işleme al
             5 sonuvcu ekarana bas

             */
            #endregion
            // notla ilgili matematiksel işlmeler burada yapılacaktır
            double ortalama = 0;
            ortalama = (vize1 + vize2) * 0.4 + final * 0.6;


            // ortalama 60 dan yüksekse geçti düşükse kaldı
            if (ortalama >= 0 && ortalama < 60)//1. şart
            {
                Console.Clear();
                Console.WriteLine($"not ortalamanız: {ortalama}");
                Console.WriteLine("tembel bir öğrenci kaldın....");
            }
            else if (ortalama >= 60 && ortalama <= 100)//harika anlattın //2.şart
            {
                Console.Clear();
                Console.WriteLine($"not ortalamanız: {ortalama}");
                Console.WriteLine("çalışkan bir öğrenci geçti....");
            }
            else if (ortalama > 100 || ortalama < 0)//3. şart
            {
                Console.WriteLine("hatalı bir değer girdiniz....");//100 üzeri bir değer ve 0 altı bir deper girildiğinde burası çalışır
            }
            else
            {
                Console.WriteLine("hatalı bir değer girdiniz....");//100 üzeri bir değer ve 0 altı bir deper girildiğinde burası çalışır
            }



        }
        static void Sorular()
        {

            string[] sorular = new string[]
         {
            "1. Soru: Hangi gezegen güneş sistemindeki en büyük gezegendir?",
            "2. Soru: Türkiye'nin başkenti hangi şehirdir?",
            "3. Soru: Hangi hayvan aslanın diğer adıdır?",
            "4. Soru: Yer çekimi hangi fiziksel fenomenle ilgilidir?",
            "5. Soru: Hangi renk sembolik olarak aşkı temsil eder?",
            "6. Soru: Hangi ünlü ressam 'Mona Lisa' tablosunu yapmıştır?",
            "7. Soru: Hangi gezegenin uydusu Ay'dır?",
            "8. Soru: H2O formülü hangi bileşiği ifade eder?",
            "9. Soru: Türkiye'nin en yüksek dağı hangisidir?",
            "10. Soru: Hangi gezegen sıcaklık açısından en soğuktur?"
         };

            string[][] secenekler = new string[][]
            {
            new string[] { "A) Mars", "B) Jüpiter", "C) Dünya", "D) Venüs" },
            new string[] { "A) İstanbul", "B) Ankara", "C) İzmir", "D) Bursa" },
            new string[] { "A) Kaplan", "B) Fil", "C) At", "D) Aslan" },
            new string[] { "A) Manyetizma", "B) Işık", "C) Elektrik", "D) Kütle" },
            new string[] { "A) Mavi", "B) Kırmızı", "C) Yeşil", "D) Pembe" },
            new string[] { "A) Leonardo da Vinci", "B) Pablo Picasso", "C) Vincent van Gogh", "D) Michelangelo" },
            new string[] { "A) Mars", "B) Venüs", "C) Jüpiter", "D) Ay" },
            new string[] { "A) Su", "B) Hidrojen Peroksit", "C) Karbondioksit", "D) Hidrojen Sülfit" },
            new string[] { "A) Ağrı Dağı", "B) Erciyes Dağı", "C) Uludağ", "D) Kaçkar Dağları" },
            new string[] { "A) Mars", "B) Jüpiter", "C) Neptün", "D) Uranüs" }
            };

            Random rastgele = new Random();
            int[] kullanilanSecenekler = new int[secenekler.Length]; // Default olarak tüm şıklar kullanılmadı olarak işaretlenir.

            for (int i = 0; i < sorular.Length; i++)
            {
                int soruIndex = rastgele.Next(0, sorular.Length);

                // Doğru şıkkı kullanılmadı olarak işaretleyin
                int dogruSecenekIndex = -1;

                // Eğer soru dizini seçilen sorunun dizininden farklıysa
                // doğru şıkkı belirleyin ve kullanıldı olarak işaretleyin
                if (i != soruIndex)
                {
                    dogruSecenekIndex = rastgele.Next(0, secenekler[soruIndex].Length);
                    kullanilanSecenekler[soruIndex] = 1;
                }

                Console.WriteLine(sorular[soruIndex]);
                for (int j = 0; j < secenekler[soruIndex].Length; j++)
                {
                    Console.WriteLine(secenekler[soruIndex][j]);
                }

                char dogruCevap = (char)('A' + dogruSecenekIndex);
                char kullaniciCevap;

                do
                {
                    Console.Write("Cevabınızı giriniz (A/B/C/D): ");
                } while (!char.TryParse(Console.ReadLine().ToUpper(), out kullaniciCevap) || kullaniciCevap < 'A' || kullaniciCevap > 'D');

                if (kullaniciCevap == dogruCevap)
                {
                    Console.WriteLine("Tebrikler, doğru cevap!");
                }
                else
                {
                    Console.WriteLine($"Maalesef, doğru cevap {dogruCevap} olacaktı.");
                }

                Console.WriteLine();
                sorular[soruIndex] = sorular[i];
                secenekler[soruIndex] = secenekler[i];
            }


        }
    }

}





