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
    public partial class DSHoaDon : Form
    {
        string chuoikn = "";
        SqlConnection ketnoi;
        SqlDataAdapter bodocghi;

        void ketnoicsdl()
        {
            chuoikn = global::DACS1_QLPKB.Properties.Settings.Default.DoAnQLPKConnectionString1;
            ketnoi = new SqlConnection(chuoikn);

            ketnoi.Open();
            string sql = "select * from HoaDon ";
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
            string sql = "select Tenthuoc, Soluong from ThuocBenhNhan where IDtoa = '" + textBoxidtoa.Text + "' ";
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            cmd.CommandType = CommandType.Text;
            bodocghi = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            bodocghi.Fill(dt);
            ketnoi.Close();
            dataGridView2.DataSource = dt;
        }

        public DSHoaDon()
        {
            InitializeComponent();
        }

        public void cbxloaitk()
        {
            List<string> loaitk = new List<string>() { "Tên Bệnh Nhân", "SĐT" , "Ngày Khám"};
            comboBoxloaitim.DataSource = loaitk;
        }

        private void ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
            cbxloaitk();
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int luuhd;
            luuhd = e.RowIndex;
            textBoxidhd.Text = dataGridView1.Rows[luuhd].Cells[0].Value.ToString();
            textBoxidtoa.Text = dataGridView1.Rows[luuhd].Cells[1].Value.ToString();
            textBoxtenbn.Text = dataGridView1.Rows[luuhd].Cells[2].Value.ToString();
            textBoxsdt.Text = dataGridView1.Rows[luuhd].Cells[3].Value.ToString();
            textBoxbskham.Text = dataGridView1.Rows[luuhd].Cells[4].Value.ToString();
            textBoxtongtien.Text = dataGridView1.Rows[luuhd].Cells[5].Value.ToString();
            textBoxngayk.Text = dataGridView1.Rows[luuhd].Cells[6].Value.ToString();
            dt();
        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            string sql = string.Format("delete from HoaDon where IDhd = ('{0}')", textBoxidhd.Text);
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            ketnoi.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Xóa thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ketnoi.Close();
        }

        private void buttonreset_Click(object sender, EventArgs e)
        {
            string sqlrs = "select * from HoaDon";
            SqlDataAdapter dat = new SqlDataAdapter(sqlrs, ketnoi);
            DataSet ds = new System.Data.DataSet();
            dat.Fill(ds, "HoaDon");
            dataGridView1.DataSource = ds.Tables[0];
            textBoxtimkiem.Text = "";
        }

        private void buttontimkiem_Click(object sender, EventArgs e)
        {
            if (comboBoxloaitim.Text == "Tên Bệnh Nhân")
            {
                dateTimePicker1.Enabled = false;
                textBoxtimkiem.Enabled = true;
                string sql = "select * from HoaDon where Tenbn like N'%" + textBoxtimkiem.Text.Trim() + "%' ";
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
                dateTimePicker1.Enabled = false;
                textBoxtimkiem.Enabled = true;
                string sql = "select * from HoaDon where SDTbn like '%" + textBoxtimkiem.Text.Trim() + "%' ";
                SqlCommand cmd = new SqlCommand(sql, ketnoi);
                cmd.CommandType = CommandType.Text;
                bodocghi = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                bodocghi.Fill(dt);
                ketnoi.Close();
                dataGridView1.DataSource = dt;
            }
            if (comboBoxloaitim.Text == "Ngày Khám")
            {
                dateTimePicker1.Enabled = true;
                textBoxtimkiem.Enabled = false;
                string sql = "select * from HoaDon where Ngaykham like '%" + dateTimePicker1.Value.ToString("MM/dd/yyyy") + "%' ";
                SqlCommand cmd = new SqlCommand(sql, ketnoi);
                cmd.CommandType = CommandType.Text;
                bodocghi = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                bodocghi.Fill(dt);
                ketnoi.Close();
                dataGridView1.DataSource = dt;
            }
        }

        private void comboBoxloaitim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxloaitim.Text == "Tên Bệnh Nhân")
            {
                dateTimePicker1.Enabled = false;
                textBoxtimkiem.Enabled = true;
            }
            if (comboBoxloaitim.Text == "SĐT")
            {
                dateTimePicker1.Enabled = false;
                textBoxtimkiem.Enabled = true;
            }
            if (comboBoxloaitim.Text == "Ngày Khám")
            {
                dateTimePicker1.Enabled = true;
                textBoxtimkiem.Enabled = false;
            }
        }

        private void buttonchitiethd_Click(object sender, EventArgs e)
        {
            if(textBoxidhd.Text == "")
            {
                MessageBox.Show("Vui lòng chọn hóa đơn!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ClassBenhNhan.IDHD = textBoxidhd.Text;
                ClassBenhNhan.IDTOA = textBoxidtoa.Text;
                ClassBenhNhan.TENBN = textBoxtenbn.Text;
                ClassBenhNhan.BSKHAM = textBoxbskham.Text;
                ClassBenhNhan.SDTBN = textBoxsdt.Text;
                ClassBenhNhan.NGAYK = textBoxngayk.Text;
                ChiTietHoaDon cthd = new ChiTietHoaDon();
                cthd.ShowDialog();
            }
            
        }
    }
}
