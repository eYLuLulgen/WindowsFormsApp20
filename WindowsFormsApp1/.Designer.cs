namespace WindowsFormsApp1
{
    partial class BaşvuruSayfası
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTT = new System.Windows.Forms.TextBox();
            this.txtKT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btCıkıs = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMNo = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbvade = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnD = new System.Windows.Forms.Button();
            this.btnIO = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(674, 15);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(112, 27);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "ARA";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(377, 15);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(130, 26);
            this.txtName.TabIndex = 2;
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(513, 15);
            this.textSurname.Name = "textSurname";
            this.textSurname.ReadOnly = true;
            this.textSurname.Size = new System.Drawing.Size(136, 26);
            this.textSurname.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Location = new System.Drawing.Point(0, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 125);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Başvurulacak Ürün";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(172, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 28);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Kredi Vadesi";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Taksit Tutarı";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Kredi Tutarı";
            // 
            // txtTT
            // 
            this.txtTT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTT.Location = new System.Drawing.Point(132, 81);
            this.txtTT.Name = "txtTT";
            this.txtTT.ReadOnly = true;
            this.txtTT.Size = new System.Drawing.Size(136, 26);
            this.txtTT.TabIndex = 9;
            this.txtTT.TextChanged += new System.EventHandler(this.txtTT_TextChanged);
            // 
            // txtKT
            // 
            this.txtKT.Location = new System.Drawing.Point(132, 13);
            this.txtKT.Name = "txtKT";
            this.txtKT.Size = new System.Drawing.Size(136, 26);
            this.txtKT.TabIndex = 7;
            this.txtKT.TextChanged += new System.EventHandler(this.txtKT_TextChanged);
            this.txtKT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKT_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Müşteri No";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btCıkıs
            // 
            this.btCıkıs.Location = new System.Drawing.Point(658, 573);
            this.btCıkıs.Name = "btCıkıs";
            this.btCıkıs.Size = new System.Drawing.Size(133, 41);
            this.btCıkıs.TabIndex = 12;
            this.btCıkıs.Text = "Çıkış";
            this.btCıkıs.UseVisualStyleBackColor = true;
            this.btCıkıs.Click += new System.EventHandler(this.btCıkıs_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(499, 573);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(133, 41);
            this.btClear.TabIndex = 11;
            this.btClear.Text = "Temizle";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(800, 346);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 573);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "Başvuru Onay";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ad/Soyad";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMNo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textSurname);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Location = new System.Drawing.Point(6, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 70);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtMNo
            // 
            this.txtMNo.Location = new System.Drawing.Point(123, 15);
            this.txtMNo.Name = "txtMNo";
            this.txtMNo.Size = new System.Drawing.Size(130, 26);
            this.txtMNo.TabIndex = 10;
            this.txtMNo.TextChanged += new System.EventHandler(this.txtMNo_TextChanged);
            this.txtMNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMNo_KeyPress_1);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cmbvade);
            this.panel4.Controls.Add(this.txtKT);
            this.panel4.Controls.Add(this.txtTT);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(401, 79);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(403, 125);
            this.panel4.TabIndex = 17;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // cmbvade
            // 
            this.cmbvade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbvade.FormattingEnabled = true;
            this.cmbvade.Location = new System.Drawing.Point(132, 47);
            this.cmbvade.Name = "cmbvade";
            this.cmbvade.Size = new System.Drawing.Size(136, 28);
            this.cmbvade.TabIndex = 17;
            this.cmbvade.SelectedIndexChanged += new System.EventHandler(this.cmbvade_SelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnD);
            this.panel5.Controls.Add(this.btnIO);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.btCıkıs);
            this.panel5.Controls.Add(this.btClear);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Location = new System.Drawing.Point(12, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(811, 626);
            this.panel5.TabIndex = 18;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint_1);
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(340, 573);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(133, 41);
            this.btnD.TabIndex = 11;
            this.btnD.Text = "Detay";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnIO
            // 
            this.btnIO.Location = new System.Drawing.Point(181, 573);
            this.btnIO.Name = "btnIO";
            this.btnIO.Size = new System.Drawing.Size(133, 41);
            this.btnIO.TabIndex = 18;
            this.btnIO.Text = "İkinci Onay";
            this.btnIO.UseVisualStyleBackColor = true;
            this.btnIO.Click += new System.EventHandler(this.btnIO_Click_1);
            // 
            // BaşvuruSayfası
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(832, 652);
            this.Controls.Add(this.panel5);
            this.Name = "BaşvuruSayfası";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTT;
        private System.Windows.Forms.TextBox txtKT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCıkıs;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtMNo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnIO;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.ComboBox cmbvade;
    }
}

