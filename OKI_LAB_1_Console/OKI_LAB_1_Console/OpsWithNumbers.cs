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
            int sizeBeforeChanges = str.Length;
            const int COUNT_BITS_IN_BYTE = 8;
            for (int i = 0; i < COUNT_BITS_IN_BYTE - sizeBeforeChanges; i++)
            { str = str.Insert(0, "0"); }
            return str;
        }

        public string TransformFrom10NumSysTo2NumSys()
        {

            UInt64 copiedNum = nums.Number;
            char[] temp;
            string result = "";

            while (copiedNum > 0)
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
            foreach (char s in temp)
            {
                result += s.ToString();
            }

            if (nums.IsNeedToAddZeroToTheEnd)
            { result = AddingZeroToEnd(result); }

            return result;
        }

        public string TransformFrom10NumSysTo8NumSys()
        {
            List<UInt64> results = new List<UInt64>();
            int i = 0;
            UInt64 tempResult = UInt64.Parse(TransformFrom10NumSysTo2NumSys()), tempResult1 = 0;
            string result = "";
            while (tempResult > 0)
            {
                //Написать от 0 до 7
                if (i == 0)
                {
                    tempResult1 += 1 * (tempResult % 10);
                }
                else if (i == 1)
                {
                    tempResult1 += 2 * (tempResult % 10);
                }
                else
                {
                    tempResult1 += 4 * (tempResult % 10);
                    results.Add(tempResult1);
                }

                tempResult /= 10;

                if (tempResult == 0 && i != 2)
                { results.Add(tempResult1); }
                else if(i == 2)
                {
                    i = 0;
                    tempResult1 = 0;
                }
                else
                {
                    i++;
                }
            }
            results.Reverse(0, results.Count);
            foreach(UInt64 nums in results)
            {
                result += nums.ToString();
            }
            return result;
        }

        public string TransformFrom8NumSysTo10NumSys()
        {
            string result = "";

            List<UInt64> results = new List<UInt64>();

            UInt64 numcopied = nums.Number, tempResult = 0;

            while(numcopied > 0)
            {
                results.Add(numcopied % 10);
                numcopied /= 10;
            }
            results.Reverse();
            int j = 0;
            for(int i = results.Count; i > 0; i--)
            {
                tempResult += results[j] * (UInt64)Math.Pow(8, i-1);
                
                j++;
            }
            result += tempResult.ToString();
            return result;
        }
    }
}
