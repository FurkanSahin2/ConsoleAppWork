using System;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Hesap Makinesi Uygulamasına Hoş Geldiniz!");

                Console.Write("İlk Sayıyı Girin: ");
                double sayi1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("İkinci Sayıyı Girin: ");
                double sayi2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("İşlem Türünü Seçiniz: + | - | * | / :  ");
                char ıslemTuru = Convert.ToChar(Console.ReadLine());

                double sonuc = 0;

                switch (ıslemTuru)
                {
                        case '+':
                        sonuc = sayi1 + sayi2;
                        break;
      
                        case '-':
                        sonuc = sayi1 - sayi2;
                        break;
                
                        case '*':
                        sonuc = sayi1 * sayi2;
                        break;
                
                        case '/':
                        if (sayi2 != 0)
                            {
                                sonuc = sayi1 / sayi2;
                            }
                        else
                            {
                                Console.WriteLine("Hata: Bölen sıfır olamaz!");
                            }
                        break;

                        default:
                            Console.WriteLine("Hata: Geçersiz işlem türü!");
                        break;
                }

                Console.WriteLine("Sonuç: " + sonuc);

                Console.WriteLine("Hesap Makinesi Uygulaması Başarıyla Sonlandı. Çıkmak için bir tuşa basın!");
                Console.ReadKey();
        }
    }
}
    


