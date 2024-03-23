
namespace DACS1_QLPKB
{
    partial class ThongTinBS
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
            this.buttondoimk = new System.Windows.Forms.Button();
            this.buttonreset = new System.Windows.Forms.Button();
            this.buttonxoa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDbs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenbs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDTbs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diachibs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttoncapnhat = new System.Windows.Forms.Button();
            this.buttonthembs = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxsdt = new System.Windows.Forms.TextBox();
            this.textBoxdiachi = new System.Windows.Forms.TextBox();
            this.textBoxidbs = new System.Windows.Forms.TextBox();
            this.textBoxtenbs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttondoimk
            // 
            this.buttondoimk.BackColor = System.Drawing.Color.White;
            this.buttondoimk.Location = new System.Drawing.Point(308, 137);
            this.buttondoimk.Name = "buttondoimk";
            this.buttondoimk.Size = new System.Drawing.Size(92, 35);
            this.buttondoimk.TabIndex = 37;
            this.buttondoimk.Text = "Đổi Mật Khẩu";
            this.buttondoimk.UseVisualStyleBackColor = false;
            this.buttondoimk.Click += new System.EventHandler(this.buttondoimk_Click);
            // 
            // buttonreset
            // 
            this.buttonreset.BackColor = System.Drawing.Color.White;
            this.buttonreset.Location = new System.Drawing.Point(406, 136);
            this.buttonreset.Name = "buttonreset";
            this.buttonreset.Size = new System.Drawing.Size(92, 35);
            this.buttonreset.TabIndex = 38;
            this.buttonreset.Text = "Reset";
            this.buttonreset.UseVisualStyleBackColor = false;
            this.buttonreset.Click += new System.EventHandler(this.buttonreset_Click);
            // 
            // buttonxoa
            // 
            this.buttonxoa.BackColor = System.Drawing.Color.White;
            this.buttonxoa.Location = new System.Drawing.Point(210, 136);
            this.buttonxoa.Name = "buttonxoa";
            this.buttonxoa.Size = new System.Drawing.Size(92, 36);
            this.buttonxoa.TabIndex = 36;
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
            this.groupBox2.Location = new System.Drawing.Point(11, 177);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(778, 262);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Bác Sĩ:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDbs,
            this.Tenbs,
            this.SDTbs,
            this.Diachibs});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(774, 245);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // IDbs
            // 
            this.IDbs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDbs.DataPropertyName = "IDbs";
            this.IDbs.HeaderText = "ID BS";
            this.IDbs.Name = "IDbs";
            // 
            // Tenbs
            // 
            this.Tenbs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tenbs.DataPropertyName = "Tenbs";
            this.Tenbs.HeaderText = "Tên BS";
            this.Tenbs.Name = "Tenbs";
            // 
            // SDTbs
            // 
            this.SDTbs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SDTbs.DataPropertyName = "SDTbs";
            this.SDTbs.HeaderText = "SĐT";
            this.SDTbs.Name = "SDTbs";
            // 
            // Diachibs
            // 
            this.Diachibs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Diachibs.DataPropertyName = "Diachibs";
            this.Diachibs.HeaderText = "Địa Chỉ";
            this.Diachibs.Name = "Diachibs";
            // 
            // buttoncapnhat
            // 
            this.buttoncapnhat.BackColor = System.Drawing.Color.White;
            this.buttoncapnhat.Location = new System.Drawing.Point(113, 136);
            this.buttoncapnhat.Margin = new System.Windows.Forms.Padding(2);
            this.buttoncapnhat.Name = "buttoncapnhat";
            this.buttoncapnhat.Size = new System.Drawing.Size(92, 36);
            this.buttoncapnhat.TabIndex = 34;
            this.buttoncapnhat.Text = "Cập Nhật";
            this.buttoncapnhat.UseVisualStyleBackColor = false;
            this.buttoncapnhat.Click += new System.EventHandler(this.buttoncapnhat_Click);
            // 
            // buttonthembs
            // 
            this.buttonthembs.BackColor = System.Drawing.Color.White;
            this.buttonthembs.Location = new System.Drawing.Point(11, 136);
            this.buttonthembs.Margin = new System.Windows.Forms.Padding(2);
            this.buttonthembs.Name = "buttonthembs";
            this.buttonthembs.Size = new System.Drawing.Size(98, 36);
            this.buttonthembs.TabIndex = 35;
            this.buttonthembs.Text = "Thêm BS";
            this.buttonthembs.UseVisualStyleBackColor = false;
            this.buttonthembs.Click += new System.EventHandler(this.buttonthembs_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(304, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 21);
            this.label5.TabIndex = 32;
            this.label5.Text = "THÔNG TIN BÁC SĨ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxsdt);
            this.groupBox1.Controls.Add(this.textBoxdiachi);
            this.groupBox1.Controls.Add(this.textBoxidbs);
            this.groupBox1.Controls.Add(this.textBoxtenbs);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(778, 97);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Chi Tiết:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID BS:";
            // 
            // textBoxsdt
            // 
            this.textBoxsdt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxsdt.Location = new System.Drawing.Point(508, 66);
            this.textBoxsdt.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxsdt.MaxLength = 10;
            this.textBoxsdt.Name = "textBoxsdt";
            this.textBoxsdt.Size = new System.Drawing.Size(206, 20);
            this.textBoxsdt.TabIndex = 1;
            this.textBoxsdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxsdt_KeyPress);
            // 
            // textBoxdiachi
            // 
            this.textBoxdiachi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxdiachi.Location = new System.Drawing.Point(508, 36);
            this.textBoxdiachi.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxdiachi.Name = "textBoxdiachi";
            this.textBoxdiachi.Size = new System.Drawing.Size(206, 20);
            this.textBoxdiachi.TabIndex = 1;
            // 
            // textBoxidbs
            // 
            this.textBoxidbs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxidbs.Location = new System.Drawing.Point(103, 37);
            this.textBoxidbs.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxidbs.Name = "textBoxidbs";
            this.textBoxidbs.ReadOnly = true;
            this.textBoxidbs.Size = new System.Drawing.Size(70, 20);
            this.textBoxidbs.TabIndex = 1;
            // 
            // textBoxtenbs
            // 
            this.textBoxtenbs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxtenbs.Location = new System.Drawing.Point(103, 69);
            this.textBoxtenbs.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxtenbs.Name = "textBoxtenbs";
            this.textBoxtenbs.Size = new System.Drawing.Size(206, 20);
            this.textBoxtenbs.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 69);
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
            this.label2.Location = new System.Drawing.Point(429, 39);
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
            this.label1.Location = new System.Drawing.Point(24, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bác Sĩ:";
            // 
            // ThongTinBS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttondoimk);
            this.Controls.Add(this.buttonreset);
            this.Controls.Add(this.buttonxoa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttoncapnhat);
            this.Controls.Add(this.buttonthembs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Name = "ThongTinBS";
            this.Text = "Thông Tin Bác Sĩ";
            this.Load += new System.EventHandler(this.ThongTinBS_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttondoimk;
        private System.Windows.Forms.Button buttonreset;
        private System.Windows.Forms.Button buttonxoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttoncapnhat;
        private System.Windows.Forms.Button buttonthembs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxsdt;
        private System.Windows.Forms.TextBox textBoxdiachi;
        private System.Windows.Forms.TextBox textBoxidbs;
        private System.Windows.Forms.TextBox textBoxtenbs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDbs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenbs;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDTbs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diachibs;
    }
}