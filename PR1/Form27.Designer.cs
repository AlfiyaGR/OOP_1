namespace PR1
{
    partial class Form27
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form27));
            this.button1 = new System.Windows.Forms.Button();
            this.label_M = new System.Windows.Forms.Label();
            this.label_N = new System.Windows.Forms.Label();
            this.createMatrix_button = new System.Windows.Forms.Button();
            this.numericUpDown_n = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_m = new System.Windows.Forms.NumericUpDown();
            this.groupBox_matrix = new System.Windows.Forms.GroupBox();
            this.groupBox_changeMatrix = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_n)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_m)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(719, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 0;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_M
            // 
            this.label_M.AutoSize = true;
            this.label_M.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_M.Location = new System.Drawing.Point(399, 8);
            this.label_M.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_M.Name = "label_M";
            this.label_M.Size = new System.Drawing.Size(22, 20);
            this.label_M.TabIndex = 2;
            this.label_M.Text = "m";
            // 
            // label_N
            // 
            this.label_N.AutoSize = true;
            this.label_N.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_N.Location = new System.Drawing.Point(403, 31);
            this.label_N.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_N.Name = "label_N";
            this.label_N.Size = new System.Drawing.Size(18, 20);
            this.label_N.TabIndex = 3;
            this.label_N.Text = "n";
            // 
            // createMatrix_button
            // 
            this.createMatrix_button.BackColor = System.Drawing.SystemColors.Info;
            this.createMatrix_button.Location = new System.Drawing.Point(490, 11);
            this.createMatrix_button.Margin = new System.Windows.Forms.Padding(2);
            this.createMatrix_button.Name = "createMatrix_button";
            this.createMatrix_button.Size = new System.Drawing.Size(142, 29);
            this.createMatrix_button.TabIndex = 6;
            this.createMatrix_button.Text = "Создать матрицу";
            this.createMatrix_button.UseVisualStyleBackColor = false;
            this.createMatrix_button.Click += new System.EventHandler(this.createMatrix_button_Click);
            // 
            // numericUpDown_n
            // 
            this.numericUpDown_n.Location = new System.Drawing.Point(425, 31);
            this.numericUpDown_n.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_n.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_n.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_n.Name = "numericUpDown_n";
            this.numericUpDown_n.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown_n.TabIndex = 7;
            this.numericUpDown_n.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_m
            // 
            this.numericUpDown_m.Location = new System.Drawing.Point(425, 9);
            this.numericUpDown_m.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_m.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_m.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_m.Name = "numericUpDown_m";
            this.numericUpDown_m.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown_m.TabIndex = 8;
            this.numericUpDown_m.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox_matrix
            // 
            this.groupBox_matrix.Location = new System.Drawing.Point(11, 31);
            this.groupBox_matrix.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_matrix.Name = "groupBox_matrix";
            this.groupBox_matrix.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_matrix.Size = new System.Drawing.Size(357, 423);
            this.groupBox_matrix.TabIndex = 9;
            this.groupBox_matrix.TabStop = false;
            this.groupBox_matrix.Text = "Матрица";
            // 
            // groupBox_changeMatrix
            // 
            this.groupBox_changeMatrix.Location = new System.Drawing.Point(425, 64);
            this.groupBox_changeMatrix.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_changeMatrix.Name = "groupBox_changeMatrix";
            this.groupBox_changeMatrix.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_changeMatrix.Size = new System.Drawing.Size(357, 423);
            this.groupBox_changeMatrix.TabIndex = 10;
            this.groupBox_changeMatrix.TabStop = false;
            this.groupBox_changeMatrix.Text = "Измененная матрица";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.Location = new System.Drawing.Point(265, 466);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 48);
            this.button2.TabIndex = 11;
            this.button2.Text = "Нажать";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form27
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(810, 526);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox_changeMatrix);
            this.Controls.Add(this.groupBox_matrix);
            this.Controls.Add(this.numericUpDown_m);
            this.Controls.Add(this.numericUpDown_n);
            this.Controls.Add(this.createMatrix_button);
            this.Controls.Add(this.label_N);
            this.Controls.Add(this.label_M);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form27";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задание 27";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_n)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_m)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_M;
        private System.Windows.Forms.Label label_N;
        private System.Windows.Forms.Button createMatrix_button;
        private System.Windows.Forms.NumericUpDown numericUpDown_n;
        private System.Windows.Forms.NumericUpDown numericUpDown_m;
        private System.Windows.Forms.GroupBox groupBox_matrix;
        private System.Windows.Forms.GroupBox groupBox_changeMatrix;
        private System.Windows.Forms.Button button2;
    }
}