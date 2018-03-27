using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02_02
{
    class Program
    {
        public int SumAll(params int[] aNumbers) {
            int i;
            int tmp = 0;
            for (i = 0; i < aNumbers.Length; i++) {
                tmp += aNumbers[i];
            }
            return (tmp);
        }
        static void Main(string[] args)
        {
            Program tmpC = new Program();
            int total1 = tmpC.SumAll(1, 2);
            int total2 = tmpC.SumAll(1, 2,3,4,5);
            int total3 = tmpC.SumAll(1, 2,3,4,5,6,7,8,9,10);
            Console.WriteLine(total1);
            Console.WriteLine(total2);
            Console.WriteLine(total3);

            Console.ReadKey();
        }
    }
}
