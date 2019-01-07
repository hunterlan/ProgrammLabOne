using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OKI_LAB_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GetResult_Click(object sender, RoutedEventArgs e)
        {
            string result = "";
            Numbers num = new Numbers();
            OpsWithNumbers ops;
            
            try
            {
                if(Number.Text.Length == 0)
                {
                    throw new Exception("Пустое поле ввода");
                }
                else
                {
                    num.Number = Number.Text;
                }
                switch (FirstNumSys.SelectedIndex)
                {
                    case 0:
                        {
                            num.StartedNumSystem = 2;
                        }
                        break;
                    case 1:
                        {
                            num.StartedNumSystem = 8;
                        }
                        break;
                    case 2:
                        {
                            num.StartedNumSystem = 10;
                        }
                        break;
                    case 3:
                        {
                            num.StartedNumSystem = 16;
                        }
                        break;
                }
                switch (SecondNumSys.SelectedIndex)
                {
                    case 0:
                        {
                            num.FinishedNumSystem = 2;
                        }
                        break;
                    case 1:
                        {
                            num.FinishedNumSystem = 8;
                        }
                        break;
                    case 2:
                        {
                            num.FinishedNumSystem = 10;
                        }
                        break;
                    case 3:
                        {
                            num.FinishedNumSystem = 16;
                        }
                        break;
                }
                ops = new OpsWithNumbers(num);
                if (num.StartedNumSystem == 2 && num.FinishedNumSystem == 10)
                {
                    result = ops.TransformFrom2NumSysTo10NumSys();
                }
                else if (num.StartedNumSystem == 2 && num.FinishedNumSystem == 8)
                {
                    var tempResult = ops.TransformFrom2NumSysTo10NumSys();
                    num.Number = tempResult;
                    result = ops.TransformFrom10NumSysTo8NumSys();
                }
                else if (num.StartedNumSystem == 2 && num.FinishedNumSystem == 16)
                {
                    var tempResult = ops.TransformFrom2NumSysTo10NumSys();
                    num.Number = tempResult;
                    result = ops.TransformFrom10NumSysTo16NumSys();
                }
                else if (num.StartedNumSystem == 8 && num.FinishedNumSystem == 10)
                {
                    result = ops.TransformFrom8NumSysTo10NumSys();
                }
                else if (num.StartedNumSystem == 8 && num.FinishedNumSystem == 2)
                {
                    var tempResult = ops.TransformFrom8NumSysTo10NumSys();
                    num.Number = tempResult;
                    result = ops.TransformFrom10NumSysTo2NumSys();
                }
                else if (num.StartedNumSystem == 8 && num.FinishedNumSystem == 16)
                {
                    var tempResult = ops.TransformFrom8NumSysTo10NumSys();
                    num.Number = tempResult;
                    result = ops.TransformFrom10NumSysTo16NumSys();
                }
                else if (num.StartedNumSystem == 16 && num.FinishedNumSystem == 10)
                {
                    result = ops.TransformFrom16NumSysTo10NumSys();
                }
                else if (num.StartedNumSystem == 16 && num.FinishedNumSystem == 8)
                {
                    var tempResult = ops.TransformFrom16NumSysTo10NumSys();
                    num.Number = tempResult;
                    result = ops.TransformFrom10NumSysTo8NumSys();
                }
                else if (num.StartedNumSystem == 16 && num.FinishedNumSystem == 2)
                {
                    var tempResult = ops.TransformFrom16NumSysTo10NumSys();
                    num.Number = tempResult;
                    result = ops.TransformFrom10NumSysTo2NumSys();
                }
                else if (num.StartedNumSystem == 10 && num.FinishedNumSystem == 2)
                {
                    result = ops.TransformFrom10NumSysTo2NumSys();
                }
                else if (num.StartedNumSystem == 10 && num.FinishedNumSystem == 8)
                {
                    result = ops.TransformFrom10NumSysTo8NumSys();
                }
                else if (num.StartedNumSystem == 10 && num.FinishedNumSystem == 16)
                {
                    result = ops.TransformFrom10NumSysTo16NumSys();
                }
                Result.Text = result;
            }
            catch(Exception exc)
            {
                Exceptions.ShowException(exc);
            }
            
        }
    }
}
