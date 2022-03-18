namespace WinFormsApp20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1proses_Click(object sender, EventArgs e)
        {
            label2empty.Text = textBox1input.Text;
        }
    }
}