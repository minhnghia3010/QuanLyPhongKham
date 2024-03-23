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
    public partial class ThongTinBenhNhan : Form
    {
        string chuoikn = "";
        SqlConnection ketnoi;
        SqlDataAdapter bodocghi;

        void ketnoicsdl()
        {
            chuoikn = global::DACS1_QLPKB.Properties.Settings.Default.DoAnQLPKConnectionString1;
            ketnoi = new SqlConnection(chuoikn);

            ketnoi.Open();
            string sql = "select IDbn, Tenbn, SDTbn, Diachibn, Gioitinh from BenhNhan ";
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            cmd.CommandType = CommandType.Text;
            bodocghi = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            bodocghi.Fill(dt);
            ketnoi.Close();
            dataGridViewbenhnhan.DataSource = dt;

            ketnoi.Open();
            string ssql = "select IDdsbn, Tenbn, SDTbn, Tinhtrang from DanhSachBenhNhan where Tinhtrang = N'"+ "Chưa Khám"+"' ";
            SqlCommand ccmd = new SqlCommand(ssql, ketnoi);
            ccmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(ccmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            ketnoi.Close();
            dataGridViewdsbenhnhan.DataSource = dtb;
        }
        public ThongTinBenhNhan()
        {
            InitializeComponent();
        }

        public void bsk()
        {
            string sql = "select * from BacSi";
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            bodocghi = new SqlDataAdapter();
            bodocghi.SelectCommand = cmd;
            DataTable dt = new DataTable();
            bodocghi.Fill(dt);

            comboBoxbskham.DataSource = dt;
            comboBoxbskham.DisplayMember = "Tenbs";
            comboBoxbskham.ValueMember = "IDbs";
        }

        public void cbxloaitk()
        {
            List<string> loaitk = new List<string>() {"Tên Bệnh Nhân", "SĐT", "Địa Chỉ"};
            comboBoxloaitimkiem.DataSource = loaitk;
        }

        private void ThongTinBenhNhan_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
            cbxloaitk();
            bsk();
        }

        private void dataGridViewbenhnhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            int luubn;
            luubn = e.RowIndex;
            textBoxidbn.Text = dataGridViewbenhnhan.Rows[luubn].Cells[0].Value.ToString();
            textBoxtenbn.Text = dataGridViewbenhnhan.Rows[luubn].Cells[1].Value.ToString();
            textBoxsdtbn.Text = dataGridViewbenhnhan.Rows[luubn].Cells[2].Value.ToString();
            textBoxdiachibn.Text = dataGridViewbenhnhan.Rows[luubn].Cells[3].Value.ToString();
            textBoxgioitinh.Text = dataGridViewbenhnhan.Rows[luubn].Cells[4].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonthembn_Click(object sender, EventArgs e)
        {
            ThemBN tbn = new ThemBN();
            tbn.ShowDialog();
        }

        private void buttoncapnhatbn_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            string sql = ("update BenhNhan set Tenbn = N'" + textBoxtenbn.Text + "', SDTbn = '" + textBoxsdtbn.Text + "', Diachibn  = N'" + textBoxdiachibn.Text + "', Gioitinh = N'"+ textBoxgioitinh.Text +"', Trieuchung = N'"+ textBoxtrieuchung.Text +"' where IDbn = '" + int.Parse(textBoxidbn.Text) + "'");
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đổi thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ketnoi.Close();
        }

        private void buttonxoabn_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("delete from BenhNhan where IDbn = ('{0}')", textBoxidbn.Text);
                SqlCommand cmd = new SqlCommand(sql, ketnoi);
                ketnoi.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ketnoi.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonreset_Click(object sender, EventArgs e)
        {
            string sqlrs = "select IDbn, Tenbn, SDTbn, Diachibn, Gioitinh from BenhNhan";
            SqlDataAdapter dat = new SqlDataAdapter(sqlrs, ketnoi);
            DataSet ds = new System.Data.DataSet();
            dat.Fill(ds, "BenhNhan");
            dataGridViewbenhnhan.DataSource = ds.Tables[0];

            string sqlrs1 = "select IDdsbn, Tenbn, SDTbn, Tinhtrang from DanhSachBenhNhan where Tinhtrang = N'" + "Chưa Khám" + "' ";
            SqlDataAdapter dat1 = new SqlDataAdapter(sqlrs1, ketnoi);
            DataSet ds1 = new System.Data.DataSet();
            dat1.Fill(ds1, "DanhSachBenhNhan");
            dataGridViewdsbenhnhan.DataSource = ds1.Tables[0];
            textBoxtimkiem.Text = "";
        }

        private void buttontimkiem_Click(object sender, EventArgs e)
        {
            if(comboBoxloaitimkiem.Text == "Tên Bệnh Nhân")
            {
            string sql = "select IDbn, Tenbn, SDTbn, Diachibn, Gioitinh from BenhNhan where Tenbn like N'%" + textBoxtimkiem.Text.Trim() + "%' ";
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            cmd.CommandType = CommandType.Text;
            bodocghi = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            bodocghi.Fill(dt);
            ketnoi.Close();
            dataGridViewbenhnhan.DataSource = dt;
            }
            if (comboBoxloaitimkiem.Text == "SĐT")
            {
                string sql = "select IDbn, Tenbn, SDTbn, Diachibn, Gioitinh from BenhNhan where SDTbn like '%" + textBoxtimkiem.Text.Trim() + "%' ";
                SqlCommand cmd = new SqlCommand(sql, ketnoi);
                cmd.CommandType = CommandType.Text;
                bodocghi = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                bodocghi.Fill(dt);
                ketnoi.Close();
                dataGridViewbenhnhan.DataSource = dt;
            }
            if (comboBoxloaitimkiem.Text == "Địa Chỉ")
            {
                string sql = "select IDbn, Tenbn, SDTbn, Diachibn, Gioitinh from BenhNhan where Diachibn like N'%" + textBoxtimkiem.Text.Trim() + "%' ";
                SqlCommand cmd = new SqlCommand(sql, ketnoi);
                cmd.CommandType = CommandType.Text;
                bodocghi = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                bodocghi.Fill(dt);
                ketnoi.Close();
                dataGridViewbenhnhan.DataSource = dt;
            }

        }

        private void buttondangkydsbn_Click(object sender, EventArgs e)
        {
            string sql = string.Format("insert into DanhSachBenhNhan(IDbn, Tenbn, SDTbn, Trieuchung, BSkham, Tinhtrang, IDbs) VALUES ('{0}', N'{1}', '{2}', N'{3}', N'{4}', N'{5}', '{6}')", textBoxidbn.Text, textBoxtenbn.Text, textBoxsdtbn.Text, textBoxtrieuchung.Text, comboBoxbskham.Text, "Chưa Khám", int.Parse(comboBoxbskham.SelectedValue.ToString()));
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            ketnoi.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Thêm Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ketnoi.Close();
        }

        private void buttonxembenhan_Click(object sender, EventArgs e)
        {
            ChiTietBenhAn cbn = new ChiTietBenhAn();
            cbn.ShowDialog();
        }
    }
}
