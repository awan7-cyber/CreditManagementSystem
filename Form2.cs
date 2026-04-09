using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace DukaanKhataa
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           guna2CircleProgressBar2.ProgressStartCap = 0;
            // timer1.Start();
          //  metroProgressSpinner1.Visible = true;
        }
         private  int sec = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            timer1.Interval = 1000;
           
            if(sec>=5)
            {
                timer1.Stop();
               // metroProgressSpinner1.Visible=false;
                 
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
               

            sec++;
        }
    }
}
