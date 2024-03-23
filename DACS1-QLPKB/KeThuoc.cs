using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DACS1_QLPKB
{
    public partial class KeThuoc : Form
    {
        string chuoikn = "";
        SqlConnection ketnoi;
        SqlDataAdapter bodocghi;
        DataTable dt1 = new DataTable("DonThuocBenhNhan");


        void ketnoicsdl()
        {
            chuoikn = global::DACS1_QLPKB.Properties.Settings.Default.DoAnQLPKConnectionString1;
            ketnoi = new SqlConnection(chuoikn);

            string sql = "select IDthuoc, Tenthuoc, Gia from Thuoc";
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            bodocghi = new SqlDataAdapter();
            bodocghi.SelectCommand = cmd;
            DataTable dt = new DataTable();
            bodocghi.Fill(dt);
            comboBoxtenthuoc.DataSource = dt;
            comboBoxtenthuoc.DisplayMember = "Tenthuoc";
            comboBoxtenthuoc.ValueMember = "IDthuoc";
            comboBoxgia.DataSource = dt;
            comboBoxgia.DisplayMember = "Gia";
            comboBoxgia.ValueMember = "Gia";

            

            ketnoi.Open();
            string sql1 = "select IDtoa, IDthuoc, Tenthuoc, Soluong, Gia from ThuocBenhNhan where IDtoa = '" + textBoxidtoa.Text + "'";
            SqlCommand cmd1 = new SqlCommand(sql1, ketnoi);
            cmd1.CommandType = CommandType.Text;
            bodocghi = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            bodocghi.Fill(dt1);
            ketnoi.Close();
            dataGridView1.DataSource = dt1;
        }
 
        public KeThuoc()
        {
            InitializeComponent();
        }

        public void tinhtongsp()
        {
            int tien = dataGridView1.Rows.Count;
            float thanhtien = 0;
            for (int i = 0; i < tien - 1; i++)
            {
                thanhtien += float.Parse(dataGridView1.Rows[i].Cells["Gia"].Value.ToString()) * float.Parse(dataGridView1.Rows[i].Cells["Soluong"].Value.ToString());
            }
            labeltongtien.Text = thanhtien.ToString();
        }

        private void KeThuoc_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }


        private void buttonchonbn_Click(object sender, EventArgs e)
        {
            DSToa dst = new DSToa();
            dst.ShowDialog();
            textBoxidtoa.Text = ClassBenhNhan.IDTOA;
            textBoxtenbn.Text = ClassBenhNhan.TENBN;
            textBoxsdt.Text = ClassBenhNhan.SDTBN;
            textBoxchuandoan.Text = ClassBenhNhan.BENH;
            textBoxbskham.Text = ClassBenhNhan.BSKHAM;
            textBoxngaykham.Text = ClassBenhNhan.NGAYK;
            
        }

        private void dataGridView2_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
        }

        private void buttonupdatedt_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            string sql = ("update ThuocBenhNhan set Soluong = '"+ Convert.ToDecimal(numericUpDownsoluong.Value) +"' where IDtoa = '" + int.Parse(textBoxidtoa.Text) + "' and IDthuoc = '"+ int.Parse(comboBoxtenthuoc.SelectedValue.ToString()) +"'");
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đổi thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ketnoi.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void buttonreset2_Click(object sender, EventArgs e)
        {
            string sqlrs = "select IDtoa, IDthuoc, Tenthuoc, Soluong, Gia from ThuocBenhNhan where IDtoa = '" + textBoxidtoa.Text + "'";
            SqlDataAdapter dat = new SqlDataAdapter(sqlrs, ketnoi);
            DataSet ds = new System.Data.DataSet();
            dat.Fill(ds, "ThuocBenhNhan");
            dataGridView1.DataSource = ds.Tables[0];
            tinhtongsp();
        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            try
            {
                ketnoi.Open();
                string sql = string.Format("delete from ThuocBenhNhan where IDtoa = '" + int.Parse(textBoxidtoa.Text) + "' and IDthuoc = '" + int.Parse(comboBoxtenthuoc.SelectedValue.ToString()) + "'");
                SqlCommand cmd = new SqlCommand(sql, ketnoi);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ketnoi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonthemthuoc_Click(object sender, EventArgs e)
        {
            try
            {
                ketnoi.Open();
                string sql = string.Format("insert into ThuocBenhNhan(IDToa, IDthuoc, Tenthuoc, Soluong, Gia) VALUES ('{0}','{1}',N'{2}','{3}', '{4}')", int.Parse(textBoxidtoa.Text), int.Parse(comboBoxtenthuoc.SelectedValue.ToString()), comboBoxtenthuoc.Text, numericUpDownsoluong.Value, Convert.ToDecimal(comboBoxgia.SelectedValue));
                SqlCommand cmd = new SqlCommand(sql, ketnoi);
                string sql1 = "update Thuoc set SoLuong = SoLuong - '" + Convert.ToDecimal(numericUpDownsoluong.Value) + "' where IDthuoc = '" + int.Parse(comboBoxtenthuoc.SelectedValue.ToString()) + "'";
                SqlCommand cmd1 = new SqlCommand(sql1, ketnoi);
                cmd.ExecuteNonQuery();   
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Thêm Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ketnoi.Close();
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void buttonthantoan_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            string sql1 = string.Format("insert into BenhAn VALUES ('{0}', N'{1}', '{2}', N'{3}')", int.Parse(textBoxidtoa.Text), textBoxtenbn.Text, textBoxsdt.Text, textBoxchuandoan.Text);
            SqlCommand cmd1 = new SqlCommand(sql1, ketnoi);
            string sql = string.Format("insert into HoaDon VALUES ('{0}', N'{1}', '{2}', N'{3}', '{4}', '{5}')", int.Parse(textBoxidtoa.Text), textBoxtenbn.Text, textBoxsdt.Text, textBoxbskham.Text, Convert.ToDecimal(labeltongtien.Text), textBoxngaykham.Text);
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            string sql2 = ("update Toathuoc set Thanhtoan = N'" + "Đã thanh toán" + "' where IDtoa = '"+ textBoxidtoa.Text +"'");
            SqlCommand cmd2 = new SqlCommand(sql2, ketnoi);
            cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Thanh Toán Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ketnoi.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
