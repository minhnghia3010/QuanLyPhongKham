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
    public partial class ThongTinBS : Form
    {
        string chuoikn = "";
        SqlConnection ketnoi;
        SqlDataAdapter bodocghi;

        void ketnoicsdl()
        {
            chuoikn = global::DACS1_QLPKB.Properties.Settings.Default.DoAnQLPKConnectionString1;
            ketnoi = new SqlConnection(chuoikn);

            ketnoi.Open();
            string sql = "select IDbs, Tenbs, DiaChibs, SDTbs from BacSi ";
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            cmd.CommandType = CommandType.Text;
            bodocghi = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            bodocghi.Fill(dt);
            ketnoi.Close();
            dataGridView1.DataSource = dt;
        }
        public ThongTinBS()
        {
            InitializeComponent();
        }

        private void ThongTinBS_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int luubs;
            luubs = e.RowIndex;
            textBoxidbs.Text = dataGridView1.Rows[luubs].Cells[0].Value.ToString();
            textBoxtenbs.Text = dataGridView1.Rows[luubs].Cells[1].Value.ToString();
            textBoxdiachi.Text = dataGridView1.Rows[luubs].Cells[2].Value.ToString();
            textBoxsdt.Text = dataGridView1.Rows[luubs].Cells[3].Value.ToString();
        }

        private void buttoncapnhat_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            string sql = ("update BacSi set Tenbs = N'" + textBoxtenbs.Text + "', SDTbs = '" + textBoxsdt.Text + "', Diachibs  = N'" + textBoxdiachi.Text + "'where IDbs = '" + int.Parse(textBoxidbs.Text) + "'");
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đổi thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ketnoi.Close();
        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            string sql = string.Format("delete from BacSi where IDbs = ('{0}')", textBoxidbs.Text);
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            ketnoi.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xóa thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ketnoi.Close();
        }

        private void buttonthembs_Click(object sender, EventArgs e)
        {
            ThemBS tbs = new ThemBS();
            tbs.ShowDialog();
        }

        private void buttondoimk_Click(object sender, EventArgs e)
        {
            DoiMatKhau dmk = new DoiMatKhau();
            dmk.ShowDialog();
        }

        private void buttonreset_Click(object sender, EventArgs e)
        {
            string sqlrs = "select IDbs, Tenbs, DiaChibs, SDTbs from BacSi";
            SqlDataAdapter dat = new SqlDataAdapter(sqlrs, ketnoi);
            DataSet ds = new System.Data.DataSet();
            dat.Fill(ds, "BacSi");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void textBoxsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
