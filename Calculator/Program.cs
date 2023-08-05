using System;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {

            // Hesap makinesi:

            //Console.WriteLine("Hesap Makinesi Uygulamasına Hoş Geldiniz!");

            //Console.Write("İlk Sayıyı Girin: ");
            //double sayi1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("İkinci Sayıyı Girin: ");
            //double sayi2 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("İşlem Türünü Seçiniz: + | - | * | / :  ");
            //char ıslemTuru = Convert.ToChar(Console.ReadLine());

            //double sonuc = 0;

            //switch (ıslemTuru)
            //{
            //        case '+':
            //        sonuc = sayi1 + sayi2;
            //        break;

            //        case '-':
            //        sonuc = sayi1 - sayi2;
            //        break;

            //        case '*':
            //        sonuc = sayi1 * sayi2;
            //        break;

            //        case '/':
            //        if (sayi2 != 0)
            //            {
            //                sonuc = sayi1 / sayi2;
            //            }
            //        else
            //            {
            //                Console.WriteLine("Hata: Bölen sıfır olamaz!");
            //            }
            //        break;

            //        default:
            //            Console.WriteLine("Hata: Geçersiz işlem türü!");
            //        break;
            //}

            //Console.WriteLine("Sonuç: " + sonuc);

            //Console.WriteLine("Hesap Makinesi Uygulaması Başarıyla Sonlandı. Çıkmak için bir tuşa basın!");
            //Console.ReadKey();



            // Bu kodu çalıştırdığınızda, program size 5 sayı girmenizi isteyecek ve ardından bu sayıların toplamını hesaplayacak ve ekrana yazdıracaktır.


            //        Console.WriteLine("Sayı toplama programına hoşgeldiniz!");

            //        int sayi1, sayi2, sayi3, sayi4, sayi5;
            //        int toplam = 0;

            //        Console.Write("5 adet sayı giriniz: ");
            //        sayi1 = Convert.ToInt32(Console.ReadLine());
            //        sayi2  = Convert.ToInt32(Console.ReadLine());
            //        sayi3 = Convert.ToInt32(Console.ReadLine());
            //        sayi4 = Convert.ToInt32(Console.ReadLine());
            //        sayi5 = Convert.ToInt32(Console.ReadLine());

            //        toplam = sayi1 + sayi2 + sayi3 + sayi4 + sayi5;
            //        Console.WriteLine("Girilen sayıların toplamı = " + toplam);
            //        Console.WriteLine("Programdan çıkış yapmak için bir tuşa basın");
            //        Console.ReadLine();
            //}


            // Bu program, kullanıcıdan bir dizi sayı girmesini isteyecek ve girilen sayıların toplamını hesaplayacaktır. Kullanıcı 0 (sıfır) girdiğinde,
            // program çalışmayı durduracak ve girilen sayıların toplamını ekrana yazdıracaktır.


            int sayi, toplam = 0;
            Console.WriteLine("Not: Sayıları girdikten sonra 0 tuşuna basın!");
            Console.Write("Toplamak istediğiniz sayıları giriniz: ");

            do
            {
                sayi = Convert.ToInt32(Console.ReadLine());
                toplam += sayi;
            } while (sayi != 0);

            Console.WriteLine("Girilen sayıların toplamı: " + toplam);
            Console.ReadLine();




        }

       
    }

}







