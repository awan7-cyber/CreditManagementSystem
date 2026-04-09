using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DukaanKhataa
{
    public partial class PaymentDetails : Form
    {
        public PaymentDetails()
        {
            InitializeComponent();
        }

        int cid;
        int loan;
        public int CustomerId;
        string connStr = ConfigurationManager.ConnectionStrings["KhataaDB"].ConnectionString;


        async Task<DataTable> LoadFilterdDetails(int iid, string type, int? days=null)
        {
            DataTable Sales = new DataTable();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
               await conn.OpenAsync();
                using (SqlCommand cmd = new SqlCommand("udhaarop", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@query", "filterkhlasa");
                    cmd.Parameters.AddWithValue("@cid", iid);
                    cmd.Parameters.AddWithValue("@type", type);
                    cmd.Parameters.AddWithValue("@duration",days);  
                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync()) 
                    {
                        
                            Sales.Load(reader);
                    }
                }

            }
            if (Sales.Rows.Count > 0) { return Sales; }
            return Sales;
        }


      void DisplayFilteredData( DataTable tbl)
        {
            if(tbl.Rows.Count>0)
            {
                paymenttbl.DataSource = tbl;
            }
            

        }

        async Task getbyid(int id)
        {

            using(SqlConnection connection= new SqlConnection(connStr))
            {
                await connection.OpenAsync();       
                using (SqlCommand sqlCommand = new SqlCommand("CustomerOp", connection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@query", "searchbyid");
                    sqlCommand.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader= await sqlCommand.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())  // ✅ pehle row load karo
                        {
                            dropdown1.Text = reader["Name"].ToString();
                            //idtxt.Text = reader["Adress"].ToString();
                            //cnictxt.Text = reader["CNIC"].ToString();
                            cid = Convert.ToInt32(reader["CustomerId"]);
                        }
                    }
                }
            }

               

        }

        async Task<DataTable> loadeatails(int id)
        {
            DataTable tb = new DataTable();
            using (SqlConnection sql = new SqlConnection(connStr))
            {
                await sql.OpenAsync();
                using (SqlCommand cmd = new SqlCommand("udhaarop", sql))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@query", "khlasa");
                    cmd.Parameters.AddWithValue("@cid", id);

                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        await Task.Run(() =>
                        {
                            tb.Load(reader);
                        });
                    }
                }
            }


            return tb;
        }
        void DisplayDetails(DataTable table)
        {
            if (table.Rows.Count > 0)
            {
                paymenttbl.DataSource = table;
             
                Payment payment = new Payment();
                paymenttbl.Columns.Add(payment.detailbtn());
                paymenttbl.CurrentCell = paymenttbl.Rows[0].Cells["detailbtn"];
            }
        }

        

        async Task<int> loadbalance()
        {
            int balance;
            using (SqlConnection connection = new SqlConnection(connStr))
            {
               
                await connection.OpenAsync();
                using (SqlCommand cmd = new SqlCommand("sale", connection))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@query", "pendingbalance");
                    cmd.Parameters.AddWithValue("@id", cid);
                    object result = await cmd.ExecuteScalarAsync();
                    balance = int.Parse(result.ToString());

                }
            }
            return balance;
        } 

        void displaybalance(int balance)
        {
            if (balance>=0)
            {                
                rbill.Text = balance.ToString();
            }
            else
            {
                rbill.Text = "00";
            }
        }
       async private void dropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropdown1.SelectedValue != null)
            {
                int selectedId;
                if (int.TryParse(dropdown1.SelectedValue.ToString(), out selectedId))
                {
                     await  getbyid(selectedId);
                    var data = await loadbalance();
                    displaybalance(data);// Safe fetch
                }
            }
            else
            {
                return;

            }
        }

        private void PaymentDetails_Load(object sender, EventArgs e)
        {
           
        }

        private void paymenttbl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (paymenttbl.Columns[e.ColumnIndex].Name == "detailbtn")
            {
                DataGridViewRow row = paymenttbl.Rows[e.RowIndex];
                if (row.Cells["Ref"].Value != null)
                {
                    int SaleId = Convert.ToInt32(row.Cells["Ref"].Value);
                    Khataa_Maloom khataa_ = new Khataa_Maloom();
                    khataa_.Cid = CustomerId;
                    khataa_.Sid = SaleId;
                    khataa_.ShowDialog();

                }
            }
        }

        private void PaymentDetails_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void PaymentDetails_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Escape)
            {
                if (MessageBox.Show("Close form?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

       async private void PaymentDetails_Shown(object sender, EventArgs e)
        {
            if (CustomerId != 0)
            {

                await  getbyid(CustomerId);
                var data = await loadbalance();
                displaybalance(data);
                var balance = await loadeatails(CustomerId);
                DisplayDetails(balance);
               
            }
            else
            {

            }
        }




        private async void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = guna2ComboBox1.Text;
            if (selected == "Sale")
            {
                var data = await LoadFilterdDetails(CustomerId, "Sale");
                DisplayFilteredData(data);
            }
           if(selected != "Sale")
            {
                var data = await LoadFilterdDetails(CustomerId, "Payment");
                DisplayFilteredData(data);
            }

        }


        async Task<DataTable> filterdays(int days, int id)
        {
            DataTable data = new DataTable();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                await conn.OpenAsync();
                {
                    using (SqlCommand cmd = new SqlCommand("summary", conn))
                    {
                        cmd.CommandType=CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@query", "filterdays");
                        cmd.Parameters.AddWithValue("@days", days);
                        cmd.Parameters.AddWithValue("@cid", id);
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            data.Load(reader);
                        }
                    }
                }
            }
            return data;    
        }

        async private void guna2TileButton2_Click(object sender, EventArgs e)
        {
            var type = guna2ComboBox1.Text;

            DisplayFilteredData(await LoadFilterdDetails(CustomerId, type,-7));
        }

        async private void guna2TileButton3_Click(object sender, EventArgs e)
        {
            var type = guna2ComboBox1.Text;

            DisplayFilteredData(await LoadFilterdDetails(CustomerId, type, -15));
        }

        async  private void guna2TileButton4_Click(object sender, EventArgs e)
        {
            var type = guna2ComboBox1.Text;

            DisplayFilteredData(await LoadFilterdDetails(CustomerId, type, -30));
        }

        async  private void guna2TileButton5_Click(object sender, EventArgs e)
        {
            var type = guna2ComboBox1.Text;

            DisplayFilteredData(await LoadFilterdDetails(CustomerId, type, -90));
        }

         async  private void guna2TileButton6_Click(object sender, EventArgs e)
         {

            var type = guna2ComboBox1.Text;

            DisplayFilteredData(await LoadFilterdDetails(CustomerId, type, -180));

         }
    }
}
