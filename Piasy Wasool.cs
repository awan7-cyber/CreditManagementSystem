using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DukaanKhataa
{
    public partial class Piasy_Wasool : Form
    {
        public Piasy_Wasool()
        {
            InitializeComponent();
        }

        string connStr = ConfigurationManager.ConnectionStrings["KhataaDB"].ConnectionString;
        int cid;
        int loan;

        SqlConnection conn = new SqlConnection("Data Source=TASAWAR-LAPTOP\\MSSQLSERVER01;Initial Catalog=Khataa;Integrated Security=True");
         private void button2_Click(object sender, EventArgs e)
         {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
         }

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (dropdown1.SelectedItem!=null)
            {
                try
                {
                    int totaludhaar = int.Parse(rbill.Text.ToString());
                    int wasoolrqm = int.Parse(wasool.Text.ToString());
                    if (wasoolrqm != 0)
                    {
                        if (totaludhaar > 0)
                        {
                            if (wasoolrqm > 0)
                            {
                                int remainngudhaar;
                                remainngudhaar = totaludhaar - wasoolrqm;

                                if (remainngudhaar > 0)
                                {
                                    //baqayatxt.Text = remainngudhaar.ToString();
                                    //textBox1.Text = "";
                                    //retrurna.Hide();
                                    //textBox1.Hide();
                                }
                                else
                                {

                                    //retrurna.Show();
                                    //textBox1.Show();
                                    //baqayatxt.Text = "00";
                                    //remainngudhaar = remainngudhaar * -1;
                                    //textBox1.Text = remainngudhaar.ToString();


                                }
                            }
                        }
                    }     
                }
                catch (Exception ex)
                {
                    ////textBox1.Text = "";
                    ////textBox1.Hide();
                    ////retrurna.Hide();
                    //baqayatxt.Text = "0";
                    MessageBox.Show("Enter Valid Input");
                }
            }
            else
            {
                //textBox1.Text = "";
                //textBox1.Hide();
                //retrurna.Hide();
                //baqayatxt.Text = "";
                wasool.Text = "0";   
            }
        }

        void loadpendingdues()
        {
            conn.Open();
            SqlCommand sql = new SqlCommand("paymentop", conn);
            sql.CommandType = CommandType.StoredProcedure;
            sql.Parameters.AddWithValue("@query", "pendingdues");
            sql.Parameters.AddWithValue("@cid", cid);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql);    
            DataTable dataTable = new DataTable();  
            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0) 
            {
                invoicetbl.DataSource=dataTable;
                conn.Close();
            }
            else
            {
                invoicetbl.DataSource = null;
            }
            conn.Close();
        }

        void generatepayment( decimal paidamount)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("paymentop", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@query", "insertpayment");
                cmd.Parameters.AddWithValue("@cid", cid);
                cmd.Parameters.AddWithValue("@paidamount", paidamount);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                loadbalance();
                wasool.Text = "";
              //  baqayatxt.Text = "";
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            int paidamount = int.Parse(wasool.Text.ToString());
            int pendingamount = int.Parse(rbill.Text.ToString());
           // int remain = int.Parse(baqayatxt.Text.ToString());
            

            if (paidamount>pendingamount)
            {
                generatepayment(pendingamount);
                MessageBox.Show("aap ka khataa clear hoo chuka hy");
                loadpendingdues();
            }
            if (paidamount<pendingamount)
            {
                
                generatepayment(paidamount);
                MessageBox.Show("aap ka balance  aa chuka hy");
                loadpendingdues();
            }

            else
            {
                generatepayment(paidamount);
            }

            // Date.Text = DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            time.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        void getAllNames()
        {
            try
            {
                // 🔹 App.config se connection string

                // 🔹 Using block ensures connection automatically close ho jaye
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    using (SqlCommand sqlCommand = new SqlCommand("CustomerOp", conn))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@query", "get");
                        sqlCommand.Parameters.AddWithValue("@name", DBNull.Value);

                        // 🔹 Open connection
                        conn.Open();

                        // 🔹 Fill DataTable
                        SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);
                        DataTable data = new DataTable();
                        sqlData.Fill(data);

                        // 🔹 Bind to ComboBox
                        if (data.Rows.Count > 0)
                        {
                            dropdown1.DataSource = data;
                            dropdown1.DisplayMember = "Name"; // jo dikhega
                            dropdown1.ValueMember = "CustomerId";     // actual DB value

                            // 🔹 Searchable dropdown
                            dropdown1.DropDownStyle = ComboBoxStyle.DropDown;
                            dropdown1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                            dropdown1.AutoCompleteSource = AutoCompleteSource.ListItems;
                        }
                        else
                        {
                            dropdown1.DataSource = null;
                            MessageBox.Show("No data found");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void Piasy_Wasool_Load(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToString("MM-dd-yyyy");
            getAllNames();
            loadbalance();
            //retrurna.Hide();
            //textBox1.Hide();
            timer1.Start();
        }

        void loadbalance()
        {
            
             
            SqlCommand command = new SqlCommand("sale", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@query", "pendingbalance");
            command.Parameters.AddWithValue("@id", cid);
            conn.Open();
            object result = command.ExecuteScalar();

            if (result != DBNull.Value)
            {
                loan = Convert.ToInt32(result);
                conn.Close();
                rbill.Text = loan.ToString();
            }



            else
            {
                conn.Close();
                rbill.Text = "00";

            }
            conn.Close();


        }

        //for customer details
        void getbyid(int id)
        {

            try
            {
                if (dropdown1.SelectedItem != null)
                {
                    SqlCommand sqlCommand = new SqlCommand("CustomerOp", conn);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@query", "searchbyid");
                    sqlCommand.Parameters.AddWithValue("@id", id);
                    conn.Open();
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    if (sqlDataReader.Read())
                    {
                        idtxt.Text = sqlDataReader["Adress"].ToString();
                        cnictxt.Text = sqlDataReader["CNIC"].ToString();
                        cid = int.Parse(sqlDataReader["CustomerId"].ToString());
                       
                        conn.Close();

                        if (rbill.Text == "")
                        {
                            rbill.Text = "00";
                        }

                        loadbalance();
                    }


                    else
                    {

                        idtxt.Text = "";
                        cnictxt.Text = "";
                    }
                    conn.Close();


                }
                else
                {
                    idtxt.Text = "";
                    cnictxt.Text = "";
                    rbill.Text = "";
                }

            }
            catch
            {
                MessageBox.Show("App ka andraaj durust nahi");
            }

        }

        private void dropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropdown1.SelectedValue != null)
            {
                int selectedId;
                if (int.TryParse(dropdown1.SelectedValue.ToString(), out selectedId))
                {
                    getbyid(selectedId);
                    loadpendingdues();
                    wasool.Focus();
                }
            }
            else
            {
                return;

            }
        }

        private void dropdown1_CursorChanged(object sender, EventArgs e)
        {

            //textBox1.Text = "";
            //textBox1.Hide();
            //retrurna.Hide();
            //baqayatxt.Text = "";
           wasool.Text = "0";
        }

        private void dropdown1_SelectedValueChanged(object sender, EventArgs e)
        {

            //textBox1.Text = "";
            //textBox1.Hide();
            //retrurna.Hide();
            //baqayatxt.Text = "";
            wasool.Text = "0";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void Piasy_Wasool_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Escape)
            {
                if(MessageBox.Show("Close form?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if(wasool.Text.Length>=2)
                {
                    button1.PerformClick();
                }
                
            }

        }

        private void wasool_Click(object sender, EventArgs e)
        {
            int select = int.Parse(wasool.Text.ToString());
            int udhaar = int.Parse(rbill.Text.ToString());
            if (select>udhaar)
            {
                MessageBox.Show("Invaild Amount","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                wasool.Text = select.ToString();
            }
        }
    }
}
