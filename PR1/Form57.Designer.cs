namespace PR1
{
    partial class Form57
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form57));
            this.label = new System.Windows.Forms.Label();
            this.textBox_AB = new System.Windows.Forms.TextBox();
            this.textBox_BC = new System.Windows.Forms.TextBox();
            this.textBox_CA = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_CA = new System.Windows.Forms.Label();
            this.label_BC = new System.Windows.Forms.Label();
            this.label_AB = new System.Windows.Forms.Label();
            this.A_angle = new System.Windows.Forms.Label();
            this.B_angle = new System.Windows.Forms.Label();
            this.C_angle = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label.Location = new System.Drawing.Point(23, 22);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(125, 13);
            this.label.TabIndex = 1;
            this.label.Text = "Введите длины сторон:";
            // 
            // textBox_AB
            // 
            this.textBox_AB.Location = new System.Drawing.Point(52, 32);
            this.textBox_AB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_AB.Name = "textBox_AB";
            this.textBox_AB.Size = new System.Drawing.Size(76, 20);
            this.textBox_AB.TabIndex = 2;
            // 
            // textBox_BC
            // 
            this.textBox_BC.Location = new System.Drawing.Point(52, 54);
            this.textBox_BC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_BC.Name = "textBox_BC";
            this.textBox_BC.Size = new System.Drawing.Size(76, 20);
            this.textBox_BC.TabIndex = 3;
            // 
            // textBox_CA
            // 
            this.textBox_CA.Location = new System.Drawing.Point(52, 77);
            this.textBox_CA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_CA.Name = "textBox_CA";
            this.textBox_CA.Size = new System.Drawing.Size(76, 20);
            this.textBox_CA.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(26, 186);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 62);
            this.button1.TabIndex = 5;
            this.button1.Text = "Узнать площадь и периметр";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(205, 46);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 202);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label_CA);
            this.groupBox1.Controls.Add(this.label_BC);
            this.groupBox1.Controls.Add(this.label_AB);
            this.groupBox1.Controls.Add(this.textBox_BC);
            this.groupBox1.Controls.Add(this.textBox_AB);
            this.groupBox1.Controls.Add(this.textBox_CA);
            this.groupBox1.Location = new System.Drawing.Point(9, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(150, 124);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Стороны";
            // 
            // label_CA
            // 
            this.label_CA.AutoSize = true;
            this.label_CA.Location = new System.Drawing.Point(14, 80);
            this.label_CA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_CA.Name = "label_CA";
            this.label_CA.Size = new System.Drawing.Size(21, 13);
            this.label_CA.TabIndex = 7;
            this.label_CA.Text = "CA";
            // 
            // label_BC
            // 
            this.label_BC.AutoSize = true;
            this.label_BC.Location = new System.Drawing.Point(14, 57);
            this.label_BC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_BC.Name = "label_BC";
            this.label_BC.Size = new System.Drawing.Size(21, 13);
            this.label_BC.TabIndex = 6;
            this.label_BC.Text = "BC";
            // 
            // label_AB
            // 
            this.label_AB.AutoSize = true;
            this.label_AB.Location = new System.Drawing.Point(14, 34);
            this.label_AB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_AB.Name = "label_AB";
            this.label_AB.Size = new System.Drawing.Size(21, 13);
            this.label_AB.TabIndex = 5;
            this.label_AB.Text = "AB";
            // 
            // A_angle
            // 
            this.A_angle.AutoSize = true;
            this.A_angle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A_angle.Location = new System.Drawing.Point(184, 210);
            this.A_angle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.A_angle.Name = "A_angle";
            this.A_angle.Size = new System.Drawing.Size(39, 37);
            this.A_angle.TabIndex = 10;
            this.A_angle.Text = "A";
            // 
            // B_angle
            // 
            this.B_angle.AutoSize = true;
            this.B_angle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B_angle.Location = new System.Drawing.Point(325, 22);
            this.B_angle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.B_angle.Name = "B_angle";
            this.B_angle.Size = new System.Drawing.Size(38, 37);
            this.B_angle.TabIndex = 11;
            this.B_angle.Text = "B";
            // 
            // C_angle
            // 
            this.C_angle.AutoSize = true;
            this.C_angle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.C_angle.Location = new System.Drawing.Point(383, 242);
            this.C_angle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.C_angle.Name = "C_angle";
            this.C_angle.Size = new System.Drawing.Size(40, 37);
            this.C_angle.TabIndex = 12;
            this.C_angle.Text = "C";
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(349, 3);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 13;
            this.back_button.Text = "Назад";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // Form57
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(431, 295);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.C_angle);
            this.Controls.Add(this.B_angle);
            this.Controls.Add(this.A_angle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form57";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задание 57";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBox_AB;
        private System.Windows.Forms.TextBox textBox_BC;
        private System.Windows.Forms.TextBox textBox_CA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_CA;
        private System.Windows.Forms.Label label_BC;
        private System.Windows.Forms.Label label_AB;
        private System.Windows.Forms.Label A_angle;
        private System.Windows.Forms.Label B_angle;
        private System.Windows.Forms.Label C_angle;
        private System.Windows.Forms.Button back_button;
    }
}