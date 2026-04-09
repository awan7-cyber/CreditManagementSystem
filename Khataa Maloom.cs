using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DukaanKhataa
{
    public partial class Khataa_Maloom : Form
    {
        public Khataa_Maloom()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=TASAWAR-LAPTOP\\MSSQLSERVER01;Initial Catalog=Khataa;Integrated Security=True");
        string connStr = ConfigurationManager.ConnectionStrings["KhataaDB"].ConnectionString;
        public int Cid;
        public int Sid;

        int loan;
        int cid;
      
    

        void getnameid()
        {
            SqlCommand cmd = new SqlCommand("operations", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@query","getidbyname");
           // cmd.Parameters.AddWithValue("@name", nametxt.Text);
            conn.Open();    
          //  SqlDataReader sqlDataReader = cmd.ExecuteReader();
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            string id;
            if (sqlDataReader.Read())
            {
                id = sqlDataReader["Id"].ToString();
                MessageBox.Show(id);
                 conn.Close();
                int ID=int.Parse(id);
               // getbyid(ID);
                getall(ID);

            }
            conn.Close() ;

           
        }

        void getall(int id)
        {

            SqlCommand sqlCommand = new SqlCommand("operations", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@query", "getitem");
            sqlCommand.Parameters.AddWithValue("@id", id);
            conn.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                //gridBill.DataSource = dt;
                conn.Close();
            }
            else
            {
               // MessageBox.Show("Issue hy bahiyaa");
               // gridBill.DataSource =null;
            }
            conn.Close();
        }

        void get()
        {
            
        }


        

        private void Khataa_Maloom_Load(object sender, EventArgs e)
        {
            timer1.Start();
            date.Text = DateTime.Now.ToString("MM-dd:yyyy");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            sartjhaty sartjhaty = new sartjhaty();
            sartjhaty.Show();
        }

        int count = 0;
       



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text= DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void firstp_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void lastp_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void nametxt_TextChanged(object sender, EventArgs e)
        {
           
        }

        async Task gtbyid(int id, string mode)
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                await con.OpenAsync();
                using (SqlCommand sqlCommand = new SqlCommand("CustomerOp", con))
                {
                  
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@query", "searchbyid");
                    sqlCommand.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader sqlDataReader =await sqlCommand.ExecuteReaderAsync())
                    {
                          if(await  sqlDataReader.ReadAsync())
                        { 

                        if (mode == "otherform")
                        {
                            dropdown1.Text = sqlDataReader["Name"].ToString();
                     
                        }
                        idtxt.Text = sqlDataReader["Adress"].ToString();
                        cnictxt.Text = sqlDataReader["CNIC"].ToString();
                        cid = int.Parse(sqlDataReader["CustomerId"].ToString());
                        //if (rbill.Text == "")
                        //{
                        //  //  rbill.Text = "00";
                        //}
                        //else
                        //{

                        //    idtxt.Text = "";
                        //    cnictxt.Text = "";
                        
                        // } 

                    }
                    }
                }
            }       

        }
        void loadbalance()
        {


            SqlCommand command = new SqlCommand("sale", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@query", "pendingbalance");
            command.Parameters.AddWithValue("@id", cid);
            conn.Open();
            object result = command.ExecuteScalar();

            if (result != null)
            {
                loan = Convert.ToInt32(result);
                conn.Close();
              //  rbill.Text = loan.ToString();
            }



            else
            {
                conn.Close();
              //  rbill.Text = "00";

            }
            conn.Close();


        }


   
       async Task<DataTable> load_top()
        {
         DataTable
                Topproducts = new DataTable();

                using (SqlConnection con = new SqlConnection(connStr))
                {
                  await con.OpenAsync();  
                using (SqlCommand sqlCommand = new SqlCommand("Customerop",con))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@query", "TopSaleItems");
                    sqlCommand.Parameters.AddWithValue("@id", cid);

                    using (SqlDataReader read = await sqlCommand.ExecuteReaderAsync())
                    {
                        Topproducts.Load(read);
                    }
                }
                }
            return Topproducts; 
        }

        void displaytop(DataTable table) 
        {

            flowLayoutPanel2.Controls.Clear();
            flowLayoutPanel1.BackColor = Color.LightGray;
            panel2.SuspendLayout();
            foreach (DataRow row in table.Rows)
            {
                // 🔹 Main panel (product card)
                Panel card = new Panel();
                card.Width = 110;
                card.Height = 200;
                card.BorderStyle = BorderStyle.FixedSingle;
                card.Tag = row["ProductId"];

                // 🔹 Image
                PictureBox pic = new PictureBox();
                pic.Cursor = Cursors.Hand;
                pic.Tag = row; // pura row store
                               // pic.Click += Product_Click;
                pic.Width = 100;
                pic.Height = 90;
                pic.Top = 5;
                pic.Left = 5;
                pic.SizeMode = PictureBoxSizeMode.StretchImage;

                string path = Path.Combine(Application.StartupPath,
                                              row["ImagePath"].ToString());

                if (File.Exists(path))
                    using (var img = Image.FromFile(path))
                    {
                        pic.Image = new Bitmap(img, pic.Width, pic.Height);
                    }


                // 🔹 Name
                Label lblName = new Label();
                lblName.Text = row["Product_Name"].ToString();
                lblName.Top = 120;
                lblName.Width = 140;
                lblName.Font = new Font("Segoe UI", 10, FontStyle.Bold);

                // 🔹 Category


                // 🔹 quan
                Label lblquan = new Label();
                lblquan.Text = " " + row["Qty"] + "عدد ";
                lblquan.Top = 150;
                lblquan.Width = 140;
                lblquan.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                lblquan.ForeColor = Color.Green;

                // 🔹 price
                Label lblPrice = new Label();
                lblPrice.Text = "کل رقم " + row["Amount"];
                lblPrice.Top = 180;
                lblPrice.Width = 140;
                lblPrice.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                lblPrice.ForeColor = Color.Green;



                // Add to card
                card.Controls.Add(pic);
                card.Controls.Add(lblName);

                card.Controls.Add(lblquan);
                card.Controls.Add(lblPrice);


                // Add card to FlowLayoutPanel
                flowLayoutPanel2.Controls.Add(card);
            }
            panel2.SuspendLayout();
        }

  async      private void dropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropdown1.SelectedValue != null)
            {
                int selectedId;
                if (int.TryParse(dropdown1.SelectedValue.ToString(), out selectedId))
                {
                  await  gtbyid(selectedId,"ownform");

                    productsworker.RunWorkerAsync();
                }

               
            }
            else
            {

            }
        }
      
       async Task<DataTable>  LoadProducts( bool isfilter, string type, DateTime? data)
        {

            DataTable tb = new DataTable();
            using (SqlConnection con = new SqlConnection(connStr))
            {
                await con.OpenAsync();
                using (SqlCommand sqlCommand = new SqlCommand("Customerop", con))
                {
                    if (isfilter == false)
                    {

                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        if (type == "allsales")
                        {
                            sqlCommand.Parameters.AddWithValue("@query", "cproduct");
                        }
                        if (type == "salebyid")
                        {
                            sqlCommand.Parameters.AddWithValue("@query", "csproduct");
                            sqlCommand.Parameters.AddWithValue("@sid", Sid);
                        }
                        sqlCommand.Parameters.AddWithValue("@id", cid);

                        using (SqlDataReader read = await sqlCommand.ExecuteReaderAsync())
                        {
                            tb.Load(read);
                        }            
                    }
                   
                    else
                    {    
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@query", "searchbydate");
                        sqlCommand.Parameters.AddWithValue("@id", cid);
                        sqlCommand.Parameters.AddWithValue("@date", data);
                        using (SqlDataReader read = await sqlCommand.ExecuteReaderAsync())
                        {
                            tb.Load(read);
                        }
                    }
                }
                 
            }

            return tb;

        }
        void Displayproducts(DataTable productstable)
        {
            if (productstable.Rows.Count > 0)
            {
                flowLayoutPanel1.Controls.Clear();
                flowLayoutPanel1.BackColor = Color.LightGray;
                foreach (DataRow row in productstable.Rows)
                {
                    // 🔹 Main panel (product card)
                    Panel card = new Panel();
                    card.Width = 150;
                    card.Height = 250;
                    card.BorderStyle = BorderStyle.FixedSingle;
                    card.Tag = row["ProductId"];

                    // 🔹 Image
                    PictureBox pic = new PictureBox();
                    pic.Cursor = Cursors.Hand;
                    pic.Tag = row; // pura row store
                                   // pic.Click += Product_Click;
                    pic.Width = 120;
                    pic.Height = 110;
                    pic.Top = 5;
                    pic.Left = 5;
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;

                    string path = Path.Combine(Application.StartupPath,
                                                  row["ImagePath"].ToString());




                    if (File.Exists(path))
                        using (var img = Image.FromFile(path))
                        {
                            pic.Image = new Bitmap(img, pic.Width, pic.Height);
                        }
                    // 🔹 Name
                    Label lblName = new Label();
                    lblName.Text = row["Product_Name"].ToString();
                    lblName.Top = 120;
                    lblName.Width = 140;
                    lblName.Font = new Font("Segoe UI", 9, FontStyle.Bold);

                    // 🔹 Category


                    // 🔹 quan
                    Label lblquan = new Label();
                    lblquan.Text = "" + row["Qty"] + "تعداد";
                    lblquan.Top = 150;
                    lblquan.Width = 140;
                    lblquan.ForeColor = Color.Green;
                    lblquan.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    // 🔹 price
                    Label lblPrice = new Label();
                    lblPrice.Text = "کل رقم " + row["Amount"] + " روپے";
                    lblPrice.Top = 180;
                    lblPrice.Width = 140;
                    lblPrice.ForeColor = Color.Green;
                    lblPrice.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    // 🔹 Date
                    Label lbldate = new Label();
                    lbldate.Text = "" + row["Saledate"] + "";
                    lbldate.Top = 210;
                    lbldate.Width = 140;
                    lbldate.ForeColor = Color.Green;
                    lbldate.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                    // Add to card
                    card.Controls.Add(pic);
                    card.Controls.Add(lblName);

                    card.Controls.Add(lblquan);
                    card.Controls.Add(lblPrice);
                    card.Controls.Add(lbldate);

                    // Add card to FlowLayoutPanel
                    flowLayoutPanel1.Controls.Add(card);
                }
            }

            else
            {
                flowLayoutPanel1.Controls.Clear();
                Label message = new Label();
                message.Text = "Ajj Koi Sale ni hy";
                flowLayoutPanel1.Controls.Add(message);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void Khataa_Maloom_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Escape)
            {
                if (MessageBox.Show("Close form?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            if(e.KeyCode==Keys.Enter)
            {

            }
        }

     async   private void Khataa_Maloom_Shown(object sender, EventArgs e)
        {
            if (Cid != 0)
            {
                await gtbyid(Cid, "otherform");
                loadbalance();
                Displayproducts(await LoadProducts(false, "salebyid", DateTime.Now));
                displaytop(await load_top());
            }
          
            customerworker.RunWorkerAsync();


        }

        DataTable names;
        void displaynames()
        {
            if (names.Rows.Count > 0)
            {
                dropdown1.DataSource = names;
                dropdown1.DisplayMember = "Name"; // jo dikhega
                dropdown1.ValueMember = "CustomerId";     // actual DB value
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
        void getAllNames()
        {
            try
            {

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    using (SqlCommand sqlCommand = new SqlCommand("CustomerOp", conn))
                    {
                        names = new DataTable();
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@query", "get");
                        sqlCommand.Parameters.AddWithValue("@name", DBNull.Value);

                        conn.Open();

                        SqlDataAdapter sqlData = new SqlDataAdapter(sqlCommand);

                        sqlData.Fill(names);


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void productsworker_DoWork(object sender, DoWorkEventArgs e)
        {
            //LoadProducts(false, DateTime.Now, "allsales");
            //load_top();
        }

        private void productsworker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //Displayproducts();
            //displaytop();
        }

        private void customerworker_DoWork(object sender, DoWorkEventArgs e)
        {
            getAllNames();
        }

        private void customerworker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            displaynames();
        }
    }
}
