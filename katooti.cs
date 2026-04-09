using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DukaanKhataa
{
    public partial class katooti : Form
    {
        public katooti()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            doodhhisaab doodhhisaab = new doodhhisaab();
            doodhhisaab.Show();
        }
    }
}
