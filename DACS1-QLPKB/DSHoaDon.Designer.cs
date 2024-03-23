
namespace DACS1_QLPKB
{
    partial class DSHoaDon
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Tenthuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxloaitim = new System.Windows.Forms.ComboBox();
            this.buttonreset = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ngaykham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDhd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDtoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDTbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BSkham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxbskham = new System.Windows.Forms.TextBox();
            this.textBoxtongtien = new System.Windows.Forms.TextBox();
            this.buttonchitiethd = new System.Windows.Forms.Button();
            this.buttonxoa = new System.Windows.Forms.Button();
            this.textBoxsdt = new System.Windows.Forms.TextBox();
            this.textBoxtenbn = new System.Windows.Forms.TextBox();
            this.textBoxidtoa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxidhd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxtimkiem = new System.Windows.Forms.TextBox();
            this.buttontimkiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxngayk = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Location = new System.Drawing.Point(571, 396);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(824, 253);
            this.groupBox3.TabIndex = 52;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi Tiết Thuốc";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tenthuoc,
            this.Soluong});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(4, 19);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(816, 230);
            this.dataGridView2.TabIndex = 0;
            // 
            // Tenthuoc
            // 
            this.Tenthuoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tenthuoc.DataPropertyName = "Tenthuoc";
            this.Tenthuoc.HeaderText = "Tên Thuốc";
            this.Tenthuoc.MinimumWidth = 6;
            this.Tenthuoc.Name = "Tenthuoc";
            // 
            // Soluong
            // 
            this.Soluong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Soluong.DataPropertyName = "Soluong";
            this.Soluong.HeaderText = "Số Lượng";
            this.Soluong.MinimumWidth = 6;
            this.Soluong.Name = "Soluong";
            // 
            // comboBoxloaitim
            // 
            this.comboBoxloaitim.FormattingEnabled = true;
            this.comboBoxloaitim.Location = new System.Drawing.Point(289, 61);
            this.comboBoxloaitim.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxloaitim.Name = "comboBoxloaitim";
            this.comboBoxloaitim.Size = new System.Drawing.Size(126, 24);
            this.comboBoxloaitim.TabIndex = 51;
            this.comboBoxloaitim.SelectedIndexChanged += new System.EventHandler(this.comboBoxloaitim_SelectedIndexChanged);
            // 
            // buttonreset
            // 
            this.buttonreset.BackColor = System.Drawing.Color.White;
            this.buttonreset.Location = new System.Drawing.Point(961, 71);
            this.buttonreset.Margin = new System.Windows.Forms.Padding(4);
            this.buttonreset.Name = "buttonreset";
            this.buttonreset.Size = new System.Drawing.Size(109, 42);
            this.buttonreset.TabIndex = 50;
            this.buttonreset.Text = "Reset";
            this.buttonreset.UseVisualStyleBackColor = false;
            this.buttonreset.Click += new System.EventHandler(this.buttonreset_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(13, 119);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1378, 271);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Hóa Đơn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ngaykham,
            this.IDhd,
            this.IDtoa,
            this.Tenbn,
            this.SDTbn,
            this.BSkham,
            this.Tongtien});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1372, 252);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Ngaykham
            // 
            this.Ngaykham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ngaykham.DataPropertyName = "Ngaykham";
            this.Ngaykham.HeaderText = "Ngày Khám";
            this.Ngaykham.MinimumWidth = 6;
            this.Ngaykham.Name = "Ngaykham";
            // 
            // IDhd
            // 
            this.IDhd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDhd.DataPropertyName = "IDhd";
            this.IDhd.HeaderText = "ID HĐ";
            this.IDhd.MinimumWidth = 6;
            this.IDhd.Name = "IDhd";
            // 
            // IDtoa
            // 
            this.IDtoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDtoa.DataPropertyName = "IDtoa";
            this.IDtoa.HeaderText = "ID Toa";
            this.IDtoa.MinimumWidth = 6;
            this.IDtoa.Name = "IDtoa";
            // 
            // Tenbn
            // 
            this.Tenbn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tenbn.DataPropertyName = "Tenbn";
            this.Tenbn.HeaderText = "Tên BN";
            this.Tenbn.MinimumWidth = 6;
            this.Tenbn.Name = "Tenbn";
            // 
            // SDTbn
            // 
            this.SDTbn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SDTbn.DataPropertyName = "SDTbn";
            this.SDTbn.HeaderText = "SĐT";
            this.SDTbn.MinimumWidth = 6;
            this.SDTbn.Name = "SDTbn";
            // 
            // BSkham
            // 
            this.BSkham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BSkham.DataPropertyName = "BSkham";
            this.BSkham.HeaderText = "BS Khám";
            this.BSkham.MinimumWidth = 6;
            this.BSkham.Name = "BSkham";
            // 
            // Tongtien
            // 
            this.Tongtien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tongtien.DataPropertyName = "Tongtien";
            this.Tongtien.HeaderText = "Tổng Tiền";
            this.Tongtien.MinimumWidth = 6;
            this.Tongtien.Name = "Tongtien";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBoxbskham);
            this.groupBox1.Controls.Add(this.textBoxngayk);
            this.groupBox1.Controls.Add(this.textBoxtongtien);
            this.groupBox1.Controls.Add(this.buttonchitiethd);
            this.groupBox1.Controls.Add(this.buttonxoa);
            this.groupBox1.Controls.Add(this.textBoxsdt);
            this.groupBox1.Controls.Add(this.textBoxtenbn);
            this.groupBox1.Controls.Add(this.textBoxidtoa);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxidhd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 394);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(552, 255);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Hóa Đơn";
            // 
            // textBoxbskham
            // 
            this.textBoxbskham.Location = new System.Drawing.Point(135, 111);
            this.textBoxbskham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxbskham.Name = "textBoxbskham";
            this.textBoxbskham.ReadOnly = true;
            this.textBoxbskham.Size = new System.Drawing.Size(265, 22);
            this.textBoxbskham.TabIndex = 2;
            // 
            // textBoxtongtien
            // 
            this.textBoxtongtien.Location = new System.Drawing.Point(135, 141);
            this.textBoxtongtien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxtongtien.Name = "textBoxtongtien";
            this.textBoxtongtien.ReadOnly = true;
            this.textBoxtongtien.Size = new System.Drawing.Size(265, 22);
            this.textBoxtongtien.TabIndex = 2;
            // 
            // buttonchitiethd
            // 
            this.buttonchitiethd.BackColor = System.Drawing.Color.White;
            this.buttonchitiethd.Location = new System.Drawing.Point(407, 84);
            this.buttonchitiethd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonchitiethd.Name = "buttonchitiethd";
            this.buttonchitiethd.Size = new System.Drawing.Size(133, 37);
            this.buttonchitiethd.TabIndex = 42;
            this.buttonchitiethd.Text = "Chi Tiết Hóa Đơn";
            this.buttonchitiethd.UseVisualStyleBackColor = false;
            this.buttonchitiethd.Click += new System.EventHandler(this.buttonchitiethd_Click);
            // 
            // buttonxoa
            // 
            this.buttonxoa.BackColor = System.Drawing.Color.White;
            this.buttonxoa.Location = new System.Drawing.Point(407, 39);
            this.buttonxoa.Margin = new System.Windows.Forms.Padding(4);
            this.buttonxoa.Name = "buttonxoa";
            this.buttonxoa.Size = new System.Drawing.Size(133, 37);
            this.buttonxoa.TabIndex = 42;
            this.buttonxoa.Text = "Xóa";
            this.buttonxoa.UseVisualStyleBackColor = false;
            this.buttonxoa.Click += new System.EventHandler(this.buttonxoa_Click);
            // 
            // textBoxsdt
            // 
            this.textBoxsdt.Location = new System.Drawing.Point(136, 85);
            this.textBoxsdt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxsdt.Name = "textBoxsdt";
            this.textBoxsdt.ReadOnly = true;
            this.textBoxsdt.Size = new System.Drawing.Size(264, 22);
            this.textBoxsdt.TabIndex = 2;
            // 
            // textBoxtenbn
            // 
            this.textBoxtenbn.Location = new System.Drawing.Point(136, 55);
            this.textBoxtenbn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxtenbn.Name = "textBoxtenbn";
            this.textBoxtenbn.ReadOnly = true;
            this.textBoxtenbn.Size = new System.Drawing.Size(264, 22);
            this.textBoxtenbn.TabIndex = 2;
            // 
            // textBoxidtoa
            // 
            this.textBoxidtoa.Location = new System.Drawing.Point(300, 26);
            this.textBoxidtoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxidtoa.Name = "textBoxidtoa";
            this.textBoxidtoa.ReadOnly = true;
            this.textBoxidtoa.Size = new System.Drawing.Size(100, 22);
            this.textBoxidtoa.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "BS Khám:";
            // 
            // textBoxidhd
            // 
            this.textBoxidhd.Location = new System.Drawing.Point(136, 26);
            this.textBoxidhd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxidhd.Name = "textBoxidhd";
            this.textBoxidhd.ReadOnly = true;
            this.textBoxidhd.Size = new System.Drawing.Size(100, 22);
            this.textBoxidhd.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tổng Tiền:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "SDT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ Tên:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(240, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "ID Toa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID Hóa Đơn:";
            // 
            // textBoxtimkiem
            // 
            this.textBoxtimkiem.Location = new System.Drawing.Point(421, 71);
            this.textBoxtimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxtimkiem.Multiline = true;
            this.textBoxtimkiem.Name = "textBoxtimkiem";
            this.textBoxtimkiem.Size = new System.Drawing.Size(367, 42);
            this.textBoxtimkiem.TabIndex = 45;
            // 
            // buttontimkiem
            // 
            this.buttontimkiem.BackColor = System.Drawing.Color.White;
            this.buttontimkiem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttontimkiem.Location = new System.Drawing.Point(794, 71);
            this.buttontimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttontimkiem.Name = "buttontimkiem";
            this.buttontimkiem.Size = new System.Drawing.Size(160, 42);
            this.buttontimkiem.TabIndex = 49;
            this.buttontimkiem.Text = "Tìm Kiếm";
            this.buttontimkiem.UseVisualStyleBackColor = false;
            this.buttontimkiem.Click += new System.EventHandler(this.buttontimkiem_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(572, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 27);
            this.label1.TabIndex = 46;
            this.label1.Text = "THỐNG KÊ HÓA ĐƠN";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(170, 92);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(245, 22);
            this.dateTimePicker1.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ngày Khám:";
            // 
            // textBoxngayk
            // 
            this.textBoxngayk.Location = new System.Drawing.Point(135, 167);
            this.textBoxngayk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxngayk.Name = "textBoxngayk";
            this.textBoxngayk.ReadOnly = true;
            this.textBoxngayk.Size = new System.Drawing.Size(265, 22);
            this.textBoxngayk.TabIndex = 2;
            // 
            // DSHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 660);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.comboBoxloaitim);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttontimkiem);
            this.Controls.Add(this.buttonreset);
            this.Controls.Add(this.textBoxtimkiem);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DSHoaDon";
            this.Text = "Chi Tiết Hóa Đơn";
            this.Load += new System.EventHandler(this.ChiTietHoaDon_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenthuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private System.Windows.Forms.ComboBox comboBoxloaitim;
        private System.Windows.Forms.Button buttonreset;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxtongtien;
        private System.Windows.Forms.TextBox textBoxsdt;
        private System.Windows.Forms.Button buttonxoa;
        private System.Windows.Forms.TextBox textBoxtenbn;
        private System.Windows.Forms.TextBox textBoxidtoa;
        private System.Windows.Forms.TextBox textBoxidhd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxtimkiem;
        private System.Windows.Forms.Button buttontimkiem;
        private System.Windows.Forms.TextBox textBoxbskham;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonchitiethd;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaykham;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDhd;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDtoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDTbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BSkham;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tongtien;
        private System.Windows.Forms.TextBox textBoxngayk;
        private System.Windows.Forms.Label label7;
    }
}