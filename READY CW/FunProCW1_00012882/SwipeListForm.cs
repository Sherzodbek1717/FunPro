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
    public partial class SwipeListForm : Form
    {
        public SwipeListForm()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            //this code will load the data.
            dgv_swipe.DataMember = "";
            dgv_swipe.DataSource = null;
            dgv_swipe.DataSource = new SwipeManager().GetAll();
        }

        private void SwipeListForm_Load(object sender, EventArgs e)
        {
            MdiParent = MyForms.GetForm<ParentForm>();
            LoadData();

            //this code will convert the numbers in table to normal time. 
            var date = DateTime.Now;
            var TimeAsInt = date.Hour * 60 + date.Minute;
           /* MessageBox.Show(TimeAsInt.ToString());*/
           /* var myHours = TimeAsInt / 60;
            var myMinutes = TimeAsInt % 60;
            MessageBox.Show($"{myHours}:{myMinutes}");*/
        }

        private void btnAdd_Swipe_Click(object sender, EventArgs e)
        {
            //this code will open a form with Adding a new Swipe
            var formSwipe = new SwipeEditForm();
            formSwipe.CreateNewSwipe();
        }
    }
}
