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
    public partial class ThongTinNV : Form
    {
        string chuoikn = "";
        SqlConnection ketnoi;
        SqlDataAdapter bodocghi;

        void ketnoicsdl()
        {
            chuoikn = global::DACS1_QLPKB.Properties.Settings.Default.DoAnQLPKConnectionString1;
            ketnoi = new SqlConnection(chuoikn);

            ketnoi.Open();
            string sql = "select * from NhanVien ";
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            cmd.CommandType = CommandType.Text;
            bodocghi = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            bodocghi.Fill(dt);
            ketnoi.Close();
            dataGridView1.DataSource = dt;
        }
        public ThongTinNV()
        {
            InitializeComponent();
        }

        private void ThongTinNV_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int luunv;
            luunv = e.RowIndex;
            textBoxidnv.Text = dataGridView1.Rows[luunv].Cells[0].Value.ToString();
            textBoxtennv.Text = dataGridView1.Rows[luunv].Cells[1].Value.ToString();
            textBoxsdt.Text = dataGridView1.Rows[luunv].Cells[2].Value.ToString();
            textBoxdiachi.Text = dataGridView1.Rows[luunv].Cells[3].Value.ToString();
            textBoxluong.Text = dataGridView1.Rows[luunv].Cells[4].Value.ToString();
        }

        private void buttonthemnv_Click(object sender, EventArgs e)
        {
            ThemNV tnv = new ThemNV();
            tnv.ShowDialog();
        }

        private void textBoxsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void buttoncapnhat_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            string sql = ("update NhanVien set Tennv = N'" + textBoxtennv.Text + "', SDTnv = '" + textBoxsdt.Text + "', DiaChinv  = N'" + textBoxdiachi.Text + "', Luong = '"+ textBoxluong.Text +"' where IDnv = '" + int.Parse(textBoxidnv.Text) + "'");
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đổi thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ketnoi.Close();
        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            string sql = string.Format("delete from NhanVien where IDnv = ('{0}')", textBoxidnv.Text);
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            ketnoi.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xóa thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ketnoi.Close();
        }

        private void buttonreset_Click(object sender, EventArgs e)
        {
            string sqlrs = "select * from NhanVien";
            SqlDataAdapter dat = new SqlDataAdapter(sqlrs, ketnoi);
            DataSet ds = new System.Data.DataSet();
            dat.Fill(ds, "NhanVien");
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
