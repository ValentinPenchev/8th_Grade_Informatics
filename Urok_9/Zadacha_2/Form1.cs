namespace Zadacha_2
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

            double S = side * side;

            label2.Text = "Лицето е: " + S.ToString();
        }
    }
}