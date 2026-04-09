using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace DukaanKhataa
{
    public partial class Khataa_Update : Form
    {
        public Khataa_Update()
        {
            InitializeComponent();
        }

        int cid;
        int sid;
        int loan = 0;
        int grandTotal = 0;
        string status;
        string connStr = ConfigurationManager.ConnectionStrings["KhataaDB"].ConnectionString;
        DataTable names;
        SqlConnection conn = new SqlConnection("Data Source=TASAWAR-LAPTOP\\MSSQLSERVER01;Initial Catalog=Khataa;Integrated Security=True");
        Dictionary<string, Image> imageCache = new Dictionary<string, Image>();

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        

        


       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //if(idtxt.Text!="")
            //{

            //    generatesale();

            //    if (dropdown1.SelectedValue != null)
            //    {
            //        int selectedId;
            //        if (int.TryParse(dropdown1.SelectedValue.ToString(), out selectedId))
            //        {
            //            getbyid(selectedId); // Safe fetch
            //        }
            //    }     
               
            //}
            //else
            //{
            //    MessageBox.Show("Please select customer");
            //}
          
        }                                                                                                                            
        private  void Khataa_Update_Load(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToString("MM-dd-yyyy");
            timer1.Start();
            SetupBillGrid();
            gridBill.CellClick += gridBill_CellClick;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         
          
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void pnametxt_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void idtxt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void pnametxt_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pnametxt_Enter(object sender, EventArgs e)
        {
            
        }

        private void nametxt_TextChanged(object sender, EventArgs e)
        {

            //try
            //{
            //    if (nametxt.Text != "")
            //    {
            //        getnameid();
            //    }
            //}
            //catch { }
        }

        private void dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dropdown_TextChanged(object sender, EventArgs e)
        {
           // displaynames();
        }

        private void dropdown1_TextChanged(object sender, EventArgs e)
        {
            if (dropdown1.Text == "")
            {
                idtxt.Text = "";
                rbill.Text = "00";
                cnictxt.Text = "";
            }
        }

        async  private void dropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropdown1.SelectedValue != null) 
            {
                int selectedId;
                if (int.TryParse(dropdown1.SelectedValue.ToString(), out selectedId))
                {
                    getbyid(selectedId);
                    var data = await loadbalance();
                    displaybalance(data);
                }
               // SetupBillGrid();
            }
            else 
            {
                return;
                
            }
        }


        void  LoadProducts(DataTable dt)
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.BackColor = Color.LightGray;

            panel3.SuspendLayout();

            foreach (DataRow row in dt.Rows)
            {
                // 🔹 Card Panel
                Panel card = new Panel();
                card.Width = 130;
                card.Height = 200;
                card.BorderStyle = BorderStyle.FixedSingle;
                card.Tag = row["ProductId"];

                // 🔹 Picture
                PictureBox pic = new PictureBox();
                pic.Cursor = Cursors.Hand;
                pic.Tag = row;
                pic.Click += Product_Click;
                pic.Width = 120;
                pic.Height = 110;
                pic.Top = 5;
                pic.Left = 5;
                pic.SizeMode = PictureBoxSizeMode.StretchImage;

                // 🔥 Placeholder image (smooth feel)
                 // apni loading image add kar lena

                string imgPath = Path.Combine(Application.StartupPath,
                                              row["ImagePath"].ToString());

                // 🔥 Background image loading (NO await → parallel load)
                _ = Task.Run(() =>
                {
                    Image img = null;

                    // ✅ Cache check
                    if (imageCache.ContainsKey(imgPath))
                    {
                        img = imageCache[imgPath];
                    }
                    else
                    {
                        if (File.Exists(imgPath))
                        {
                            using (var temp = Image.FromFile(imgPath))
                            {
                                img = new Bitmap(temp, 120, 110);
                            }

                            imageCache[imgPath] = img; // 🔥 cache me save
                        }
                    }

                    if (img != null && pic.IsHandleCreated)
                    {
                        pic.Invoke(new Action(() =>
                        {
                            pic.Image = img;
                        }));
                    }
                });


                // 🔹 Name
                Label lblName = new Label();
                lblName.Text = row["Product_Name"].ToString();
                lblName.Top = 120;
                lblName.Width = 130;
                lblName.Font = new Font("Segoe UI", 9, FontStyle.Bold);

                // 🔹 Price
                Label lblPrice = new Label();
                lblPrice.Text = "قیمت: " + row["Price"] + " روپے";
                lblPrice.Top = 160;
                lblPrice.Width = 130;

                // 🔹 Add controls
                card.Controls.Add(pic);
                card.Controls.Add(lblName);
                card.Controls.Add(lblPrice);

                flowLayoutPanel1.Controls.Add(card);
            }

            panel3.ResumeLayout();
        }



        void GetProducs() 
        {

            DataTable   dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT ProductId,Product_Name, Price,Stock ,ImagePath FROM Products", con);
                da.Fill(dt);
            }

           
        }


        async  Task <DataTable> GetProducts()
        {

         DataTable   dt = new DataTable();

            using (SqlConnection pconn = new SqlConnection(connStr))
            {
               await pconn.OpenAsync();
                using (SqlCommand cmd = new SqlCommand("SELECT ProductId,Product_Name, Price,Stock ,ImagePath FROM Products",pconn))
                {
                    using (SqlDataReader read = await cmd.ExecuteReaderAsync())
                    {

                        await Task.Run(() =>
                        {
                            dt.Load(read); // 🔥 ab background thread pe
                        });
                    }

                }
            }
            return dt;
           

        }

        void getbyid(int id)
        {

            try
            {
                if (cid == id)
                {
                    return;
                }
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


        void displaynames(DataTable result)
        {
            if (result.Rows.Count > 0)
            {
                // 🔹 Add default item at the END
                DataRow defaultRow = result.NewRow();
                defaultRow["Name"] = "Select Customer";
                defaultRow["CustomerId"] = 0;
                result.Rows.Add(defaultRow); // add at end

                dropdown1.DataSource = result;
                dropdown1.DisplayMember = "Name";
                dropdown1.ValueMember = "CustomerId";
                dropdown1.DropDownStyle = ComboBoxStyle.DropDown;
                dropdown1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                dropdown1.AutoCompleteSource = AutoCompleteSource.ListItems;

                // 🔹 Focus last item
                dropdown1.SelectedIndex = result.Rows.Count - 1;
            }
            else
            {
                dropdown1.DataSource = null;
                MessageBox.Show("No data found");
            }
        }


        async Task <DataTable> getAllNames()
        {
           
                DataTable data = new DataTable();
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    await conn.OpenAsync();
                    using (SqlCommand sqlCommand = new SqlCommand("CustomerOp", conn))
                    {
                        
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@query", "get");
                        sqlCommand.Parameters.AddWithValue("@name", DBNull.Value);
                        using (SqlDataReader sqlData = await sqlCommand.ExecuteReaderAsync())
                        {
                            await Task.Run(() => { data.Load(sqlData); }); 
                        }    

                    }
                }

                return data;
            }
           
        
       
       //async  void loadbalance()
       // {
       //     int balance;
       //     using (SqlConnection sqlConnection = new SqlConnection(connStr))
       //     {
       //         using (SqlCommand command = new SqlCommand("sale", conn))
       //         {
       //             command.CommandType = CommandType.StoredProcedure;
       //             command.Parameters.AddWithValue("@query", "pendingbalance");
       //             command.Parameters.AddWithValue("@id", cid);
       //             await conn.OpenAsync();
       //             object result =await command.ExecuteScalarAsync();
       //             balance = int.Parse(result.ToString());
       //         }
       //         if (balance != 0)
       //         {                  
       //             rbill.Text = balance.ToString();
       //         }
       //         else
       //         {
       //             rbill.Text = "00";
       //         }
       //     }
       // }

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

                    if (result != null && result != DBNull.Value)
                    {
                        balance = Convert.ToInt32(result);  
                    }
                    else
                    {
                        balance = 0; 
                    }


                }
            }
            return balance;
        }

        void displaybalance(int balance)
        {
            if (balance >= 0)
            {
                rbill.Text = balance.ToString();
            }
            else
            {
                rbill.Text = "00";
            }
        }


        void Product_Click(object sender, EventArgs e)
        {
            if(cnictxt.Text!="")
            {

            
            PictureBox pic = sender as PictureBox;
            DataRow row = pic.Tag as DataRow;

            int id = Convert.ToInt32(row["ProductId"]);
            string name = row["Product_Name"].ToString();
            decimal price = Convert.ToDecimal(row["Price"]);

            // 🔁 check: product already bill me hai?
            foreach (DataGridViewRow r in gridBill.Rows)
            {
                if (Convert.ToInt32(r.Cells["Id"].Value) == id)
                {
                    int qty = Convert.ToInt32(r.Cells["Qty"].Value);
                    qty++;

                    r.Cells["Qty"].Value = qty;
                    r.Cells["Total"].Value = qty * price;
                    UpdateTotal();
                    return;
                }
               
            }

            // 🆕 new product add
            gridBill.Rows.Add(
                id,
                name,
                price,
                1,
                price
            );

            UpdateTotal();
            }

            else
            {
                MessageBox.Show("Please Select Your Customer");
            }
        }

        int Grandtotal()
        {
            grandTotal = 0;
            foreach (DataGridViewRow r in gridBill.Rows)
            {
                if (r.IsNewRow) continue;

                int qty = Convert.ToInt32(r.Cells["Qty"].Value);
                int price = Convert.ToInt32(r.Cells["Price"].Value);

                grandTotal += qty * price; // add each product total
                
            }
            return grandTotal;
        }

      

        void updatestock(int productid, int quantity)
        {
            SqlCommand update = new SqlCommand("Products",conn);
            update.CommandType = CommandType.StoredProcedure;
            update.Parameters.AddWithValue("@query", "updatestock");
            update.Parameters.AddWithValue("@id", productid);
            update.Parameters.AddWithValue("@qty", quantity);
        }

            void generatesale(string stat)
            {
            int setzero = 0;
            int pending;
            int paid;

            if (pendingtxt.Text == "")
            {
                pending = int.Parse(tbill.Text.ToString());
                status = "Pending";
            }
            else 
            {
                int.TryParse(pendingtxt.Text, out pending);
            }
                //calculate all total from gridview
            int tamount = Grandtotal();
            int uid;
            conn.Close();
            
                conn.Open();  // Open once

            //insert into Invoice table  and then give its saleid to SaleItems Table

            if (stat == "partial")
            {
                int pamount = int.Parse(paidtxt.Text.ToString());
                SqlCommand sqlCommand = new SqlCommand("paymentop", conn);
                sqlCommand.CommandType= CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@query", "insertpayment");
                sqlCommand.Parameters.AddWithValue("@cid", cid);
                sqlCommand.Parameters.AddWithValue("@paidamount", pamount);
                sqlCommand.ExecuteNonQuery();
               
            }


                SqlCommand cmd = new SqlCommand("sale", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@query", "mainsale");
                cmd.Parameters.AddWithValue("@customerid", cid);
                cmd.Parameters.AddWithValue("@total", tamount);
                cmd.Parameters.AddWithValue("@pending", pending);
                 int.TryParse(paidtxt.Text.Trim(), out pending);
                cmd.Parameters.AddWithValue("@paid", pending);
                cmd.Parameters.AddWithValue("@status", status);
              
               //saleid comes from procedure  
                sid = Convert.ToInt32(cmd.ExecuteScalar()); 
       
                foreach (DataGridViewRow r in gridBill.Rows)
                    {

                // adds individual row of datagridview in db table
                //collecting data from datagridview columns 
                    int pid = Convert.ToInt32(r.Cells["Id"].Value);
                    int qty = Convert.ToInt32(r.Cells["Qty"].Value);
                    int price = Convert.ToInt32(r.Cells["Price"].Value);
                    int total = qty * price;

                if (pid > 0)
                {
                    //adding the saleitems into saledetails table
                    SqlCommand sql = new SqlCommand("sale", conn);
                    sql.CommandType = CommandType.StoredProcedure;
                    sql.Parameters.AddWithValue("@query", "addsaleitems");
                    sql.Parameters.AddWithValue("@sid", sid);
                    sql.Parameters.AddWithValue("@productid", pid);
                    sql.Parameters.AddWithValue("@quan", price);
                    sql.Parameters.AddWithValue("@price", qty);
                    sql.Parameters.AddWithValue("@total", total);     
                    sql.ExecuteNonQuery();
                    sql.Parameters.Clear();

                    updatestock(pid, qty);
                }
                else { gridBill.Columns.Clear();

                    MessageBox.Show("Added Successfully");
                    SetupBillGrid();
                    tbill.Text = "0";
                }
                // Clear params for next iteration
                }
           // sqlCommand.ExecuteNonQuery();
            conn.Close(); 
            
                // Close once
            }

        
        void generateudhaar()
        {
            
        }

        void UpdateTotal()
        {
            grandTotal = 0;

            foreach (DataGridViewRow row in gridBill.Rows)
            {
                if (row.IsNewRow) continue;

                int total = Convert.ToInt32(row.Cells["Total"].Value);
                grandTotal += total;
              
            }

            tbill.Text = grandTotal.ToString();
        }


        void SetupBillGrid()
        {
            gridBill.Columns.Clear();


            // Columns add

            gridBill.Font = new Font("Jameel Noori Nastaleeq", 15, FontStyle.Bold);
            gridBill.Columns.Add("Id", "Id");
            gridBill.Columns.Add("Name", "نام");
            gridBill.Columns.Add("Price", "قیمت");
            gridBill.Columns.Add("Qty", "تعداد");
            gridBill.Columns.Add("Total", "کل رقم");

            // ➕ PLUS button
            DataGridViewButtonColumn btnPlus = new DataGridViewButtonColumn();
            btnPlus.Name = "Plus";
            btnPlus.HeaderText = "+";
            btnPlus.Text = "+";
            btnPlus.UseColumnTextForButtonValue = true;

            // ➖ MINUS button
            DataGridViewButtonColumn btnMinus = new DataGridViewButtonColumn();
            btnMinus.Name = "Minus";
            btnMinus.HeaderText = "-";
            btnMinus.Text = "-";
            btnMinus.UseColumnTextForButtonValue = true;
            gridBill.Columns.Add(btnPlus);
            gridBill.Columns.Add(btnMinus);

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.Name = "Delete";
            btnDelete.HeaderText = "X";
            btnDelete.Text = "X";
            btnDelete.UseColumnTextForButtonValue = true;

            gridBill.Columns.Add(btnDelete);

        }


        private void gridBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            

            var row = gridBill.Rows[e.RowIndex];

            int qty = Convert.ToInt32(row.Cells["Qty"].Value);
            int price = Convert.ToInt32(row.Cells["Price"].Value);

            // ➕
            if (gridBill.Columns[e.ColumnIndex].Name == "Plus")
            {
                qty++;
            }

            // ➖
            if (gridBill.Columns[e.ColumnIndex].Name == "Minus")
            {
                if (qty > 1)
                    qty--;
            }

            row.Cells["Qty"].Value = qty;
            row.Cells["Total"].Value = qty * price;

            if (gridBill.Columns[e.ColumnIndex].Name == "Delete")
            {
                gridBill.Rows.RemoveAt(e.RowIndex);
                UpdateTotal();
            }


            UpdateTotal();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cnictxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            Payment form1 = new Payment();
            form1.Show();
        }

        private async void  button2_Click_1(object sender, EventArgs e)
        {
            if (idtxt.Text != "")
            {
                if (paidtxt.Text!="") 
                {
                    generatesale("partial");
                }
                else
                {
                    generatesale("all");
                }

                if (dropdown1.SelectedValue != null)
                {
                    var data = await loadbalance();
                    displaybalance(data);
                }

            }
            else
            {
                MessageBox.Show("Please select customer");
            }
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            
           
        }

        private void paidtxt_TextChanged(object sender, EventArgs e)
        {
            if (paidtxt.Text.Length > 1)
            {
                var totalbill = int.Parse(tbill.Text.ToString());
                var paidamount = int.Parse(paidtxt.Text.ToString());
                int pending;
                if (paidamount < totalbill)
                {
                    pending = totalbill - paidamount;
                    pendingtxt.Text = pending.ToString();
                    status = "Partial Payment";

                }

                else if (paidamount == totalbill)
                {
                    pending = 0;
                    pendingtxt.Text = pending.ToString();
                    status = "Cleared";
                }

                else
                {
                    MessageBox.Show("Apna Andraaj Drust akreem");
                }
            }
        }

        private void Khataa_Update_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Escape)
            {
                if (MessageBox.Show("Close form?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            if (e.KeyCode == Keys.Enter) 
            {
                if(gridBill.Rows.Count>1)
                {
                    if (MessageBox.Show("Generate Sale?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        btnsave.PerformClick();
                    }
                }
             
                
            }
        }

        private async void Khataa_Update_Shown(object sender, EventArgs e)
        {
            loader.BringToFront();
            
            var namess = await getAllNames();
            displaynames(namess);
            
            var data=   await GetProducts();
            LoadProducts(data);
            loader.SendToBack();
            nameloader.Visible=true;
            nameloader.SendToBack();
           
           
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            
          // GetProducts();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
           
          //  LoadProducts();
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
         //   getAllNames();
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
           // displaynames();
        }

        private void flowLayoutPanel1_Scroll(object sender, ScrollEventArgs e)
        {
           // LoadVisibleImages();
        }
        //void LoadVisibleImages()
        //{
        //    foreach (Control ctrl in flowLayoutPanel1.Controls)
        //    {
        //        Panel card = ctrl as Panel;
        //        if (card == null) continue;

        //        // check visible area
        //        if (card.Bounds.IntersectsWith(flowLayoutPanel1.ClientRectangle))
        //        {
        //            PictureBox pic = card.Controls.OfType<PictureBox>().FirstOrDefault();
        //            if (pic != null )
        //            {
        //                DataRow row = pic.Tag as DataRow;

        //                string imgPath = Path.Combine(Application.StartupPath,
        //                                              row["ImagePath"].ToString());

        //                LoadImageAsync(pic, imgPath);
        //            }
        //        }
        //    }
        //}
        //void LoadImageAsync(PictureBox pic, string imgPath)
        //{
        //    _ = Task.Run(() =>
        //    {
        //        Image img = null;

        //        if (imageCache.ContainsKey(imgPath))
        //        {
        //            img = imageCache[imgPath];
        //        }
        //        else if (File.Exists(imgPath))
        //        {
        //            using (var temp = Image.FromFile(imgPath))
        //            {
        //                img = new Bitmap(temp, 120, 110);
        //            }

        //            imageCache[imgPath] = img;
        //        }

        //        if (img != null && pic.IsHandleCreated)
        //        {
        //            pic.Invoke(new Action(() =>
        //            {
        //                pic.Image = img;
        //            }));
        //        }
        //    });
        //}

    }
}
