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
    public partial class ThemBS : Form
    {
        string chuoikn = "";
        SqlConnection ketnoi;

        void ketnoicsdl()
        {
            chuoikn = global::DACS1_QLPKB.Properties.Settings.Default.DoAnQLPKConnectionString1;

            ketnoi = new SqlConnection(chuoikn);

        }

        public bool KTThongTin()
        {
            if (textBoxtenbsmoi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên bác sĩ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxtenbsmoi.Focus();
                return false;
            }
            if (textBoxdiachi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxdiachi.Focus();
                return false;
            }
            if (textBoxsdt.Text == "")
            {
                MessageBox.Show("Vui lòng nhập SĐT bác sĩ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxsdt.Focus();
                return false;
            }
            if (textBoxtaikhoan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản bác sĩ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxtaikhoan.Focus();
                return false;
            }
            if (textBoxmatkhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu bác sĩ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxmatkhau.Focus();
                return false;
            }
            return true;
        }
        public ThemBS()
        {
            InitializeComponent();
        }

        private void ThemBS_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (KTThongTin())
            {
                try
                {
                    string sql = string.Format("insert into BacSi VALUES (N'{0}','{1}',N'{2}','{3}','{4}')", textBoxtenbsmoi.Text, textBoxsdt.Text, textBoxdiachi.Text, textBoxtaikhoan.Text, textBoxmatkhau.Text);
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
            textBoxtenbsmoi.Text = "";
            textBoxdiachi.Text = "";
            textBoxsdt.Text = "";
            textBoxtaikhoan.Text = "";
            textBoxmatkhau.Text = "";
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn Có Muốn Thoát Hay Không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
                this.Close();
        }

        private void textBoxsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
