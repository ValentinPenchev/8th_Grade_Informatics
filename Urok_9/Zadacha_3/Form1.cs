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
            double sideA = double.Parse(textBox1.Text); // Метод Parse - превръщане на променливата от текст в число
            double sideB = double.Parse(textBox2.Text); // Метод Parse - превръщане на променливата от текст в число

            double P = 2 * sideA + 2 * sideB;
            double S = sideA * sideB;

            label2.Text = "Периметъра е: " + P.ToString();// Метод ToString - превръщане на променливата от число в текст
            label3.Text = "Лицето е: " + S.ToString();// Метод ToString - превръщане на променливата от число в текст
        }
    }
}