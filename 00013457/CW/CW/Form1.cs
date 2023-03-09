namespace CW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var c = new sp_swipe("BIS");


            _ = MessageBox.Show($"{a.em_13457} is on {c.sp_emp_13457}");
        }

        private class sp_swipe
        {
            private string v;

            public sp_swipe(string v)
            {
                this.v = v;
            }
        }
    }
}