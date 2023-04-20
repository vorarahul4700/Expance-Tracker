namespace Expance_Tracker
{
    partial class Users
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
            label3 = new Label();
            AddBtn = new Button();
            UPhoneTb = new TextBox();
            label2 = new Label();
            UnameTb = new TextBox();
            label1 = new Label();
            label4 = new Label();
            UPasswordTb = new TextBox();
            label5 = new Label();
            UAddressTb = new TextBox();
            label6 = new Label();
            DOB = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Lucida Fax", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(49, 9);
            label3.Name = "label3";
            label3.Size = new Size(206, 25);
            label3.TabIndex = 11;
            label3.Text = "Expance Tracker";
            // 
            // AddBtn
            // 
            AddBtn.AccessibleName = "";
            AddBtn.BackColor = SystemColors.ActiveCaption;
            AddBtn.Font = new Font("Lucida Fax", 10F, FontStyle.Bold, GraphicsUnit.Point);
            AddBtn.Location = new Point(80, 471);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(145, 37);
            AddBtn.TabIndex = 10;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // UPhoneTb
            // 
            UPhoneTb.Location = new Point(29, 252);
            UPhoneTb.Name = "UPhoneTb";
            UPhoneTb.Size = new Size(247, 23);
            UPhoneTb.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 229);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 8;
            label2.Text = "Phone";
            // 
            // UnameTb
            // 
            UnameTb.Location = new Point(29, 144);
            UnameTb.Name = "UnameTb";
            UnameTb.Size = new Size(247, 23);
            UnameTb.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 121);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 6;
            label1.Text = "UserName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(109, 63);
            label4.Name = "label4";
            label4.Size = new Size(86, 18);
            label4.TabIndex = 12;
            label4.Text = "Add User";
            // 
            // UPasswordTb
            // 
            UPasswordTb.Location = new Point(29, 306);
            UPasswordTb.Name = "UPasswordTb";
            UPasswordTb.Size = new Size(247, 23);
            UPasswordTb.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 283);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 13;
            label5.Text = "Password";
            // 
            // UAddressTb
            // 
            UAddressTb.Location = new Point(29, 360);
            UAddressTb.Multiline = true;
            UAddressTb.Name = "UAddressTb";
            UAddressTb.Size = new Size(247, 83);
            UAddressTb.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 337);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 15;
            label6.Text = "Address";
            // 
            // DOB
            // 
            DOB.Location = new Point(29, 198);
            DOB.Name = "DOB";
            DOB.Size = new Size(247, 23);
            DOB.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 175);
            label7.Name = "label7";
            label7.Size = new Size(73, 15);
            label7.TabIndex = 20;
            label7.Text = "Date of Birth";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Lucida Fax", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(132, 516);
            label8.Name = "label8";
            label8.Size = new Size(41, 16);
            label8.TabIndex = 21;
            label8.Text = "Back";
            label8.Click += label8_Click;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 572);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(DOB);
            Controls.Add(UAddressTb);
            Controls.Add(label6);
            Controls.Add(UPasswordTb);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(AddBtn);
            Controls.Add(UPhoneTb);
            Controls.Add(label2);
            Controls.Add(UnameTb);
            Controls.Add(label1);
            Name = "Users";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Users";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button AddBtn;
        private TextBox UPhoneTb;
        private Label label2;
        private TextBox UnameTb;
        private Label label1;
        private Label label4;
        private TextBox UPasswordTb;
        private Label label5;
        private TextBox UAddressTb;
        private Label label6;
        private DateTimePicker DOB;
        private Label label7;
        private Label label8;
    }
}