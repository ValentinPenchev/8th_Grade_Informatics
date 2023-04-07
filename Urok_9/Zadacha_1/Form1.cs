namespace Zadacha_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double side = double.Parse(textBox1.Text);

            double P = side * 4;

            label2.Text = "Периметъра е: " + P.ToString();

        }
    }
}