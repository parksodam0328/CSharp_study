using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02_02
{
    class CSamsungPhone : CSmartPhone
    {
        public CSamsungPhone()
        {

        }
        public override string GetMarket() //오버라이딩
        {
            string parentMarket = base.GetMarket(); //상위클래스의 GetMarket 함수를 호출하기 위해 base 키워드 사용
            return (parentMarket + ", Samsung");
        }
        public int GetButtonCount() 
        {
            return (3);
        }
    }
}
