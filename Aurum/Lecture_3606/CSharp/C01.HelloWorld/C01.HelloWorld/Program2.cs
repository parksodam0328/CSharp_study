using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c01.helloworld
{
    class Program2
    {
        static void Main(string[] args)
        {
            int tmpX;
            int tmpY;
			tmpX = 7;
			tmpY = 8;

            Console.WriteLine("%d + %d = %d", tmpX, tmpY, tmpX + tmpY);
            Console.WriteLine("{0} + {1} = {2}", tmpX, tmpY, tmpX + tmpY);

            Console.WriteLine("{0} + {1} = {2} ({0}, {1})", tmpX, tmpY, tmpX + tmpY);
            Console.WriteLine("{0} + {1} = {2}", tmpX.ToString(), tmpY.ToString(), tmpX.ToString() + tmpY.ToString());

			Console.WriteLine("{0} + {1} = {2}", tmpX.ToString(), tmpY.ToString(), (tmpX + tmpY).ToString());

            string tmpName = "class";
            String tmpLang = "c#";
            Console.WriteLine("{0} : {1}", tmpName, tmpName);
            Console.WriteLine("{0}", tmpName + " : " + tmpLang);

            Console.ReadKey();
        }
    }
}
