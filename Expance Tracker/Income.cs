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
    public partial class Income : Form
    {
        public Income()
        {
            InitializeComponent();
            GetTotInc();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=""Expanse Tracker"";Integrated Security=True;Pooling=False");
        private void clear()
        {
            IncNameTb.Text = "";
            IncAmtTb.Text = "";
            IncDescTb.Text = "";
            CatCb.SelectedIndex = 0;
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (IncNameTb.Text == "" || IncAmtTb.Text == "" || IncDescTb.Text == "" || CatCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into IncomeTb1(IncName,IncAmt,IncCat,IncDate,IncDesc,IncUser)values(@IN,@IA,@IC,@ID,@IDe,@IU)", Con);
                    cmd.Parameters.AddWithValue("@IN", IncNameTb.Text);
                    cmd.Parameters.AddWithValue("@IA", IncAmtTb.Text);
                    cmd.Parameters.AddWithValue("@IC", CatCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ID", IncDate.Value.Date);
                    cmd.Parameters.AddWithValue("@Ide", IncDescTb.Text);
                    cmd.Parameters.AddWithValue("@IU", Login.user);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Income Added!!");
                    Con.Close();
                    clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {
            Expenses Obj = new Expenses();
            Obj.Show();
            this.Hide();
        }
        private void label5_Click(object sender, EventArgs e)
        {
            ViewIncome Obj = new ViewIncome();
            Obj.Show();
            this.Hide();
        }
        private void label6_Click(object sender, EventArgs e)
        {
            ViewExpenses Obj = new ViewExpenses();
            Obj.Show();
            this.Hide();
        }
        private void GetTotInc()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Sum(IncAmt) from IncomeTb1 where IncUser = '" + Login.user + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //Inc = Convert.ToInt32(dt.Rows[0][0].ToString());
            TotInclbl.Text = "Rs. " + dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void label7_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Close();
        }
    }
}
