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
    public partial class KhamBenh : Form
    {
        string chuoikn = "";
        SqlConnection ketnoi;
        SqlDataAdapter bodocghi;

        void ketnoicsdl()
        {
            chuoikn = global::DACS1_QLPKB.Properties.Settings.Default.DoAnQLPKConnectionString1;
            ketnoi = new SqlConnection(chuoikn);

            ketnoi.Open();
            string sql = "select IDdsbn, IDbn, Tenbn, SDTbn, Trieuchung, BSkham from DanhSachBenhNhan where Tinhtrang = N'" + "Chưa Khám" + "'";
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            cmd.CommandType = CommandType.Text;
            bodocghi = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            bodocghi.Fill(dt);
            ketnoi.Close();
            dataGridView1.DataSource = dt;
        }
        public KhamBenh()
        {
            InitializeComponent();
        }

        public void cd()
        {
            string sql = "select IDbenh, Tenbenh from Benh";
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            bodocghi = new SqlDataAdapter();
            bodocghi.SelectCommand = cmd;
            DataTable dt = new DataTable();
            bodocghi.Fill(dt);

            comboBoxchuandoan.DataSource = dt;
            comboBoxchuandoan.DisplayMember = "Tenbenh";
            comboBoxchuandoan.ValueMember = "IDbenh";
        }

        private void KhamBenh_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
            cd();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int luukb;
                luukb = e.RowIndex;
                textBoxiddsbn.Text = dataGridView1.Rows[luukb].Cells[0].Value.ToString();
                textBoxidbn.Text = dataGridView1.Rows[luukb].Cells[1].Value.ToString();
                textBoxtenbn.Text = dataGridView1.Rows[luukb].Cells[2].Value.ToString();
                textBoxsdt.Text = dataGridView1.Rows[luukb].Cells[3].Value.ToString();
                textBoxtrieuchung.Text = dataGridView1.Rows[luukb].Cells[4].Value.ToString();
                textBoxbskham.Text = dataGridView1.Rows[luukb].Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonxoa_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = string.Format("delete from DanhSachBenhNhan where IDdsbn = '"+ textBoxiddsbn.Text +"' and TinhTrang = N'"+ "Chưa Khám" +"'");
                SqlCommand cmd = new SqlCommand(sql, ketnoi);
                ketnoi.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ketnoi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonthemtoa_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            string sql1 = ("update DanhSachBenhNhan set Benh = N'" + comboBoxchuandoan.Text + "', Tinhtrang = N'" + "Đã Khám" + "', IDbenh = '"+ int.Parse(comboBoxchuandoan.SelectedValue.ToString()) +"' where IDdsbn = '" + textBoxiddsbn.Text + "'");
            SqlCommand cmd1 = new SqlCommand(sql1, ketnoi);
            string sql = string.Format("insert into ToaThuoc VALUES (N'{0}', '{1}', N'{2}', N'{3}', '{4}', N'{5}', '{6}')", textBoxtenbn.Text, textBoxsdt.Text, comboBoxchuandoan.Text, textBoxbskham.Text, textBoxiddsbn.Text, "Chưa Thanh Toán", dateTimePicker1.Value.ToString("MM/dd/yyyy"));
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Thêm Thành Công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ketnoi.Close();
        }

        private void buttonreset1_Click(object sender, EventArgs e)
        {
            string sqlrs = "select IDdsbn, IDbn, Tenbn, SDTbn, Trieuchung, BSkham from DanhSachBenhNhan where Tinhtrang = N'" + "Chưa Khám" + "'";
            SqlDataAdapter dat = new SqlDataAdapter(sqlrs, ketnoi);
            DataSet ds = new System.Data.DataSet();
            dat.Fill(ds, "DanhSachBenhNhan");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void comboBoxchuandoan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
