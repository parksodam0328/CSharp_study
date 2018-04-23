using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter01_03
{
    class Program
    {
        static void Main(string[] args)
        {
            object a = 100; //boxing
            object c = 1234567890L; //boxing
            object w = "abcde"; //boxing
            Console.WriteLine(a);
            Console.WriteLine(c);
            Console.WriteLine(w);
			
			//각 object가 가리키는 타입 출력
            Console.WriteLine(a.GetType());
            Console.WriteLine(c.GetType());
            Console.WriteLine(w.GetType());

            if (a.GetType() == System.Type.GetType("System.Int32"))
            {
                Console.WriteLine("a is Int32");
            }

            float d = 1.2345f;
            int e = (int)d;
            int f = 12345;
            float g = 3.1415f;
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);


			//숫자형 문자형으로 변환
            Console.WriteLine(f.ToString("D8"));
            Console.WriteLine(g.ToString("F2"));

            string h = "123456";
            string m = "1.23456";

			//문자형 숫자형으로 변환
            int o = int.Parse(h);
            float p = float.Parse(m);
            Console.WriteLine(o);
            Console.WriteLine(p);

            const int q = 567; // const 키워드 사용으로 변경 불가
            // q=123; error

            EFruit tmpEF = EFruit.EF_Banana; //tmpEF = EF_Banana 
			if (tmpEF == EFruit.EF_Apple)
            {
                Console.WriteLine("Apple");
            }
            switch (tmpEF) //열거형도 들어갈 수 있음
            {
                case EFruit.EF_Apple:
                    Console.WriteLine("EF_Apple");
                    break;
                case EFruit.EF_Banana:
                    Console.WriteLine("EF_Banana");
                    break;
                case EFruit.EF_Lemon:
                    Console.WriteLine("EF_Lemon");
                    break;
            }
			
            int[] tmpPoints = new int[(int)EFruit.EF_Count]; //3
            int i;
            for (i = 0; i < (int)EFruit.EF_Count; i++)
            {
                tmpPoints[i] = i + 1;
            }
            for (i = 0; i < (int)EFruit.EF_Count; i++)
            {
                Console.Write(tmpPoints[i]);
                Console.Write(" : ");
                Console.WriteLine((EFruit)i);
            }

            int? r = null; //? : 변수에 값이 없을 수도 있음을 나타내는 키워드
            Console.WriteLine(r.HasValue); //HasValue : 값이 있으면 true, 없으면 false 반환
            if(r.HasValue == true)
            {
                Console.WriteLine(r.Value);
            }
            r = 234;
            Console.WriteLine(r.HasValue);
            if (r.HasValue == true)
            {
                Console.WriteLine(r.Value);
            }

            int _a = 111;
            int _b = _a + 50;
            int _c = 5 * 7;
            int _d = 123 / 5;
            double _e = _d * 5.0;
            int _f = _a++;
            int _g = _f--;
            string _h = "123" + "456";
            string _j = (_c == 35) ? "AAA" : "BBB";
            int _k = 1 << 4;
            int _l = 1 << 3;
            int _m = (_k | _l);
            int _n = (_k | _l) & (1 << 3);
            _c *= 3;
            Console.WriteLine(_a);
            Console.WriteLine(_b);
            Console.WriteLine(_c);
            Console.WriteLine(_d);
            Console.WriteLine(_e);
            Console.WriteLine(_f);
            Console.WriteLine(_g);
            Console.WriteLine(_h);
            Console.WriteLine(_j);
            Console.WriteLine(_k);
            Console.WriteLine(_l);
            Console.WriteLine(_m.ToString("X8")); //16진수로 변환
            Console.WriteLine(_n.ToString("X8"));

            Console.ReadKey();
        }
        enum EFruit
        {
            EF_Apple,
            EF_Banana,
            EF_Lemon,
            EF_Count
        }
    }
}
