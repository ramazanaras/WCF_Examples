using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfHesaplaLib
{
    public class Hesapla : IIslemler //implemente ettik
    {
        public int SayilariTopla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int SayilariCikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}
