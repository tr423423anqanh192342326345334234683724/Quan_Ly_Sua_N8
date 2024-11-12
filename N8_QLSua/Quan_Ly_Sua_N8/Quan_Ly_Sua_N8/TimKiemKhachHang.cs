using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Sua_N8
{
    public partial class TimKiemKhachHang : Form
    {
        N8_KhachHang kh = new N8_KhachHang();
        public TimKiemKhachHang()
        {
            InitializeComponent();
            cbb_khoa.Items.Add("MaKhachHang");
            cbb_khoa.Items.Add("HoVaTen");
            cbb_khoa.SelectedIndex = 0;
        }

        private void btn_ketqua_Click(object sender, EventArgs e)
        {
            string giatri = cbb_khoa.SelectedItem.ToString();
            string tim = tb_nd.Text.Trim();
            if (giatri == "MaKhachHang")
            {
                dgv_timkh.DataSource = kh.TimKiemMa(tim);
            }
            if (giatri == "HoVaTen")
            {
                dgv_timkh.DataSource = kh.TimKiemTen(tim);
            }
        }

        private void TimKiemKhachHang_Load(object sender, EventArgs e)
        {
            dgv_timkh.DataSource = kh.GetKhachHang();
        }
    }
}
