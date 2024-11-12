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
    public partial class QLBANSUA : Form
    {
        public QLBANSUA()
        {
            InitializeComponent();
        }

        private void CloseAllChildForms()
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
        }
        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            QL_NhanVien qlnv = new QL_NhanVien();
            qlnv.MdiParent = this;
            qlnv.Show();
        }

        private void tìmKiếmNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            TimKiemNhanVien tknv = new TimKiemNhanVien();
            tknv.MdiParent = this;
            tknv.Show();

        }

        private void thôngTinKháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            QL_KhachHang qlkh = new QL_KhachHang();
            qlkh.MdiParent = this;
            qlkh.Show();
        }

        private void tìmKiếmKháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            TimKiemKhachHang tkkh = new TimKiemKhachHang();
            tkkh.MdiParent = this;
            tkkh.Show();
        }

        private void thôngTinSảnPhẩmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            QL_SanPham qlsp = new QL_SanPham();
            qlsp.MdiParent = this;
            qlsp.Show();
        }

        private void tìmKiếmSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            TimKiemSanPham tksp = new TimKiemSanPham();
            tksp.MdiParent = this;
            tksp.Show();
        }

        private void tìmKiếmHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            TimKiemHoaDon tkhd = new TimKiemHoaDon();
            tkhd.MdiParent = this;
            tkhd.Show();
        }

        private void thôngTinPhiếuNhậpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            QL_PhieuNhap ctpn = new QL_PhieuNhap();
            ctpn.MdiParent = this;
            ctpn.Show();
        }

        private void tìmKiếmPhiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            TimKiemPhieuNhap tkpn = new TimKiemPhieuNhap();
            tkpn.MdiParent = this;
            tkpn.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void thôngTinHóaĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            QL_HoaDon qlhd = new QL_HoaDon();
            qlhd.MdiParent = this;
            qlhd.Show();
        }
    }
}
