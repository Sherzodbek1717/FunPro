using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunProCW1_00012882
{
    class MyForms

        //this code was copied from Vasiliy Kuznetsov the best Teacher at WIUT.
    {
        public static T GetForm<T>() where T : class, new()
        {
           return Application.OpenForms.OfType<T>().FirstOrDefault() ?? new T(); 
        }
    }
}
