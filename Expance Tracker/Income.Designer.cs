namespace Expance_Tracker
{
    partial class Income
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
            panel1 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label8 = new Label();
            label9 = new Label();
            IncNameTb = new TextBox();
            IncAmtTb = new TextBox();
            label10 = new Label();
            IncDescTb = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            SaveBtn = new Button();
            CatCb = new ComboBox();
            IncDate = new DateTimePicker();
            label14 = new Label();
            panel4 = new Panel();
            TotInclbl = new Label();
            label23 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleTurquoise;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(214, 454);
            panel1.TabIndex = 22;
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
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(12, 239);
            label5.Name = "label5";
            label5.Size = new Size(117, 18);
            label5.TabIndex = 10;
            label5.Text = "View Income";
            label5.Click += label5_Click;
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
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(12, 155);
            label3.Name = "label3";
            label3.Size = new Size(70, 18);
            label3.TabIndex = 6;
            label3.Text = "Income";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lucida Fax", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(5, 20);
            label1.Name = "label1";
            label1.Size = new Size(138, 25);
            label1.TabIndex = 2;
            label1.Text = "Dashboard";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(249, 24);
            label8.Name = "label8";
            label8.Size = new Size(148, 18);
            label8.TabIndex = 23;
            label8.Text = "Personal Income";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(315, 108);
            label9.Name = "label9";
            label9.Size = new Size(105, 16);
            label9.TabIndex = 24;
            label9.Text = "Income Name";
            // 
            // IncNameTb
            // 
            IncNameTb.Location = new Point(315, 131);
            IncNameTb.Name = "IncNameTb";
            IncNameTb.Size = new Size(202, 23);
            IncNameTb.TabIndex = 25;
            // 
            // IncAmtTb
            // 
            IncAmtTb.Location = new Point(315, 185);
            IncAmtTb.Name = "IncAmtTb";
            IncAmtTb.Size = new Size(202, 23);
            IncAmtTb.TabIndex = 27;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(315, 162);
            label10.Name = "label10";
            label10.Size = new Size(64, 16);
            label10.TabIndex = 26;
            label10.Text = "Amount";
            // 
            // IncDescTb
            // 
            IncDescTb.Location = new Point(315, 239);
            IncDescTb.Multiline = true;
            IncDescTb.Name = "IncDescTb";
            IncDescTb.Size = new Size(202, 90);
            IncDescTb.TabIndex = 29;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(315, 216);
            label11.Name = "label11";
            label11.Size = new Size(90, 16);
            label11.TabIndex = 28;
            label11.Text = "Description";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(563, 106);
            label12.Name = "label12";
            label12.Size = new Size(82, 16);
            label12.TabIndex = 30;
            label12.Text = "Categories";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(563, 161);
            label13.Name = "label13";
            label13.Size = new Size(40, 16);
            label13.TabIndex = 32;
            label13.Text = "Date";
            // 
            // SaveBtn
            // 
            SaveBtn.Font = new Font("Lucida Fax", 10F, FontStyle.Bold, GraphicsUnit.Point);
            SaveBtn.Location = new Point(475, 380);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(128, 25);
            SaveBtn.TabIndex = 34;
            SaveBtn.Text = "Save Income";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // CatCb
            // 
            CatCb.FormattingEnabled = true;
            CatCb.Items.AddRange(new object[] { "Food", "Shopping", "Medical", "Salary", "Household", "Travel", "Vehicle", "Others" });
            CatCb.Location = new Point(563, 130);
            CatCb.Name = "CatCb";
            CatCb.Size = new Size(202, 23);
            CatCb.TabIndex = 35;
            // 
            // IncDate
            // 
            IncDate.Location = new Point(563, 185);
            IncDate.Name = "IncDate";
            IncDate.Size = new Size(202, 23);
            IncDate.TabIndex = 36;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Lucida Fax", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label14.Location = new Point(447, 58);
            label14.Name = "label14";
            label14.Size = new Size(184, 26);
            label14.TabIndex = 81;
            label14.Text = "Income Details";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Controls.Add(TotInclbl);
            panel4.Controls.Add(label23);
            panel4.Location = new Point(563, 239);
            panel4.Name = "panel4";
            panel4.Size = new Size(202, 64);
            panel4.TabIndex = 20;
            // 
            // TotInclbl
            // 
            TotInclbl.AutoSize = true;
            TotInclbl.Font = new Font("Lucida Fax", 10F, FontStyle.Bold, GraphicsUnit.Point);
            TotInclbl.Location = new Point(58, 36);
            TotInclbl.Name = "TotInclbl";
            TotInclbl.Size = new Size(86, 16);
            TotInclbl.TabIndex = 15;
            TotInclbl.Text = "Dashboard";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(50, 12);
            label23.Name = "label23";
            label23.Size = new Size(102, 16);
            label23.TabIndex = 14;
            label23.Text = "Total Income";
            // 
            // Income
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(901, 454);
            Controls.Add(panel4);
            Controls.Add(label14);
            Controls.Add(IncDate);
            Controls.Add(CatCb);
            Controls.Add(SaveBtn);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(IncDescTb);
            Controls.Add(label11);
            Controls.Add(IncAmtTb);
            Controls.Add(label10);
            Controls.Add(IncNameTb);
            Controls.Add(label9);
            Controls.Add(panel1);
            Controls.Add(label8);
            Name = "Income";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label8;
        private Label label9;
        private TextBox IncNameTb;
        private TextBox IncAmtTb;
        private Label label10;
        private TextBox IncDescTb;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button SaveBtn;
        private ComboBox CatCb;
        private DateTimePicker IncDate;
        private Label label14;
        private Panel panel4;
        private Label TotInclbl;
        private Label label23;
    }
}