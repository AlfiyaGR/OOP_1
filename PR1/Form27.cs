using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace PR1
{
    public partial class Form27 : Form
    {
        public MatrixField matrixField { get; private set; }
        public MatrixField matrixField_Changed { get; private set; }

        public Form27()
        {
            InitializeComponent();
        }
     
        public class NewValue : TextBox
        {
            public int X { get; set; }
            public int Y { get; set; }
            public NewValue(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }
        }

        public class MatrixField
        {
            public NewValue[,] textBoxes;
            public MatrixField(int x, int y)
            {
                textBoxes = new NewValue[x, y];
            }
            public void Matrix_Values()
            {
                var rand = new Random();
                for (int i = 0; i < textBoxes.GetLength(0); i++)
                {
                    for (int j = 0; j < textBoxes.GetLength(1); j++)
                    {
                        textBoxes[i, j] = new NewValue(i, j)
                        {
                            Size = new Size(20, 40),
                            Visible = true,
                            Location = new Point(i * 30 + 20, j * 40 + 20),
                            Text = rand.Next(1, 100).ToString(),
                            ReadOnly = true
                        };
                    }
                }
            }
            public int MatrixChange_indexMax()
            {
                int Max = 0;
                int strokaMax = 0;
                for (int i = 0; i < textBoxes.GetLength(0); i++)
                {
                    for (int j = 0; j < textBoxes.GetLength(1); j++)
                    {
                        if (int.Parse(textBoxes[i, j].Text) > Max)
                        {
                            strokaMax = j;
                            Max = int.Parse(textBoxes[i, j].Text);
                        }
                    }
                }
                return strokaMax;
            }
            public int MatrixChange_indexMin()
            {
                int Min = 101;
                int strokaMin = 0;
                for (int i = 0; i < textBoxes.GetLength(0); i++)
                {
                    for (int j = 0; j < textBoxes.GetLength(1); j++)
                    {
                        if (int.Parse(textBoxes[i, j].Text) < Min)
                        {
                            strokaMin = j;
                            Min = int.Parse(textBoxes[i, j].Text);
                        }
                    }
                }
                return strokaMin;
            }
            public void Matrix_Input(string s, int i, int j)
            {
                textBoxes[i, j] = new NewValue(i, j)
                {
                    Size = new Size(20, 40),
                    Visible = true,
                    Location = new Point(i * 30 + 20, j * 40 + 20),
                    Text = s,
                    ReadOnly = true
                };
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void createMatrix_button_Click(object sender, EventArgs e)
        {
            groupBox_matrix.Controls.Clear();
            int M = int.Parse(numericUpDown_m.Value.ToString());
            int N = int.Parse(numericUpDown_n.Value.ToString());
            matrixField = new MatrixField(M, N);
            matrixField.Matrix_Values();
            foreach (NewValue i in matrixField.textBoxes)
            {
                groupBox_matrix.Controls.Add(i);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            groupBox_changeMatrix.Controls.Clear();
            matrixField_Changed = new MatrixField(matrixField.textBoxes.GetLength(0), matrixField.textBoxes.GetLength(1));
            int max = matrixField.MatrixChange_indexMax();
            int min = matrixField.MatrixChange_indexMin();
            for (int i = 0, n = matrixField.textBoxes.GetLength(0); i < n; i++)
            {
                for (int j = 0, m = matrixField.textBoxes.GetLength(1); j < m; j++)
                {
                    if (j == min)
                    {
                        matrixField_Changed.Matrix_Input(matrixField.textBoxes[i, min].Text, i, max);
                        continue;
                    }
                    if (j == max)
                    {
                        matrixField_Changed.Matrix_Input(matrixField.textBoxes[i, max].Text, i, min);
                        continue;
                    }
                    matrixField_Changed.Matrix_Input(matrixField.textBoxes[i, j].Text, i, j);
                }
            }
            foreach (NewValue i in matrixField_Changed.textBoxes)
            {
                groupBox_changeMatrix.Controls.Add(i);
            }
        }
    }
}
