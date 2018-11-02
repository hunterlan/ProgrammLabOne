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

            int sizeResultBeforeAdding = result.Length;
            if (nums.IsNeedToAddZeroToTheEnd)
            {
                for (int i = 0; i < COUNT_BITS_IN_BYTE - sizeResultBeforeAdding; i++)
                {
                    result = result.Insert(0, "0");
                }
            }

            return result;
        }
    }
}
