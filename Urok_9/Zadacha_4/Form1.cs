namespace Zadacha_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double currency = double.Parse(textBox1.Text);
            double total;

            if (comboBox1.Text == "EUR")
            {
                total = currency * 0.51;
                label2.Text = textBox1.Text + " BGN = " +  total.ToString() + " EUR";
            }
            else if (comboBox1.Text == "USD")
            {
                total = currency * 0.56;
                label2.Text = textBox1.Text + " BGN = " + total.ToString() + " USD";
            }

            
        }
    }
}