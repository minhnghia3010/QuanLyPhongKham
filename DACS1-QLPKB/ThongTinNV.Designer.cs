
namespace DACS1_QLPKB
{
    partial class ThongTinNV
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
            this.buttonxoa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDnv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDTnv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diachinv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttoncapnhat = new System.Windows.Forms.Button();
            this.buttonthemnv = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxsdt = new System.Windows.Forms.TextBox();
            this.textBoxluong = new System.Windows.Forms.TextBox();
            this.textBoxdiachi = new System.Windows.Forms.TextBox();
            this.textBoxidnv = new System.Windows.Forms.TextBox();
            this.textBoxtennv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonreset
            // 
            this.buttonreset.BackColor = System.Drawing.Color.White;
            this.buttonreset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonreset.Location = new System.Drawing.Point(308, 134);
            this.buttonreset.Name = "buttonreset";
            this.buttonreset.Size = new System.Drawing.Size(92, 35);
            this.buttonreset.TabIndex = 28;
            this.buttonreset.Text = "Reset";
            this.buttonreset.UseVisualStyleBackColor = false;
            this.buttonreset.Click += new System.EventHandler(this.buttonreset_Click);
            // 
            // buttonxoa
            // 
            this.buttonxoa.BackColor = System.Drawing.Color.White;
            this.buttonxoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonxoa.Location = new System.Drawing.Point(210, 133);
            this.buttonxoa.Name = "buttonxoa";
            this.buttonxoa.Size = new System.Drawing.Size(92, 36);
            this.buttonxoa.TabIndex = 27;
            this.buttonxoa.Text = "Xóa";
            this.buttonxoa.UseVisualStyleBackColor = false;
            this.buttonxoa.Click += new System.EventHandler(this.buttonxoa_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(11, 174);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(778, 248);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Nhân Viên:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDnv,
            this.Tennv,
            this.SDTnv,
            this.Diachinv,
            this.Luong});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(774, 231);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // IDnv
            // 
            this.IDnv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDnv.DataPropertyName = "IDnv";
            this.IDnv.HeaderText = "ID NV";
            this.IDnv.Name = "IDnv";
            // 
            // Tennv
            // 
            this.Tennv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tennv.DataPropertyName = "Tennv";
            this.Tennv.HeaderText = "Tên NV";
            this.Tennv.Name = "Tennv";
            // 
            // SDTnv
            // 
            this.SDTnv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SDTnv.DataPropertyName = "SDTnv";
            this.SDTnv.HeaderText = "SĐT";
            this.SDTnv.Name = "SDTnv";
            // 
            // Diachinv
            // 
            this.Diachinv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Diachinv.DataPropertyName = "Diachinv";
            this.Diachinv.HeaderText = "Địa Chỉ";
            this.Diachinv.Name = "Diachinv";
            // 
            // Luong
            // 
            this.Luong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Luong.DataPropertyName = "Luong";
            this.Luong.HeaderText = "Lương";
            this.Luong.Name = "Luong";
            // 
            // buttoncapnhat
            // 
            this.buttoncapnhat.BackColor = System.Drawing.Color.White;
            this.buttoncapnhat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttoncapnhat.Location = new System.Drawing.Point(113, 133);
            this.buttoncapnhat.Margin = new System.Windows.Forms.Padding(2);
            this.buttoncapnhat.Name = "buttoncapnhat";
            this.buttoncapnhat.Size = new System.Drawing.Size(92, 36);
            this.buttoncapnhat.TabIndex = 25;
            this.buttoncapnhat.Text = "Cập Nhật";
            this.buttoncapnhat.UseVisualStyleBackColor = false;
            this.buttoncapnhat.Click += new System.EventHandler(this.buttoncapnhat_Click);
            // 
            // buttonthemnv
            // 
            this.buttonthemnv.BackColor = System.Drawing.Color.White;
            this.buttonthemnv.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonthemnv.Location = new System.Drawing.Point(11, 133);
            this.buttonthemnv.Margin = new System.Windows.Forms.Padding(2);
            this.buttonthemnv.Name = "buttonthemnv";
            this.buttonthemnv.Size = new System.Drawing.Size(98, 36);
            this.buttonthemnv.TabIndex = 26;
            this.buttonthemnv.Text = "Thêm NV";
            this.buttonthemnv.UseVisualStyleBackColor = false;
            this.buttonthemnv.Click += new System.EventHandler(this.buttonthemnv_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(276, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxsdt);
            this.groupBox1.Controls.Add(this.textBoxluong);
            this.groupBox1.Controls.Add(this.textBoxdiachi);
            this.groupBox1.Controls.Add(this.textBoxidnv);
            this.groupBox1.Controls.Add(this.textBoxtennv);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(778, 97);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Chi Tiết:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID NV:";
            // 
            // textBoxsdt
            // 
            this.textBoxsdt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxsdt.Location = new System.Drawing.Point(365, 69);
            this.textBoxsdt.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxsdt.MaxLength = 10;
            this.textBoxsdt.Name = "textBoxsdt";
            this.textBoxsdt.Size = new System.Drawing.Size(184, 20);
            this.textBoxsdt.TabIndex = 1;
            this.textBoxsdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxsdt_KeyPress);
            // 
            // textBoxluong
            // 
            this.textBoxluong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxluong.Location = new System.Drawing.Point(612, 37);
            this.textBoxluong.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxluong.Name = "textBoxluong";
            this.textBoxluong.Size = new System.Drawing.Size(161, 20);
            this.textBoxluong.TabIndex = 1;
            this.textBoxluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxsdt_KeyPress);
            // 
            // textBoxdiachi
            // 
            this.textBoxdiachi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxdiachi.Location = new System.Drawing.Point(365, 36);
            this.textBoxdiachi.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxdiachi.Name = "textBoxdiachi";
            this.textBoxdiachi.Size = new System.Drawing.Size(184, 20);
            this.textBoxdiachi.TabIndex = 1;
            // 
            // textBoxidnv
            // 
            this.textBoxidnv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxidnv.Location = new System.Drawing.Point(83, 37);
            this.textBoxidnv.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxidnv.Name = "textBoxidnv";
            this.textBoxidnv.ReadOnly = true;
            this.textBoxidnv.Size = new System.Drawing.Size(43, 20);
            this.textBoxidnv.TabIndex = 1;
            // 
            // textBoxtennv
            // 
            this.textBoxtennv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxtennv.Location = new System.Drawing.Point(83, 69);
            this.textBoxtennv.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxtennv.Name = "textBoxtennv";
            this.textBoxtennv.Size = new System.Drawing.Size(188, 20);
            this.textBoxtennv.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(568, 40);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Lương:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số Điện Thoại:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Địa Chỉ:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Nhân Viên:";
            // 
            // ThongTinNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 433);
            this.Controls.Add(this.buttonreset);
            this.Controls.Add(this.buttonxoa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttoncapnhat);
            this.Controls.Add(this.buttonthemnv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Name = "ThongTinNV";
            this.Text = "Thông Tin Nhân Viên";
            this.Load += new System.EventHandler(this.ThongTinNV_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonreset;
        private System.Windows.Forms.Button buttonxoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttoncapnhat;
        private System.Windows.Forms.Button buttonthemnv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxsdt;
        private System.Windows.Forms.TextBox textBoxluong;
        private System.Windows.Forms.TextBox textBoxdiachi;
        private System.Windows.Forms.TextBox textBoxidnv;
        private System.Windows.Forms.TextBox textBoxtennv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDnv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDTnv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diachinv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Luong;
    }
}