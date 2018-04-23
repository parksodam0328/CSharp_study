using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02_03
{
    class Program
    {
        static void Main(string[] args)
        {
            CPartialClass tmpPC = new CPartialClass();
            Console.WriteLine(tmpPC.theModule1);
            Console.WriteLine(tmpPC.theModule2);
            Console.WriteLine(tmpPC.FunctionA());
            Console.WriteLine(tmpPC.FunctionB());

            CVector2i tmpV2 = new CVector2i();
            tmpV2.X = 3;
            Console.WriteLine(tmpV2.X);

            tmpV2.Y = 7;
			Console.WriteLine(tmpV2.Y);
			Console.WriteLine(tmpV2.theY);

 //           tmpV2.Info = "AAA"; 읽기 전용이기 때문
            Console.WriteLine(tmpV2.Info);
            CVector2i tmpV3 = new CVector2i() { X = 8, Y = 9 };
            Console.WriteLine(tmpV3.Info);

            var tmpStudent = new { Number = 1, Name = "Mirim" }; //객체생성 익명 객체 (클래스 없이)
            Console.WriteLine(tmpStudent.Number);
            Console.WriteLine(tmpStudent.Name);
        }
    }
    partial class CPartialClass
    {
        public CPartialClass()
        {
            theModule1 = 3;
            theModule2 = 5;
        }
        public int theModule2;
        public int FunctionB()
        {
            return (2);
        }
    }
}
