using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01.HelloWorld
{
    class CMyClass
    {
        public static int Add(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            return (a + b);
        }
        public int Multiply(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a * b);
            return (a * b);
        }
        static void Main(string[] args)
        {
            int res1 = CMyClass.Add(5, 6);
            Console.WriteLine("{0}", res1);

            CMyClass tmpMC = new CMyClass();
            int res2 = tmpMC.Multiply(5, 6);
            Console.WriteLine("{0}", res2);
        }
    }
}
