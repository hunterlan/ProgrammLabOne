using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OKI_LAB_1
{
    class Numbers
    {
        private UInt64 startedNumSystem, finishedNumSystem;
        public string Number { get; set; }

        public UInt64 StartedNumSystem
        {
            set
            {
                try
                {
                    if (value != 2 && value != 8 && value != 10 && value != 16)
                    {
                        throw new Exception("Нельзя выбирать другую систему исчесления\n");
                    }
                    else
                    {
                        startedNumSystem = (UInt64)value;
                    }
                }
                catch(Exception exc)
                {
                    Exceptions.ShowException(exc);
                }
                
            }
            get { return startedNumSystem; }
        }

        public UInt64 FinishedNumSystem
        {
            set
            { 
                try
                {
                    if (value == startedNumSystem)
                    {
                        throw new Exception("Система исчеления не может быть равна самой себе");
                    }
                    else if (value != 2 && value != 8 && value != 10 && value != 16)
                    {
                        throw new Exception("Нельзя выбирать другую систему исчесления\n");
                    }
                    else
                    {
                        finishedNumSystem = (UInt64)value;
                    }
                }
                catch(Exception exc)
                {
                    Exceptions.ShowException(exc);
                }
            }
            get { return finishedNumSystem; }
        }
        
        public bool IsNeedToAddZeroToTheEnd { get; set; }
    }
}
