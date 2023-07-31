using System;

namespace Ders1
{
    class Program
    {
        static void Main(string[] args)// main metoto daima statik olmak zorundadır
        {
            //deneme();
            // int sayi = int.Parse(Console.ReadLine());//f9 breakpoint koymamıza yarıyor...
            // GeriyeDegerDondermeyenVeParametreAlmayan();//metotdu 

            int sayi1, sayi2;//1.iş

            Console.Write("1. sayı giriniz: ");//2. işi // 5
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. sayıyı giriniz: ");//3..iş //10
            sayi2 = int.Parse(Console.ReadLine());

            int toplam = sayi1 + sayi2;
            Console.WriteLine("sayıların toplamı: " + toplam);

            ikisayiTopla(sayi1, sayi2);// 4.iş

            Console.ReadKey();
        }

        static void ikisayiTopla(int s1, int s2) // geri değer döndürmeyen ve parametre alıyor
        {
            Console.WriteLine("sayıların toplamı: " + (s1 + s2));

        }
        

        static void GeriyeDegerDondermeyenVeParametreAlmayan()//metot imza
        {
            Console.WriteLine("geriye değer döndermeyen ve parametre almayan");


        }

        static void metornek()
        {
            #region Degiskenler
            string str; //1
            int i;
            float flm;
            double d;
            decimal dm;
            char c;
            byte by;
            long lng;
            short shr;
            bool bl;
            var vr = 123;
            /* uint 
             ulong
             ushort
             */
            // decimal > double > float = ondalıklı sayı alı 0 - 1
            // long> int > short =tam sayı değğer alır 1 23 -5
            // bool true- False 
            //int sayi1 = 12, sayi2 = 15;

            bool sayikarsilastir = 12 > 15;   // doğru mu yanlış mı //false
            Console.WriteLine(sayikarsilastir);    // false


            bool karsi = 15 > 12;//true
            if (karsi)//false == false //doğtruu
            {
                Console.WriteLine("if içine girfiniz...");  //true
            }
            else
            {
                Console.WriteLine("biliyorom yanlış yaptın o yizden bana gelidin demiiii");
            }





            #endregion
        }
        /// <summary>
        /// 
        /// </summary>
        static void OdevResulHoca()
        {
            Console.WriteLine("Cinsiyetinizi girin (Erkek/Kadın): ");
            string cinsiyet = Console.ReadLine().ToLower();

            Console.WriteLine("Çocuğunuz var mı? (Evet/Hayır): ");
            string cocukDurumu = Console.ReadLine().ToLower();

            Console.WriteLine("Çalışma yıl sayınızı girin: ");
            int calismaYil = int.Parse(Console.ReadLine());

            double indirimTutar = 0;
            double anaPara = 900;

            bool durum = cinsiyet == "kadın";

            if (durum)
            {
                if (calismaYil >= 0 && calismaYil <= 5)
                    indirimTutar = anaPara * 0.05;
                else if (calismaYil >= 6 && calismaYil <= 10)
                    indirimTutar = anaPara * 0.07;
                else if (calismaYil >= 11 && calismaYil <= 15)
                    indirimTutar = anaPara * 0.12;
                else if (calismaYil >= 16 && calismaYil <= 20)
                    indirimTutar = anaPara * 0.17;
                else if (calismaYil >= 21)
                    indirimTutar = 250 + (anaPara * 0.09);
            }
            else if (cinsiyet == "kadın" && cocukDurumu == "evet")
            {
                if (calismaYil >= 0 && calismaYil <= 5)
                    indirimTutar = anaPara * 0.04;
                else if (calismaYil >= 6 && calismaYil <= 10)
                    indirimTutar = anaPara * 0.09;
                else if (calismaYil >= 11 && calismaYil <= 15)
                    indirimTutar = anaPara * 0.14;
                else if (calismaYil >= 16 && calismaYil <= 20)
                    indirimTutar = anaPara * 0.19;
                else if (calismaYil >= 21)
                    indirimTutar = 350 + (anaPara * 0.09);
            }
            else if (cinsiyet == "erkek")
            {
                if (calismaYil >= 0 && calismaYil <= 5)
                    indirimTutar = anaPara * 0.03;
                else if (calismaYil >= 6 && calismaYil <= 10)
                    indirimTutar = anaPara * 0.08;
                else if (calismaYil >= 11 && calismaYil <= 15)
                    indirimTutar = anaPara * 0.12;
                else if (calismaYil >= 16 && calismaYil <= 20)
                    indirimTutar = anaPara * 0.17;
                else if (calismaYil >= 21)
                    indirimTutar = 225 + (anaPara * 0.085);
            }
            else if (cinsiyet == "erkek" && cocukDurumu == "evet")
            {
                if (calismaYil >= 0 && calismaYil <= 5)
                    indirimTutar = anaPara * 0.035;
                else if (calismaYil >= 6 && calismaYil <= 10)
                    indirimTutar = anaPara * 0.08;
                else if (calismaYil >= 11 && calismaYil <= 15)
                    indirimTutar = anaPara * 0.13;
                else if (calismaYil >= 16 && calismaYil <= 20)
                    indirimTutar = anaPara * 0.18;
                else if (calismaYil >= 21)
                    indirimTutar = 324.75 + (anaPara * 0.085);
            }

            double yeniFiyat = anaPara - indirimTutar;
            Console.WriteLine("Yeni fiyat hesaplaması: " + yeniFiyat);
        }
        /// <summary>
        /// 3slash yaptığında summary 
        /// </summary>
        static void IkiSayiKarsilastir()
        {

        }
        static void icerikler()
        {
            #region Konsoldan Değer Okuma
            Console.Write("Adınızı ve soyadınızı giriniz: "); // Write methodu değeri yazdırdıktan sonra WriteLine gibi bir alt satıra geçmez
            string adSoyad = Console.ReadLine(); // konsoldan değer okunur ve adSoyad değişkenine atanır
            Console.WriteLine("Adınız ve soyadınız: " + adSoyad);
            #endregion



            #region Operatörler
            // Logical operators (Mantıksal operatörler): && (and), || (or), ! (not)
            // Relational operators (İlişkisel operatörler): ==, !=, >=, <=, >, <
            // Arithmetic operators (Aritmetik operatörler): +, -, *, /, %
            // Assignment operator (Atama operatörü): =
            #endregion



            #region Logical Operators (Mantıksal Operatörler)
            /* Önermeler: 1 = true, 0 = false
             * p    q       ve (&&)
             * --------------------
             * 0    0       0
             * 0    1       0
             * 1    0       0
             * 1    1       1
             * 
             * p    q     veya (||)
             * --------------------
             * 0    0       0
             * 0    1       1
             * 1    0       1
             * 1    1       1
            */
            #endregion



            #region if Şart Yapısı ve Algoritmalar

            // Algoritma: Bir problemin çözümü için oluşturulan iyi tanımlanmış adımlardır. Amaç problemi parçalara ayırıp her bir parçayı ayrı ayrı çözerek problemin çözülmesini sağlamaktır.
            // Algoritma oluşturmak için istenirse kağıt üzerinde istenirse de Akış Diyagramları (Flow Chart) kullanılabilir. Algoritma oluşturulduktan sonra kod üzerinde uygulanır.



            int sayi = 10;
            if (sayi == 10)
                Console.WriteLine("On");
            // sayi == 10 true sonucunu vereceği için if içerisindeki satırlar çalıştırılarak ekrana On yazdırılır. eğer ; ile biten tek kod bloğu kullanılacaksa süslü parantez ({, }) kullanmak şart değildir



            sayi = 20;
            if (sayi == 10)
            {
                Console.WriteLine("On");
            }
            // sayi == 10 false sonucunu vereceği için if içerisindeki satırlar çalıştırılmayacaktır ve ekranda herhangi bir çıktı olmayacaktır



            sayi = 30;
            if (sayi == 10)
            {
                Console.WriteLine("On");
            }
            else // yukarıdaki if koşulunun değili yani sayi != 10 veya !(sayi == 10)
            {
                Console.WriteLine("On değil");
            }
            // sayi == 10 false sonucunu vereceği için else içerisindeki satırlar çalıştırılarak konsola On değil yazdırılacaktır



            // Algoritma Örnek 1: Yaş Grubu
            /*
            1. başla
            2. kullanıcıya yaş sorulur
            3. kullanıcıdan yaşı alınır
            4. eğer kullanıcının yaşı 0 ile 30 arasında ise genç
            5. eğer kullanıcının yaşı 31 ile 60 arasında ise orta yaşlı
            6. eğer kullanıcının yaşı 60'tan büyük ise yaşlı olarak belirlenip
            7. ekrana kullanıcının yaşı ile yaş karşılığı yazdırılır
            8. bitiş
            */
            string yasSonucu; // aşağıdaki tüm kodlar çalıştırıldıktan sonra ekrana yazdıracağımız yaşın karşılığı, tüm if, else if ve else içerisinde değeri mutlaka atanmalıdır
            Console.Write("Yaşınız: ");
            string giris = Console.ReadLine();
            int yas = Convert.ToInt32(giris); // yaş sayısal bir veri olduğu için kullanıcından Console.ReadLine ile metinsel veri (string) alındıktan sonra
                                              // Convert.ToInt32 methodu ile integer'a dönüştürülüp yas değişkenine atanır
            if (yas >= 0 && yas <= 30) // yas 0 ve 30 aralığında ise (0 ve 30 dahil),
                                       // örnek 1: yas 15 için yas >= 0 = true, yas <= 30 = true, true && true = true sonucunu verir ve if içerisindeki kodlar çalıştırılır,
                                       // örnek 2: yas 35 için yas => 0 = true, yas <= 30 = false, true && false = false sonucunu verir ve if atlanır
            {
                yasSonucu = "Genç";
            }
            else if (yas >= 31 && yas <= 60) // yas 31 ve 60 aralığında ise (31 ve 60 dahil),
                                             // aralık kesişmelerine dikkat edilmelidir yani kesişme olmamalıdır, yukarıdaki if koşulunda üst sınır 30, bu satırdaki else if koşulunda alt sınır 31 olmalıdır
            {
                yasSonucu = "Orta yaşlı";
            }
            else // yukarıdaki if ve else if koşullarının değili yani yas < 0 || yas > 60
            {
                yasSonucu = "Yaşlı";
            }
            Console.WriteLine($"Yaşınız: {yas} ({yasSonucu})");



            // Algoritma Örnek 2: Not Sonucu
            /*
            1. başla
            2. kullanıcıya 0 ile 100 arasında not sorulur
            3. kullanıcından not alınır
            4. eğer kullanıcının notu 0'dan küçük veya 100'den büyükse ekrana geçersiz not yazdırılır
            5. eğer kullanıcının notu 0 ile 59 arasında ise ekrana kaldı yazdırılır,
            6. eğer kullanıcının notu 60 ile 100 arasında ise ekrana geçti yazdırılır
            7. bitiş
            */
            Console.Write("Not giriniz: ");
            int not = Convert.ToInt32(Console.ReadLine()); // Console.ReadLine methodu ile kullanıcıdan giriş aldındıktan sonra Convert.ToInt32 methodu ile integer'a dönüştürülüp sonucu değişkene atanabilir

            // 1. yöntem:
            //if (not < 0 || not > 100)
            //    Console.WriteLine("Geçersiz not");
            //else if (not >= 0 && not < 60)
            //    Console.WriteLine("Kaldı");
            //else
            //    Console.WriteLine("Geçti");

            // 2. yöntem:
            if (not < 0 || not > 100)
            {
                Console.WriteLine("Geçersiz not");
            }
            else // yukarıdaki if koşulu yani (not < 0 || not > 100)'ün değili: !(not < 0 || not > 100): (not >= 0 && not <= 100)
                 // herhangi bir koşulun değili alınırken &&: ||, ||: &&, =: !=, !=: =, >: <=, <: >=, >=: <, <=: > olarak dönüştürülür
            {
                if (not >= 0 && not < 60) // herhangi bir if veya else içerisinde istenildiği kadar if veya if else blokları kullanılabilir
                {
                    Console.WriteLine("Kaldı");
                }
                else // yukarıdaki if koşulu yani (not => 0 && not < 60)'ın değili: !(not => 0 && not < 60): (not < 0 || not >= 60)
                {
                    Console.WriteLine("Geçti");
                }
            }

            #endregion




        }
        static void deneme()
        {
            Console.WriteLine("Vize1, Vize2 ve Final Notu Hesaplama Programına Hoş Geldiniz!");
            // Notları yüzdelik dilimlere göre ağırlıklı olarak hesaplama
            double vize1Yuzde = 0.4;
            double vize2Yuzde = 0.4;
            double finalYuzde = 0.6;

            // Kullanıcıdan vize1, vize2 ve final notlarını almak için
            Console.Write("Vize1 Notunuzu Giriniz: ");
            double vize1Not = double.Parse(Console.ReadLine());

            Console.Write("Vize2 Notunuzu Giriniz: ");
            double vize2Not = double.Parse(Console.ReadLine());

            Console.Write("Final Notunuzu Giriniz: ");
            double finalNot = double.Parse(Console.ReadLine());

            // Notların geçerli aralıkta olup olmadığını kontrol etme
            if (vize1Not < 0 || vize1Not > 100 || vize2Not < 0 || vize2Not > 100 || finalNot < 0 || finalNot > 100)
            {
                Console.WriteLine("Geçersiz not girişi. Notlar 0-100 aralığında olmalıdır.");
            }
            else
            {
                double toplamVizeNotu = (vize1Not + vize2Not) / 2;
                double ortalama = (toplamVizeNotu * (vize1Yuzde + vize2Yuzde)) + (finalNot * finalYuzde);

                // Ortalamayı ekrana yazdırma
                Console.WriteLine($"Ortalamanız: {ortalama}");

                // Ortalamaya göre durumu belirleme
                if (ortalama >= 60)
                {
                    Console.WriteLine("Geçtiniz.");
                }
                else
                {
                    Console.WriteLine("Kaldınız.");
                }
            }
        }
        static void MerveVizeFinal()
        {
            double ortalama, vize1, vize2, final;

            Console.Write("Lütfen vize 1 notunuzu giriniz : ");
            vize1 = Convert.ToDouble(Console.ReadLine());
            if (vize1 >= 0 && vize1 <= 100)
            {
                Console.Write("Lütfen vize 2 notunuzu giriniz : ");
                vize2 = Convert.ToDouble(Console.ReadLine());
                if (vize2 >= 0 && vize2 <= 100)
                {
                    Console.Write("Lütfen final notunuzu giriniz : ");
                    final = Convert.ToDouble(Console.ReadLine());
                    if (final >= 0 && final <= 100)
                    {
                        ortalama = ((vize1 + vize2) * 0.2) + (final * 0.6);
                        if (ortalama >= 60)
                        {
                            Console.WriteLine("Geçti");
                        }
                        else
                        {
                            Console.WriteLine("Kaldı");
                        }
                    }
                }
                else
                {
                    Console.Write("Lütfen vize 2 notunuzu giriniz : ");
                    vize2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Lütfen final notunuzu giriniz : ");
                    final = Convert.ToDouble(Console.ReadLine());
                    if (final >= 0 && final <= 100)
                    {
                        ortalama = ((vize1 + vize2) * 0.2) + (final * 0.6);
                        if (ortalama >= 60)
                        {
                            Console.WriteLine("Geçti");
                        }
                        else
                        {
                            Console.WriteLine("Kaldı");
                        }
                    }
                    else
                    {
                        Console.Write("Lütfen final notunuzu giriniz : ");
                        final = Convert.ToDouble(Console.ReadLine());
                        ortalama = ((vize1 + vize2) * 0.2) + (final * 0.6);
                        if (ortalama >= 60)
                        {
                            Console.WriteLine("Geçti");
                        }
                        else
                        {
                            Console.WriteLine("Kaldı");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Geçersiz not tekrar giriniz");
                Console.Write("Lütfen vize 1 notunuzu giriniz : ");
                vize1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Lütfen vize 2 notunuzu giriniz : ");
                vize2 = Convert.ToDouble(Console.ReadLine());
                if (vize2 >= 0 && vize2 <= 100)
                {
                    Console.Write("Lütfen final notunuzu giriniz : ");
                    final = Convert.ToDouble(Console.ReadLine());
                    if (final >= 0 && final <= 100)
                    {
                        ortalama = ((vize1 + vize2) * 0.2) + (final * 0.6);
                        if (ortalama >= 60)
                        {
                            Console.WriteLine("Geçti");
                        }
                        else
                        {
                            Console.WriteLine("Kaldı");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz not tekrar giriniz");
                    Console.Write("Lütfen vize 2 notunuzu giriniz : ");
                    vize2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Lütfen final notunuzu giriniz : ");
                    final = Convert.ToDouble(Console.ReadLine());
                    if (final >= 0 && final <= 100)
                    {
                        ortalama = ((vize1 + vize2) * 0.2) + (final * 0.6);
                        if (ortalama >= 60)
                        {
                            Console.WriteLine("Geçti");
                        }
                        else
                        {
                            Console.WriteLine("Kaldı");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz not lütfen tekrar giriniz");
                        Console.Write("Lütfen final notunuzu giriniz : ");
                        final = Convert.ToDouble(Console.ReadLine());
                        ortalama = ((vize1 + vize2) * 0.2) + (final * 0.6);
                        if (ortalama >= 60)
                        {
                            Console.WriteLine("Geçti");
                        }
                        else
                        {
                            Console.WriteLine("Kaldı");
                        }
                    }
                }

            }
        }
    }
}
