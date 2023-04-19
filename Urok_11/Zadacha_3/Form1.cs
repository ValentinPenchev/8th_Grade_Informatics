namespace Zadacha_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sideA = double.Parse(textBox3.Text);
            
            //double P = Math.Round(sideA * 4, 2);
            double S = Math.Round(sideA * sideA, 2);

            label7.Text = "Периметъра е "  + Math.Round(sideA, 2); ;
            label1.Text = "Лицето е " + S.ToString();

        }
    }
}