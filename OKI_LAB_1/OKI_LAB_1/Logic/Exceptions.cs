using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OKI_LAB_1
{
    class Exceptions
    {
        public static void ShowException(Exception exc)
        {
            MessageBox.Show(exc.Message, "Ошибка!");
        }
    }
}
