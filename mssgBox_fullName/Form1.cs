namespace mssgBox_fullName
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gaeus Caskie A. Fabro", "Full Name", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}