using System.Data;
using System.Data.SqlClient;
namespace Expance_Tracker
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            GetIncDate();
            GetNumInc();
            GetNumExp();
            GetMaxInc();
            GetMaxExp();
            GetExpDate();
            GetTotInc();
            GetTotExp();           
            GetMinInc();
            GetMinExp();
            GetMaxIncCat();
            GetMaxExpCat();
            GetBalance();
        }
        private void label3_Click(object sender, EventArgs e)
        {
            Income Obj = new Income();
            Obj.Show();
            this.Hide();
        }
        private void label6_Click(object sender, EventArgs e)
        {
            ViewExpenses Obj = new ViewExpenses();
            Obj.Show();
            this.Hide();
        }
        private void label5_Click(object sender, EventArgs e)
        {
            ViewIncome Obj = new ViewIncome();
            Obj.Show();
            this.Hide();
        }
        private void label4_Click(object sender, EventArgs e)
        {
            Expenses Obj = new Expenses();
            Obj.Show();
            this.Hide();
        }
        private void label36_Click(object sender, EventArgs e)
        {
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=""Expanse Tracker"";Integrated Security=True;Pooling=False");
        int Inc, Exp;
        private void GetTotInc()
        {
#pragma warning disable CS0168 // Variable is declared but never used
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Sum(IncAmt) from IncomeTb1 where IncUser = '" + Login.user + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Inc = Convert.ToInt32(dt.Rows[0][0].ToString());
                TotInclbl.Text = "Rs. " + dt.Rows[0][0].ToString();
                Con.Close();
            }
            catch (Exception e)
            {
                Con.Close();
            }
#pragma warning restore CS0168 // Variable is declared but never used
        }
        private void GetNumInc()
        {
#pragma warning disable CS0168 // Variable is declared but never used
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from IncomeTb1 where IncUser = '" + Login.user + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                NumInclbl.Text = dt.Rows[0][0].ToString();
                Con.Close();
            }
            catch (Exception e)
            {
                Con.Close();
            }
#pragma warning restore CS0168 // Variable is declared but never used
        }
        private void GetIncDate()
        {
#pragma warning disable CS0168 // Variable is declared but never used
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Max(IncDate) from IncomeTb1 where IncUser = '" + Login.user + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DateInclbl.Text = dt.Rows[0][0].ToString();
                LastInclbl.Text = dt.Rows[0][0].ToString();
                Con.Close();
            }
            catch (Exception e)
            {
                Con.Close();
            }
#pragma warning restore CS0168 // Variable is declared but never used
        }
        private void GetMaxInc()
        {
#pragma warning disable CS0168 // Variable is declared but never used
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Max(IncAmt) from IncomeTb1 where IncUser = '" + Login.user + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MaxInclbl.Text = "Rs. " + dt.Rows[0][0].ToString();
                Con.Close();
            }
            catch (Exception e)
            {
                Con.Close();
            }
#pragma warning restore CS0168 // Variable is declared but never used
        }
        private void GetMinInc()
        {
#pragma warning disable CS0168 // Variable is declared but never used
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Min(IncAmt) from IncomeTb1 where IncUser = '" + Login.user + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MinInclbl.Text = "Rs. " + dt.Rows[0][0].ToString();
                Con.Close();
            }
            catch (Exception e)
            {
                Con.Close();
            }
#pragma warning restore CS0168 // Variable is declared but never used
        }
        private void GetMaxIncCat()
        {
#pragma warning disable CS0168 // Variable is declared but never used
            try
            {
                Con.Open();
                string InnerQuery = "select Max(IncAmt) from IncomeTb1";
                DataTable dt1 = new DataTable();
                SqlDataAdapter sda1 = new SqlDataAdapter(InnerQuery, Con);
                sda1.Fill(dt1);
                string Query = "select IncCat From IncomeTb1 where IncAmt = '" + dt1.Rows[0][0].ToString() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BestIncCatlbl.Text = dt.Rows[0][0].ToString();
                Con.Close();
            }
            catch (Exception e)
            {
                Con.Close();
            }
#pragma warning restore CS0168 // Variable is declared but never used
        }
        private void GetTotExp()
        {
#pragma warning disable CS0168 // Variable is declared but never used
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Sum(ExpAmt) from ExpenseTb1 where ExpUser = '" + Login.user + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Exp = Convert.ToInt32(dt.Rows[0][0].ToString());
                TotExplbl.Text = "Rs. " + dt.Rows[0][0].ToString();
            }
            catch (Exception e)
            {
                Con.Close();
            }
#pragma warning restore CS0168 // Variable is declared but never used
        }
        private void GetBalance()
        {
            double Bal = Inc - Exp;
            Balancelbl.Text = "Rs.  " + Bal;
        }
        private void GetNumExp()
        {
#pragma warning disable CS0168 // Variable is declared but never used
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from ExpenseTb1 where ExpUser = '" + Login.user + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                NumExplbl.Text = dt.Rows[0][0].ToString();
                Con.Close();
            }
            catch (Exception e)
            {
                Con.Close();
            }
#pragma warning restore CS0168 // Variable is declared but never used
        }
        private void GetExpDate()
        {
#pragma warning disable CS0168 // Variable is declared but never used
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Max(ExpDate) from ExpenseTb1 where ExpUser = '" + Login.user + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DateExplbl.Text = dt.Rows[0][0].ToString();
                LastExplbl.Text = dt.Rows[0][0].ToString();
                Con.Close();
            }
            catch (Exception e)
            {
                Con.Close();
            }
#pragma warning restore CS0168 // Variable is declared but never used
        }
        private void GetMaxExp()
        {
#pragma warning disable CS0168 // Variable is declared but never used
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Max(ExpAmt) from ExpenseTb1 where ExpUser = '" + Login.user + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MaxExplbl.Text = "Rs. " + dt.Rows[0][0].ToString();
                Con.Close();
            }
            catch (Exception e)
            {
                Con.Close();
            }
#pragma warning restore CS0168 // Variable is declared but never used
        }
        private void GetMinExp()
        {
#pragma warning disable CS0168 // Variable is declared but never used
            try
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Min(ExpAmt) from ExpenseTb1 where ExpUser = '" + Login.user + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                MinExplbl.Text = "Rs. " + dt.Rows[0][0].ToString();
                Con.Close();
            }
            catch (Exception e)
            {
                Con.Close();
            }
#pragma warning restore CS0168 // Variable is declared but never used
        }
        private void GetMaxExpCat()
        {
#pragma warning disable CS0168 // Variable is declared but never used
            try
            {
                Con.Open();
                string InnerQuery = "select Max(ExpAmt) from ExpenseTb1";
                DataTable dt1 = new DataTable();
                SqlDataAdapter sda1 = new SqlDataAdapter(InnerQuery, Con);
                sda1.Fill(dt1);
                string Query = "select ExpCat from ExpenseTb1 where ExpAmt = '" + dt1.Rows[0][0].ToString() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BestExpCatlbl.Text = dt.Rows[0][0].ToString();
                Con.Close();
            }
            catch (Exception e)
            {
                Con.Close();
            }
#pragma warning restore CS0168 // Variable is declared but never used
        }
        private void TotInclbl_Click(object sender, EventArgs e)
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