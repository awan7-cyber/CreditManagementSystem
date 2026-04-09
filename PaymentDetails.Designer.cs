namespace DukaanKhataa
{
    partial class PaymentDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dropdown1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.time = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.paymenttbl = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2TileButton2 = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2TileButton3 = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2TileButton4 = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2TileButton5 = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2TileButton6 = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbill = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymenttbl)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dropdown1
            // 
            this.dropdown1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dropdown1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dropdown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropdown1.FormattingEnabled = true;
            this.dropdown1.Location = new System.Drawing.Point(922, 95);
            this.dropdown1.Name = "dropdown1";
            this.dropdown1.Size = new System.Drawing.Size(181, 28);
            this.dropdown1.TabIndex = 76;
            this.dropdown1.SelectedIndexChanged += new System.EventHandler(this.dropdown1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1109, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 46);
            this.label3.TabIndex = 75;
            this.label3.Text = "گاہک کا نام";
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
            this.panel2.TabIndex = 79;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.time.Location = new System.Drawing.Point(1124, 23);
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
            this.label1.Location = new System.Drawing.Point(524, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "کھاتے کی مکمل تفصیل";
            // 
            // paymenttbl
            // 
            this.paymenttbl.AllowUserToAddRows = false;
            this.paymenttbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.paymenttbl.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.paymenttbl.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.paymenttbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.paymenttbl.DefaultCellStyle = dataGridViewCellStyle6;
            this.paymenttbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paymenttbl.Location = new System.Drawing.Point(0, 271);
            this.paymenttbl.Name = "paymenttbl";
            this.paymenttbl.Size = new System.Drawing.Size(1267, 326);
            this.paymenttbl.TabIndex = 80;
            this.paymenttbl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.paymenttbl_CellContentClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.guna2TileButton2);
            this.flowLayoutPanel1.Controls.Add(this.guna2TileButton3);
            this.flowLayoutPanel1.Controls.Add(this.guna2TileButton4);
            this.flowLayoutPanel1.Controls.Add(this.guna2TileButton5);
            this.flowLayoutPanel1.Controls.Add(this.guna2TileButton6);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(56, 182);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(20);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1190, 66);
            this.flowLayoutPanel1.TabIndex = 83;
            // 
            // guna2TileButton2
            // 
            this.guna2TileButton2.Animated = true;
            this.guna2TileButton2.AutoRoundedCorners = true;
            this.guna2TileButton2.BorderRadius = 28;
            this.guna2TileButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2TileButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2TileButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2TileButton2.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 20F, System.Drawing.FontStyle.Bold);
            this.guna2TileButton2.ForeColor = System.Drawing.Color.White;
            this.guna2TileButton2.IndicateFocus = true;
            this.guna2TileButton2.Location = new System.Drawing.Point(935, 3);
            this.guna2TileButton2.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.guna2TileButton2.Name = "guna2TileButton2";
            this.guna2TileButton2.Size = new System.Drawing.Size(202, 58);
            this.guna2TileButton2.TabIndex = 87;
            this.guna2TileButton2.Text = "گزشتہ 7 دن";
            this.guna2TileButton2.Click += new System.EventHandler(this.guna2TileButton2_Click);
            // 
            // guna2TileButton3
            // 
            this.guna2TileButton3.Animated = true;
            this.guna2TileButton3.AutoRoundedCorners = true;
            this.guna2TileButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2TileButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2TileButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2TileButton3.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 20F, System.Drawing.FontStyle.Bold);
            this.guna2TileButton3.ForeColor = System.Drawing.Color.White;
            this.guna2TileButton3.IndicateFocus = true;
            this.guna2TileButton3.Location = new System.Drawing.Point(710, 3);
            this.guna2TileButton3.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.guna2TileButton3.Name = "guna2TileButton3";
            this.guna2TileButton3.Size = new System.Drawing.Size(202, 58);
            this.guna2TileButton3.TabIndex = 88;
            this.guna2TileButton3.Text = "گزشتہ 15 دن";
            this.guna2TileButton3.Click += new System.EventHandler(this.guna2TileButton3_Click);
            // 
            // guna2TileButton4
            // 
            this.guna2TileButton4.Animated = true;
            this.guna2TileButton4.AutoRoundedCorners = true;
            this.guna2TileButton4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2TileButton4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2TileButton4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2TileButton4.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 20F, System.Drawing.FontStyle.Bold);
            this.guna2TileButton4.ForeColor = System.Drawing.Color.White;
            this.guna2TileButton4.IndicateFocus = true;
            this.guna2TileButton4.Location = new System.Drawing.Point(485, 3);
            this.guna2TileButton4.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.guna2TileButton4.Name = "guna2TileButton4";
            this.guna2TileButton4.Size = new System.Drawing.Size(202, 58);
            this.guna2TileButton4.TabIndex = 89;
            this.guna2TileButton4.Text = "گزشتہ 1 مہینہ";
            this.guna2TileButton4.Click += new System.EventHandler(this.guna2TileButton4_Click);
            // 
            // guna2TileButton5
            // 
            this.guna2TileButton5.Animated = true;
            this.guna2TileButton5.AutoRoundedCorners = true;
            this.guna2TileButton5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2TileButton5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2TileButton5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2TileButton5.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 20F, System.Drawing.FontStyle.Bold);
            this.guna2TileButton5.ForeColor = System.Drawing.Color.White;
            this.guna2TileButton5.IndicateFocus = true;
            this.guna2TileButton5.Location = new System.Drawing.Point(260, 3);
            this.guna2TileButton5.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.guna2TileButton5.Name = "guna2TileButton5";
            this.guna2TileButton5.Size = new System.Drawing.Size(202, 58);
            this.guna2TileButton5.TabIndex = 90;
            this.guna2TileButton5.Text = "گزشتہ 3 مہینہ";
            this.guna2TileButton5.Click += new System.EventHandler(this.guna2TileButton5_Click);
            // 
            // guna2TileButton6
            // 
            this.guna2TileButton6.Animated = true;
            this.guna2TileButton6.AutoRoundedCorners = true;
            this.guna2TileButton6.BorderRadius = 28;
            this.guna2TileButton6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2TileButton6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2TileButton6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2TileButton6.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 20F, System.Drawing.FontStyle.Bold);
            this.guna2TileButton6.ForeColor = System.Drawing.Color.White;
            this.guna2TileButton6.IndicateFocus = true;
            this.guna2TileButton6.Location = new System.Drawing.Point(35, 3);
            this.guna2TileButton6.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.guna2TileButton6.Name = "guna2TileButton6";
            this.guna2TileButton6.Size = new System.Drawing.Size(202, 58);
            this.guna2TileButton6.TabIndex = 91;
            this.guna2TileButton6.Text = "گزشتہ 6 مہینہ";
            this.guna2TileButton6.Click += new System.EventHandler(this.guna2TileButton6_Click);
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderRadius = 14;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "Sale",
            "Payment"});
            this.guna2ComboBox1.Location = new System.Drawing.Point(510, 91);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(113, 36);
            this.guna2ComboBox1.TabIndex = 84;
            this.guna2ComboBox1.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(629, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 46);
            this.label2.TabIndex = 85;
            this.label2.Text = "قسم منتخب کریں";
            // 
            // rbill
            // 
            this.rbill.AutoSize = true;
            this.rbill.BackColor = System.Drawing.Color.Black;
            this.rbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbill.ForeColor = System.Drawing.Color.White;
            this.rbill.Location = new System.Drawing.Point(59, 85);
            this.rbill.Name = "rbill";
            this.rbill.Size = new System.Drawing.Size(35, 37);
            this.rbill.TabIndex = 87;
            this.rbill.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Jameel Noori Nastaleeq", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(213, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 58);
            this.label6.TabIndex = 86;
            this.label6.Text = "پچھلا اُدھار";
            // 
            // PaymentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 597);
            this.Controls.Add(this.rbill);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.paymenttbl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dropdown1);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.KeyPreview = true;
            this.Name = "PaymentDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentDetails";
            this.Load += new System.EventHandler(this.PaymentDetails_Load);
            this.Shown += new System.EventHandler(this.PaymentDetails_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PaymentDetails_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PaymentDetails_KeyPress);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paymenttbl)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox dropdown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView paymenttbl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton2;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton3;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton4;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton5;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label rbill;
        private System.Windows.Forms.Label label6;
    }
}