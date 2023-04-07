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
            int side = int.Parse(textBox1.Text); // Метод Parse - превръщане на променливата от текст в число

            int P = side * 4;

            label2.Text = "Периметъра е: " + P.ToString();// Метод ToString - превръщане на променливата от число в текст
        }
    }
}