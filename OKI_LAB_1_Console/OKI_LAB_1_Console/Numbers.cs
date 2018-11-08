using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OKI_LAB_1_Console
{
    class Numbers
    {
        private UInt64 startedNumSystem, finishedNumSystem;
        public UInt64 Number { get; set; }

        public UInt64 StartedNumSystem
        {
            set
            {
                if(value != 2 || value != 8 || value != 10 || value != 16)
                {
                    //Calling exception
                }
                else
                {
                    startedNumSystem = (UInt64)value;
                }
            }
            get { return startedNumSystem; }
        }

        public UInt64 FinishedNumSystem
        {
            set
            { 
                if(value == startedNumSystem)
                {
                    //Calling other type exception
                }
                else if (value != 2 || value != 8 || value != 10 || value != 16)
                {
                    //Calling exception
                }
                else
                {
                    finishedNumSystem = (UInt64)value;
                }
            }
            get { return finishedNumSystem; }
        }
        
        public bool IsNeedToAddZeroToTheEnd { get; set; }
    }
}
