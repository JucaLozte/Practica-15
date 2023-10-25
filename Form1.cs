using System.Diagnostics.Eventing.Reader;

namespace Practica_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sueldo, nsueldo;
            sueldo = double.Parse(textBox1.Text);
            if (sueldo < 400000.00) nsueldo = sueldo * 1.15;
            else nsueldo = sueldo * 1.08;
            textBox2.Text = nsueldo.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}