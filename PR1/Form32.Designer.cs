namespace PR1
{
    partial class Form32
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form32));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_a = new System.Windows.Forms.Button();
            this.button_b = new System.Windows.Forms.Button();
            this.button_c = new System.Windows.Forms.Button();
            this.label_a = new System.Windows.Forms.Label();
            this.label_b = new System.Windows.Forms.Label();
            this.label_c = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(742, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 0;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 38);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(455, 320);
            this.dataGridView1.TabIndex = 1;
            // 
            // button_a
            // 
            this.button_a.Location = new System.Drawing.Point(625, 142);
            this.button_a.Margin = new System.Windows.Forms.Padding(2);
            this.button_a.Name = "button_a";
            this.button_a.Size = new System.Drawing.Size(56, 19);
            this.button_a.TabIndex = 2;
            this.button_a.Text = "Узнать";
            this.button_a.UseVisualStyleBackColor = true;
            this.button_a.Click += new System.EventHandler(this.button_a_Click);
            // 
            // button_b
            // 
            this.button_b.Location = new System.Drawing.Point(625, 223);
            this.button_b.Margin = new System.Windows.Forms.Padding(2);
            this.button_b.Name = "button_b";
            this.button_b.Size = new System.Drawing.Size(56, 19);
            this.button_b.TabIndex = 3;
            this.button_b.Text = "Узнать";
            this.button_b.UseVisualStyleBackColor = true;
            this.button_b.Click += new System.EventHandler(this.button_b_Click);
            // 
            // button_c
            // 
            this.button_c.Location = new System.Drawing.Point(625, 311);
            this.button_c.Margin = new System.Windows.Forms.Padding(2);
            this.button_c.Name = "button_c";
            this.button_c.Size = new System.Drawing.Size(56, 19);
            this.button_c.TabIndex = 4;
            this.button_c.Text = "Узнать";
            this.button_c.UseVisualStyleBackColor = true;
            this.button_c.Click += new System.EventHandler(this.button_c_Click);
            // 
            // label_a
            // 
            this.label_a.AutoSize = true;
            this.label_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_a.Location = new System.Drawing.Point(480, 107);
            this.label_a.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_a.Name = "label_a";
            this.label_a.Size = new System.Drawing.Size(291, 34);
            this.label_a.TabIndex = 5;
            this.label_a.Text = "Общая сумма, \r\nвыплаченная за квартал всем работникам";
            // 
            // label_b
            // 
            this.label_b.AutoSize = true;
            this.label_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_b.Location = new System.Drawing.Point(480, 188);
            this.label_b.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_b.Name = "label_b";
            this.label_b.Size = new System.Drawing.Size(302, 34);
            this.label_b.TabIndex = 6;
            this.label_b.Text = "Зарплату, \r\nполученную за квартал каждым работником";
            // 
            // label_c
            // 
            this.label_c.AutoSize = true;
            this.label_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_c.Location = new System.Drawing.Point(480, 276);
            this.label_c.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_c.Name = "label_c";
            this.label_c.Size = new System.Drawing.Size(234, 34);
            this.label_c.TabIndex = 7;
            this.label_c.Text = "Общую зарплату\r\nвсех работников за каждый месяц";
            // 
            // Form32
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(809, 397);
            this.Controls.Add(this.label_c);
            this.Controls.Add(this.label_b);
            this.Controls.Add(this.label_a);
            this.Controls.Add(this.button_c);
            this.Controls.Add(this.button_b);
            this.Controls.Add(this.button_a);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form32";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задание 32";
            this.Load += new System.EventHandler(this.Form32_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_a;
        private System.Windows.Forms.Button button_b;
        private System.Windows.Forms.Button button_c;
        private System.Windows.Forms.Label label_a;
        private System.Windows.Forms.Label label_b;
        private System.Windows.Forms.Label label_c;
    }
}