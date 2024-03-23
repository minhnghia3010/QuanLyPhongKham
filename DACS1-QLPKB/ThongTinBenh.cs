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
    public partial class ThongTinBenh : Form
    {
        string chuoikn = "";
        SqlConnection ketnoi;
        SqlDataAdapter bodocghi;

        void ketnoicsdl()
        {
            chuoikn = global::DACS1_QLPKB.Properties.Settings.Default.DoAnQLPKConnectionString1;
            ketnoi = new SqlConnection(chuoikn);

            ketnoi.Open();
            string sql = "select * from Benh ";
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            cmd.CommandType = CommandType.Text;
            bodocghi = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            bodocghi.Fill(dt);
            ketnoi.Close();
            dataGridView1.DataSource = dt;
        }
        public ThongTinBenh()
        {
            InitializeComponent();
        }

        private void ThongTinBenh_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int luubenh;
            luubenh = e.RowIndex;
            textBoxidbenh.Text = dataGridView1.Rows[luubenh].Cells[0].Value.ToString();
            textBoxtenbenh.Text = dataGridView1.Rows[luubenh].Cells[1].Value.ToString();
        }

        private void buttonthembenh_Click(object sender, EventArgs e)
        {
            if (textBoxtenbenh.Text != "")
            {
                try
                {
                    string sql = string.Format("insert into Benh VALUES (N'{0}')", textBoxtenbenh.Text);
                    SqlCommand cmd = new SqlCommand(sql, ketnoi);
                    ketnoi.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ketnoi.Close();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public void clear()
        {
            textBoxtenbenh.Text = "";
        }

        private void buttoncapnhat_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            string sql = ("update Benh set Tenbenh = N'" + textBoxtenbenh.Text + "' where IDbenh = '" + int.Parse(textBoxidbenh.Text) + "'");
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đổi thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ketnoi.Close();
        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            string sql = string.Format("delete from Benh where IDbenh = ('{0}')", textBoxidbenh.Text);
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            ketnoi.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xóa thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ketnoi.Close();
        }

        private void buttonreset_Click(object sender, EventArgs e)
        {
            string sqlrs = "select * from Benh";
            SqlDataAdapter dat = new SqlDataAdapter(sqlrs, ketnoi);
            DataSet ds = new System.Data.DataSet();
            dat.Fill(ds, "Benh");
            dataGridView1.DataSource = ds.Tables[0];
            textBoxtimkiem.Text = "";
        }

        private void buttontimkiem_Click(object sender, EventArgs e)
        {
            string sql = "select * from Benh where Tenbenh like '%"+ textBoxtimkiem.Text.Trim() +"%' ";
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            cmd.CommandType = CommandType.Text;
            bodocghi = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            bodocghi.Fill(dt);
            ketnoi.Close();
            dataGridView1.DataSource = dt;
        }
    }
}
