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
    public partial class DSToa : Form
    {
        string chuoikn = "";
        SqlConnection ketnoi;
        SqlDataAdapter bodocghi;

        void ketnoicsdl()
        {
            chuoikn = global::DACS1_QLPKB.Properties.Settings.Default.DoAnQLPKConnectionString1;
            ketnoi = new SqlConnection(chuoikn);
        }
        public DSToa()
        {
            InitializeComponent();
        }
        void napdstoa()
        {
            ketnoi.Open();
            string sql = "select IDtoa, Tenbn, SDTbn, Benh, BSkham, Ngaykham from ToaThuoc where Thanhtoan = N'"+ "Chưa Thanh Toán" +"' ";
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            cmd.CommandType = CommandType.Text;
            bodocghi = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            bodocghi.Fill(dt);
            ketnoi.Close();
            dataGridView1.DataSource = dt;
        }

        private void DSToa_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
            napdstoa();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            ClassBenhNhan.IDTOA = dataGridView1.SelectedRows[0].Cells["IDtoa"].Value.ToString();
            ClassBenhNhan.TENBN = dataGridView1.SelectedRows[0].Cells["Tenbn"].Value.ToString();
            ClassBenhNhan.BENH = dataGridView1.SelectedRows[0].Cells["Benh"].Value.ToString();
            ClassBenhNhan.BSKHAM = dataGridView1.SelectedRows[0].Cells["BSkham"].Value.ToString();
            ClassBenhNhan.SDTBN = dataGridView1.SelectedRows[0].Cells["SDTbn"].Value.ToString();
            ClassBenhNhan.NGAYK = dataGridView1.SelectedRows[0].Cells["Ngaykham"].Value.ToString();
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
