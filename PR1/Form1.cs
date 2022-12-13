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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) // 2 задание
            {
                this.Hide();
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
            else if (radioButton2.Checked) // 7 задание
            {
                this.Hide();
                Form7 form7 = new Form7();
                form7.ShowDialog();
            }
            else if (radioButton3.Checked) // 27 задание
            {
                this.Hide();
                Form27 form27 = new Form27();
                form27.ShowDialog();
            }
            else if (radioButton4.Checked) // 32 задание
            {
                this.Hide();
                Form32 form32 = new Form32();
                form32.ShowDialog();
            }
            else if (radioButton5.Checked) // 57 задание
            {
                this.Hide();
                Form57 form57 = new Form57();
                form57.ShowDialog();
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
