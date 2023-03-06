using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIUT_CW
{
    internal class Applicant
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Surname { get; set; }
        public string Address { get; set; }
        public DateTime DoB { get; set; }
        public bool IsMarried { get; set; }
        public string PassportNo { get; set; }
        public Course Course { get; set; }

        public Applicant()
        {
            IsMarried = false; 

        }
    }
}
