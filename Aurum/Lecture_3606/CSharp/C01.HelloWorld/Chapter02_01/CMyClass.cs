using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02_01
{
    class CMyClass
    {
		//멤버변수 선언
        public int theStudentCount;
        public String theName;
        public int theGrade;

		//생성자
        public CMyClass() //1
        {
            theStudentCount = 20;
            theName = "NoName";
            theGrade = 0;
        }
		//생성자 오버로딩
        public CMyClass(int aGrade) //2
        {
            theStudentCount = 20;
            theName = "NoName";
            theGrade = aGrade;
        } 
        public CMyClass(int aGrade, string aName) : this() //1번 생성자 호출
        {
            theName = aName;
            theGrade = aGrade;
        }

        public String GetName()
        {
            string res = string.Format("{0}학년 {1}, {2}명", theGrade, theName, theStudentCount);
            return (res);
        }
        public void Increase(int aValue)
        {
            aValue++; 
        }

        public void Increase(ref int aValue) // 참조
        {
            aValue++;
        }
        public void MakeValue(out int aValue) // 값타입 생성(대입)
        {
            aValue = 19;
        }
    }
}
