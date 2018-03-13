using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseContainer
{
    class CBaseGame
    {
        //배열의 선언
        public int[] number;
        public CBaseGame() //생성자
        {
            //배열의 할당
            number = new int[3];
        }
        public int initialize() //중복 없이 1~9 3개 추출
        {
            Random rand = new Random();
            int i;
            int[] tempNum = new int[9];
            for( i = 0; i < 9; i++)
            {
                tempNum[i] = i + 1;
            }
            for (i = 0; i < 100; i++)
            {
                int iNum1 = rand.Next(0, 9);
                int iNum2 = rand.Next(0, 9);
                int temp = tempNum[iNum1];
                tempNum[iNum1] = tempNum[iNum2];
                tempNum[iNum2] = temp;
            }
            number[0] = tempNum[0];
            number[1] = tempNum[1];
            number[2] = tempNum[2];
            return (1);
        }
        //ref 키워드는 값을 밖으로 내보내는 기능
        //c에서 포인터와 같은 것으로 보면 된다.
        public int CheckNumber(int aNum1, int aNum2, int aNum3, ref int aStrikeCount, ref int aBallCount)
        {
            int i;
            int j;
            int[] input = { aNum1, aNum2, aNum3 };
            aStrikeCount = 0;
            aBallCount = 0;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (number[i] == input[j])
                    {
                        if(i==j)
                        {
                            aStrikeCount++;
                        }
                        else
                        {
                            aBallCount++;
                        }
                    }
                }
            }
            return (1);
        }
    }
}
