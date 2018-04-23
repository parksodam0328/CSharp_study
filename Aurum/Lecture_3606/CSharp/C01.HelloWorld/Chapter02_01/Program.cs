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
            int b = 5;//ref는 외부에서 초기화 필요
            tmpMC1.Increase(a);
            tmpMC1.Increase(ref b); // 반드시 외부 초기화 필요

            Console.WriteLine(a);
            Console.WriteLine(b);

            int c; // 초기화 해줘도 상관 x -> 함수 내부에서 생성해주기 때문
            tmpMC1.MakeValue(out c); // 함수 내부에서 생성
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
