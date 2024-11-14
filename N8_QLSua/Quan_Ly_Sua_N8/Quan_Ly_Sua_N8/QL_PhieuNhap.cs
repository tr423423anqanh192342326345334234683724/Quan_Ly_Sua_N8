using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Sua_N8
{
    public partial class QL_PhieuNhap : Form
    {
        N8_PhieuNhap pn = new N8_PhieuNhap();

        public QL_PhieuNhap()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dgvpn.DataSource = pn.LayDuLieu();
        }

        private void QL_PhieuNhap_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                pn.ThemPhieu(
                    int.Parse(tb_manv.Text),
                    int.Parse(tb_masp.Text),
                    dt_ngaynhap.Value,
                    tb_nhacungcap.Text,
                    int.Parse(tb_soluong.Text)
                );
                LoadData();
                MessageBox.Show("Thêm phiếu nhập thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                pn.SuaPhieu(
                    int.Parse(tb_maphieu.Text),
                    int.Parse(tb_manv.Text),
                    int.Parse(tb_masp.Text),
                    dt_ngaynhap.Value,
                    tb_nhacungcap.Text,
                    int.Parse(tb_soluong.Text)
                );
                MessageBox.Show("Cập nhật phiếu nhập thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                pn.XoaPN(int.Parse(tb_maphieu.Text));
                MessageBox.Show("Xóa phiếu nhập thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvpn_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvpn.Rows[e.RowIndex];

                tb_maphieu.Text = row.Cells["MaPhieu"].Value.ToString();
                tb_manv.Text = row.Cells["MaNhanVien"].Value.ToString();
                tb_masp.Text = row.Cells["MaSanPham"].Value.ToString();
                dt_ngaynhap.Value = Convert.ToDateTime(row.Cells["NgayNhap"].Value);
                tb_nhacungcap.Text = row.Cells["TenNCC"].Value.ToString();
                tb_soluong.Text = row.Cells["SoLuong"].Value.ToString();
                tb_tong.Text = row.Cells["TongTien"].Value.ToString();
            }
        }
    }
}
