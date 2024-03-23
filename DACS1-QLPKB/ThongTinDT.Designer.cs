
namespace DACS1_QLPKB
{
    partial class ThongTinDT
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
            this.buttonreset = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDthuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenthuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chucnang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttoncapnhat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxsoluong = new System.Windows.Forms.TextBox();
            this.textBoxchucnang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxgia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxtenthuoc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxiddt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonxoa = new System.Windows.Forms.Button();
            this.buttonthemdt = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonreset
            // 
            this.buttonreset.BackColor = System.Drawing.Color.White;
            this.buttonreset.Location = new System.Drawing.Point(333, 143);
            this.buttonreset.Name = "buttonreset";
            this.buttonreset.Size = new System.Drawing.Size(92, 35);
            this.buttonreset.TabIndex = 29;
            this.buttonreset.Text = "Reset";
            this.buttonreset.UseVisualStyleBackColor = false;
            this.buttonreset.Click += new System.EventHandler(this.buttonreset_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDthuoc,
            this.Tenthuoc,
            this.Soluong,
            this.Gia,
            this.Chucnang});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(766, 246);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // IDthuoc
            // 
            this.IDthuoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDthuoc.DataPropertyName = "IDthuoc";
            this.IDthuoc.HeaderText = "ID Thuốc";
            this.IDthuoc.Name = "IDthuoc";
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
            // Gia
            // 
            this.Gia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá";
            this.Gia.Name = "Gia";
            // 
            // Chucnang
            // 
            this.Chucnang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Chucnang.DataPropertyName = "Chucnang";
            this.Chucnang.HeaderText = "Chức Năng";
            this.Chucnang.Name = "Chucnang";
            // 
            // buttoncapnhat
            // 
            this.buttoncapnhat.BackColor = System.Drawing.Color.White;
            this.buttoncapnhat.Location = new System.Drawing.Point(120, 142);
            this.buttoncapnhat.Margin = new System.Windows.Forms.Padding(2);
            this.buttoncapnhat.Name = "buttoncapnhat";
            this.buttoncapnhat.Size = new System.Drawing.Size(102, 35);
            this.buttoncapnhat.TabIndex = 28;
            this.buttoncapnhat.Text = "Cập Nhật";
            this.buttoncapnhat.UseVisualStyleBackColor = false;
            this.buttoncapnhat.Click += new System.EventHandler(this.buttoncapnhat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBoxsoluong);
            this.groupBox1.Controls.Add(this.textBoxchucnang);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxgia);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxtenthuoc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxiddt);
            this.groupBox1.Location = new System.Drawing.Point(14, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 94);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn thuốc:";
            // 
            // textBoxsoluong
            // 
            this.textBoxsoluong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxsoluong.Location = new System.Drawing.Point(517, 66);
            this.textBoxsoluong.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxsoluong.MaxLength = 10;
            this.textBoxsoluong.Name = "textBoxsoluong";
            this.textBoxsoluong.Size = new System.Drawing.Size(182, 20);
            this.textBoxsoluong.TabIndex = 16;
            this.textBoxsoluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxgia_KeyPress);
            // 
            // textBoxchucnang
            // 
            this.textBoxchucnang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxchucnang.Location = new System.Drawing.Point(517, 42);
            this.textBoxchucnang.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxchucnang.Name = "textBoxchucnang";
            this.textBoxchucnang.Size = new System.Drawing.Size(182, 20);
            this.textBoxchucnang.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(415, 69);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Số Lượng:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Chức Năng:";
            // 
            // textBoxgia
            // 
            this.textBoxgia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxgia.Location = new System.Drawing.Point(133, 66);
            this.textBoxgia.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxgia.Multiline = true;
            this.textBoxgia.Name = "textBoxgia";
            this.textBoxgia.Size = new System.Drawing.Size(169, 20);
            this.textBoxgia.TabIndex = 12;
            this.textBoxgia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxgia_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Giá:";
            // 
            // textBoxtenthuoc
            // 
            this.textBoxtenthuoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxtenthuoc.Location = new System.Drawing.Point(133, 42);
            this.textBoxtenthuoc.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxtenthuoc.Multiline = true;
            this.textBoxtenthuoc.Name = "textBoxtenthuoc";
            this.textBoxtenthuoc.Size = new System.Drawing.Size(169, 20);
            this.textBoxtenthuoc.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 45);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tên Thuốc:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID Đơn Thuốc:";
            // 
            // textBoxiddt
            // 
            this.textBoxiddt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxiddt.Location = new System.Drawing.Point(133, 18);
            this.textBoxiddt.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxiddt.Name = "textBoxiddt";
            this.textBoxiddt.ReadOnly = true;
            this.textBoxiddt.Size = new System.Drawing.Size(76, 20);
            this.textBoxiddt.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(293, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 22);
            this.label1.TabIndex = 23;
            this.label1.Text = "CẬP NHẬT ĐƠN THUỐC";
            // 
            // buttonxoa
            // 
            this.buttonxoa.BackColor = System.Drawing.Color.White;
            this.buttonxoa.Location = new System.Drawing.Point(226, 142);
            this.buttonxoa.Margin = new System.Windows.Forms.Padding(2);
            this.buttonxoa.Name = "buttonxoa";
            this.buttonxoa.Size = new System.Drawing.Size(102, 35);
            this.buttonxoa.TabIndex = 26;
            this.buttonxoa.Text = "Xóa";
            this.buttonxoa.UseVisualStyleBackColor = false;
            this.buttonxoa.Click += new System.EventHandler(this.buttonxoa_Click);
            // 
            // buttonthemdt
            // 
            this.buttonthemdt.BackColor = System.Drawing.Color.White;
            this.buttonthemdt.Location = new System.Drawing.Point(14, 142);
            this.buttonthemdt.Margin = new System.Windows.Forms.Padding(2);
            this.buttonthemdt.Name = "buttonthemdt";
            this.buttonthemdt.Size = new System.Drawing.Size(102, 35);
            this.buttonthemdt.TabIndex = 27;
            this.buttonthemdt.Text = "Thêm DT";
            this.buttonthemdt.UseVisualStyleBackColor = false;
            this.buttonthemdt.Click += new System.EventHandler(this.buttonthemdt_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(14, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(772, 265);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Thuốc";
            // 
            // ThongTinDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 451);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonreset);
            this.Controls.Add(this.buttoncapnhat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonxoa);
            this.Controls.Add(this.buttonthemdt);
            this.Name = "ThongTinDT";
            this.Text = "Thông Tin Đơn Thuốc";
            this.Load += new System.EventHandler(this.ThongTinDT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonreset;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttoncapnhat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxsoluong;
        private System.Windows.Forms.TextBox textBoxchucnang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxgia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxtenthuoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxiddt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonxoa;
        private System.Windows.Forms.Button buttonthemdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDthuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenthuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chucnang;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}