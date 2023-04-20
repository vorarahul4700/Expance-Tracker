using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Expance_Tracker
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void label4_Click(object sender, EventArgs e)
        {
            Users Obj = new Users();
            Obj.Show();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=""Expanse Tracker"";Integrated Security=True;Pooling=False");
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public static String user;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Enter Both UserName and Password");
            }
            else
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM UserTb1 WHERE UName = '" + UnameTb.Text + "'and UPass='" + PasswordTb.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    user = UnameTb.Text;
                    Dashboard Obj = new Dashboard();
                    Obj.Show();
                    this.Hide();
                    Con.Close();
                }
                else
                {
                    MessageBox.Show("Wrong UserName of Password!!!");
                    UnameTb.Text = "";
                    PasswordTb.Text = "";
                }
                Con.Close();
            }
        }
    }
}
