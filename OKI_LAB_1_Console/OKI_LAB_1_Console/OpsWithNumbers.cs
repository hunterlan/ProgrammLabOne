using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OKI_LAB_1_Console
{
    class OpsWithNumbers
    {
        Numbers nums;
        public OpsWithNumbers(Numbers getPropertiesNum)
        {
            nums = getPropertiesNum;
        }

        public string AddingZeroToEnd(string str)
        {

        }

        public string TransformFrom10NumSysTo2NumSys()
        {
            const int COUNT_BITS_IN_BYTE = 8;

            int copiedNum = nums.Number;
            char[] temp;
            string result = "";

            while(copiedNum > 0)
            {
                if (copiedNum % 2 == 0)
                { result += "0"; }
                else
                { result += "1"; }
                copiedNum /= 2;
            }

            temp = result.ToCharArray();
            result = "";
            Array.Reverse(temp);
            foreach(char s in temp)
            {
                result += s.ToString();
            }

            

            return result;
        }

        public string TransformFrom10NumSysTo8NumSys()
        {
            int i = 0;
            int tempResult = Int32.Parse(TransformFrom10NumSysTo2NumSys()), tempResult1 = 0;
            string result = "";
            while(tempResult > 0)
            {
                if(i == 0)
                { tempResult1 += 1 * (tempResult % 10); }
                else if(i == 1)
                { tempResult += 2 * (tempResult % 10); }
                else
                {
                    tempResult1 += 4 * (tempResult % 10);
                    i = 0;
                }
                tempResult /= 10;
                i++;
            }
            result = tempResult1.ToString();
            return result;
        }

        public string TransformFrom8NumSysTo10NumSys()
        {
            string result = "";

            return result;
        }
    }
}
