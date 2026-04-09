using DukaanKhataa.Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.ModelBinding;
using System.Windows.Forms;
using Tesseract;

namespace DukaanKhataa
{
    public partial class BottelCalculator : Form
    {
        List<Calculator> calculatorList = new List<Calculator>();
        public BottelCalculator()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if(Costbottletxt.Text !="" && salepricetxt.Text!="")
            {
                calculateBottelCost();
                CalculateBottelProfit();
            }
        }

        private void BottelCalculator_Load(object sender, EventArgs e)
        {
            calcbtn.Font = new Font("Jameel Noori Nastaleeq", 12);
        }

      
            int getquantity()
            {
                int qty = 0;

             
                if (int.TryParse(Qtytxt.Text, out qty))
                {
                    string size = Sizetxt.Text;

                if (qty > 0 && bottlenametxt.Text!= "7 Up" && Unittxt.Text != "1/2 Liter")
                {
                    return qty * 6;
                }
                else if (qty>0 && Unittxt.Text== "1/2 Liter")
                {
                    return qty * 12;
                }
                else if (qty > 0 && Unittxt.Text == "2 Liter")
                {
                    return qty * 12;
                }
                else
                {
                    return qty;
                }
                }

                
                return 0;
            }



        decimal calculateBottelCost()
        {
            int qty = getquantity();

            if (qty > 0)
            {
               
                decimal totalcost = 0;
                decimal.TryParse(PurchasePricetxt.Text, out totalcost);

                if (totalcost > 0)
                {
                    decimal bottleCost = totalcost / qty;
                    Costbottletxt.Text = bottleCost.ToString("0.00");
                    return bottleCost;
                }
            }

            // Agar qty <= 0 ya totalcost invalid ho
            Costbottletxt.Text = "0";
            return 0;
        }




        decimal CalculateBottelProfit()
        {
            decimal salePrice = 0;

            // Safe parse sale price
            if (decimal.TryParse(salepricetxt.Text, out salePrice) && salePrice > 0)
            {
                decimal cost = calculateBottelCost(); // Ye function already safe hai
                decimal bottleProfit = salePrice - cost;
                bottelprofittxt.Text = bottleProfit.ToString("0.00");
                return bottleProfit;
            }

            // Agar sale price invalid ho ya <=0
            bottelprofittxt.Text = "0";
            return 0;
        }


         void freeboxes()
        {
            bottelprofittxt.Text = "";
            bottlenametxt.Text= "";
            bottlequantxt.Text = "";
            Costbottletxt.Text = "";
            PurchasePricetxt.Text = "";
            Qtytxt.Text= "";
            salepricetxt.Text = "";
            Unittxt.Text = "";
            bottlenametxt.Focus();  

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if(bottlenametxt.Text!="" && bottlequantxt.Text!="" && PurchasePricetxt.Text!="" && salepricetxt.Text!="")
            { 

            List<Calculator> calculators;
            Calculator calculator = new Calculator();
            calculator.Name = bottlenametxt.Text;
            calculator.Unit = Unittxt.Text;
            calculator.Size = Sizetxt.Text;

            calculator.BottleCost = calculateBottelCost();
            calculator.BottleProfit = CalculateBottelProfit();
            calculator.Stock = getquantity();
            calculator.TotalProfit = calculator.BottleProfit * calculator.Stock;

            calculator.TotalCost = int.Parse(PurchasePricetxt.Text.ToString());
            calculator.SalePrice = decimal.Parse(salepricetxt.Text.ToString());
            calculatorList.Add(calculator);

            tbldata.DataSource = null;
            tbldata.DataSource = calculatorList;
            tbldata.Columns["BottleCost"].DefaultCellStyle.Format = "0.00";
            tbldata.Columns["BottleProfit"].DefaultCellStyle.Format = "0.00";
            tbldata.Columns["TotalProfit"].DefaultCellStyle.Format = "0.00";
            freeboxes();

            }
            else
            {
                MessageBox.Show("Plesae Fill all Fields");
            }
        }

        private void PurchasePricetxt_TextChanged(object sender, EventArgs e)
        {
            calculateBottelCost();
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void salepricetxt_TextChanged(object sender, EventArgs e)
        {
            CalculateBottelProfit();
        }

        private void Sizetxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            int qty = getquantity();
            bottlequantxt.Text = qty.ToString();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            calculateBottelCost() ;
        }

        decimal Grandinvestment;
        decimal GrandProfit;
        void GrandCalculation()
        {
            Grandinvestment = 0;
            GrandProfit = 0;
            foreach (DataGridViewRow dataGridView in tbldata.Rows)
            {
               decimal totalinvestment = Convert.ToDecimal(dataGridView.Cells[4].Value);
                decimal totalprofit = Convert.ToDecimal(dataGridView.Cells[8].Value);

                Grandinvestment += totalinvestment;
                GrandProfit += totalprofit;
            }
            tcostlbl.Text=Grandinvestment.ToString();
            tproflbl.Text=GrandProfit.ToString("0.00");
        }
        private void BottelCalculator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                e.Handled=true; 
                e.SuppressKeyPress=true;    
                calcbtn.PerformClick();
                GrandCalculation();     
            }
            if (e.KeyCode == Keys.N)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                tbldata.DataSource = null;
                Grandinvestment = 0;
                GrandProfit = 0;    
                tcostlbl.Text="00";
                tproflbl.Text = "";
                calculatorList.Clear();
            }
        }

        private void Qtytxt_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Qtytxt_Leave(object sender, EventArgs e)
        {
            int qty = getquantity();
            bottlequantxt.Text = qty.ToString();
        }
        private string imagePath = "";

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
           
        }
      

    private void btnScan_Click(object sender, EventArgs e)
    {
       
    }

        private void btnSelectImage_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files|*.txt;*.png;*.jpg";
            if(openFile.ShowDialog()==DialogResult.OK)
            {
                imagePath=openFile.FileName;  
                //pictureBox1.Image=Image.FromFile(imagePath);
            }
        }

        private void btnScan_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (TesseractEngine engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default))
                {
                    using (var img = Pix.LoadFromFile(imagePath))
                    {
                        using (var page = engine.Process(img))
                        {
                            string text = page.GetText();
                           // txtResult.Text = text;
                            string[] lines = text.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                           

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
