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
    public partial class Form32 : Form
    {
        public class user
        {
            public int worker;
            public int first;
            public int second;
            public int third;

            public user(int _worker, int _first, int _second, int _third)
            {
                worker = _worker;
                first = _first;
                second = _second;
                third = _third;
            }
        }
        List<user> users = new List<user>();

        public Form32()
        {
            InitializeComponent();
        }

        private void Form32_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            var rand = new Random();

            for (int i = 0; i < 12; i++)
            {
                users.Add(new user(i + 1, rand.Next(15000, 40000), rand.Next(15000, 40000), rand.Next(15000, 40000)));
            }

            DataTable table = new DataTable();
            table.Columns.Add("Работники", typeof(int));
            table.Columns.Add("1", typeof(int));
            table.Columns.Add("2", typeof(int));
            table.Columns.Add("3", typeof(int));

            for (int i = 0; i < users.Count; i++)
            {
                table.Rows.Add(users[i].worker, users[i].first, users[i].second, users[i].third);
            }

            dataGridView1.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button_a_Click(object sender, EventArgs e)
        {
            int summa = 0;
            for (int i = 0; i < users.Count; i++)
            {
                summa += users[i].first + users[i].second + users[i].third;
            }
            MessageBox.Show("Общая сумма, выплаченная за квартал всем работникам: " + summa);
        }

        private void button_b_Click(object sender, EventArgs e)
        {
            string s = "";
            for (int i = 0; i < users.Count; i++)
            {
                s += "Работник" + (i + 1) + " получил " + (users[i].first + users[i].second + users[i].third) + " за квартал.\n";
            }
            MessageBox.Show(s);
        }

        private void button_c_Click(object sender, EventArgs e)
        {
            int summa1 = 0;
            int summa2 = 0;
            int summa3 = 0;
            for (int i = 0; i < users.Count; i++)
            {
                summa1 += users[i].first;
                summa2 += users[i].second;
                summa3 += users[i].third;
            }
            MessageBox.Show("За первый месяц работники получили " + summa1 + " рублей, за второй - " + summa2 + " руб., за третий - " + summa3 + " руб.");
        }
    }
}
