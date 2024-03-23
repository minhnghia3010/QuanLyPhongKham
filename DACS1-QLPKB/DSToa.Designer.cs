
namespace DACS1_QLPKB
{
    partial class DSToa
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IDtoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDTbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Benh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BSkham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaykham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDtoa,
            this.Tenbn,
            this.SDTbn,
            this.Benh,
            this.BSkham,
            this.Ngaykham});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(558, 337);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // IDtoa
            // 
            this.IDtoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDtoa.DataPropertyName = "IDtoa";
            this.IDtoa.HeaderText = "ID Toa";
            this.IDtoa.Name = "IDtoa";
            this.IDtoa.ReadOnly = true;
            // 
            // Tenbn
            // 
            this.Tenbn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tenbn.DataPropertyName = "Tenbn";
            this.Tenbn.HeaderText = "Tên BN";
            this.Tenbn.Name = "Tenbn";
            this.Tenbn.ReadOnly = true;
            // 
            // SDTbn
            // 
            this.SDTbn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SDTbn.DataPropertyName = "SDTbn";
            this.SDTbn.HeaderText = "SĐT";
            this.SDTbn.Name = "SDTbn";
            this.SDTbn.ReadOnly = true;
            // 
            // Benh
            // 
            this.Benh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Benh.DataPropertyName = "Benh";
            this.Benh.HeaderText = "Chuẩn Đoán";
            this.Benh.Name = "Benh";
            this.Benh.ReadOnly = true;
            // 
            // BSkham
            // 
            this.BSkham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BSkham.DataPropertyName = "BSkham";
            this.BSkham.HeaderText = "BS Khám";
            this.BSkham.Name = "BSkham";
            this.BSkham.ReadOnly = true;
            // 
            // Ngaykham
            // 
            this.Ngaykham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ngaykham.DataPropertyName = "Ngaykham";
            this.Ngaykham.HeaderText = "Ngày Khám";
            this.Ngaykham.Name = "Ngaykham";
            // 
            // DSToa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 337);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DSToa";
            this.Text = "Danh Sách Toa";
            this.Load += new System.EventHandler(this.DSToa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDtoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDTbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Benh;
        private System.Windows.Forms.DataGridViewTextBoxColumn BSkham;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaykham;
    }
}