using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunProCW1_00012882.DAL
{
    public class Swipe
    {
        private DateTime swipeDate;
        private DateTime swipeIn;
        private DateTime swipeOut;

        public int Id { get; set; }
        public int EmployeeID { get; set; }
        public DateTime SwipeDate
        {
            get => swipeDate;
            set
            { 
                //in this code the user will not be able to choose the data from the future.
                if (value.Date > DateTime.Now) //user can not choose the future data.
                    throw new Exception("You can not choose from the future");
                swipeDate = value;
            }
        }
        public DateTime SwipeIn
        {
            get => swipeIn;
            set
            {
                if (value.Date > DateTime.Now) //user can not choose the future data.
                    throw new Exception("You can not choose from the future");
                swipeIn = value;
            }
        }
        public DateTime SwipeOut 
        {
            get => swipeOut;
            set
            {
                if (value.Date > DateTime.Now) //user can not choose the future data.
                    throw new Exception("You can not choose from the future");
                swipeOut = value;
            }
        }

        public override string ToString()
        {
            return $"SELECT FROM em_employee_12882 WHERE Id = {Id}";
        }
    }
}
