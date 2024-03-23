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
    public partial class ThongTinDT : Form
    {
        string chuoikn = "";
        SqlConnection ketnoi;
        SqlDataAdapter bodocghi;

        void ketnoicsdl()
        {
            chuoikn = global::DACS1_QLPKB.Properties.Settings.Default.DoAnQLPKConnectionString1;
            ketnoi = new SqlConnection(chuoikn);

            ketnoi.Open();
            string sql = "select * from Thuoc ";
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            cmd.CommandType = CommandType.Text;
            bodocghi = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            bodocghi.Fill(dt);
            ketnoi.Close();
            dataGridView1.DataSource = dt;
        }
        public ThongTinDT()
        {
            InitializeComponent();
        }

        private void ThongTinDT_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int luudt;
            luudt = e.RowIndex;
            textBoxiddt.Text = dataGridView1.Rows[luudt].Cells[0].Value.ToString();
            textBoxtenthuoc.Text = dataGridView1.Rows[luudt].Cells[1].Value.ToString();
            textBoxsoluong.Text = dataGridView1.Rows[luudt].Cells[2].Value.ToString();
            textBoxgia.Text = dataGridView1.Rows[luudt].Cells[3].Value.ToString();
            textBoxchucnang.Text = dataGridView1.Rows[luudt].Cells[4].Value.ToString();
        }

        private void buttonthemdt_Click(object sender, EventArgs e)
        {
            ThemThuoc tt = new ThemThuoc();
            tt.ShowDialog();
        }

        private void buttoncapnhat_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            string sql = ("update Thuoc set Tenthuoc = N'" + textBoxtenthuoc.Text + "', Soluong = '" + Convert.ToDecimal(textBoxsoluong.Text) + "', Gia  = N'" + textBoxgia.Text + "', Chucnang = N'" + textBoxchucnang.Text + "' where IDthuoc = '" + int.Parse(textBoxiddt.Text) + "'");
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đổi thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ketnoi.Close();
        }

        private void textBoxgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            string sql = string.Format("delete from Thuoc where IDthuoc = ('{0}')", textBoxiddt.Text);
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            ketnoi.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xóa thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ketnoi.Close();
        }

        private void buttonreset_Click(object sender, EventArgs e)
        {
            string sqlrs = "select * from Thuoc";
            SqlDataAdapter dat = new SqlDataAdapter(sqlrs, ketnoi);
            DataSet ds = new System.Data.DataSet();
            dat.Fill(ds, "Thuoc");
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
