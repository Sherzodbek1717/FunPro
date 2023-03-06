namespace WIUT_CW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var a = new Applicant("asdf", "dfdfdf", new Course("BA"));
            
            MessageBox.Show($"{a.Name} applied for {a.Course.Name}");
        }
    }
}