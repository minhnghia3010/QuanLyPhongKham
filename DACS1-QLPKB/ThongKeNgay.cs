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
    public partial class ThongKeNgay : Form
    {
        string chuoikn = "";
        SqlConnection ketnoi;
        SqlDataAdapter bodocghi;

        void ketnoicsdl()
        {
            chuoikn = global::DACS1_QLPKB.Properties.Settings.Default.DoAnQLPKConnectionString1;
            ketnoi = new SqlConnection(chuoikn);

           
        }

        void timngay()
        {
            ketnoi.Open();
            string sql = "select * from HoaDon where Ngaykham >= '"+ dateTimePicker1.Value.ToString("MM/dd/yyyy") + "' and Ngaykham <= '"+ dateTimePicker2.Value.ToString("MM/dd/yyyy") + "' ";
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            cmd.CommandType = CommandType.Text;
            bodocghi = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            bodocghi.Fill(dt);
            ketnoi.Close();
            dataGridView1.DataSource = dt;
        }

        public ThongKeNgay()
        {
            InitializeComponent();
        }

        private void ThongKeNgay_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
            
        }

        private void buttontimkiem_Click(object sender, EventArgs e)
        {
            timngay();
        }
    }
}
