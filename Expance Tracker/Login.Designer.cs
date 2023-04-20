namespace Expance_Tracker
{
    partial class Login
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
            label1 = new Label();
            UnameTb = new TextBox();
            PasswordTb = new TextBox();
            label2 = new Label();
            LoginBtn = new Button();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(54, 66);
            label1.Name = "label1";
            label1.Size = new Size(79, 16);
            label1.TabIndex = 0;
            label1.Text = "UserName";
            // 
            // UnameTb
            // 
            UnameTb.Location = new Point(54, 89);
            UnameTb.Name = "UnameTb";
            UnameTb.Size = new Size(163, 23);
            UnameTb.TabIndex = 1;
            // 
            // PasswordTb
            // 
            PasswordTb.Location = new Point(54, 155);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.Size = new Size(163, 23);
            PasswordTb.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(54, 132);
            label2.Name = "label2";
            label2.Size = new Size(72, 16);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = SystemColors.ActiveCaption;
            LoginBtn.Font = new Font("Lucida Fax", 10F, FontStyle.Bold, GraphicsUnit.Point);
            LoginBtn.Location = new Point(79, 201);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(102, 33);
            LoginBtn.TabIndex = 4;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Lucida Fax", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(47, 20);
            label3.Name = "label3";
            label3.Size = new Size(206, 25);
            label3.TabIndex = 5;
            label3.Text = "Expance Tracker";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Fax", 8F, FontStyle.Underline, GraphicsUnit.Point);
            label4.Location = new Point(99, 248);
            label4.Name = "label4";
            label4.Size = new Size(52, 14);
            label4.TabIndex = 6;
            label4.Text = "Register";
            label4.Click += label4_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 305);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(LoginBtn);
            Controls.Add(PasswordTb);
            Controls.Add(label2);
            Controls.Add(UnameTb);
            Controls.Add(label1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox UnameTb;
        private TextBox PasswordTb;
        private Label label2;
        private Button LoginBtn;
        private Label label3;
        private Label label4;
    }
}