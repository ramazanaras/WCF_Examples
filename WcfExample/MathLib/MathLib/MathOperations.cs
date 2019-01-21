using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    public class MathOperations : IMathOperations
    {
        public int Topla(int x, int y)
        {
            return x + y;
        }

        public int Carp(int x, int y)
        {
            return x * y;
        }

        public int Bol(int x, int y)
        {
            return x / y;
        }
    }
}
