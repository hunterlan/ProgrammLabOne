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

            int copiedNum = nums.Number;
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
            List<int> results = new List<int>();
            int i = 0;
            int tempResult = Int32.Parse(TransformFrom10NumSysTo2NumSys()), tempResult1 = 0;
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
            //Поменять местами 1 и 4 элемент, 2 и 3, ну ты понял)))
            foreach(int nums in results)
            {
                result += nums.ToString();
            }
            return result;
        }

        public string TransformFrom8NumSysTo10NumSys()
        {
            string result = "";

            return result;
        }
    }
}
