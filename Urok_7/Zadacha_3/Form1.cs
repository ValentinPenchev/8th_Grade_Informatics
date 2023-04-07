namespace Zadacha_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string date = DateTime.Today.ToShortDateString();
            string time = DateTime.Now.ToShortTimeString();

            label3.Text = "Hello, " + textBox1.Text + " " +
             textBox2.Text + "!Today is " + date + " , " +
              time + ". How are you, " + textBox2.Text + "?";

        }
    }
}