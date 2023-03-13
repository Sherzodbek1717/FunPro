using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FunProCW1_00012882;

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
                //this code will throw an erroe when user will not fill the textbox or will put a space there.
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Name cannot be empty");

                //The code below was not working here, do not know the reason. It is not seeing the tbxName. Textbox where user writes the name.

               /* if (!System.Text.RegularExpressions.Regex.IsMatch(tbxName.Text, "^[a-zA-Z ]"))
                {
                    MessageBox.Show("This textbox accepts only alphabetical characters");
                    tbxName.Text.Remove(tbxName.Text.Length - 1);
                }*/

                name = value;
            }
        }
        public bool IsActive { get; set; }
        public DateTime StartDate
        {
            get => startDate;
            set
            {
                //here user will not be able to choose the future data, it will throw an error.
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
                //here user will not be able to choose the future data, it will throw an error.
                if (value.Date > DateTime.Now) //user can not choose the future data.
                    throw new Exception("You can not choose from the future");
                dischargeDate = value;
            } 
        }
        public Swipe Swipe { get; set; }
    }
}
