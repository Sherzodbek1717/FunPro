using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunProCW1_00012882.DAL
{
    partial class EmployeeManager
    {
        public List<Employee> Sort(ByAttribute attribute)
        {
            switch (attribute)
            {
                case ByAttribute.Name:
                    var result = GetAll();
                    result.Sort(new ByNameComparer());
                    return result;
            }
            return null;
        }

        private class ByNameComparer : IComparer<Employee>
        {
            public int Compare(Employee x, Employee y)
            {
                return string.Compare(x.Name, y.Name);
            }
        }
    }
}
