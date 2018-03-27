using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02_01
{
    class CMyClass
    {
        public int theStudentCount;
        public String theName;
        public int theGrade;

        public CMyClass()
        {
            theStudentCount = 20;
            theName = "NoName";
            theGrade = 0;
        }
        public CMyClass(int aGrade)
        {
            theStudentCount = 20;
            theName = "NoName";
            theGrade = aGrade;
        } 
        public CMyClass(int aGrade, string aName) : this()
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
