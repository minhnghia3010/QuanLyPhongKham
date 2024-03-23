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
    public partial class ThemNV : Form
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
            if (textBoxtennv.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxtennv.Focus();
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
            if (textBoxluong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập lương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxluong.Focus();
                return false;
            }
            return true;
        }

        public ThemNV()
        {
            InitializeComponent();
        }

        private void ThemNV_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }

        private void buttonthem_Click(object sender, EventArgs e)
        {
            if (KTThongTin())
            {
                try
                {
                    string sql = string.Format("insert into NhanVien VALUES (N'{0}','{1}',N'{2}','{3}')", textBoxtennv.Text, textBoxsdt.Text, textBoxdiachi.Text, textBoxluong.Text);
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
            textBoxtennv.Text = "";
            textBoxdiachi.Text = "";
            textBoxsdt.Text = "";
            textBoxluong.Text = "";
        }

        private void buttonthoat_Click(object sender, EventArgs e)
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
