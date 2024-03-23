
namespace DACS1_QLPKB
{
    partial class ThongTinBenh
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxtenbenh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonxoa = new System.Windows.Forms.Button();
            this.textBoxidbenh = new System.Windows.Forms.TextBox();
            this.buttonthembenh = new System.Windows.Forms.Button();
            this.buttoncapnhat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttontimkiem = new System.Windows.Forms.Button();
            this.buttonreset = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDbenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenbenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxtimkiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBoxtenbenh);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonxoa);
            this.groupBox1.Controls.Add(this.textBoxidbenh);
            this.groupBox1.Controls.Add(this.buttonthembenh);
            this.groupBox1.Controls.Add(this.buttoncapnhat);
            this.groupBox1.Location = new System.Drawing.Point(9, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(370, 146);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Bệnh ";
            // 
            // textBoxtenbenh
            // 
            this.textBoxtenbenh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxtenbenh.Location = new System.Drawing.Point(96, 48);
            this.textBoxtenbenh.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxtenbenh.Name = "textBoxtenbenh";
            this.textBoxtenbenh.Size = new System.Drawing.Size(185, 20);
            this.textBoxtenbenh.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Bệnh:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID Bệnh:";
            // 
            // buttonxoa
            // 
            this.buttonxoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonxoa.BackColor = System.Drawing.Color.White;
            this.buttonxoa.Location = new System.Drawing.Point(244, 93);
            this.buttonxoa.Name = "buttonxoa";
            this.buttonxoa.Size = new System.Drawing.Size(114, 36);
            this.buttonxoa.TabIndex = 19;
            this.buttonxoa.Text = "Xóa";
            this.buttonxoa.UseVisualStyleBackColor = false;
            this.buttonxoa.Click += new System.EventHandler(this.buttonxoa_Click);
            // 
            // textBoxidbenh
            // 
            this.textBoxidbenh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxidbenh.Location = new System.Drawing.Point(96, 24);
            this.textBoxidbenh.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxidbenh.Name = "textBoxidbenh";
            this.textBoxidbenh.ReadOnly = true;
            this.textBoxidbenh.Size = new System.Drawing.Size(62, 20);
            this.textBoxidbenh.TabIndex = 2;
            // 
            // buttonthembenh
            // 
            this.buttonthembenh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonthembenh.BackColor = System.Drawing.Color.White;
            this.buttonthembenh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonthembenh.Location = new System.Drawing.Point(7, 93);
            this.buttonthembenh.Margin = new System.Windows.Forms.Padding(2);
            this.buttonthembenh.Name = "buttonthembenh";
            this.buttonthembenh.Size = new System.Drawing.Size(114, 36);
            this.buttonthembenh.TabIndex = 18;
            this.buttonthembenh.Text = "Thêm Bệnh";
            this.buttonthembenh.UseVisualStyleBackColor = false;
            this.buttonthembenh.Click += new System.EventHandler(this.buttonthembenh_Click);
            // 
            // buttoncapnhat
            // 
            this.buttoncapnhat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttoncapnhat.BackColor = System.Drawing.Color.White;
            this.buttoncapnhat.Location = new System.Drawing.Point(125, 93);
            this.buttoncapnhat.Margin = new System.Windows.Forms.Padding(2);
            this.buttoncapnhat.Name = "buttoncapnhat";
            this.buttoncapnhat.Size = new System.Drawing.Size(114, 36);
            this.buttoncapnhat.TabIndex = 15;
            this.buttoncapnhat.Text = "Cập Nhật";
            this.buttoncapnhat.UseVisualStyleBackColor = false;
            this.buttoncapnhat.Click += new System.EventHandler(this.buttoncapnhat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.buttontimkiem);
            this.groupBox2.Controls.Add(this.buttonreset);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.textBoxtimkiem);
            this.groupBox2.Location = new System.Drawing.Point(9, 199);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(370, 236);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm Bệnh";
            // 
            // buttontimkiem
            // 
            this.buttontimkiem.BackColor = System.Drawing.Color.White;
            this.buttontimkiem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttontimkiem.Location = new System.Drawing.Point(14, 49);
            this.buttontimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.buttontimkiem.Name = "buttontimkiem";
            this.buttontimkiem.Size = new System.Drawing.Size(144, 27);
            this.buttontimkiem.TabIndex = 18;
            this.buttontimkiem.Text = "Tìm Kiếm";
            this.buttontimkiem.UseVisualStyleBackColor = false;
            this.buttontimkiem.Click += new System.EventHandler(this.buttontimkiem_Click);
            // 
            // buttonreset
            // 
            this.buttonreset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonreset.BackColor = System.Drawing.Color.White;
            this.buttonreset.Location = new System.Drawing.Point(221, 49);
            this.buttonreset.Name = "buttonreset";
            this.buttonreset.Size = new System.Drawing.Size(144, 27);
            this.buttonreset.TabIndex = 11;
            this.buttonreset.Text = "Reset";
            this.buttonreset.UseVisualStyleBackColor = false;
            this.buttonreset.Click += new System.EventHandler(this.buttonreset_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDbenh,
            this.Tenbenh});
            this.dataGridView1.Location = new System.Drawing.Point(14, 80);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(352, 152);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // IDbenh
            // 
            this.IDbenh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDbenh.DataPropertyName = "IDbenh";
            this.IDbenh.HeaderText = "ID Bệnh";
            this.IDbenh.Name = "IDbenh";
            // 
            // Tenbenh
            // 
            this.Tenbenh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tenbenh.DataPropertyName = "Tenbenh";
            this.Tenbenh.HeaderText = "Tên Bệnh";
            this.Tenbenh.Name = "Tenbenh";
            // 
            // textBoxtimkiem
            // 
            this.textBoxtimkiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxtimkiem.Location = new System.Drawing.Point(14, 25);
            this.textBoxtimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxtimkiem.Name = "textBoxtimkiem";
            this.textBoxtimkiem.Size = new System.Drawing.Size(351, 20);
            this.textBoxtimkiem.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(118, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 21);
            this.label1.TabIndex = 32;
            this.label1.Text = "TRA CỨU BỆNH";
            // 
            // ThongTinBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 443);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Name = "ThongTinBenh";
            this.Text = "Thông Tin Bệnh";
            this.Load += new System.EventHandler(this.ThongTinBenh_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxtenbenh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonxoa;
        private System.Windows.Forms.TextBox textBoxidbenh;
        private System.Windows.Forms.Button buttonthembenh;
        private System.Windows.Forms.Button buttoncapnhat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttontimkiem;
        private System.Windows.Forms.Button buttonreset;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxtimkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDbenh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenbenh;
    }
}