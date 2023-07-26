using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDelegate();
    public delegate void MyDelegate2(string text);
    public delegate int MyDelegate3(int number1, int number2);

    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();

            MyDelegate myDelegate = customerManager.SendMessage;
            // Version - 2:
            //MyDelegate myDelegate = new MyDelegate(customerManager.SendMessage);
            
            // Eklemek için;
            myDelegate += customerManager.ShowAlert;
            // Çıkartmak için;
            myDelegate -= customerManager.SendMessage;

            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2 += customerManager.ShowAlert2;

            Matematik matematik = new Matematik();

            MyDelegate3 myDelegate3 = matematik.Topla;
            myDelegate3 += matematik.Carp;
            int sonuc = myDelegate3(2, 5);
            
            Console.WriteLine(sonuc);
            // Consol'da 'matematik.Topla' görmezden gelindi. Çünkü bu delege bir int döndürüyor ve...
            // eğer bir delegenin geri dönüş tipi 'return type' ise consola son verdiğimiz delegeyi ekrana yazacaktır.  
            

            myDelegate2("Hello");
            // myDelegate2("Dikkat et!");
            myDelegate();
            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello!");
        }
        public void ShowAlert()
        {
            Console.WriteLine("Be Careful!");
        }
        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }
        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert);
        }
    }

    public class Matematik
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }
}
