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
    public partial class TimKiemNhanVien : Form
    {
        N8_NhanVien nv = new N8_NhanVien();

        public TimKiemNhanVien()
        {
            InitializeComponent();
            cbchon.Items.Add("MaKhachHang");
            cbchon.Items.Add("HoVaTen");
            cbchon.SelectedIndex = 0;

        }

        private void btnTIm_Click(object sender, EventArgs e)
        {
            string giatri = cbchon.SelectedItem.ToString();
            string tim = txtTimKiem.Text.Trim();
            if (giatri == "MaKhachHang")
            {
                dgvDSNV.DataSource = nv.TimKiemMa(tim);
            }
            if (giatri == "HoVaTen")
            {
                dgvDSNV.DataSource = nv.TimKiemTen(tim);
            }

        }

        private void TimKiemNhanVien_Load(object sender, EventArgs e)
        {
            dgvDSNV.DataSource = nv.LayDSNV();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
