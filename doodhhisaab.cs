using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DukaanKhataa
{
    public partial class doodhhisaab : Form
    {
        public doodhhisaab()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=TASAWAR-LAPTOP\\MSSQLSERVER01;Initial Catalog=Khataa;Integrated Security=True");
        float price = 0f;
        float totalweight;
        float finalweight;
        float dharaabasket = 0f;

        void getmilkdetails()
        {
            try 
            { 
            SqlCommand sqlCommand = new SqlCommand("operations", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@query", "getmilk");
            //sqlCommand.Parameters.AddWithValue("@id", int.Parse(idtxt.Text.ToString()));
            //conn.Open();
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //while(sqlDataReader.Read())
            //    {
            //        nametxt.Text = sqlDataReader["Name"].ToString();
            //        doodhkilotxt.Text= sqlDataReader["Miqdaar"].ToString();
            //        raqamdoodhtxt.Text= sqlDataReader["Raqam"].ToString();
            //    }
                conn.Close();
            }
          
            catch { }
        }
        
        void insert()
        {

            try
            {
                string time = "";
                if(time== "شام کا دودھ")
                {
                    time = "Shaam";
                }
                else
                {
                    time = "Subhaa";
                }
                SqlCommand sqlCommand = new SqlCommand("operations", conn);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@query", "insertmilk");
            //    sqlCommand.Parameters.AddWithValue("@id", int.Parse(idtxt.Text.ToString()));
                sqlCommand.Parameters.AddWithValue("@waqt",time);
                sqlCommand.Parameters.AddWithValue("@quan", finalweight);
                sqlCommand.Parameters.AddWithValue("@price", price);
                conn.Open();
                sqlCommand.ExecuteNonQuery();
                conn.Close();
            }
            catch { }
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            katooti katooti = new katooti();
            katooti.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
   
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           // totalweight= float.Parse(textBox3.Text.ToString());
         
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        //    if(comboBox2.Text== "چھوٹی بالٹی")
        //    {
        //        dharaabasket=250;
              
        //        finalweight=totalweight-dharaabasket;
        //        if (finalweight <= 0)
        //        {
        //            MessageBox.Show("🤷‍ 🤷‍ 🤷‍ 🤷‍");
        //            return;
        //        }
        //        fwtxt.Text = finalweight.ToString();
        //        finalweight = finalweight / 1000f;
        //        price = finalweight * 200;
        //        doodhkilotxt.Text=finalweight.ToString();
        //        raqamdoodhtxt.Text=price.ToString();    

             


        //    }
        //    else if(comboBox2.Text== "بڑی بالٹی")
        //    {
        //        dharaabasket = 320;
        //        finalweight = totalweight - dharaabasket;
        //        if (finalweight <= 0)
        //        {
        //            MessageBox.Show("🤷‍ 🤷‍ 🤷‍ 🤷‍");
        //            return;
        //        }
        //        fwtxt.Text = finalweight.ToString();
        //        finalweight = finalweight / 1000f;
        //        price = finalweight * 200;
        //        MessageBox.Show(finalweight.ToString("0.000"));
        //    }
        //    else if(comboBox2.Text== "لوہے والی بالٹی")
        //    {
        //        dharaabasket = 1200;
        //        finalweight = totalweight - dharaabasket;
        //        if(finalweight<=0)
        //        {
        //            MessageBox.Show("🤷‍ 🤷‍ 🤷‍ 🤷‍");
        //            return;
        //        }
        //        price = finalweight * 200;
        //        fwtxt.Text = finalweight.ToString();
        //        finalweight = finalweight / 1000f;
        //        MessageBox.Show(finalweight.ToString("0.000"));
        //    }
        }

        private void doodhhisaab_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            getmilkdetails();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            insert();
        }

        private void doodhhisaab_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                string name = nametxt.Text;
                decimal qty= decimal.Parse(qtytxt.Text.ToString());
                decimal price = decimal.Parse(pricetxt.Text.ToString());
                decimal saleprice = decimal.Parse(salepricetxt.Text.ToString());
                decimal Cost = price * qty;

                decimal Sale = saleprice * qty;
                decimal Profit = Sale - Cost;

                    if(name !="" && qty !=0 && price!=0)
                    {
                        ProfitTable.Rows.Add(name, qty, price,Sale,Profit);
                 
                    decimal grandProfit = 0;
                    decimal grandinvestment = 0;

                    foreach (DataGridViewRow row in ProfitTable.Rows)
                    {
                        grandProfit += Convert.ToDecimal(row.Cells[4].Value); // Sale column
                        grandinvestment += Convert.ToDecimal(row.Cells[3].Value); // Sale column

                    }

                        investmentlbl.Text = grandinvestment.ToString();
                        totalprofitlbl.Text=grandProfit.ToString();
                    nametxt.Focus();

                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
            }
        }
    }
}
