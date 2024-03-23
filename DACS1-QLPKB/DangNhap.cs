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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MSI;Initial Catalog=DoAnQLPK;Integrated Security=True");
            try
            {
                con.Open();
                string tk = txttaikhoan.Text;
                string mk = txtmatkhau.Text;
                string sql = "select * from BacSi where TaiKhoan = '" + tk + "' and MatKhau =  '" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    MessageBox.Show("Đăng Nhập Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormMain fm = new FormMain();
                    fm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng Nhập Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txttaikhoan.Text = "";
                    txtmatkhau.Text = "";
                    txttaikhoan.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Kết Nối");
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn Có Muốn Thoát Hay Không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
                Application.Exit();
        }
    }
}
