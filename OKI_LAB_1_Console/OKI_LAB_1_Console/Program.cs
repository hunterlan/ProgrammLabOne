using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OKI_LAB_1_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers forOps = new Numbers();
            forOps.Number = "11100";
            forOps.IsNeedToAddZeroToTheEnd = false;
            OpsWithNumbers ops = new OpsWithNumbers(forOps);
            Console.WriteLine(ops.TransformFrom2NumSysTo10NumSys());
        }
    }
}
