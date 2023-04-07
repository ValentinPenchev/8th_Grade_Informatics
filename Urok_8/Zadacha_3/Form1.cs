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
            int sideA = int.Parse(textBox1.Text); // Метод Parse - превръщане на променливата от текст в число
            int sideB = int.Parse(textBox2.Text); // Метод Parse - превръщане на променливата от текст в число

            int P = 2 * sideA + 2 * sideB;
            int S = sideA * sideB;

            label2.Text = "Периметъра е: " + P.ToString();// Метод ToString - превръщане на променливата от число в текст
            label3.Text = "Лицето е: " + S.ToString();// Метод ToString - превръщане на променливата от число в текст
        }
    }
}