using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunProCW1_00012882.DAL
{
    public class Employee
    {
        private string name;
        private DateTime startDate;
        private DateTime dischargeDate;

        public int Id { get; set; }
        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Name cannot be empty");

                name = value;
            }
        }
        public bool IsActive { get; set; }
        public DateTime StartDate
        {
            get => startDate;
            set
            {
                if (value.Date > DateTime.Now) //user can not choose the future data.
                    throw new Exception("You can not choose from the future");
                startDate = value;
            }
        }
        public DateTime DischargeDate 
        {
            get => dischargeDate;
            set 
            {
                if (value.Date > DateTime.Now) //user can not choose the future data.
                    throw new Exception("You can not choose from the future");
                dischargeDate = value;
            } 
        }
        public Swipe Swipe { get; set; }
    }
}
