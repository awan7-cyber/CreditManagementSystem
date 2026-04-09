using CrystalDecisions.Shared;
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

namespace DukaanKhataa
{
    public partial class Payment : Form
    {


        public Payment()
        {
            InitializeComponent();
        }
       SqlConnection conn = new SqlConnection("Data Source=TASAWAR-LAPTOP\\MSSQLSERVER01;Initial Catalog=Khataa;Integrated Security=True");
       public string mode;


      public  DataGridViewButtonColumn detailbtn()
        {
            DataGridViewButtonColumn detailbtn = new DataGridViewButtonColumn();
            detailbtn.Width = 200;
            detailbtn.Width = 200;
            detailbtn.Name = "detailbtn";
            detailbtn.Text = "View Details";
            detailbtn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            detailbtn.HeaderText = "Check Details";
            detailbtn.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            detailbtn.UseColumnTextForButtonValue = true;
            return detailbtn;
        }

        void loadtodaypayment()
        {

            DateTime start = DateTime.Today;
            DateTime end = start.AddDays(1);

            SqlCommand sqlCommand = new SqlCommand("paymentop", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@query", "htodaypayments");
            sqlCommand.Parameters.AddWithValue("@sdate", start);
            sqlCommand.Parameters.AddWithValue("@edate", end);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0) 
            {
                
                    todaytbl.Columns.Clear();         
                    todaytbl.DataSource = dt;
                    todaytbl.Columns.Add(detailbtn());
                    todaytbl.Columns["CustomerId"].Visible=false;
                                      
            }
            else
            {
                todaytbl.DataSource = null;
            }
                conn.Close();
        }




        void historybyid(string query,string procedure,int id)
        {
            SqlCommand sqlCommand = new SqlCommand(procedure, conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@query", query);
            sqlCommand.Parameters.AddWithValue("@cid", id);
            conn.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            if(dt.Rows.Count>0)
            {
                detailstbl.Columns.Clear();
                detailstbl.DataSource=dt;
                detailstbl.Columns["CustomerId"].Visible = false;
                detailstbl.Columns["Name"].Visible = false;
                if (procedure == "udhaarop") 
                {
                    detailstbl.Columns["SaleId"].Visible = false;

                    detailstbl.Columns.Add(detailbtn());
                }
               
                    conn.Close();
                
                return ;
            }
            else
            {
                detailstbl.DataSource = null;
            }
            conn.Close();
        }


        void loadallpayment()
        {
            conn.Open();
            SqlCommand sql = new SqlCommand("paymentop", conn);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@query", "hallpayments");
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                todaytbl.Columns.Clear();
                todaytbl.DataSource = dt;
                todaytbl.Columns["CustomerId"].Visible=false;
                todaytbl.Columns.Add(detailbtn());          
            }
            else
            {
                todaytbl.DataSource = null;
            }
                conn.Close();
        }

        void todayudhaar() 
        {
            DateTime start = DateTime.Today;
            DateTime end = start.AddDays(1);

            SqlCommand sqlCommand = new SqlCommand("udhaarop", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@query", "gettodayudaar");
            sqlCommand.Parameters.AddWithValue("@sdate",start);
            sqlCommand.Parameters.AddWithValue("@edate",end);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                todaytbl.Columns.Clear();
                todaytbl.DataSource = dt;
                todaytbl.Columns["CustomerId"].Visible = false;
                todaytbl.Columns.Add(detailbtn());   
            }
            else
            {
                todaytbl.DataSource = null;
            }
                conn.Close();
        }

        void alludhaar() 
        {
            SqlCommand sqlCommand = new SqlCommand("udhaarop", conn);
            sqlCommand.CommandType=CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@query", "getalludaar");
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0) 
            {
                todaytbl.Columns.Clear();
                todaytbl.DataSource=dt;
                todaytbl.Columns["CustomerId"].Visible=false;
               
                todaytbl.Columns.Add(detailbtn());
            }
            else
            {
                todaytbl.DataSource = null;
            }
                conn.Close();

        }

        void leftbtnssetup()
        { 
        
          
           if(mode == "udhaar" && allbtn.Text == "پچھلا ادھار")
            {
                headlbl.Text = "پچھلے ادھار کی تفصیل";
                alludhaar();
            }

            //Payments Data
          
            else if (mode == "payment" && allbtn.Text == "پچھلی ادائیگی")
            {
                headlbl.Text = "پچھلی ادائیگیوں کی تفصیل";
                loadallpayment();
            }
        }
         
        void rightbtnssetup()
        {
            if (mode == "udhaar" && todaybtn.Text == "آج کا ادھار")
            {
                headlbl.Text = "آج کے ادھار کی تفصیل";
                todayudhaar();
            }
            //Payments Data
            else if (mode == "payment" && todaybtn.Text == "آج کی ادائیگی")
            {
                headlbl.Text = "آج کی ادائیگی کی تفصیل";
                loadtodaypayment();
            }

        }

        void udhaarsetup() 
        {
            // Main heading
            mainheadlbl.Text = "ادھار کا حساب کتاب";

            // Buttons
            allbtn.Text = "پچھلا ادھار";
            todaybtn.Text = "آج کا ادھار";

        }

        void paymentsetup()
        {
            mainheadlbl.Text = "ادائیگیوں کا حساب کتاب";

            allbtn.Text = "پچھلی ادائیگی";
            todaybtn.Text = "آج کی ادائیگی";
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            if (mode == "udhaar")
            {
                udhaarsetup();
            }
            else 
            {
                paymentsetup();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rightbtnssetup();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            leftbtnssetup();
        }

        private void todaytbl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(mainheadlbl.Text== "ادائیگیوں کا حساب کتاب")
            {
                int row = e.RowIndex;
                DataGridViewRow data = todaytbl.Rows[row];
                int Customerid = int.Parse(data.Cells["CustomerId"].Value.ToString());
                historybyid("hbyid", "paymentop", Customerid);

            }
            else
            {
                int row = e.RowIndex;
                DataGridViewRow data = todaytbl.Rows[row];
                int a = int.Parse(data.Cells["CustomerId"].Value.ToString());
                historybyid("halludhaar", "udhaarop", a);
            }
           
        }

        private void todaytbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void detailstbl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            DataGridViewRow viewRow = detailstbl.Rows[row]; 
            string customerid= viewRow.Cells["CustomerId"].Value.ToString();
            string saleid = viewRow.Cells["SaleId"].Value.ToString();
        
            Khataa_Maloom khataa_ = new Khataa_Maloom();
            khataa_.Cid = int.Parse(customerid);
            khataa_.Sid=int.Parse(saleid);
            khataa_.ShowDialog();


        }

        private void Payment_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Escape)
            {
                if (MessageBox.Show("Close form?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }
    }
}
