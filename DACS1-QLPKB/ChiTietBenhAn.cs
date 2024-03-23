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
    public partial class ChiTietBenhAn : Form
    {
        string chuoikn = "";
        SqlConnection ketnoi;
        SqlDataAdapter bodocghi;

        void ketnoicsdl()
        {
            chuoikn = global::DACS1_QLPKB.Properties.Settings.Default.DoAnQLPKConnectionString1;
            ketnoi = new SqlConnection(chuoikn);

            ketnoi.Open();
            string sql = "select * from BenhAn ";
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            cmd.CommandType = CommandType.Text;
            bodocghi = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            bodocghi.Fill(dt);
            ketnoi.Close();
            dataGridView1.DataSource = dt;
        }

        void dt()
        {
            ketnoi.Open();
            string sql = "select Tenthuoc, Soluong from ThuocBenhNhan where IDtoa = '"+ textBoxidtoa.Text +"' ";
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            cmd.CommandType = CommandType.Text;
            bodocghi = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            bodocghi.Fill(dt);
            ketnoi.Close();
            dataGridView2.DataSource = dt;
        }

        public ChiTietBenhAn()
        {
            InitializeComponent();
        }

        public void cbxloaitk()
        {
            List<string> loaitk = new List<string>() { "Tên Bệnh Nhân", "SĐT"};
            comboBoxloaitim.DataSource = loaitk;
        }

        private void ChiTietBenhAn_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
            cbxloaitk();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int luuban;
            luuban = e.RowIndex;
            textBoxidban.Text = dataGridView1.Rows[luuban].Cells[0].Value.ToString();
            textBoxidtoa.Text = dataGridView1.Rows[luuban].Cells[1].Value.ToString();
            textBoxtenbn.Text = dataGridView1.Rows[luuban].Cells[2].Value.ToString();
            textBoxsdt.Text = dataGridView1.Rows[luuban].Cells[3].Value.ToString();
            textBoxbenh.Text = dataGridView1.Rows[luuban].Cells[4].Value.ToString();
            dt();
        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            string sql = string.Format("delete from BenhAn where IDban = ('{0}')", textBoxidban.Text);
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            ketnoi.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xóa thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ketnoi.Close();
        }

        private void buttonreset_Click(object sender, EventArgs e)
        {
            string sqlrs = "select * from BenhAn";
            SqlDataAdapter dat = new SqlDataAdapter(sqlrs, ketnoi);
            DataSet ds = new System.Data.DataSet();
            dat.Fill(ds, "BenhAn");
            dataGridView1.DataSource = ds.Tables[0];
            textBoxtimkiem.Text = "";
        }

        private void buttontimkiem_Click(object sender, EventArgs e)
        {
            if (comboBoxloaitim.Text == "Tên Bệnh Nhân")
            {
                string sql = "select * from BenhAn where Tenbn like N'%" + textBoxtimkiem.Text.Trim() + "%' ";
                SqlCommand cmd = new SqlCommand(sql, ketnoi);
                cmd.CommandType = CommandType.Text;
                bodocghi = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                bodocghi.Fill(dt);
                ketnoi.Close();
                dataGridView1.DataSource = dt;
            }
            if (comboBoxloaitim.Text == "SĐT")
            {
                string sql = "select * from BenhAn where SDTbn like '%" + textBoxtimkiem.Text.Trim() + "%' ";
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
}
