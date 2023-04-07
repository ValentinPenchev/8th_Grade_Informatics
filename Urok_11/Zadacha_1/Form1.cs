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
            //Пример 1 - за изчисляване на лице

           double r = double.Parse(textBox1.Text);

           double s = Math.PI * r * r;

           double var = Math.Round(s, 2);
           label3.Text = "Лицето е " + var.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Пример 2 - дължината на окръжност с радиус r
            double r = double.Parse(textBox2.Text);

            double c = 2 * Math.PI * r;

            double var = Math.Round(c, 2);
            label5.Text = "Дължината е " + var.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Пример 3

            double a = double.Parse(textBox3.Text);
            double b = double.Parse(textBox4.Text);

            double ans = Math.Ceiling((a * b)/2);
            double var = Math.Round(ans, 2);
            label7.Text = "Броя кутии боя " + var.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Пример 4

            double y = double.Parse(textBox6.Text);

            double x = Math.Floor(y + 0.5);

            label13.Text = x.ToString();
        }
    }
}