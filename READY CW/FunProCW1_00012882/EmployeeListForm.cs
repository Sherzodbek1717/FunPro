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
    public partial class EmployeeListForm : Form
    {
        public EmployeeListForm()
        {
            InitializeComponent();
        }

        private void EmployeeListForm_Load(object sender, EventArgs e)
        {
            // this code will automatically refresh the table every time it is played.
            MdiParent = MyForms.GetForm<ParentForm>();
            LoadData();
        }

        public void LoadData()
        {
            //this code was copied from Vasiliy Kuznetsov, the best teacher at WIUT.
            dgv.DataMember = "";
            dgv.DataSource = null;
            dgv.DataSource = new EmployeeManager().GetAll();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //will refresh the data.
            LoadData();
        }



        private void btnSort_Click(object sender, EventArgs e)
        {
            //this code was copied from Vasiliy Kuznetsov, the best teacher at WIUT.
            dgv.DataMember = "";
          dgv.DataSource = null;
          dgv.DataSource = new EmployeeManager().Sort();
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //the code will filter the Employees with IsActive ticked.
              var fltr = $"SELECT FROM em_employee_12882 WHERE em_is_active_12882 = {true}";
              dgv.DataSource = new EmployeeManager().Search();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            var fff = $"SELECT FROM em_employee_12882 WHERE em_is_active_12882 = {false}";
            dgv.DataSource = new EmployeeManager().Search();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //this code will Delete the whole row.
            if (dgv.SelectedRows.Count == 0)
                MessageBox.Show("Please select an employee to delete");
            else
            {
                var c = (Employee)dgv.SelectedRows[0].DataBoundItem;
                new EmployeeManager().Delete(c.Id);
                LoadData();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //this code will open a new form with data to be added to the table
            var form = new EmployeeEditForm();
            form.CreateNewEmployee();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //this code will open a new form where user can edit the data.
            if (dgv.SelectedRows.Count == 0)
                MessageBox.Show("Please select an employee");
            else
            {
                var c = (Employee)dgv.SelectedRows[0].DataBoundItem;
                new EmployeeEditForm().UpdateEmployee(c);
            }

        }
    }
}
