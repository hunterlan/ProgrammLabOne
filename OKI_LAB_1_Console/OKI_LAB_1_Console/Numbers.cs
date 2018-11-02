using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OKI_LAB_1_Console
{
    class Numbers
    {
        private int startedNumSystem, finishedNumSystem;
        public int Number { get; set; }

        public int StartedNumSystem
        {
            set
            {
                if(value != 2 || value != 8 || value != 10 || value != 16)
                {
                    //Calling exception
                }
                else
                {
                    startedNumSystem = value;
                }
            }
            get { return startedNumSystem; }
        }

        public int FinishedNumSystem
        {
            set
            {
                if (value != 2 || value != 8 || value != 10 || value != 16)
                {
                    //Calling exception
                }
                else if(value == startedNumSystem)
                {
                    //Calling other type exception
                }
                else
                {
                    finishedNumSystem = value;
                }
            }
            get { return finishedNumSystem; }
        }
        
        public bool IsNeedToAddZeroToTheEnd { get; set; }
    }
}
