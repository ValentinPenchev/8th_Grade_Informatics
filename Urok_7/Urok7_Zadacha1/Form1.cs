namespace Urok7_Zadacha1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;

            label2.Text = "Здравей, " + name + "!";

        }
    }
}