using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DACS1_QLPKB
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            SettingHeThong f = new SettingHeThong();
            addform(f);
        }
        private void addform(Form f)
        {
            this.panel1.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.Text = f.Text;
            this.panel1.Controls.Add(f);
            f.Show();
        }

        private void capnhathethongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingHeThong f = new SettingHeThong();
            addform(f);
        }

        private void doimkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiMatKhau f = new DoiMatKhau();
            addform(f);
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn Có Muốn Thoát Hay Không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
                Application.Exit();
        }

        private void bacsiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinBS f = new ThongTinBS();
            addform(f);
        }

        private void nhanvienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinNV f = new ThongTinNV();
            addform(f);
        }

        private void donthuocToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThongTinDT f = new ThongTinDT();
            addform(f);
        }

        private void tracuubenhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinBenh f = new ThongTinBenh();
            addform(f);
        }

        private void benhnhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinBenhNhan f = new ThongTinBenhNhan();
            addform(f);
        }

        private void khambenhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KhamBenh f = new KhamBenh();
            addform(f);
        }

        private void kethuocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KeThuoc f = new KeThuoc();
            addform(f);
        }

        private void tracuuhoadonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DSHoaDon f = new DSHoaDon();
            addform(f);
        }

        private void thongkengayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeNgay f = new ThongKeNgay();
            addform(f);
        }
    }
}
