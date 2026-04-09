using Guna.UI2.WinForms;
using MetroFramework.Forms;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=TASAWAR-LAPTOP\\MSSQLSERVER01;Initial Catalog=Khataa;Integrated Security=True");
        string data="";

        public int Cid;
        int todaywassool;
        int customers;
        int balance;
        int udhaar;
        int total;
        string st;

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {}

        private void panel5_Paint(object sender, PaintEventArgs e)
        {


        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        { }

        int todaywasool()
        {
         int todaywassol;
            DateTime start = DateTime.Today;
            DateTime end = start.AddDays(1);

            SqlCommand sqlCommand = new SqlCommand("paymentop", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@query", "todaypayments");
            sqlCommand.Parameters.AddWithValue("@sdate", start);
            sqlCommand.Parameters.AddWithValue("edate", end);
            conn.Open();
            object resut = sqlCommand.ExecuteScalar();
            todaywassol = resut != null && resut != DBNull.Value? Convert.ToInt32(resut) : 0;

          // zz todayrecievetxt.Text=todaywassol.ToString();
            conn.Close();
            return todaywassol; 
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void label3_Click(object sender, EventArgs e)
        {}

        private void panel3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Piasy_Wasool piasy_Wasool = new Piasy_Wasool();
            piasy_Wasool.FormClosed += (s, args) => this.Show();
            piasy_Wasool.Show();
           
        }

        private void panel4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Khataa_Update khataa_Update = new Khataa_Update();
            khataa_Update.FormClosed += (s, args)=>this.Show();
            khataa_Update.Show();

        }
        private void panel5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            NayaKhataa nayaKhataa = new NayaKhataa();
            nayaKhataa.FormClosed += (s, args) => this.Show();
            nayaKhataa.Show();
        }
        private void panel6_Click(object sender, EventArgs e)
        {

        }


        int loadtodayudhaar()
        {

            DateTime startdate= DateTime.Today;   
            DateTime enddate=startdate.AddDays(1);

            int todayudhaar;
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("sale", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@query", "todaycredit");
            sqlCommand.Parameters.AddWithValue("@sdate", startdate);
            sqlCommand.Parameters.AddWithValue("@edate", enddate);
            object reult = sqlCommand.ExecuteScalar();
            todayudhaar = reult != null && reult != DBNull.Value ? Convert.ToInt32(reult) : 0;

            //ajjtxt.Text = todayudhaar.ToString();
            conn.Close();
            return todayudhaar;
        }
        int loadbalance()
        {
            int value;
            SqlCommand sqlCommand = new SqlCommand("sale", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@query", "allpending");
            conn.Open();
            object reult = sqlCommand.ExecuteScalar();
            value = reult != null && reult != DBNull.Value ? Convert.ToInt32(reult) : 0;

           // rbill.Text = value.ToString();

            conn.Close();
            return value;   
        }

        void showloaders() 
        {
            l1.Visible = true;
            l2.Visible = true;
            l3.Visible = true;
            l4.Visible = true;      
        }
        void hideloaders() 
        
        {
            l1.Visible = false; 

            l2.Visible= false;  
            l3.Visible= false;  
            l4.Visible= false;  
        }
        int customer()
        {
            int value;
            SqlCommand sqlCommand = new SqlCommand("Customerop", conn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@query", "allc");
            conn.Open();
            object reult = sqlCommand.ExecuteScalar();
            value = reult != null && reult != DBNull.Value ? Convert.ToInt32(reult) : 0;

          //  totalk.Text = value.ToString();

            conn.Close();
            return value;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
            //guna2WinProgressIndicator1.Visible = true;
            //MessageBox.Show("Hello");
            timer1.Interval = 1000;
            timer1.Start();
            datetxt.Text= DateTime.Now.ToString("dd/MM/yyyy");
           
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
           
          
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timetxt.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void khataamaloom_Paint(object sender, PaintEventArgs e)
        {
             
        }

        private void khataamaloom_Click(object sender, EventArgs e)
        {
            this.Hide();
            sartjhaty sartjhaty = new sartjhaty();
            sartjhaty.FormClosed += (s, args) => this.Show();
            sartjhaty.Show();
        }

        private void statusbox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {
           
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {
        // 
        }

        private void panel3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Payment payment = new Payment();
            payment.FormClosed += (s, args) => this.Show();
            payment.mode = "payment";
            payment.Show();
       
        } 

        private void panel5_Click(object sender, EventArgs e)
        {
            
            data = "udhaar";
            this.Hide();
            Payment payment = new Payment();
            payment.mode = data;
            payment.FormClosed += (s, args) => this.Show();
            payment.Show();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N) { shiftpages("nayakhataa");}
            else if (e.Control && e.KeyCode == Keys.U) { shiftpages("khataaupdate"); }
            else if (e.Control && e.KeyCode == Keys.M) { shiftpages("maloomaat"); }
            else if (e.Control && e.KeyCode == Keys.P) { shiftpages("paisywasool"); }
          //  else if (e.Control && e.KeyCode == Keys.D) { shiftpages("aajkaudhaar"); }
           // else if (e.Control && e.KeyCode == Keys.W) { shiftpages("aajkewasooli"); }
            //else if (e.Control && e.KeyCode == Keys.V) { shiftpages("allproducts"); }
            e.SuppressKeyPress = true;
            e.Handled = true;
        }

        void shiftpages(string pagename)
        {
            if (pagename == "nayakhataa")
            {
                NayaKhataa nayaKhataa =new NayaKhataa();
                nayaKhataa.ShowDialog();
                backgroundWorker2.RunWorkerAsync();
            }
            else if (pagename == "khataaupdate")
            {
                Khataa_Update khataa_Update = new Khataa_Update();
                khataa_Update.ShowDialog();
                backgroundWorker2.RunWorkerAsync();
            }
            else if (pagename == "paisywasool")
            {
                Piasy_Wasool khataa_Update = new Piasy_Wasool();  
                khataa_Update.ShowDialog();
                backgroundWorker2.RunWorkerAsync(); 
            }
            else if (pagename == "maloomaat")
            {
                sartjhaty khataa_Update = new sartjhaty();  
                khataa_Update.ShowDialog();
                backgroundWorker2.RunWorkerAsync(); 
            }
            else if (pagename == "aajkaudhaar")
            {             
                Payment khataa_Update = new Payment();
                khataa_Update.mode = "payment";               
                khataa_Update.ShowDialog();
                backgroundWorker2.RunWorkerAsync(); 
            }
            else if (pagename == "aajkewasooli")
            {
                Payment khataa_Update = new Payment();
                khataa_Update.mode = "udhaar";
                khataa_Update.ShowDialog();
                backgroundWorker2.RunWorkerAsync();
            }
            else if (pagename == "allproducts")
            {
                PaymentDetails _Maloom = new PaymentDetails();        
                _Maloom.ShowDialog();
                backgroundWorker2.RunWorkerAsync();
            }
            
        }

       
        private void Form1_Shown(object sender, EventArgs e)
        {
            showloaders(); 
            backgroundWorker2.RunWorkerAsync();
             
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
          
            udhaar =loadtodayudhaar();
            balance=  loadbalance();
            customers= customer();
            todaywassool=   todaywasool();
         
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            totalk.Text = customers.ToString();
            ajjtxt.Text=udhaar.ToString();
            todayrecievetxt.Text = todaywassool.ToString();
            rbill.Text = balance.ToString();
            hideloaders();
        }

        private void guna2Chip1_Click(object sender, EventArgs e)
        {
            this.Close();
            doodhhisaab doodhhisaab = new doodhhisaab();
            doodhhisaab.Show();
        }
    }
}
