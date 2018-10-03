using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04_02
{
    class Program
    {
        public delegate int calculater(int a, int b);
        public static int Plus(int a, int b)
        {
            Console.WriteLine("{0}+{1}={2}", a, b, a + b);
            return (a + b);
        }
        public static int Minus(int a, int b)
        {
            Console.WriteLine("{0}-{1}={2}", a, b, a - b);
            return (a - b);
        }
        public static int Multiply(int a, int b)
        {
            Console.WriteLine("{0}*{1}={2}", a, b, a * b);
            return (a * b);
        }
        public static int Divide(int a, int b)
        {
            Console.WriteLine("{0}/{1}={2}", a, b, a / b);
            return (a / b);
        }

        public calculater DelegateOper;
        public event calculater EventOper;
        static void Main(string[] args)
        {
            calculater cal1;
            cal1 = new calculater(Plus);
            int res1 = cal1(3, 5);
            Console.WriteLine("return : {0}", res1);

            calculater cal2;
            cal2 = new calculater(Multiply);
            int res2 = cal2(4, 5);
            Console.WriteLine("return : {0}", res2);

            calculater cal3;
            cal3 = new calculater(Divide);
            int res3 = cal3(10, 5);
            Console.WriteLine("return : {0}", res3);

            calculater tmpOperation;
            tmpOperation = new calculater(Plus);
            tmpOperation += new calculater(Minus);

            tmpOperation(8, 9);

            tmpOperation += new calculater(Multiply);
            tmpOperation += new calculater(Divide);

            tmpOperation(3, 2);

            Console.WriteLine("Remove");
            tmpOperation -= new calculater(Minus);
            tmpOperation(7, 3);

            tmpOperation += delegate (int a, int b)
            {
                Console.WriteLine("{0}%{1}={2}", a, b, a % b);
                return (a % b);
            };
            tmpOperation(4, 3);

            Program tmpPrg = new Program();

            tmpPrg.DelegateOper = new calculater(Plus);
            tmpPrg.DelegateOper += new calculater(Multiply);
            tmpPrg.DelegateOper(2, 3);

            tmpPrg.DelegateOper = new calculater(Minus);
            tmpPrg.DelegateOper += new calculater(Divide);
            tmpPrg.DelegateOper(4,5);

            List<string> tmpStrs = new List<string>();

            tmpStrs.Add("flower");
            tmpStrs.Add("leaf");
            tmpStrs.Add("tree");

            tmpStrs.Sort(delegate (string a, string b)
            {
                return b.CompareTo(a);
            });

            foreach(string iter in tmpStrs)
            {
                Console.WriteLine(iter);
            }

            List<int> tmpInts = new List<int>();
            tmpInts.Add(51);
            tmpInts.Add(15);
            tmpInts.Add(27);
            tmpInts.Add(41);
            tmpInts.Add(32);

            tmpInts.Sort(delegate (int a, int b)
            {
                return b.CompareTo(a);
            });
            Console.WriteLine("DES");
            foreach(int iter in tmpInts)
            {
                Console.WriteLine(iter);
            }
            Console.WriteLine("ASC");
            tmpInts.Sort(delegate (int a, int b)
            {
                return a.CompareTo(b);
            });
            foreach (int iter in tmpInts)
            {
                Console.WriteLine(iter);
            }

            tmpInts.Sort((int a, int b) => b.CompareTo(a));
            Console.WriteLine("DES");
            foreach (int iter in tmpInts)
            {
                Console.WriteLine(iter);
            }

            tmpInts.Sort((int a, int b) => a.CompareTo(b));
            Console.WriteLine("ASC");
            foreach (int iter in tmpInts)
            {
                Console.WriteLine(iter);
            }

            calculater AddFunc = (a, b) => a + b;
            calculater MinusFunc = (a, b) => a - b;

            Console.WriteLine("{0}+{1}={2}", 5, 3, AddFunc(5, 3));
            Console.WriteLine("{0}-0{1}={2}", 5, 3, MinusFunc(5, 3));

            Func<int, int, int> MulFunc = (a, b) => a * b;
            Func<string, string, string> ConCat = (a, b) => a + b;

            Console.WriteLine("{0}+{1}={2}", 5, 3, MulFunc(5, 3));
            Console.WriteLine("{0}+{1}={2}", 5, 3, ConCat("5","3"));
            Console.ReadKey();
        }
    }
}
