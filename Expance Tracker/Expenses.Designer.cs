namespace Expance_Tracker
{
    partial class Expenses
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
            label14 = new Label();
            ExpDate = new DateTimePicker();
            CatCb = new ComboBox();
            SaveBtn = new Button();
            label13 = new Label();
            label12 = new Label();
            ExpDescTb = new TextBox();
            label11 = new Label();
            ExpAmtTb = new TextBox();
            label10 = new Label();
            ExpNameTb = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label9 = new Label();
            panel1 = new Panel();
            panel4 = new Panel();
            TotExplbl = new Label();
            label23 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Lucida Fax", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label14.Location = new Point(441, 59);
            label14.Name = "label14";
            label14.Size = new Size(193, 26);
            label14.TabIndex = 95;
            label14.Text = "Expense Details";
            // 
            // ExpDate
            // 
            ExpDate.Location = new Point(557, 186);
            ExpDate.Name = "ExpDate";
            ExpDate.Size = new Size(202, 23);
            ExpDate.TabIndex = 94;
            // 
            // CatCb
            // 
            CatCb.FormattingEnabled = true;
            CatCb.Items.AddRange(new object[] { "Food", "Shopping", "Medical", "Household", "Travel", "Vehicle", "Others" });
            CatCb.Location = new Point(557, 131);
            CatCb.Name = "CatCb";
            CatCb.Size = new Size(202, 23);
            CatCb.TabIndex = 93;
            // 
            // SaveBtn
            // 
            SaveBtn.Font = new Font("Lucida Fax", 10F, FontStyle.Bold, GraphicsUnit.Point);
            SaveBtn.Location = new Point(476, 380);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(137, 25);
            SaveBtn.TabIndex = 92;
            SaveBtn.Text = "Save Expense";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(557, 162);
            label13.Name = "label13";
            label13.Size = new Size(40, 16);
            label13.TabIndex = 91;
            label13.Text = "Date";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(557, 107);
            label12.Name = "label12";
            label12.Size = new Size(82, 16);
            label12.TabIndex = 90;
            label12.Text = "Categories";
            // 
            // ExpDescTb
            // 
            ExpDescTb.Location = new Point(309, 240);
            ExpDescTb.Multiline = true;
            ExpDescTb.Name = "ExpDescTb";
            ExpDescTb.Size = new Size(202, 90);
            ExpDescTb.TabIndex = 89;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(309, 217);
            label11.Name = "label11";
            label11.Size = new Size(90, 16);
            label11.TabIndex = 88;
            label11.Text = "Description";
            // 
            // ExpAmtTb
            // 
            ExpAmtTb.Location = new Point(309, 186);
            ExpAmtTb.Name = "ExpAmtTb";
            ExpAmtTb.Size = new Size(202, 23);
            ExpAmtTb.TabIndex = 87;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(309, 163);
            label10.Name = "label10";
            label10.Size = new Size(64, 16);
            label10.TabIndex = 86;
            label10.Text = "Amount";
            // 
            // ExpNameTb
            // 
            ExpNameTb.Location = new Point(309, 132);
            ExpNameTb.Name = "ExpNameTb";
            ExpNameTb.Size = new Size(202, 23);
            ExpNameTb.TabIndex = 85;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(317, 24);
            label8.Name = "label8";
            label8.Size = new Size(148, 18);
            label8.TabIndex = 83;
            label8.Text = "Personal Income";
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
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(12, 197);
            label4.Name = "label4";
            label4.Size = new Size(78, 18);
            label4.TabIndex = 8;
            label4.Text = "Expense";
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
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(309, 109);
            label9.Name = "label9";
            label9.Size = new Size(109, 16);
            label9.TabIndex = 84;
            label9.Text = "Expense Name";
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
            panel1.TabIndex = 82;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Controls.Add(TotExplbl);
            panel4.Controls.Add(label23);
            panel4.Location = new Point(557, 240);
            panel4.Name = "panel4";
            panel4.Size = new Size(202, 64);
            panel4.TabIndex = 96;
            // 
            // TotExplbl
            // 
            TotExplbl.AutoSize = true;
            TotExplbl.Font = new Font("Lucida Fax", 10F, FontStyle.Bold, GraphicsUnit.Point);
            TotExplbl.Location = new Point(58, 36);
            TotExplbl.Name = "TotExplbl";
            TotExplbl.Size = new Size(86, 16);
            TotExplbl.TabIndex = 15;
            TotExplbl.Text = "Dashboard";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(48, 12);
            label23.Name = "label23";
            label23.Size = new Size(106, 16);
            label23.TabIndex = 14;
            label23.Text = "Total Expense";
            // 
            // Expenses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(901, 454);
            Controls.Add(panel4);
            Controls.Add(label14);
            Controls.Add(ExpDate);
            Controls.Add(CatCb);
            Controls.Add(SaveBtn);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(ExpDescTb);
            Controls.Add(label11);
            Controls.Add(ExpAmtTb);
            Controls.Add(label10);
            Controls.Add(ExpNameTb);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(panel1);
            Name = "Expenses";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Expense";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label14;
        private DateTimePicker ExpDate;
        private ComboBox CatCb;
        private Button SaveBtn;
        private Label label13;
        private Label label12;
        private TextBox ExpDescTb;
        private Label label11;
        private TextBox ExpAmtTb;
        private Label label10;
        private TextBox ExpNameTb;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label9;
        private Panel panel1;
        private Panel panel4;
        private Label TotExplbl;
        private Label label23;
    }
}