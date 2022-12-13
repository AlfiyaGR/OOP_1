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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button_res_Click(object sender, EventArgs e)
        {
            int res;
            if (int.TryParse(textBox1.Text, out res) && int.TryParse(textBox3.Text, out res))
            {
                int n1 = int.Parse(textBox1.Text);
                int n2 = int.Parse(textBox3.Text);
                if (n1 % 2 == 0 && n2 % 2 == 0)
                {
                    MessageBox.Show("Оба числа четные!");
                }
                else if (n1 % 2 != 0 && n2 % 2 == 0)
                {
                    MessageBox.Show("Первое число нечетное, второе - четное!");
                }
                else if (n1 % 2 == 0 && n2 % 2 != 0)
                {
                    MessageBox.Show("Первое число четное, второе - нечетное!");
                }
                else if (n1 % 2 != 0 && n2 % 2 != 0)
                {
                    MessageBox.Show("Оба числа нечетные!");
                }
            }
            else
            {
                MessageBox.Show("Введите другие значения!");
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
