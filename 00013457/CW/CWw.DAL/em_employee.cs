using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWw.DAL
{
    public class em_employee
    {
        public int em_13457 { get; set; }

        public string em_name_13457 { get; set; }
        public bool em_is_active_13457 { get; set; }
        public DateTime em_start_date_13457 { get; set; }
        public int em_discharge_date_13457 { get; set; }



        public em_employee()
        {
            em_is_active_13457 = false;
        }
    }
}
