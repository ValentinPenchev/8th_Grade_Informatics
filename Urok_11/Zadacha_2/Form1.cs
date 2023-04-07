namespace Zadacha_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double lengthОfRod = double.Parse(textBox3.Text);

            double numCut = double.Parse(textBox4.Text);

            double ans = Math.Ceiling(lengthОfRod / numCut);

            label5.Text =  ans.ToString() + " броя ";
        }
    }
}