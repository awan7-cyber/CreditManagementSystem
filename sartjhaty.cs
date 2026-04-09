using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DukaanKhataa
{
    public partial class sartjhaty : Form
    {
        public sartjhaty()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=TASAWAR-LAPTOP\\MSSQLSERVER01;Initial Catalog=Khataa;Integrated Security=True");
        DataTable filterddata;
        string CONN = "Data Source=TASAWAR-LAPTOP\\MSSQLSERVER01;Initial Catalog=Khataa;Integrated Security=True";
        Payment payment = new Payment();

        void getnoofcustomer()
        {
            SqlCommand cmd = new SqlCommand("operations", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@query", "noofcustomer");
            conn.Open();
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            {
                while (sqlDataReader.Read()) 
                {
                    //count.Text = sqlDataReader["Total"].ToString();
                    
                }
                
            }
            conn.Close();
        }

        public async Task<DataTable> SelectFilterAsync(string filter, DateTime? startdate = null, DateTime? enddate = null)
        {
            DataTable table = new DataTable();

            using (SqlConnection con = new SqlConnection(CONN))
            {
                await con.OpenAsync();

                using (SqlCommand cmd = new SqlCommand("summary", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@query", filter);

                    if (filter == "todayudhaar" && startdate != null && enddate != null)
                    {
                        cmd.Parameters.AddWithValue("@sdate", startdate);
                        cmd.Parameters.AddWithValue("@edate", enddate);
                    }

                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        table.Load(reader); // DataTable fill
                    }
                }
            }

            return table;
        }




        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Khataa_Maloom khataa_Maloom=new Khataa_Maloom();
            khataa_Maloom.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();  
            form1.Show();
        }
      

       

        private void sartjhaty_Load(object sender, EventArgs e)
        {
           
        }

        private void udata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (udata.Columns[e.ColumnIndex].Name == "detailbtn")
            {
                DataGridViewRow row = udata.Rows[e.RowIndex];
                if (row.Cells["CustomerId"].Value != null)
                {
                    int customer_id = Convert.ToInt32(row.Cells["CustomerId"].Value);
                    PaymentDetails payment = new PaymentDetails();
                    payment.CustomerId = customer_id;
                    payment.ShowDialog();
                }
            }
        }

        private void sartjhaty_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Escape:
                    if (MessageBox.Show("Close form?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        this.Close();
                    }
                 break;

                case Keys.T:
                   metroTile1.PerformClick();
                    break;

                case Keys.U:
                    metroTile2.PerformClick();
                    break;

                case Keys.Z:
                    metroTile3.PerformClick();
                    break;

                case Keys.K:
                    metroTile4.PerformClick();
                    break;

                case Keys.P:
                    metroTile5.PerformClick();


                    break;

                case Keys.A:
                    metroTile6.PerformClick();
                    break;


            }
            
        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        void displayresult(DataTable data)
        {
            
            if (data.Rows.Count > 0)
            {
                udata.Columns.Clear();
                udata.DataSource = data;
                udata.Columns["CustomerId"].Visible = false;
                udata.Columns.Add(payment.detailbtn());
                udata.CurrentCell = udata.Rows[0].Cells["detailbtn"];
            }
        }

        private async void metroTile1_Click_1(object sender, EventArgs e)
        {
          //  ll.BackColor = Color.Yellow;
            headertxt.Text = "تمام کسٹمرز";
           
             var data= await SelectFilterAsync("allcustomers");

            if (data.Rows.Count > 0)
            {
                udata.Columns.Clear();
                udata.DataSource = data;              
            }
         
           
        }

        private async void metroTile2_Click(object sender, EventArgs e)
        {

            headertxt.Text = "ادھار والے";
            var data = await SelectFilterAsync("pendingamount");
            displayresult(data);
          
        }

        private async void metroTile3_Click(object sender, EventArgs e)
        {
            headertxt.Text = "زیادہ ادھار والے";
            var data = await SelectFilterAsync("mostpending");

            displayresult(data);
        }

        private async void metroTile4_Click(object sender, EventArgs e)
        {
            headertxt.Text = "کم ادھار والے";
            var data = await SelectFilterAsync("lesspending");
            displayresult(data);
        }

        private async void metroTile6_Click(object sender, EventArgs e)
        {
            headertxt.Text = "آج کے ادھار والے";
            DateTime sdate = DateTime.Today;
            DateTime edate = sdate.AddDays(2);
            var data = await SelectFilterAsync("todayudhaar",sdate,edate);
            displayresult(data);

        }

        private async void metroTile5_Click(object sender, EventArgs e)
        {
            headertxt.Text = "پرانا ادھار والے";
            var data = await SelectFilterAsync("oldudhaar");
            displayresult(data);
        }

        private void udata_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int row = udata.CurrentCell.RowIndex;

                int id = Convert.ToInt32(udata.Rows[row].Cells["CustomerId"].Value);

                PaymentDetails payment = new PaymentDetails();
                payment.CustomerId = id;
                payment.ShowDialog();

                e.Handled = true;
            }
        }

        private void metroTile_Click_1(object sender, EventArgs e)
        {

        }
    }
}
