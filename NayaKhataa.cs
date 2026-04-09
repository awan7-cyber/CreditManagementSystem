using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DukaanKhataa
{
    public partial class NayaKhataa : Form
    {
        public NayaKhataa()
        {
            InitializeComponent();
        }

        SqlConnection conn =new SqlConnection("Data Source=TASAWAR-LAPTOP\\MSSQLSERVER01;Initial Catalog=Khataa;Integrated Security=True");


        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        void freebox()
        {
            
            nametxt.Text = "";
            cnictxt.Text = "";
            adresstxt.Text = "";
        }
        private void NayaKhataa_Load(object sender, EventArgs e)
        {
            timer1.Start();
            date.Text = DateTime.Now.ToString("MM-dd:yyyy");
          
        }
        DataTable dataTable = new DataTable();
        void customerload()
        {
            SqlCommand sqlCommand = new SqlCommand("CustomerOp", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@query", "get");
            conn.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand); 
           
            sqlDataAdapter.Fill(dataTable);
            conn.Close();
              
        }

        void displaycustomer()
        {
            if (dataTable.Rows.Count > 0)
            {
                Ctabl.DataSource = dataTable;

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(nametxt.Text!="" && cnictxt.Text!="" && adresstxt.Text!="")
            {

                try
                {
                    SqlCommand sqlCommand = new SqlCommand("Customerop", conn);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@query", "insert");
                 
                    sqlCommand.Parameters.AddWithValue("@name", nametxt.Text.ToString());
                    sqlCommand.Parameters.AddWithValue("@cnic",cnictxt.Text.ToString());
                    sqlCommand.Parameters.AddWithValue("@address", adresstxt.Text.ToString());
                 
                    conn.Open();
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Alhamulliah");
                    conn.Close();
                    freebox();
                    customerload();
                }
                catch 
                {
                    MessageBox.Show("Data Sai Fill Kreen");
                }
            }
            else
            {
                MessageBox.Show("Form Sai Pur Kareen");
            }
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void Ctable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row =e.RowIndex;
            if (row >= 0) 
            {
              DataGridViewRow selectedRow = Ctabl.Rows[row];
                nametxt.Text = selectedRow.Cells["Name"].Value.ToString();
                cnictxt.Text = selectedRow.Cells["CNIC"].Value.ToString();
                adresstxt.Text = selectedRow.Cells["Adress"].Value.ToString();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void NayaKhataa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (MessageBox.Show("Close form?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void NayaKhataa_Shown(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            customerload();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            displaycustomer();
        }
    }
}
