using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02_01
{
    class Program
    {
        static void Main(string[] args)
        {
            CMyClass tmpMC1 = new CMyClass();
            Console.WriteLine(tmpMC1.GetName());

            Console.WriteLine(new CMyClass(1).GetName());
            Console.WriteLine(new CMyClass(3,"AAA").GetName());

            int a = 5;
            int b = 5;
            tmpMC1.Increase(a);
            tmpMC1.Increase(ref b); // 반드시 초기화 필요

            Console.WriteLine(a);
            Console.WriteLine(b);

            int c; // 초기화 해줘도 상관 x
            tmpMC1.MakeValue(out c); //생성
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
