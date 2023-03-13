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
    public partial class SwipeEditForm : Form
    {
        public SwipeEditForm()
        {
            InitializeComponent();
        }

        private void SwipeEditForm_Load(object sender, EventArgs e)
        {

        }


        //the code belowe was copied from Vasiliy Kuznetsov, the best teacher at WIUT.
        public Swipe Swipe { get; set; }

        public FormMode Mode { get; set; }

        public void CreateNewSwipe()
        {
            Mode = FormMode.CreateNew;
            Swipe = new Swipe();
            InitializeControls();
            MdiParent = MyForms.GetForm<ParentForm>();
            Show();
        }

        public void UpdateSwipe(Swipe swipe)
        {
            Mode = FormMode.Update;
            Swipe = swipe;
            InitializeControls();
            ShowSwipeInControls();
            MdiParent = MyForms.GetForm<ParentForm>();
            Show();
        }

        private void InitializeControls()
        {
            cbxEmployee.DataSource = new EmployeeManager().GetAll();
        }

        private void ShowSwipeInControls()
        {
            dtpDate.Value = Swipe.SwipeDate;
            dtpIn.Value = Swipe.SwipeIn;
            dtpOut.Value = Swipe.SwipeOut;
            cbxEmployee.SelectedIndex = Swipe.EmployeeID;
        }

        private void GrabUserInput()
        {
            Swipe.SwipeDate = dtpDate.Value;
            Swipe.SwipeIn = dtpIn.Value;
            Swipe.SwipeOut = dtpOut.Value;
            Swipe.EmployeeID = cbxEmployee.SelectedIndex;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            //this code will save the data
            try
            {
                GrabUserInput();
                var manager = new SwipeManager();
                if (Mode == FormMode.CreateNew)
                    manager.Create(Swipe);
                else
                    manager.Update(Swipe);

                MyForms.GetForm<SwipeListForm>().LoadData();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //this code will close only an active window.
            Close();
        }
    }
}
