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

            Console.WriteLine("---------------------------");
            // Metotlara ulaşmak için:

            var metotlar = tip.GetMethods();

            foreach (var info in metotlar)
            {
                Console.WriteLine("Metot adı: {0}", info.Name);
                foreach (var parametreInfo in info.GetParameters())
                {
                    Console.WriteLine("Parametre: {0}", parametreInfo.Name);
                }
                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute Name: {0}", attribute.GetType().Name );
                }
            }
             
            
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

        [MetotName("Carpma")]
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }

        public class MetotNameAttribute : Attribute
        {
            private string _carpma;

            public MetotNameAttribute(string carpma)
            {
                _carpma = carpma; 
            }
        }


    }

}       






