using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02_02
{
    class Program
    {
        public int SumAll(params int[] aNumbers) { //가변길이의 매개변수
            int i;
            int tmp = 0;
            for (i = 0; i < aNumbers.Length; i++) {
                tmp += aNumbers[i];
            }
            return (tmp);
        }
        public int SumAll2(int[] aNumbers)//배열을 매개변수로 받음
        {
            int i;
            int tmp = 0;
            for (i = 0; i < aNumbers.Length; i++)
            {
                tmp += aNumbers[i];
            }
            return (tmp);
        }
        public void SelectCard(int aNumber, string aShape)
        {
            Console.WriteLine("Shape : {0}, Number : {1}", aShape, aNumber % 13 + 1);
        }
        public void MakeCard(int aNumber, string aShape = "Diamond")//매개변수의 값을 지정해놓을 수 있음
        {
            Console.WriteLine("Shape:{0}, Number:{1}", aShape, aNumber % 13 + 1);
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

            int[] param4 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int total4 = tmpC.SumAll2(param4);
            Console.WriteLine(total4);

            tmpC.SelectCard(10, "Diamond");
			//이런식으로 매개변수를 전달할 수 있음
            tmpC.SelectCard(aNumber : 12, aShape : "Diamond");
            tmpC.SelectCard(aShape : "Heart", aNumber : 12); //이런식으로 전달해도 오류 안남

            tmpC.MakeCard(7);
            tmpC.MakeCard(10, "Heart");
			tmpC.MakeCard(aShape : "Heart", aNumber : 10);

			
			CSmartPhone tmpSP1 = new CSmartPhone();
            CSmartPhone tmpSP2 = new CSamsungPhone(); //업캐스팅
            CSmartPhone tmpSP3 = new CLGPhone(); //업캐스팅


			//base 키워드 사용하여 모두 부모클래스의 GetMarket 함수 호출
            Console.WriteLine(tmpSP1.GetMarket()); 
            Console.WriteLine(tmpSP2.GetMarket());
            Console.WriteLine(tmpSP3.GetMarket());

			//상위클래스의 함수 호출 -> virtual 키워드를 사용하지 않았기 때문
			Console.WriteLine(tmpSP1.GetButtonCount());
            Console.WriteLine(tmpSP2.GetButtonCount());
            Console.WriteLine(tmpSP3.GetButtonCount());

            if(tmpSP2 is CSamsungPhone) // is 연산자는 형변환 가능여부 확인, 가능하면 true, 불가능 하면 false 반환
            {
                CSamsungPhone tmpSP4 = (CSamsungPhone)tmpSP2; 
                Console.WriteLine(tmpSP4.GetButtonCount());
            } 
            CLGPhone tmpSP5 = tmpSP3 as CLGPhone; // as는 형변환이 가능하면 형변환된 객체로 반환, 아니면 null 반환
            if(tmpSP5 != null)
            {
                Console.WriteLine(tmpSP5.GetButtonCount());
            }

            CSmartPhone tmpSP7 = new CSmartPhone();
            CSmartPhone tmpSP8 = new CSmartPhone();
            CSmartPhone tmpSP9;
            UseSmartPhone(tmpSP7);
            ChangeSmartPhone(ref tmpSP8); // ref는 밖에서 꼭 생성
            MakeSmartPhone(out tmpSP9); // out은 안에서 꼭 생성

            Console.WriteLine(tmpSP7.theID);
            Console.WriteLine(tmpSP8.theID);
            Console.WriteLine(tmpSP9.theID);

            Console.ReadKey();
        }
        static void UseSmartPhone(CSmartPhone aPhone)
        {
            aPhone.theID = "Use";
        }
        static void ChangeSmartPhone(ref CSmartPhone aPhone)
        {
            aPhone.theID = "Change";
        }
        static void MakeSmartPhone(out CSmartPhone aPhone) 
        {
            aPhone = new CSmartPhone(); // out은 무조건 안에서 생성해야함
            aPhone.theID = "Make";
        }
    }
}
