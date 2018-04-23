using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02_02
{
    class CLGPhone : CSmartPhone
    {
        public CLGPhone()
        {

        }
        public override string GetMarket()
        {
            string parentMarket = base.GetMarket(); //상위클래스의 GetMarket 함수를 호출하기 위해 base 키워드 사용
			return (parentMarket + ", U+ Market");
        }
        public int GetButtonCount()
        {
            return (2);
        }
    }
}
