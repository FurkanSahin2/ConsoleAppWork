using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Delegates_Exceptions
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // TryCatch();

            // Parametresiz - Void metotlara delege yapmak için;
            // ActionDemo();

            // İki parametreli - Return type metotlara delege yapmak için;
            Func<int, int, int> add = Topla;
            Console.WriteLine(Topla(5,9));


            // Üç parametreli - Return type metotlara delege yapmak için;
            Func<int, int, int, int> add2 = Topla2;
            Console.WriteLine(add2(2, 6, 8));

            // Parametresiz - Return type metotlara delege yapmak için
            // Syntax Version - 1;
            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };


            // Syntax Version - 2;
            Func<int> getRandomNumber2 = () => new Random().Next(1, 100);

            Console.WriteLine(getRandomNumber());
            Thread.Sleep(1);
            Console.WriteLine(getRandomNumber2());

            //Console.WriteLine(Topla(2, 6));

            Console.ReadLine();

        }

        static int Topla(int x, int y)
        {
            return x + y;
        }

        static int Topla2(int x, int y, int z)
        {
            return x + y + z;
        }

        private static void ActionDemo()
        {
            HandleException(() =>
            {
                Find();
            });
        }

        private static void TryCatch()
        {
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                // Console.WriteLine(exception.Message);
            }
        }

        // Try - Catch kodlarını tekrar tekrar yazmak yerine Action delegasyonu gerçekleştiriyoruz:
        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            List<string> students = new List<string> { "Furkan", "Ali", "Hasan" };
            
            if (!students.Contains("Furkan"))
            {
                throw new RecordNotFoundException("Record Not Found!");
            }
            else
            {
                Console.WriteLine("Record Found!");
            }
        }
    }
    public class RecordNotFoundException : Exception
    {
        public RecordNotFoundException(Exception exception)
        {
            Console.WriteLine(exception.Message);
        }

        public RecordNotFoundException(string message) : base(message)
        {
        }
    }

}
