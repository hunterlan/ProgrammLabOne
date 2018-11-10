using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OKI_LAB_1
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

            UInt64 copiedNum = UInt64.Parse(nums.Number);
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
                else if (i == 2)
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
            foreach (UInt64 nums in results)
            {
                result += nums.ToString();
            }
            return result;
        }

        public string TransformFrom10NumSysTo16NumSys()
        {
            string result = "";
            UInt64 copiedNum = UInt64.Parse(nums.Number);

            List<UInt64> resultDividing = new List<UInt64>();

            while(copiedNum > 0
)
            {
                resultDividing.Add(copiedNum % 16);
                copiedNum /= 16;
            }

            resultDividing.Reverse();
            foreach(UInt64 num in resultDividing)
            {
                if(num > 9)
                {
                    switch(num)
                    {
                        case 10:
                            {
                                result += 'A';
                            }break;
                        case 11:
                            {
                                result += 'B';
                            }break;
                        case 12:
                            {
                                result += 'C';
                            }break;
                        case 13:
                            {
                                result += 'D';
                            }break;
                        case 14:
                            {
                                result += 'E';
                            }break;
                        case 15:
                            {
                                result += 'F';
                            }break;
                    }
                }
                else
                {
                    result += num.ToString();
                }
            }

            return result;
        }

        public string TransformFrom2NumSysTo10NumSys()
        {
            string result = "";

            int tempResult = 0;

            UInt64 copiedNum = UInt64.Parse(nums.Number);

            int i = 0;

            while(copiedNum > 0)
            {
                if(copiedNum % 10 == 1)
                { tempResult += (Int32)System.Math.Pow(2, i); }
                copiedNum /= 10;
                i++;
            }

            result = tempResult.ToString();

            return result;
        }

        public string TransformFrom8NumSysTo10NumSys()
        {
            string result = "";

            List<UInt64> results = new List<UInt64>();

            UInt64 numcopied = UInt64.Parse(nums.Number), tempResult = 0;

            while (numcopied > 0)
            {
                results.Add(numcopied % 10);
                numcopied /= 10;
            }
            results.Reverse();
            int j = 0;
            for (int i = results.Count; i > 0; i--)
            {
                tempResult += results[j] * (UInt64)Math.Pow(8, i - 1);

                j++;
            }

            result += tempResult.ToString();
            return result;
        }

        public string TransformFrom16NumSysTo10NumSys()
        {
            string result = "", copiedNumber = nums.Number;
            int tempResult = 0, check = 0;
            
            for(int i = 0; i < copiedNumber.Length; i++)
            {
                if(!Int32.TryParse(copiedNumber[i].ToString(), out check))
                {
                    switch (copiedNumber[i])
                    {
                        case 'A':
                            {
                                tempResult += 10 * (int)System.Math.Pow(16, copiedNumber.Length - i - 1);
                            }
                            break;
                        case 'B':
                            {
                                tempResult += 11 * (int)System.Math.Pow(16, copiedNumber.Length - i - 1);
                            }
                            break;
                        case 'C':
                            {
                                tempResult += 12 * (int)System.Math.Pow(16, copiedNumber.Length - i - 1);
                            }
                            break;
                        case 'D':
                            {
                                tempResult += 13 * (int)System.Math.Pow(16, copiedNumber.Length - i - 1);
                            }
                            break;
                        case 'E':
                            {
                                tempResult += 14 * (int)System.Math.Pow(16, copiedNumber.Length - i - 1);
                            }
                            break;
                        case 'F':
                            {
                                tempResult += 15 * (int)System.Math.Pow(16, copiedNumber.Length - i - 1);
                            }
                            break;
                    }
                }
                else
                {
                    tempResult += Int32.Parse(copiedNumber[i].ToString()) * (int)System.Math.Pow(16, copiedNumber.Length - i - 1);
                }
            }
            result = tempResult.ToString();
            return result;
        }
    }
}
