using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(2,3);
            //Console.WriteLine(dortIslem.Topla2());
            //Console.WriteLine(dortIslem.Topla(3, 4)); 

            var tip = typeof(DortIslem);

            //DortIslem dortIslem = (DortIslem)Activator.CreateInstance(tip,2,5);
            //Console.WriteLine(dortIslem.Topla(2, 6));
            //Console.WriteLine(dortIslem.Topla2());

            var instance = Activator.CreateInstance(tip, 6, 5);

            // 'GetMethod' ile istediğimiz methoda ulaşabiliyoruz. 'Invoke' ile de onu çalıştırabiliyoruz.

            // 1.Yol:
            // Console.WriteLine(instance.GetType().GetMethod("Topla2").Invoke(instance, null));

            // 2. Yol:
            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");
            Console.WriteLine(methodInfo.Invoke(instance, null));
            Console.ReadLine();
        }
    }

    public class DortIslem
    {
        private int _sayi1;
        private int _sayi2;
        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }

        public DortIslem()
        {
            
        }

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }
    }

}       




// Hesap Makinesi Uygulamam:
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Hesap Makinesi Uygulamasına Hoş Geldiniz!");

//        Console.Write("İlk Sayıyı Girin: ");
//        double sayi1 = Convert.ToDouble(Console.ReadLine());

//        Console.Write("İkinci Sayıyı Girin: ");
//        double sayi2 = Convert.ToDouble(Console.ReadLine());

//        Console.Write("İşlem Türünü Seçiniz: + | - | * | / :  ");
//        char ıslemTuru = Convert.ToChar(Console.ReadLine());

//        double sonuc = 0;

//        switch (ıslemTuru)
//        {
//            case '+':
//                sonuc = sayi1 + sayi2;
//                break;
//            case '-':
//                sonuc = sayi1 - sayi2; 
//                break;
//            case '*':
//                sonuc = sayi1 * sayi2; 
//                break;
//            case '/':
//                if (sayi2 != 0)
//                {
//                    sonuc = sayi1 / sayi2;
//                }
//                else
//                {
//                    Console.WriteLine("Hata: Bölen sıfır olamaz!");
//                }
//                break;

//            default:
//                Console.WriteLine("Hata: Geçersiz işlem türü!");
//                break;
//        }

//        Console.WriteLine("Sonuç: " + sonuc);

//        Console.WriteLine("Hesap Makinesi Uygulaması Sonlandı. Çıkmak için bir tuşa basın!");
//        Console.ReadKey();

//    }
//}


