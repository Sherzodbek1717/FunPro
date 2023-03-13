using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FunProCW1_00012882.DAL;
using FunProCW1_00012882.Properties;

namespace FunProCW1_00012882
{
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void newSwipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this code will open a new form where user can Create New Swipe.
            var formSwipe = new SwipeEditForm();
            formSwipe.CreateNewSwipe();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this code will automatically close the whole window and stop running the programm.
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this code will open about form
            var aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {
            //please ignore this code

            /*var manager = new SwipeManager();
            MessageBox.Show(
                string.Join("\n",
                manager.GetAll().Select(t=>$"{t.Id} - {t.SwipeDate}")));*/

            /*var myDate = new DateTime(2022, 9, 9);
            MessageBox.Show(myDate.Ticks.ToString());*/
        }

        private void allEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this code will open a form with all the employees.
            MyForms.GetForm<EmployeeListForm>().Show();
        }

        private void allSwipesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this code will open a form with all the swipe.
            MyForms.GetForm<SwipeListForm>().Show();
        }

        private void newEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this code will open a new form where user can Create New Employee.
            var form = new EmployeeEditForm();
            form.CreateNewEmployee();
        }
    }
}
