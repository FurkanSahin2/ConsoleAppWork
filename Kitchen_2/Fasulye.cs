using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen_2
{
    internal class Fasulye : IYemek
    {
        private IYag _yag;

        public Fasulye(IYag yag)
        {
            _yag = yag;
        }

        public void Pisir()
        {
            var result = _yag.Kullan();
            Console.WriteLine(result);
        }
    }
}
