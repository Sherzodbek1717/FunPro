using FunProCW1_00012882.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunProCW1_00012882
{
    public partial class EmployeeEditForm : Form
    {
        public EmployeeEditForm()
        {
            InitializeComponent();
        }

        //Code below was copied from Vasiliy Kuznetsov, the best teacher at WIUT and I just changed the attributes from Course/Applicant to Employee/Swipe

        public Employee Employee { get; set; }

        public FormMode Mode { get; set; }

        public void CreateNewEmployee()
        {
            Mode = FormMode.CreateNew;
            Employee = new Employee();
            InitializeControls();
            MdiParent = MyForms.GetForm<ParentForm>();
            Show();
        }

        public void UpdateEmployee(Employee employee)
        {
            Mode = FormMode.Update;
            Employee = employee;
            InitializeControls();
            ShowEmployeeInControls();
            MdiParent = MyForms.GetForm<ParentForm>();
            Show();
        }

        private void InitializeControls()
        {
        }

        private void ShowEmployeeInControls()
        {
            tbxName.Text = Employee.Name;
            cbxActive.Checked = Employee.IsActive;
            dtpStart.Value = Employee.StartDate;
            dtpDischarge.Value = Employee.DischargeDate;

        }

        private void GrabUserInput()
        {
            Employee.Name = tbxName.Text;
            Employee.IsActive = cbxActive.Checked;
            Employee.StartDate = dtpStart.Value;
            Employee.DischargeDate = dtpDischarge.Value;
        }

        //code below was provided by Vasiliy Kuznetsov, the best teacher at WIUT and I used to implement it in my code.

        private void btnSave_Click(object sender, EventArgs e)
        {
            //this code will block user to put number in the textbox name when the user will click on the Save button.
            if (!System.Text.RegularExpressions.Regex.IsMatch(tbxName.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                tbxName.Text.Remove(tbxName.Text.Length - 1);
            }

            try
            {
                GrabUserInput();
                var manager = new EmployeeManager();
                if (Mode == FormMode.CreateNew)
                    manager.Create(Employee);
                else
                    manager.Update(Employee);

                MyForms.GetForm<EmployeeListForm>().LoadData();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //this code will just let the form to be closed.
            Close();
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {

        }

        public void tbxName_TextChanged(object sender, EventArgs e)
        {
            //this code will not allow to the user to put numbers on the textbox.
            
            if (!System.Text.RegularExpressions.Regex.IsMatch(tbxName.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                tbxName.Text.Remove(tbxName.Text.Length - 1);
            }
        }
    }
}
