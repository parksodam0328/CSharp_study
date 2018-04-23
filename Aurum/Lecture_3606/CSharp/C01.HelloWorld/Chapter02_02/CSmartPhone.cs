using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02_02
{
    class CSmartPhone
    {
        public string theID;
        private string theMarket;
        public CSmartPhone()
        {
            theMarket = "Google";
            theID = "Noname";
        }
        public virtual string GetMarket() //하위클래스에서 오버라이딩 가능하게 하기 위해 virtual 키워드 선언
        {
            return (theMarket);
        }
        public int GetButtonCount()
        {
            return (1);
        }
    }
}
