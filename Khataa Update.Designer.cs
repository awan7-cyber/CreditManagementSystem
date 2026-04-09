namespace DukaanKhataa
{
    partial class Khataa_Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Khataa_Update));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.time = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbill = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gridBill = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cnictxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dropdown1 = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbill = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.paidtxt = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pendingtxt = new MetroFramework.Controls.MetroTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.loader = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.nameloader = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBill)).BeginInit();
            this.loader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.time);
            this.panel2.Controls.Add(this.Date);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1319, 66);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1255, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.time.Location = new System.Drawing.Point(1093, 20);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(18, 26);
            this.time.TabIndex = 46;
            this.time.Text = ".";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Date.Location = new System.Drawing.Point(110, 20);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(18, 26);
            this.Date.TabIndex = 45;
            this.Date.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(512, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "کھاتے میں اضافہ کریں  ";
            // 
            // rbill
            // 
            this.rbill.AutoSize = true;
            this.rbill.BackColor = System.Drawing.Color.Transparent;
            this.rbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbill.ForeColor = System.Drawing.Color.Black;
            this.rbill.Location = new System.Drawing.Point(609, 136);
            this.rbill.Name = "rbill";
            this.rbill.Size = new System.Drawing.Size(26, 29);
            this.rbill.TabIndex = 33;
            this.rbill.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(667, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 46);
            this.label6.TabIndex = 32;
            this.label6.Text = "پچھلا اُدھار";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // gridBill
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridBill.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridBill.Location = new System.Drawing.Point(0, 216);
            this.gridBill.MultiSelect = false;
            this.gridBill.Name = "gridBill";
            this.gridBill.ReadOnly = true;
            this.gridBill.Size = new System.Drawing.Size(848, 387);
            this.gridBill.TabIndex = 49;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(0, 187);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1319, 10);
            this.panel3.TabIndex = 35;
            // 
            // idtxt
            // 
            this.idtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtxt.Location = new System.Drawing.Point(584, 93);
            this.idtxt.Multiline = true;
            this.idtxt.Name = "idtxt";
            this.idtxt.ReadOnly = true;
            this.idtxt.Size = new System.Drawing.Size(156, 29);
            this.idtxt.TabIndex = 1;
            this.idtxt.TextChanged += new System.EventHandler(this.idtxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(746, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 46);
            this.label2.TabIndex = 50;
            this.label2.Text = "گاہک کا آئی ڈی";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cnictxt
            // 
            this.cnictxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnictxt.Location = new System.Drawing.Point(35, 88);
            this.cnictxt.Multiline = true;
            this.cnictxt.Name = "cnictxt";
            this.cnictxt.ReadOnly = true;
            this.cnictxt.Size = new System.Drawing.Size(186, 29);
            this.cnictxt.TabIndex = 2;
            this.cnictxt.TextChanged += new System.EventHandler(this.cnictxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(227, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 46);
            this.label4.TabIndex = 52;
            this.label4.Text = "گاہک کا شناختی کارڈ نمبر";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1216, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 46);
            this.label3.TabIndex = 54;
            this.label3.Text = "گاہک کا نام";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dropdown1
            // 
            this.dropdown1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dropdown1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dropdown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropdown1.FormattingEnabled = true;
            this.dropdown1.Location = new System.Drawing.Point(1029, 94);
            this.dropdown1.Name = "dropdown1";
            this.dropdown1.Size = new System.Drawing.Size(181, 28);
            this.dropdown1.TabIndex = 9;
            this.dropdown1.SelectedIndexChanged += new System.EventHandler(this.dropdown1_SelectedIndexChanged);
            this.dropdown1.TextChanged += new System.EventHandler(this.dropdown1_TextChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(880, 276);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(436, 438);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.flowLayoutPanel1_Scroll);
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // tbill
            // 
            this.tbill.AutoSize = true;
            this.tbill.BackColor = System.Drawing.Color.Black;
            this.tbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbill.ForeColor = System.Drawing.Color.White;
            this.tbill.Location = new System.Drawing.Point(693, 407);
            this.tbill.Name = "tbill";
            this.tbill.Size = new System.Drawing.Size(29, 31);
            this.tbill.TabIndex = 62;
            this.tbill.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Black;
            this.label13.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(773, 399);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 46);
            this.label13.TabIndex = 61;
            this.label13.Text = "کل بل";
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnsave.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(12, 664);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(176, 50);
            this.btnsave.TabIndex = 6;
            this.btnsave.Text = "محفوظ کریں";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // paidtxt
            // 
            this.paidtxt.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.paidtxt.Location = new System.Drawing.Point(338, 629);
            this.paidtxt.Name = "paidtxt";
            this.paidtxt.Size = new System.Drawing.Size(129, 30);
            this.paidtxt.TabIndex = 4;
            this.paidtxt.TextChanged += new System.EventHandler(this.paidtxt_TextChanged);
            this.paidtxt.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(487, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 46);
            this.label5.TabIndex = 64;
            this.label5.Text = "ادا شدہ رقم";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(174, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 46);
            this.label7.TabIndex = 66;
            this.label7.Text = "باقی رقم";
            // 
            // pendingtxt
            // 
            this.pendingtxt.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.pendingtxt.Location = new System.Drawing.Point(35, 412);
            this.pendingtxt.Name = "pendingtxt";
            this.pendingtxt.Size = new System.Drawing.Size(129, 30);
            this.pendingtxt.TabIndex = 5;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox1.Location = new System.Drawing.Point(880, 217);
            this.metroTextBox1.Multiline = true;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PromptText = "\"مصنوعات کا نام / کوڈ درج کریں\"";
            this.metroTextBox1.Size = new System.Drawing.Size(427, 33);
            this.metroTextBox1.TabIndex = 67;
            this.metroTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // loader
            // 
            this.loader.Controls.Add(this.label8);
            this.loader.Controls.Add(this.label7);
            this.loader.Controls.Add(this.label5);
            this.loader.Controls.Add(this.label13);
            this.loader.Controls.Add(this.tbill);
            this.loader.Controls.Add(this.pendingtxt);
            this.loader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loader.Location = new System.Drawing.Point(0, 216);
            this.loader.Name = "loader";
            this.loader.Size = new System.Drawing.Size(1319, 501);
            this.loader.TabIndex = 68;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(596, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(220, 44);
            this.label8.TabIndex = 0;
            this.label8.Text = "Loading......";
            // 
            // nameloader
            // 
            this.nameloader.Location = new System.Drawing.Point(1029, 94);
            this.nameloader.Multiline = true;
            this.nameloader.Name = "nameloader";
            this.nameloader.Size = new System.Drawing.Size(181, 28);
            this.nameloader.TabIndex = 69;
            this.nameloader.Visible = false;
            // 
            // Khataa_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 717);
            this.Controls.Add(this.nameloader);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.paidtxt);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dropdown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cnictxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.gridBill);
            this.Controls.Add(this.rbill);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.loader);
            this.KeyPreview = true;
            this.Name = "Khataa_Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khataa_Update";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Khataa_Update_Load);
            this.Shown += new System.EventHandler(this.Khataa_Update_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Khataa_Update_KeyDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBill)).EndInit();
            this.loader.ResumeLayout(false);
            this.loader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label rbill;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.DataGridView gridBill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cnictxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox dropdown1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label tbill;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnsave;
        private MetroFramework.Controls.MetroTextBox paidtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroTextBox pendingtxt;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Panel loader;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nameloader;
    }
}