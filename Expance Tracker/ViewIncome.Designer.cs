﻿namespace Expance_Tracker
{
    partial class ViewIncome
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
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label14 = new Label();
            comboBox1 = new ComboBox();
            label12 = new Label();
            label9 = new Label();
            textBox1 = new TextBox();
            label8 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            IncomeDGV = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IncomeDGV).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(12, 423);
            label7.Name = "label7";
            label7.Size = new Size(66, 18);
            label7.TabIndex = 13;
            label7.Text = "Logout";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(12, 281);
            label6.Name = "label6";
            label6.Size = new Size(125, 18);
            label6.TabIndex = 12;
            label6.Text = "View Expense";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(12, 239);
            label5.Name = "label5";
            label5.Size = new Size(117, 18);
            label5.TabIndex = 10;
            label5.Text = "View Income";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(12, 197);
            label4.Name = "label4";
            label4.Size = new Size(78, 18);
            label4.TabIndex = 8;
            label4.Text = "Expense";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(12, 155);
            label3.Name = "label3";
            label3.Size = new Size(70, 18);
            label3.TabIndex = 6;
            label3.Text = "Income";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(12, 113);
            label2.Name = "label2";
            label2.Size = new Size(99, 18);
            label2.TabIndex = 4;
            label2.Text = "Dashboard";
            label2.Click += label2_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Lucida Fax", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label14.Location = new Point(475, 49);
            label14.Name = "label14";
            label14.Size = new Size(160, 26);
            label14.TabIndex = 72;
            label14.Text = "View Income";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Food", "Shopping", "Medical", "Salary", "Household", "Travel", "Vehicle", "Others" });
            comboBox1.Location = new Point(572, 113);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(202, 23);
            comboBox1.TabIndex = 68;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(572, 94);
            label12.Name = "label12";
            label12.Size = new Size(82, 16);
            label12.TabIndex = 67;
            label12.Text = "Categories";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(314, 94);
            label9.Name = "label9";
            label9.Size = new Size(105, 16);
            label9.TabIndex = 58;
            label9.Text = "Income Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(314, 113);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(202, 23);
            textBox1.TabIndex = 62;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(253, 24);
            label8.Name = "label8";
            label8.Size = new Size(214, 18);
            label8.TabIndex = 60;
            label8.Text = "personal Income Details";
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleTurquoise;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(214, 454);
            panel1.TabIndex = 59;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lucida Fax", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(5, 20);
            label1.Name = "label1";
            label1.Size = new Size(206, 25);
            label1.TabIndex = 14;
            label1.Text = "Expance Tracker";
            // 
            // IncomeDGV
            // 
            IncomeDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            IncomeDGV.Dock = DockStyle.Bottom;
            IncomeDGV.Location = new Point(214, 155);
            IncomeDGV.Name = "IncomeDGV";
            IncomeDGV.RowTemplate.Height = 25;
            IncomeDGV.Size = new Size(687, 299);
            IncomeDGV.TabIndex = 73;
            IncomeDGV.CellContentClick += IncomeDGV_CellContentClick;
            // 
            // ViewIncome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(901, 454);
            Controls.Add(IncomeDGV);
            Controls.Add(label14);
            Controls.Add(comboBox1);
            Controls.Add(label12);
            Controls.Add(label9);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(panel1);
            Name = "ViewIncome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewIncome";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IncomeDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label14;
        private ComboBox comboBox1;
        private Label label12;
        private Label label9;
        private TextBox textBox1;
        private Label label8;
        private Panel panel1;
        private DataGridView IncomeDGV;
        private Label label1;
    }
}