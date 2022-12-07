/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2021-2022 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: ÖDEV 1
**				ÖĞRENCİ ADI............: MUHAMMED FATİH YILDIRIM
**				ÖĞRENCİ NUMARASI.......: G211210379
**              DERSİN ALINDIĞI GRUP...: 2. ÖĞRETİM B GRUBU
****************************************************************************/

using System;

namespace NDPodev1MFY
{
    static class karakterler
    {
        public static string sifre;//main kısmında kullanıcıdan istediğimiz şifreyi bu değişkene atayacağım

        public static int BuyukHarf()//büyük harf sayısını döndüren metod
        {
            int BHSayac = 0;

            for (int i = 0; i < sifre.Length; i++)
            {
                if (Char.IsUpper(sifre[i]))
                {
                    BHSayac++;
                }
            }
            return BHSayac;
        }
        public static int KucukHarf()//küçük harf sayısını döndüren metod
        {
            int KHSayac = 0;

            for (int i = 0; i < sifre.Length; i++)
            {
                if (Char.IsLower(sifre[i]))
                {
                    KHSayac++;

                }
            }
            return KHSayac;
        }
        public static int Rakam()//rakam sayısını döndüren metod
        {
            int RSayac = 0;

            for (int i = 0; i < sifre.Length; i++)
            {
                if (Char.IsNumber(sifre[i]))
                {
                    RSayac++;
                }
            }
            return RSayac;
        }
        public static int Sembol()//sembol sayısını döndüren metod(char.Issymbol() fonksiyonu hata verdiği için ascii table'daki decimal degerleri kullanarak bütün sembol karakterleri kendim girmek zorunda kaldım.)
        {
            int SSayac = 0;

            for (int i = 0; i < sifre.Length; i++)
            {
                if (sifre[i] == (char)33 || sifre[i] == (char)34 || sifre[i] == (char)35 || sifre[i] == (char)36 || sifre[i] == (char)37 || sifre[i] == (char)38 || sifre[i] == (char)39 || sifre[i] == (char)40 || sifre[i] == (char)41 || sifre[i] == (char)42 || sifre[i] == (char)43 || sifre[i] == (char)44 || sifre[i] == (char)45 || sifre[i] == (char)46 || sifre[i] == (char)47 || sifre[i] == (char)58 || sifre[i] == (char)59 || sifre[i] == (char)60 || sifre[i] == (char)61 || sifre[i] == (char)62 || sifre[i] == (char)63 || sifre[i] == (char)64 || sifre[i] == (char)91 || sifre[i] == (char)92 || sifre[i] == (char)93 || sifre[i] == (char)94 || sifre[i] == (char)95 || sifre[i] == (char)96 || sifre[i] == (char)123 || sifre[i] == (char)123 || sifre[i] == (char)125 || sifre[i] == (char)126)
                {
                    SSayac++;
                }
            }
            return SSayac;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int kontrol = 0;//eğer bu değer 1 olursa en alttaki while ile bir kere daha do kısmını döndürecek
            do
            {
                int puan = 0;

                Console.WriteLine("lutfen bir sifre giriniz");

                karakterler.sifre = Console.ReadLine();

                bool boslukvarmi = false;

                for (int i = 0; i < karakterler.sifre.Length; i++)//şifrenin elemanlarını gezerek boşluk varmı kontrol ettim.
                {
                    if (karakterler.sifre[i] == (char)32)//space(bosluk) karakterinin ascii değeri
                    {
                        boslukvarmi = true;
                    }
                }

                if (boslukvarmi == false)//boşluk yoksa buraya girer.
                {

                    if (karakterler.sifre.Length >= 9)//şifrenin uzunluğu en az 9 olmalı.
                    {

                        if (karakterler.sifre.Length == 9)//şifrenin uzunluğu 9 ise 10 puan ekler
                        {
                            puan += 10;
                        }
//***************************************************************************************************************************************************************************
                        if (karakterler.BuyukHarf() == 1)//büyük harf sayısı 1 ise puan değişkeni 10 artar.
                        {
                            puan += 10;
                        }
                        else if (karakterler.BuyukHarf() > 1)//büyük harf sayısı 1'den fazla ise puan değişkeni 20 artar.
                        {
                            puan += 20;
                        }
                        else//büyük harf yoksa kontrol değişkeni 1 olur ve döngü tekrar baştan döner.
                        {
                            Console.WriteLine("En az 1 adet buyuk harf kullanmalısınız.yeni sifre girin");
                            kontrol = 1;
                        }
//***************************************************************************************************************************************************************************
                        if (karakterler.KucukHarf() == 1)//küçük harf sayısı 1 ise puan değişkeni 10 artar.
                        {
                            puan += 10;
                        }
                        else if (karakterler.KucukHarf() > 1)//küçük harf sayısı 1'den fazla ise puan değişkeni 20 artar.
                        {
                            puan += 20;
                        }
                        else//küçük harf yoksa kontrol değişkeni 1 olur ve döngü tekrar baştan döner.
                        {
                            Console.WriteLine("En az 1 adet kucuk harf kullanmalısınız.yeni sifre girin");
                            kontrol = 1;
                        }
//***************************************************************************************************************************************************************************
                        if (karakterler.Rakam() == 1)//rakam sayısı 1 ise puan değişkeni 10 artar.
                        {
                            puan += 10;
                        }
                        else if (karakterler.Rakam() > 1)//rakam sayısı 1'den fazla ise puan değişkeni 20 artar.
                        {
                            puan += 20;
                        }
                        else//rakam yoksa kontrol değişkeni 1 olur ve döngü tekrar baştan döner.
                        {
                            Console.WriteLine("En az 1 adet rakam kullanmalısınız.yeni sifre girin");
                            kontrol = 1;
                        }
//***************************************************************************************************************************************************************************
                        if (karakterler.Sembol() < 1)//sembol yoksa kontrol değişkeni 1 olur yani tekrardan şifre istenir.
                        {
                            Console.WriteLine("En az 1 adet sembol kullanmalısınız.yeni sifre girin");
                            kontrol = 1;
                        }
                        else//sembol adedi ile 10 çarpılarak puana eklenir.
                        {
                            puan += karakterler.Sembol() * 10;
                        }

                    }
                    else//şifre 9 karakterden küçükse kontol değişkeni 1 olur ve döngü tekrar baştan döner.
                    {
                        Console.WriteLine("sifren 9 karakterden dusuk.yeni sifre girin.");
                        kontrol = 1;
                    }
                }
                else//şifre boşluk içeriyorsa zaten hiç puan eklenmeden bu kısmı atlanır. kontrol değişkeni 1 olduğundan do while döngüsü tekrar döner.
                {
                    Console.WriteLine("sifren bosluk iceriyor!!!.yeni sifre girin");
                    kontrol = 1;
                }
//****************************************************************************************************************************************************************************

                if (karakterler.BuyukHarf() >= 1 && karakterler.KucukHarf() >= 1 && karakterler.Rakam() >= 1 && karakterler.Sembol() >= 1 && boslukvarmi == false)//her karakterden en az 1 tane kullanılmış ve boşluk içermeyen şifrenin puanını değerlendirelim.
                {
                    if (puan >= 90)//90dan yüksek ise güçlü şifredir.
                    {

                        Console.WriteLine("sifren guclu");
                        Console.WriteLine(" {0} adet buyuk harf kullandınız", karakterler.BuyukHarf());
                        Console.WriteLine(" {0} adet kucuk harf kullandınız", karakterler.KucukHarf());
                        Console.WriteLine(" {0} adet rakam kullandınız", karakterler.Rakam());
                        Console.WriteLine(" {0} adet sembol kullandınız", karakterler.Sembol());
                        Console.WriteLine(" sifrenizin puanı : {0}", puan);
                        Console.WriteLine("yeni sifre girmek icin 'e' basın.cikmak icin herhangi bir tusa basin");
                        string Ssecim = Console.ReadLine();
                        char secim = char.Parse(Ssecim);

                        if (secim == 'e')//eğer e harfine basarsa kullanıcı tekrardan başa dönecek ve yeniden şifre girecek.
                        {
                            kontrol = 1;
                        }
                        else//başka bir harfe bastığında programı bitirir.
                        {
                            kontrol = 0;
                        }

                    }
                    else if (puan >= 70 && puan < 90)//70 ile 90 puan arasındaki şifre kabul edilebilir.
                    {
                        Console.WriteLine("sifren makul");
                        Console.WriteLine(" {0} adet buyuk harf kullandınız", karakterler.BuyukHarf());
                        Console.WriteLine(" {0} adet kucuk harf kullandınız", karakterler.KucukHarf());
                        Console.WriteLine(" {0} adet rakam kullandınız", karakterler.Rakam());
                        Console.WriteLine(" {0} adet sembol kullandınız", karakterler.Sembol());
                        Console.WriteLine(" sifrenizin puanı : {0}", puan);
                        Console.WriteLine("yeni sifre girmek icin 'e' basın.cikmak icin herhangi bir tusa basin");
                        string Ssecim = Console.ReadLine();
                        char secim = char.Parse(Ssecim);
                        if (secim == 'e')//eğer e harfine basarsa kullanıcı tekrardan başa dönecek ve yeniden şifre girecek.
                        {
                            kontrol = 1;
                        }
                        else//başka bir harfe bastığında programı bitirir.
                        {
                            kontrol = 0;
                        }

                    }
                    else//70 puandan düşük şifre kabul edilemez.
                    {
                        Console.WriteLine("sifren 70 puandan dusuk.yeni sifre girinn");
                        kontrol = 1;
                    }

                }

            } while (kontrol == 1);
        }
    }
}
