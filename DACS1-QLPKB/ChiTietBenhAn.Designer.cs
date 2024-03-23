
namespace DACS1_QLPKB
{
    partial class ChiTietBenhAn
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
            this.comboBoxloaitim = new System.Windows.Forms.ComboBox();
            this.buttonreset = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDtoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDTbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Benh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxbenh = new System.Windows.Forms.TextBox();
            this.textBoxsdt = new System.Windows.Forms.TextBox();
            this.buttonxoa = new System.Windows.Forms.Button();
            this.textBoxtenbn = new System.Windows.Forms.TextBox();
            this.textBoxidtoa = new System.Windows.Forms.TextBox();
            this.textBoxidban = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxtimkiem = new System.Windows.Forms.TextBox();
            this.buttontimkiem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Tenthuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxloaitim
            // 
            this.comboBoxloaitim.FormattingEnabled = true;
            this.comboBoxloaitim.Location = new System.Drawing.Point(143, 99);
            this.comboBoxloaitim.Name = "comboBoxloaitim";
            this.comboBoxloaitim.Size = new System.Drawing.Size(83, 21);
            this.comboBoxloaitim.TabIndex = 43;
            // 
            // buttonreset
            // 
            this.buttonreset.BackColor = System.Drawing.Color.White;
            this.buttonreset.Location = new System.Drawing.Point(73, 99);
            this.buttonreset.Name = "buttonreset";
            this.buttonreset.Size = new System.Drawing.Size(64, 24);
            this.buttonreset.TabIndex = 42;
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
            this.groupBox2.Location = new System.Drawing.Point(1, 170);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(612, 235);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Hiển Thị:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDban,
            this.IDtoa,
            this.Tenbn,
            this.SDTbn,
            this.Benh});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(608, 218);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // IDban
            // 
            this.IDban.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDban.DataPropertyName = "IDban";
            this.IDban.HeaderText = "ID BAn";
            this.IDban.Name = "IDban";
            // 
            // IDtoa
            // 
            this.IDtoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDtoa.DataPropertyName = "IDtoa";
            this.IDtoa.HeaderText = "ID Toa";
            this.IDtoa.Name = "IDtoa";
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
            // Benh
            // 
            this.Benh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Benh.DataPropertyName = "Benh";
            this.Benh.HeaderText = "Bệnh";
            this.Benh.Name = "Benh";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBoxbenh);
            this.groupBox1.Controls.Add(this.comboBoxloaitim);
            this.groupBox1.Controls.Add(this.textBoxsdt);
            this.groupBox1.Controls.Add(this.textBoxtenbn);
            this.groupBox1.Controls.Add(this.textBoxidtoa);
            this.groupBox1.Controls.Add(this.buttonxoa);
            this.groupBox1.Controls.Add(this.textBoxidban);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.buttonreset);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxtimkiem);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttontimkiem);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(1, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(612, 124);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Bệnh Án";
            // 
            // textBoxbenh
            // 
            this.textBoxbenh.Location = new System.Drawing.Point(366, 45);
            this.textBoxbenh.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxbenh.Name = "textBoxbenh";
            this.textBoxbenh.ReadOnly = true;
            this.textBoxbenh.Size = new System.Drawing.Size(200, 20);
            this.textBoxbenh.TabIndex = 2;
            // 
            // textBoxsdt
            // 
            this.textBoxsdt.Location = new System.Drawing.Point(102, 69);
            this.textBoxsdt.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxsdt.Name = "textBoxsdt";
            this.textBoxsdt.ReadOnly = true;
            this.textBoxsdt.Size = new System.Drawing.Size(199, 20);
            this.textBoxsdt.TabIndex = 2;
            // 
            // buttonxoa
            // 
            this.buttonxoa.BackColor = System.Drawing.Color.White;
            this.buttonxoa.Location = new System.Drawing.Point(3, 99);
            this.buttonxoa.Name = "buttonxoa";
            this.buttonxoa.Size = new System.Drawing.Size(64, 24);
            this.buttonxoa.TabIndex = 42;
            this.buttonxoa.Text = "Xóa";
            this.buttonxoa.UseVisualStyleBackColor = false;
            this.buttonxoa.Click += new System.EventHandler(this.buttonxoa_Click);
            // 
            // textBoxtenbn
            // 
            this.textBoxtenbn.Location = new System.Drawing.Point(102, 45);
            this.textBoxtenbn.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxtenbn.Name = "textBoxtenbn";
            this.textBoxtenbn.ReadOnly = true;
            this.textBoxtenbn.Size = new System.Drawing.Size(199, 20);
            this.textBoxtenbn.TabIndex = 2;
            // 
            // textBoxidtoa
            // 
            this.textBoxidtoa.Location = new System.Drawing.Point(244, 21);
            this.textBoxidtoa.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxidtoa.Name = "textBoxidtoa";
            this.textBoxidtoa.ReadOnly = true;
            this.textBoxidtoa.Size = new System.Drawing.Size(57, 20);
            this.textBoxidtoa.TabIndex = 2;
            // 
            // textBoxidban
            // 
            this.textBoxidban.Location = new System.Drawing.Point(102, 21);
            this.textBoxidban.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxidban.Name = "textBoxidban";
            this.textBoxidban.ReadOnly = true;
            this.textBoxidban.Size = new System.Drawing.Size(56, 20);
            this.textBoxidban.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Bệnh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "SDT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ Tên:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(181, 24);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "ID Toa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID Bệnh Án:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(312, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 21);
            this.label1.TabIndex = 38;
            this.label1.Text = "HỒ SƠ BỆNH ÁN";
            // 
            // textBoxtimkiem
            // 
            this.textBoxtimkiem.Location = new System.Drawing.Point(231, 99);
            this.textBoxtimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxtimkiem.Name = "textBoxtimkiem";
            this.textBoxtimkiem.Size = new System.Drawing.Size(295, 20);
            this.textBoxtimkiem.TabIndex = 37;
            // 
            // buttontimkiem
            // 
            this.buttontimkiem.BackColor = System.Drawing.Color.White;
            this.buttontimkiem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttontimkiem.Location = new System.Drawing.Point(530, 97);
            this.buttontimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.buttontimkiem.Name = "buttontimkiem";
            this.buttontimkiem.Size = new System.Drawing.Size(82, 23);
            this.buttontimkiem.TabIndex = 41;
            this.buttontimkiem.Text = "Tìm Kiếm";
            this.buttontimkiem.UseVisualStyleBackColor = false;
            this.buttontimkiem.Click += new System.EventHandler(this.buttontimkiem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Location = new System.Drawing.Point(618, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(170, 363);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin thuốc";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tenthuoc,
            this.Soluong});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(164, 344);
            this.dataGridView2.TabIndex = 0;
            // 
            // Tenthuoc
            // 
            this.Tenthuoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tenthuoc.DataPropertyName = "Tenthuoc";
            this.Tenthuoc.HeaderText = "Tên Thuốc";
            this.Tenthuoc.Name = "Tenthuoc";
            // 
            // Soluong
            // 
            this.Soluong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Soluong.DataPropertyName = "Soluong";
            this.Soluong.HeaderText = "Số Lượng";
            this.Soluong.Name = "Soluong";
            // 
            // ChiTietBenhAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 408);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "ChiTietBenhAn";
            this.Text = "Chi Tiết Bệnh Án";
            this.Load += new System.EventHandler(this.ChiTietBenhAn_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxloaitim;
        private System.Windows.Forms.Button buttonreset;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxbenh;
        private System.Windows.Forms.TextBox textBoxsdt;
        private System.Windows.Forms.TextBox textBoxtenbn;
        private System.Windows.Forms.TextBox textBoxidtoa;
        private System.Windows.Forms.TextBox textBoxidban;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxtimkiem;
        private System.Windows.Forms.Button buttontimkiem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDban;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDtoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDTbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Benh;
        private System.Windows.Forms.Button buttonxoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenthuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
    }
}