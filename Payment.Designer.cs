namespace DukaanKhataa
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainheadlbl = new System.Windows.Forms.Label();
            this.todaytbl = new System.Windows.Forms.DataGridView();
            this.allbtn = new System.Windows.Forms.Button();
            this.todaybtn = new System.Windows.Forms.Button();
            this.headlbl = new System.Windows.Forms.Label();
            this.detailstbl = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.todaytbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailstbl)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.mainheadlbl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1235, 66);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1168, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // mainheadlbl
            // 
            this.mainheadlbl.AutoSize = true;
            this.mainheadlbl.BackColor = System.Drawing.Color.Transparent;
            this.mainheadlbl.Font = new System.Drawing.Font("Cambria", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainheadlbl.ForeColor = System.Drawing.Color.White;
            this.mainheadlbl.Location = new System.Drawing.Point(437, 7);
            this.mainheadlbl.Name = "mainheadlbl";
            this.mainheadlbl.Size = new System.Drawing.Size(364, 47);
            this.mainheadlbl.TabIndex = 0;
            this.mainheadlbl.Text = "ادائیگیوں کا حساب کتاب";
            // 
            // todaytbl
            // 
            this.todaytbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.todaytbl.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.todaytbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.todaytbl.DefaultCellStyle = dataGridViewCellStyle1;
            this.todaytbl.Location = new System.Drawing.Point(0, 290);
            this.todaytbl.Name = "todaytbl";
            this.todaytbl.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.todaytbl.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.todaytbl.Size = new System.Drawing.Size(644, 321);
            this.todaytbl.TabIndex = 2;
            this.todaytbl.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.todaytbl_CellClick);
            this.todaytbl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.todaytbl_CellContentClick);
            // 
            // allbtn
            // 
            this.allbtn.BackColor = System.Drawing.Color.Olive;
            this.allbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allbtn.ForeColor = System.Drawing.Color.White;
            this.allbtn.Location = new System.Drawing.Point(509, 173);
            this.allbtn.Name = "allbtn";
            this.allbtn.Size = new System.Drawing.Size(251, 53);
            this.allbtn.TabIndex = 60;
            this.allbtn.Text = "پچھلی ادائیگی";
            this.allbtn.UseVisualStyleBackColor = false;
            this.allbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // todaybtn
            // 
            this.todaybtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.todaybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todaybtn.ForeColor = System.Drawing.Color.White;
            this.todaybtn.Location = new System.Drawing.Point(509, 90);
            this.todaybtn.Name = "todaybtn";
            this.todaybtn.Size = new System.Drawing.Size(251, 53);
            this.todaybtn.TabIndex = 63;
            this.todaybtn.Text = "آج کی ادائیگی";
            this.todaybtn.UseVisualStyleBackColor = false;
            this.todaybtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // headlbl
            // 
            this.headlbl.AutoSize = true;
            this.headlbl.BackColor = System.Drawing.Color.Transparent;
            this.headlbl.Font = new System.Drawing.Font("Cambria", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headlbl.ForeColor = System.Drawing.Color.Black;
            this.headlbl.Location = new System.Drawing.Point(453, 233);
            this.headlbl.Name = "headlbl";
            this.headlbl.Size = new System.Drawing.Size(26, 41);
            this.headlbl.TabIndex = 64;
            this.headlbl.Text = ".";
            // 
            // detailstbl
            // 
            this.detailstbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.detailstbl.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.detailstbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.detailstbl.DefaultCellStyle = dataGridViewCellStyle3;
            this.detailstbl.Location = new System.Drawing.Point(644, 290);
            this.detailstbl.Name = "detailstbl";
            this.detailstbl.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.detailstbl.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.detailstbl.Size = new System.Drawing.Size(591, 321);
            this.detailstbl.TabIndex = 65;
            this.detailstbl.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.detailstbl_CellContentClick);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 611);
            this.Controls.Add(this.detailstbl);
            this.Controls.Add(this.headlbl);
            this.Controls.Add(this.todaybtn);
            this.Controls.Add(this.allbtn);
            this.Controls.Add(this.todaytbl);
            this.Controls.Add(this.panel2);
            this.KeyPreview = true;
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Payment_KeyDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.todaytbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailstbl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label mainheadlbl;
        private System.Windows.Forms.DataGridView todaytbl;
        private System.Windows.Forms.Button allbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button todaybtn;
        private System.Windows.Forms.Label headlbl;
        private System.Windows.Forms.DataGridView detailstbl;
    }
}