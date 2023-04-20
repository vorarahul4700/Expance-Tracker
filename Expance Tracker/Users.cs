using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Expance_Tracker
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=""Expanse Tracker"";Integrated Security=True;Pooling=False");
        private void Clear()
        {
            UnameTb.Text = "";
            UPasswordTb.Text = "";
            UPhoneTb.Text = "";
            UAddressTb.Text = "";
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (UnameTb.Text == "" || UPhoneTb.Text == "" || UPasswordTb.Text == "" || UAddressTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into UserTb1(Uname,UDob,Uphone,UPass,UAddress)values(@UN,@UD,@UP,@UPA,@UA)", Con);
                    cmd.Parameters.AddWithValue("@UN", UnameTb.Text);
                    cmd.Parameters.AddWithValue("@UD", DOB.Value.Date);
                    cmd.Parameters.AddWithValue("@UP", UPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@UPA", UPasswordTb.Text);
                    cmd.Parameters.AddWithValue("@UA", UAddressTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Added!!");
                    Con.Close();
                    Clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void label8_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Close();
        }
    }
}
