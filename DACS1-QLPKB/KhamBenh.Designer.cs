
namespace DACS1_QLPKB
{
    partial class KhamBenh
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
            this.buttonthemtoa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDdsbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDTbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trieuchung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BSkham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonreset1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonxoa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxchuandoan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxidbn = new System.Windows.Forms.TextBox();
            this.textBoxiddsbn = new System.Windows.Forms.TextBox();
            this.textBoxtenbn = new System.Windows.Forms.TextBox();
            this.textBoxsdt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxtrieuchung = new System.Windows.Forms.TextBox();
            this.textBoxbskham = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonthemtoa
            // 
            this.buttonthemtoa.BackColor = System.Drawing.Color.White;
            this.buttonthemtoa.Location = new System.Drawing.Point(28, 221);
            this.buttonthemtoa.Name = "buttonthemtoa";
            this.buttonthemtoa.Size = new System.Drawing.Size(125, 36);
            this.buttonthemtoa.TabIndex = 28;
            this.buttonthemtoa.Text = "Thêm Vào Toa";
            this.buttonthemtoa.UseVisualStyleBackColor = false;
            this.buttonthemtoa.Click += new System.EventHandler(this.buttonthemtoa_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.buttonreset1);
            this.groupBox2.Location = new System.Drawing.Point(358, 44);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(602, 272);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bệnh Nhân Chờ Khám";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDdsbn,
            this.IDbn,
            this.Tenbn,
            this.SDTbn,
            this.Trieuchung,
            this.BSkham});
            this.dataGridView1.Location = new System.Drawing.Point(11, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(586, 215);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // IDdsbn
            // 
            this.IDdsbn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDdsbn.DataPropertyName = "IDdsbn";
            this.IDdsbn.HeaderText = "ID DSBN";
            this.IDdsbn.Name = "IDdsbn";
            // 
            // IDbn
            // 
            this.IDbn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDbn.DataPropertyName = "IDbn";
            this.IDbn.HeaderText = "ID BN";
            this.IDbn.Name = "IDbn";
            // 
            // Tenbn
            // 
            this.Tenbn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tenbn.DataPropertyName = "Tenbn";
            this.Tenbn.HeaderText = "Tên BN";
            this.Tenbn.Name = "Tenbn";
            // 
            // SDTbn
            // 
            this.SDTbn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SDTbn.DataPropertyName = "SDTbn";
            this.SDTbn.HeaderText = "SĐT";
            this.SDTbn.Name = "SDTbn";
            // 
            // Trieuchung
            // 
            this.Trieuchung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Trieuchung.DataPropertyName = "Trieuchung";
            this.Trieuchung.HeaderText = "Triệu Chứng";
            this.Trieuchung.Name = "Trieuchung";
            // 
            // BSkham
            // 
            this.BSkham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BSkham.DataPropertyName = "BSkham";
            this.BSkham.HeaderText = "BS Khám";
            this.BSkham.Name = "BSkham";
            // 
            // buttonreset1
            // 
            this.buttonreset1.BackColor = System.Drawing.Color.White;
            this.buttonreset1.Location = new System.Drawing.Point(11, 15);
            this.buttonreset1.Name = "buttonreset1";
            this.buttonreset1.Size = new System.Drawing.Size(86, 30);
            this.buttonreset1.TabIndex = 28;
            this.buttonreset1.Text = "Reset";
            this.buttonreset1.UseVisualStyleBackColor = false;
            this.buttonreset1.Click += new System.EventHandler(this.buttonreset1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.buttonthemtoa);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.buttonxoa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxchuandoan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxidbn);
            this.groupBox1.Controls.Add(this.textBoxiddsbn);
            this.groupBox1.Controls.Add(this.textBoxtenbn);
            this.groupBox1.Controls.Add(this.textBoxsdt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBoxtrieuchung);
            this.groupBox1.Controls.Add(this.textBoxbskham);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(342, 272);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Bệnh Nhân";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(208, 37);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "ID BN:";
            // 
            // buttonxoa
            // 
            this.buttonxoa.BackColor = System.Drawing.Color.White;
            this.buttonxoa.Location = new System.Drawing.Point(191, 221);
            this.buttonxoa.Name = "buttonxoa";
            this.buttonxoa.Size = new System.Drawing.Size(125, 36);
            this.buttonxoa.TabIndex = 25;
            this.buttonxoa.Text = "Xóa";
            this.buttonxoa.UseVisualStyleBackColor = false;
            this.buttonxoa.Click += new System.EventHandler(this.buttonxoa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "ID DSBN:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 135);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Chuẩn Đoán:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 109);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Triệu Chứng:";
            // 
            // comboBoxchuandoan
            // 
            this.comboBoxchuandoan.FormattingEnabled = true;
            this.comboBoxchuandoan.Location = new System.Drawing.Point(117, 132);
            this.comboBoxchuandoan.Name = "comboBoxchuandoan";
            this.comboBoxchuandoan.Size = new System.Drawing.Size(200, 21);
            this.comboBoxchuandoan.TabIndex = 27;
            this.comboBoxchuandoan.SelectedIndexChanged += new System.EventHandler(this.comboBoxchuandoan_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "SDT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Họ Tên:";
            // 
            // textBoxidbn
            // 
            this.textBoxidbn.Location = new System.Drawing.Point(266, 34);
            this.textBoxidbn.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxidbn.Name = "textBoxidbn";
            this.textBoxidbn.ReadOnly = true;
            this.textBoxidbn.Size = new System.Drawing.Size(50, 20);
            this.textBoxidbn.TabIndex = 20;
            // 
            // textBoxiddsbn
            // 
            this.textBoxiddsbn.Location = new System.Drawing.Point(117, 34);
            this.textBoxiddsbn.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxiddsbn.Name = "textBoxiddsbn";
            this.textBoxiddsbn.ReadOnly = true;
            this.textBoxiddsbn.Size = new System.Drawing.Size(49, 20);
            this.textBoxiddsbn.TabIndex = 21;
            // 
            // textBoxtenbn
            // 
            this.textBoxtenbn.Location = new System.Drawing.Point(117, 58);
            this.textBoxtenbn.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxtenbn.Name = "textBoxtenbn";
            this.textBoxtenbn.Size = new System.Drawing.Size(199, 20);
            this.textBoxtenbn.TabIndex = 22;
            // 
            // textBoxsdt
            // 
            this.textBoxsdt.Location = new System.Drawing.Point(117, 82);
            this.textBoxsdt.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxsdt.Name = "textBoxsdt";
            this.textBoxsdt.Size = new System.Drawing.Size(199, 20);
            this.textBoxsdt.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 162);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "BS Khám:";
            // 
            // textBoxtrieuchung
            // 
            this.textBoxtrieuchung.Location = new System.Drawing.Point(116, 107);
            this.textBoxtrieuchung.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxtrieuchung.Name = "textBoxtrieuchung";
            this.textBoxtrieuchung.Size = new System.Drawing.Size(200, 20);
            this.textBoxtrieuchung.TabIndex = 24;
            // 
            // textBoxbskham
            // 
            this.textBoxbskham.Location = new System.Drawing.Point(116, 158);
            this.textBoxbskham.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxbskham.Name = "textBoxbskham";
            this.textBoxbskham.Size = new System.Drawing.Size(200, 20);
            this.textBoxbskham.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(442, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 21);
            this.label1.TabIndex = 32;
            this.label1.Text = "KHÁM BỆNH";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 191);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Ngày Khám:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/mm/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(117, 185);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // KhamBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 322);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "KhamBenh";
            this.Text = "Khám Bệnh";
            this.Load += new System.EventHandler(this.KhamBenh_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonthemtoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDdsbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDTbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trieuchung;
        private System.Windows.Forms.DataGridViewTextBoxColumn BSkham;
        private System.Windows.Forms.Button buttonreset1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonxoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxchuandoan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxidbn;
        private System.Windows.Forms.TextBox textBoxiddsbn;
        private System.Windows.Forms.TextBox textBoxtenbn;
        private System.Windows.Forms.TextBox textBoxsdt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxtrieuchung;
        private System.Windows.Forms.TextBox textBoxbskham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
    }
}