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
    public partial class DoiMatKhau : Form
    {
        string chuoikn = "";
        SqlConnection ketnoi;
        SqlDataAdapter bodocghi;

        void ketnoicsdl()
        {
            chuoikn = global::DACS1_QLPKB.Properties.Settings.Default.DoAnQLPKConnectionString1;
            ketnoi = new SqlConnection(chuoikn);


            string sql = "select * from BacSi";
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            bodocghi = new SqlDataAdapter();
            bodocghi.SelectCommand = cmd;
            DataTable dt = new DataTable();
            bodocghi.Fill(dt);

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Tenbs";
            comboBox1.ValueMember = "Tenbs";
        }
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }

        private void buttondongy_Click(object sender, EventArgs e)
        {
            string sql = "select count (*) from BacSi where Tenbs = N'"+ comboBox1.Text +"'  and Taikhoan = N'" + textBoxtaikhoan.Text + "' and MatKhau = N'" + textBoxpasscu.Text + "'";
            bodocghi = new SqlDataAdapter(sql, ketnoi);
            DataTable dt = new DataTable();
            bodocghi.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                if (textBoxpassmoi.Text == textBoxrepassmoi.Text)
                {
                    string ssql = "update BacSi set MatKhau = N'" + textBoxpassmoi.Text + "' where Taikhoan = '" + textBoxtaikhoan.Text + "' and MatKhau = N'" + textBoxpasscu.Text + "'";
                    SqlDataAdapter da = new SqlDataAdapter(ssql, ketnoi);
                    DataTable dt1 = new DataTable();
                    da.Fill(dt1);
                    MessageBox.Show("Đổi mật khẩu thành công !", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Còn thông tin bạn chưa điền!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu bạn chưa đúng!", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonthoat_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn Có Muốn Thoát Hay Không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
                this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
