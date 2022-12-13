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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void result_button_Click(object sender, EventArgs e)
        {
            double res;
            if (double.TryParse(textBox_x.Text, out res) && double.TryParse(textBox_y.Text, out res))
            {
                double x = double.Parse(textBox_x.Text);
                double y = double.Parse(textBox_y.Text);
                double z = (Math.Min(x, y) + 0.5) / (1 + Math.Max(x, y) * Math.Max(x, y));
                textBox_z.Text = z.ToString();
            }
            else
            {
                MessageBox.Show("Введите другое значение!");
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
