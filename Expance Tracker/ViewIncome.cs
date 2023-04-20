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
    public partial class ViewIncome : Form
    {
        public ViewIncome()
        {
            InitializeComponent();
            DisplayIncomes();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=""Expanse Tracker"";Integrated Security=True;Pooling=False");
        private void DisplayIncomes()
        {
#pragma warning disable CS0168 // Variable is declared but never used
            try
            {
                Con.Open();
                string Query = "select * from IncomeTb1";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                IncomeDGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception e)
            {
                Con.Close();
            }
#pragma warning restore CS0168 // Variable is declared but never used
        }
        private void label3_Click(object sender, EventArgs e)
        {
            Income Obj = new Income();
            Obj.Show();
            this.Hide();
        }
        private void label4_Click(object sender, EventArgs e)
        {
            Expenses Obj = new Expenses();
            Obj.Show();
            this.Hide();
        }
        private void label6_Click(object sender, EventArgs e)
        {
            ViewExpenses Obj = new ViewExpenses();
            Obj.Show();
            this.Hide();
        }
        private void IncomeDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void label7_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Close();
        }
    }
}
