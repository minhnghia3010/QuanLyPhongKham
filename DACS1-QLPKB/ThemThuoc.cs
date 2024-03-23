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
    public partial class ThemThuoc : Form
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
            if (textBoxtenthuoc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên thuốc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxtenthuoc.Focus();
                return false;
            }
            if (textBoxgia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập giá thuốc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxgia.Focus();
                return false;
            }
            if (textBoxchucnang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập chức năng của thuốc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxchucnang.Focus();
                return false;
            }
            if (textBoxsoluong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng thuốc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxsoluong.Focus();
                return false;
            }
            return true;
        }
        public ThemThuoc()
        {
            InitializeComponent();
        }

        private void ThemThuoc_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }
        public void clear()
        {
            textBoxtenthuoc.Text = "";
            textBoxgia.Text = "";
            textBoxsoluong.Text = "";
            textBoxchucnang.Text = "";
        }

        private void buttonthoat_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn Có Muốn Thoát Hay Không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
                this.Close();
        }

        private void textBoxsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void buttonthem_Click(object sender, EventArgs e)
        {
            if (KTThongTin())
            {
                try
                {
                    string sql = string.Format("insert into Thuoc VALUES (N'{0}','{1}','{2}',N'{3}')", textBoxtenthuoc.Text, Convert.ToInt32(textBoxsoluong.Text), textBoxgia.Text, textBoxchucnang.Text);
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
    }
}
