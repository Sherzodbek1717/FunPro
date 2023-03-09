using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunProCW1_00012882.DAL
{
    public class Swipe
    {
        public int Id { get; set; }
        public int EmployeeID { get; set; }
        public DateTime SwipeDate { get; set; }
        public TimeSpan SwipeIn { get; set; }
        public TimeSpan SwipeOut { get; set; }
    }
}
