namespace DukaanKhataa
{
    partial class Khataa_Maloom
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
            this.date = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dropdown1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.productsworker = new System.ComponentModel.BackgroundWorker();
            this.customerworker = new System.ComponentModel.BackgroundWorker();
            this.cnictxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.firstp = new System.Windows.Forms.DateTimePicker();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.time);
            this.panel2.Controls.Add(this.date);
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
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.time.Location = new System.Drawing.Point(1109, 22);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(15, 24);
            this.time.TabIndex = 41;
            this.time.Text = ".";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.date.Location = new System.Drawing.Point(60, 19);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(15, 24);
            this.date.TabIndex = 40;
            this.date.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(517, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "کھاتوں کی معلومات";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(-3, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1301, 10);
            this.panel1.TabIndex = 35;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(424, 218);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(843, 43);
            this.textBox1.TabIndex = 52;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(15, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(370, 60);
            this.button1.TabIndex = 53;
            this.button1.Text = "زیادہ فروخت ہونے والی اشیاء";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dropdown1
            // 
            this.dropdown1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dropdown1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dropdown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropdown1.FormattingEnabled = true;
            this.dropdown1.Location = new System.Drawing.Point(969, 94);
            this.dropdown1.Name = "dropdown1";
            this.dropdown1.Size = new System.Drawing.Size(181, 28);
            this.dropdown1.TabIndex = 62;
            this.dropdown1.SelectedIndexChanged += new System.EventHandler(this.dropdown1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1156, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 41);
            this.label3.TabIndex = 61;
            this.label3.Text = "گاہک کا نام";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(15, 284);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(370, 311);
            this.flowLayoutPanel2.TabIndex = 63;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(401, 212);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 535);
            this.panel3.TabIndex = 64;
            // 
            // productsworker
            // 
            this.productsworker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.productsworker_DoWork);
            this.productsworker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.productsworker_RunWorkerCompleted);
            // 
            // customerworker
            // 
            this.customerworker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.customerworker_DoWork);
            this.customerworker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.customerworker_RunWorkerCompleted);
            // 
            // cnictxt
            // 
            this.cnictxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnictxt.Location = new System.Drawing.Point(42, 93);
            this.cnictxt.Multiline = true;
            this.cnictxt.Name = "cnictxt";
            this.cnictxt.ReadOnly = true;
            this.cnictxt.Size = new System.Drawing.Size(186, 29);
            this.cnictxt.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(234, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 46);
            this.label7.TabIndex = 70;
            this.label7.Text = "گاہک کا شناختی کارڈ نمبر";
            // 
            // idtxt
            // 
            this.idtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtxt.Location = new System.Drawing.Point(552, 92);
            this.idtxt.Multiline = true;
            this.idtxt.Name = "idtxt";
            this.idtxt.ReadOnly = true;
            this.idtxt.Size = new System.Drawing.Size(156, 29);
            this.idtxt.TabIndex = 65;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(727, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 46);
            this.label8.TabIndex = 69;
            this.label8.Text = "گاہک کا آئی ڈی";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.flowLayoutPanel1);
            this.panel4.Location = new System.Drawing.Point(424, 274);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(841, 318);
            this.panel4.TabIndex = 71;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(841, 318);
            this.flowLayoutPanel1.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(727, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 46);
            this.label5.TabIndex = 41;
            this.label5.Text = "آغازِ خریداری";
            // 
            // firstp
            // 
            this.firstp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.firstp.Location = new System.Drawing.Point(570, 152);
            this.firstp.Name = "firstp";
            this.firstp.Size = new System.Drawing.Size(151, 29);
            this.firstp.TabIndex = 46;
            this.firstp.ValueChanged += new System.EventHandler(this.firstp_ValueChanged);
            // 
            // Khataa_Maloom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 597);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.cnictxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.dropdown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.firstp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.KeyPreview = true;
            this.Name = "Khataa_Maloom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khataa_Maloom";
            this.Load += new System.EventHandler(this.Khataa_Maloom_Load);
            this.Shown += new System.EventHandler(this.Khataa_Maloom_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Khataa_Maloom_KeyDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox dropdown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.ComponentModel.BackgroundWorker productsworker;
        private System.ComponentModel.BackgroundWorker customerworker;
        private System.Windows.Forms.TextBox cnictxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker firstp;
    }
}