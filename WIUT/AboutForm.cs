using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIUT.DAL;

namespace WIUT
{
    public partial class AboutForm : Form
    {
        private static readonly log4net.ILog log =
log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                log.Info($"Save Button Clicked, `{tbxName.Text}`");
                var Course = new Course();
                Course.Name = tbxName.Text;
                MessageBox.Show("Saved");
            }
            catch (Exception ex)
            {
                log.Error(ex.ToString());
                MessageBox.Show(ex.Message);
            }


           
        }
    }
}
