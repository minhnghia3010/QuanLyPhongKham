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
    public partial class SettingHeThong : Form
    {
        string chuoikn = "";
        SqlConnection ketnoi;
        void ketnoicsdl()
        {
            chuoikn = global::DACS1_QLPKB.Properties.Settings.Default.DoAnQLPKConnectionString1;
            ketnoi = new SqlConnection(chuoikn);

            ketnoi.Open();
            string sql = @"select * from HeThong ";
            SqlDataAdapter da = new SqlDataAdapter(sql, ketnoi);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                textBoxtenpk.Text = dt.Rows[0]["Tenht"].ToString().Trim();
                textBoxtimework.Text = dt.Rows[0]["Giolam"].ToString().Trim();
                textBoxsdt.Text = dt.Rows[0]["SDT"].ToString().Trim();
                textBoxdiachi.Text = dt.Rows[0]["DiaChi"].ToString().Trim();
                textBoxemail.Text = dt.Rows[0]["DiachiEmail"].ToString().Trim();
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin này", "Thông báo !");
            }
            ketnoi.Close();
        }
        public SettingHeThong()
        {
            InitializeComponent();
        }

        private void SettingHeThong_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }

        private void buttonthoat_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn Có Muốn Thoát Hay Không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
                this.Close();
        }
        public bool KTThongTin()
        {
            if (textBoxtenpk.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên phòng khám", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxtenpk.Focus();
                return false;
            }
            if (textBoxtimework.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thời gian làm việc của bác sĩ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxtimework.Focus();
                return false;
            }
            if (textBoxsdt.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số điện thoại bác sĩ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxsdt.Focus();
                return false;
            }
            if (textBoxdiachi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxdiachi.Focus();
                return false;
            }
            if (textBoxemail.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxemail.Focus();
                return false;
            }
            return true;
        }

        private void buttoncapnhat_Click(object sender, EventArgs e)
        {
            if (KTThongTin())
            {
                try
                {
                    ketnoi.Open();
                    string sql = ("update HeThong set Tenht = N'" + textBoxtenpk.Text + "', Diachi = N'" + textBoxdiachi.Text + "', Giolam = N'" + textBoxtimework.Text + "', SDT = '" + textBoxsdt.Text + "', DiachiEmail = N'" + textBoxemail.Text + "'");
                    SqlCommand cmd = new SqlCommand(sql, ketnoi);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ketnoi.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBoxsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
