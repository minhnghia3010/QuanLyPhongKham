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
    public partial class ChiTietHoaDon : Form
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

            textBoxidhd.Text = ClassBenhNhan.IDHD;
            textBoxidtoa.Text = ClassBenhNhan.IDTOA;
            textBoxtenbn.Text = ClassBenhNhan.TENBN;
            textBoxsdt.Text = ClassBenhNhan.SDTBN;
            textBoxbskham.Text = ClassBenhNhan.BSKHAM;
            textBoxngaykham.Text = ClassBenhNhan.NGAYK;

            string sqlrs = "select IDtoa, IDthuoc, Tenthuoc, Soluong, Gia from ThuocBenhNhan where IDtoa = '" + textBoxidtoa.Text + "'";
            SqlDataAdapter dat = new SqlDataAdapter(sqlrs, ketnoi);
            DataSet ds = new System.Data.DataSet();
            dat.Fill(ds, "ThuocBenhNhan");
            dataGridView1.DataSource = ds.Tables[0];
            tinhtongsp();
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

        public ChiTietHoaDon()
        {
            InitializeComponent();
        }

        private void ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
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
                MessageBox.Show("Đã có thuốc!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonupdatedt_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            string sql = ("update ThuocBenhNhan set Soluong = '" + Convert.ToDecimal(numericUpDownsoluong.Value) + "' where IDtoa = '" + int.Parse(textBoxidtoa.Text) + "' and IDthuoc = '" + int.Parse(comboBoxtenthuoc.SelectedValue.ToString()) + "'");
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đổi đơn thuốc thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ketnoi.Close();
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

        private void buttonthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
