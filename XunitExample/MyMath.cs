using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XunitExample
{
    public class MyMath
    {
        public bool EvenOrOdd(int x)
        {
            return x % 2 == 0;
        }

        public int Add(int x, int y)
        {
            return x + y;
        }
    }
}
