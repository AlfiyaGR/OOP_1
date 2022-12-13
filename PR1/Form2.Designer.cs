namespace PR1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.result_button = new System.Windows.Forms.Button();
            this.elem_x = new System.Windows.Forms.Label();
            this.textBox_x = new System.Windows.Forms.TextBox();
            this.textBox_z = new System.Windows.Forms.TextBox();
            this.textBox_y = new System.Windows.Forms.TextBox();
            this.elem_y = new System.Windows.Forms.Label();
            this.elem_z = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // result_button
            // 
            this.result_button.BackColor = System.Drawing.Color.Pink;
            this.result_button.Font = new System.Drawing.Font("Monotype Corsiva", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result_button.Location = new System.Drawing.Point(239, 176);
            this.result_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.result_button.Name = "result_button";
            this.result_button.Size = new System.Drawing.Size(277, 73);
            this.result_button.TabIndex = 0;
            this.result_button.Text = "Вычислить z";
            this.result_button.UseVisualStyleBackColor = false;
            this.result_button.Click += new System.EventHandler(this.result_button_Click);
            // 
            // elem_x
            // 
            this.elem_x.AutoSize = true;
            this.elem_x.Location = new System.Drawing.Point(357, 58);
            this.elem_x.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.elem_x.Name = "elem_x";
            this.elem_x.Size = new System.Drawing.Size(159, 24);
            this.elem_x.TabIndex = 1;
            this.elem_x.Text = "Введите значение x:";
            // 
            // textBox_x
            // 
            this.textBox_x.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_x.Location = new System.Drawing.Point(535, 55);
            this.textBox_x.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_x.Name = "textBox_x";
            this.textBox_x.Size = new System.Drawing.Size(124, 30);
            this.textBox_x.TabIndex = 2;
            // 
            // textBox_z
            // 
            this.textBox_z.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_z.Location = new System.Drawing.Point(343, 297);
            this.textBox_z.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_z.Name = "textBox_z";
            this.textBox_z.ReadOnly = true;
            this.textBox_z.Size = new System.Drawing.Size(281, 30);
            this.textBox_z.TabIndex = 3;
            // 
            // textBox_y
            // 
            this.textBox_y.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_y.Location = new System.Drawing.Point(535, 114);
            this.textBox_y.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_y.Name = "textBox_y";
            this.textBox_y.Size = new System.Drawing.Size(124, 30);
            this.textBox_y.TabIndex = 4;
            // 
            // elem_y
            // 
            this.elem_y.AutoSize = true;
            this.elem_y.Location = new System.Drawing.Point(357, 117);
            this.elem_y.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.elem_y.Name = "elem_y";
            this.elem_y.Size = new System.Drawing.Size(158, 24);
            this.elem_y.TabIndex = 5;
            this.elem_y.Text = "Введите значение y:";
            // 
            // elem_z
            // 
            this.elem_z.AutoSize = true;
            this.elem_z.Location = new System.Drawing.Point(226, 300);
            this.elem_z.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.elem_z.Name = "elem_z";
            this.elem_z.Size = new System.Drawing.Size(109, 24);
            this.elem_z.TabIndex = 6;
            this.elem_z.Text = "Значение z = ";
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(672, 12);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(72, 27);
            this.back_button.TabIndex = 7;
            this.back_button.Text = "Назад";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // Form2
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(756, 357);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.elem_z);
            this.Controls.Add(this.elem_y);
            this.Controls.Add(this.textBox_y);
            this.Controls.Add(this.textBox_z);
            this.Controls.Add(this.textBox_x);
            this.Controls.Add(this.elem_x);
            this.Controls.Add(this.result_button);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2 задание";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button result_button;
        private System.Windows.Forms.Label elem_x;
        private System.Windows.Forms.TextBox textBox_x;
        private System.Windows.Forms.TextBox textBox_z;
        private System.Windows.Forms.TextBox textBox_y;
        private System.Windows.Forms.Label elem_y;
        private System.Windows.Forms.Label elem_z;
        private System.Windows.Forms.Button back_button;
    }
}