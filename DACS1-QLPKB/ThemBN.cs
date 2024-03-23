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
    public partial class ThemBN : Form
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
            if (textBoxtenbn.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên bệnh nhân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxtenbn.Focus();
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
                MessageBox.Show("Vui lòng nhập SĐT bệnh nhân", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxsdt.Focus();
                return false;
            }
            return true;
        }
        public ThemBN()
        {
            InitializeComponent();
        }

        private void ThemBN_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }

        private void buttonthem_Click(object sender, EventArgs e)
        {
            if (KTThongTin())
            {
                try
                {
                    string Gioitinh = "";
                    if (radioButtonnam.Checked == true)
                    {
                        Gioitinh = radioButtonnam.Text;
                    }
                    if (radioButtonnu.Checked == true)
                    {
                        Gioitinh = radioButtonnu.Text;
                    }
                    string sql = string.Format("insert into BenhNhan(Tenbn, SDTbn, Diachibn, Gioitinh) VALUES (N'{0}', '{1}', N'{2}', N'{3}')", textBoxtenbn.Text, textBoxsdt.Text, textBoxdiachi.Text, Gioitinh);
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
            textBoxtenbn.Text = "";
            textBoxdiachi.Text = "";
            textBoxsdt.Text = "";
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
