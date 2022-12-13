using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR1
{
    public partial class Form57 : Form
    {
        public Form57()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double res;
            if (double.TryParse(textBox_AB.Text, out res) && double.TryParse(textBox_BC.Text, out res) && double.TryParse(textBox_CA.Text, out res))
            {
                double AB = double.Parse(textBox_AB.Text);
                double BC = double.Parse(textBox_BC.Text);
                double CA = double.Parse(textBox_CA.Text);
                if (AB + BC > CA && CA + AB > BC && BC + CA > AB)
                {
                    double P = AB + BC + CA;
                    double p = P / 2;
                    double S = Math.Sqrt(p * (p - AB) * (p - BC) * (p - CA));
                    MessageBox.Show("Периметр равен " + P + ", а площадь = " + S + ".");
                }
                else
                    MessageBox.Show("Такого треугольника не существует!");
            }
            else
                MessageBox.Show("Введите другие значения!");
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
