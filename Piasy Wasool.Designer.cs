namespace DukaanKhataa
{
    partial class Piasy_Wasool
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.time = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dropdown1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cnictxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbill = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.wasool = new MetroFramework.Controls.MetroTextBox();
            this.invoicetbl = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoicetbl)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.time);
            this.panel2.Controls.Add(this.Date);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1267, 66);
            this.panel2.TabIndex = 1;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.time.Location = new System.Drawing.Point(1083, 23);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(18, 26);
            this.time.TabIndex = 51;
            this.time.Text = ".";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Date.Location = new System.Drawing.Point(51, 23);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(18, 26);
            this.Date.TabIndex = 50;
            this.Date.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(547, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "پیسوں کی وصولگی";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1319, 10);
            this.panel1.TabIndex = 43;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(103, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 64);
            this.button1.TabIndex = 48;
            this.button1.Text = "وصول کریں";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dropdown1
            // 
            this.dropdown1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dropdown1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dropdown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropdown1.FormattingEnabled = true;
            this.dropdown1.Location = new System.Drawing.Point(984, 90);
            this.dropdown1.Name = "dropdown1";
            this.dropdown1.Size = new System.Drawing.Size(181, 28);
            this.dropdown1.TabIndex = 68;
            this.dropdown1.SelectedIndexChanged += new System.EventHandler(this.dropdown1_SelectedIndexChanged);
            this.dropdown1.SelectedValueChanged += new System.EventHandler(this.dropdown1_SelectedValueChanged);
            this.dropdown1.CursorChanged += new System.EventHandler(this.dropdown1_CursorChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1171, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 46);
            this.label3.TabIndex = 67;
            this.label3.Text = "گاہک کا نام";
            // 
            // cnictxt
            // 
            this.cnictxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnictxt.Location = new System.Drawing.Point(12, 82);
            this.cnictxt.Multiline = true;
            this.cnictxt.Name = "cnictxt";
            this.cnictxt.ReadOnly = true;
            this.cnictxt.Size = new System.Drawing.Size(186, 29);
            this.cnictxt.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(204, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 46);
            this.label4.TabIndex = 66;
            this.label4.Text = "گاہک کا شناختی کارڈ نمبر";
            // 
            // idtxt
            // 
            this.idtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtxt.Location = new System.Drawing.Point(528, 85);
            this.idtxt.Multiline = true;
            this.idtxt.Name = "idtxt";
            this.idtxt.ReadOnly = true;
            this.idtxt.Size = new System.Drawing.Size(156, 29);
            this.idtxt.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(690, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 46);
            this.label2.TabIndex = 65;
            this.label2.Text = "گاہک کا آئی ڈی";
            // 
            // rbill
            // 
            this.rbill.AutoSize = true;
            this.rbill.BackColor = System.Drawing.Color.Black;
            this.rbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbill.ForeColor = System.Drawing.Color.White;
            this.rbill.Location = new System.Drawing.Point(535, 140);
            this.rbill.Name = "rbill";
            this.rbill.Size = new System.Drawing.Size(26, 29);
            this.rbill.TabIndex = 70;
            this.rbill.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(590, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 59);
            this.label6.TabIndex = 69;
            this.label6.Text = "پچھلا اُدھار";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(285, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 46);
            this.label8.TabIndex = 46;
            this.label8.Text = "وصول شدہ رقم";
            // 
            // wasool
            // 
            this.wasool.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.wasool.Location = new System.Drawing.Point(66, 348);
            this.wasool.Name = "wasool";
            this.wasool.Size = new System.Drawing.Size(190, 29);
            this.wasool.TabIndex = 73;
            this.wasool.Click += new System.EventHandler(this.wasool_Click);
            // 
            // invoicetbl
            // 
            this.invoicetbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.invoicetbl.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.invoicetbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoicetbl.Location = new System.Drawing.Point(422, 221);
            this.invoicetbl.Name = "invoicetbl";
            this.invoicetbl.Size = new System.Drawing.Size(840, 372);
            this.invoicetbl.TabIndex = 74;
            // 
            // Piasy_Wasool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 597);
            this.Controls.Add(this.invoicetbl);
            this.Controls.Add(this.wasool);
            this.Controls.Add(this.rbill);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dropdown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cnictxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.KeyPreview = true;
            this.Name = "Piasy_Wasool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Piasy_Wasool";
            this.Load += new System.EventHandler(this.Piasy_Wasool_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Piasy_Wasool_KeyDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoicetbl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox dropdown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cnictxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label rbill;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroTextBox wasool;
        private System.Windows.Forms.DataGridView invoicetbl;
    }
}