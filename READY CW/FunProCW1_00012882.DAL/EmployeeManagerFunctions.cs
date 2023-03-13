using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunProCW1_00012882.DAL
{
    partial class EmployeeManager
    {

        //this code will allow us to sort the data by Name.
        public List<Employee> Sort()
        {
            var result = GetAll();
            result.Sort(new ByNameComparer());
            return result;

        }

        // //this code will allow us to filter the data by IsActive ticked or not.
        public List<Employee> Search()
        {
            var result = GetAll();
            result.Sort(new ByNameComparer());
            return result;

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