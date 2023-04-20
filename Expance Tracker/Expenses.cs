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
    public partial class Expenses : Form
    {
        public Expenses()
        {
            InitializeComponent();
            GetTotExp();
        }
        private void clear()
        {
            ExpNameTb.Text = "";
            ExpAmtTb.Text = "";
            ExpDescTb.Text = "";
            CatCb.SelectedIndex = 0;
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=""Expanse Tracker"";Integrated Security=True;Pooling=False");
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (ExpNameTb.Text == "" || ExpAmtTb.Text == "" || ExpDescTb.Text == "" || CatCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into ExpenseTb1(ExpName,ExpAmt,ExpCat,ExpDate,ExpDesc,ExpUser)values(@EN,@EA,@EC,@ED,@EDe,@EU)", Con);
                    cmd.Parameters.AddWithValue("@EN", ExpNameTb.Text);
                    cmd.Parameters.AddWithValue("@EA", ExpAmtTb.Text);
                    cmd.Parameters.AddWithValue("@EC", CatCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@ED", ExpDate.Value.Date);
                    cmd.Parameters.AddWithValue("@Ede", ExpDescTb.Text);
                    cmd.Parameters.AddWithValue("@EU", Login.user);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Expense Added!!");
                    Con.Close();
                    clear();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }
        private void label6_Click(object sender, EventArgs e)
        {
            ViewExpenses Obj = new ViewExpenses();
            Obj.Show();
            this.Hide();
        }
        private void label3_Click(object sender, EventArgs e)
        {
            Income Obj = new Income();
            Obj.Show();
            this.Hide();
        }
        private void label5_Click(object sender, EventArgs e)
        {
            ViewIncome Obj = new ViewIncome();
            Obj.Show();
            this.Hide();
        }
        private void GetTotExp()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Sum(ExpAmt) from ExpenseTb1 where ExpUser = '" + Login.user + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //Exp = Convert.ToInt32(dt.Rows[0][0].ToString());
            TotExplbl.Text = "Rs. " + dt.Rows[0][0].ToString();
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
