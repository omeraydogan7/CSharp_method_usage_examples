using System;

namespace MetodsProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            // gotokullanimi(10);
            // tcornek();
            //  rastgelesayi();
           //  tahminoyunu();

            Console.ReadKey();
        }
        static void gotokullanimi(int sayi)
        {
            int sayac = sayi;  // aslında böyle yapyada gerek yoktu 

        @goto: //goto başlangıç yeri belirledim //@ etiketi genelde c# tarafından tanımlanan komutları ezme işlemi görür
            Console.WriteLine("Döngüdeyim: " + sayac);

            sayac++; //sayıyı bir bir artırıyorum

            if (sayac <= 10)//kontdol edihyoruz
                goto @goto;//kotrol sonucu buraya giriyorsa goto komutu ile dongu başına gönderiyor 

            Console.WriteLine("Döngü bitti.");//goto ile yapılan döngü işlemini bitiriyoruz.
        }
        static void ornek()
        {
            Console.Write("Bir sayı girin: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            char x = 'f';
            string a = "metin";
            int sayi2 = byte.Parse(a);
            Console.WriteLine(sayi2);

            if (sayi % 2 == 0)// kontrol ediyoruz
            {
                Console.WriteLine("Girilen sayı çift.");
            }
            else
            {
                Console.WriteLine("Girilen sayı tek.");
            }
        }
        static void deneme()
        {
            Console.Write("1. kullanıcı adını girin: ");
            string kAdi = Console.ReadLine();

            Console.Write("2. kullanıcı adını girin: ");
            string kAdi2 = Console.ReadLine();

            if (string.Equals(kAdi, kAdi2))//equals metoto iki string kelimeyi karşılaştırma yapar
            {
                Console.WriteLine("Kullanıcı adları eşit.");
            }
            else
            {
                Console.WriteLine("Kullanıcı adları eşit değil.");
            }
        }
        static void tcornek()
        {
        tekrar:
            Console.Write("TC Kimlik numaranızı girin: ");
            int tcKimlik = int.Parse(Console.ReadLine());

            Console.Write("Yaşınızı girin: ");
            int yas = int.Parse(Console.ReadLine());

            Console.Write("Mezuniyet derecesi (Lisans/Yüksek Lisans/Doktora): ");
            short mezuniyetDerecesi = short.Parse(Console.ReadLine());

            int emeklilikYasi;

            if (tcKimlik == 12345)
            {
                Console.Write("emeklilik yaşını giriniz? : ");
                emeklilikYasi = int.Parse(Console.ReadLine());
                Console.WriteLine("Geçerli TC Kimlik numarası!");
                if (emeklilikYasi >= 65)
                {
                    Console.WriteLine("emekli olabilirsiniz");
                }
                else if (emeklilikYasi <= 65)
                {
                    Console.WriteLine("emekli olamazsınız");
                }
            }
            else
            {
                Console.WriteLine("tc hatalı tekrar denemek istermisiniz");
                Console.WriteLine("denemek istersenizi e harfine istemezsenizi h harfine basınız");
                char karakter = Convert.ToChar(Console.ReadLine());
                if (karakter == 'e' || karakter == 'E')
                {
                    Console.Clear();
                    goto tekrar;
                }
                else
                {
                    Console.WriteLine("işlem sonlandırıldı.");
                    Environment.Exit(0);
                }
            }

        }
        static void tcornek2()
        {
        git:
            Console.WriteLine("Lütfen T.C. no giriniz.");
            string tcNo = Console.ReadLine();

            if (tcNo == "1234")
            {
                Console.Write("Mezuniyet durumunuzu giriniz: ");
                string mezuniyet = Console.ReadLine();

                Console.Write("Yaşınızı giriniz: ");
                int yas = Convert.ToInt32(Console.ReadLine());

                if ((mezuniyet == "Lisans" || mezuniyet == "lisans") && yas >= 65)
                {
                    Console.WriteLine("Tebrikler Emekli Olabilirsiniz");
                }
                else
                {
                    Console.WriteLine("Girilen bilgiler doğrultusunda Emekli olamazsınız!");
                    Console.WriteLine("tekrar denemek istermisiniz? <e/h>");
                    char cevap = Convert.ToChar(Console.ReadLine());

                    if (cevap == 'e' || cevap == 'E')
                    {
                        Console.Clear();
                        goto git;
                    }
                    else
                    {
                        Console.WriteLine("Eve dön.");
                        Environment.Exit(0);
                    }
                }
            }
            else
            {
                Console.WriteLine("Girilen TC no emeklilik durumuna uygun değil.");
                Console.WriteLine("tekrar denemek istermisiniz? <e/h>");
                char cevap1 = Convert.ToChar(Console.ReadLine());

                if (cevap1 == 'e' || cevap1 == 'E')
                {
                    Console.Clear();
                    goto git;

                }
                else
                {
                    Console.WriteLine("Eve dön.");
                    Environment.Exit(0);
                }
            }
        }
        static void rastgelesayi()
        {
            Random random = new Random();
            int rastgeleSayi = random.Next(1, 101); // 1 ile 100 arasında rastgele bir sayı seçer

            int hak = 5;
            Console.WriteLine("0 ile 100 arasında bir sayıyı tahmin edin. Toplam 3 hakkınız var.");

            while (hak > 0)
            {
                Console.Write("Tahmininiz: ");
                int tahmin;
                //TryParse() metotu C# dilinde bir metindeki sayısal veriyi çıkarmak ve bunu bir sayısal veri türüne dönüştürmek için kullanılan bir metottur. Bu metodun amacı, dönüşüm sırasında oluşabilecek hataları önlemektir. Eğer metindeki veri başarılı bir şekilde sayısal bir değere dönüştürülebilirse, bu dönüşüm başarılı bir şekilde gerçekleştirilir ve true değeri döndürülür. Eğer dönüşüm başarısız olursa, false değeri döndürülür.
                if (!int.TryParse(Console.ReadLine(), out tahmin))//sayısal veriyi çıkarıp ve bir depişkene atayalım
                {
                    Console.WriteLine("Geçersiz giriş! Bir tam sayı girin.");
                    continue;// işleme devam et anlamı taşıyor
                }
                if (tahmin == rastgeleSayi)
                {
                    Console.WriteLine("Tebrikler! Doğru tahmin ettiniz.");
                    break;//bloktan çıkmam işlemi yapar
                }
                else
                {
                    hak--;
                    if (hak > 0)//
                    {
                        Console.WriteLine("Yanlış tahmin! Kalan hak: " + hak);
                    }
                    else
                    {
                        Console.WriteLine("Üzgünüm, doğru sayıyı tahmin edemediniz. Doğru sayı: " + rastgeleSayi);
                    }
                }
            }
        }
        static void tahminoyunu()
        {
            Random random = new Random();
            int rastgeleSayi = random.Next(1, 50); // 1 ile 100 arasında rastgele bir sayı tutar

            int hak = 5;
            //int tahmin;

            Console.WriteLine("0 ile 100 arasında bir sayıyı tahmin edin. Toplam 5 hakkınız var.");
            
            while (hak > 0)
            {
                Console.Write("Tahmininiz: ");
                if (!int.TryParse(Console.ReadLine(), out int tahmin)) // girilen ifade sayı değilse burası çalışır
                {
                    Console.WriteLine("Geçersiz giriş! Bir tam sayı girin.");
                    break;
                }
                if (tahmin == rastgeleSayi)
                {
                    Console.WriteLine("Tebrikler! Doğru tahmin ettiniz.");
                    break;// komuttan çıkmamız yarar
                }
                else
                {
                    hak--;// işlem sırasında önce hakkı bir azaltıyoruz...

                    if (hak == 0)//kalan haklarımızı kontroll ediyoruz
                    {
                        Console.WriteLine("Üzgünüm, doğru sayıyı tahmin edemediniz. Doğru sayı: " + rastgeleSayi);
                        break; // if bloğundan çıkmaya yarar
                    }
                    if (tahmin < rastgeleSayi) //tahmin ile rastagele sayıyı kıyaslama yapıyoruz
                    {
                        Console.WriteLine("Daha büyük bir sayı tahmin edin. Kalan hakkınız: " + hak);
                    }
                    else
                    {
                        Console.WriteLine("Daha küçük bir sayı tahmin edin. Kalan hakkınız: " + hak);    //1. kullanım şekli
                        Console.WriteLine("Daha küçük bir sayı tahmin edin. Kalan hakkınız: {0}", hak);  //2. kullanım şekli
                        Console.WriteLine($"Daha küçük bir sayı tahmin edin. Kalan hakkınız: {hak}");    //3. kullanım şekli


                    }
                }
            }
        }

        static void Ders1()
        {

        }
   























    }

}




