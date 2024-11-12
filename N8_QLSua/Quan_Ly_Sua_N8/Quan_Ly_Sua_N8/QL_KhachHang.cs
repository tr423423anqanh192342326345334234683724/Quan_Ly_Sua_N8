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
    public partial class QL_KhachHang : Form
    {
        N8_KhachHang kh = new N8_KhachHang();
        public QL_KhachHang()
        {
            InitializeComponent();
            cbb_gt.Items.Add("Nam");
            cbb_gt.Items.Add("Nữ");
            cbb_gt.SelectedIndex = 0;
            dgv_kh.DataSource = kh.GetKhachHang();
        }
        private void LoadData()
        {
            dgv_kh.DataSource = kh.GetKhachHang();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                kh.ThemKH(tb_ten.Text, tb_sdt.Text, tb_dc.Text, cbb_gt.Text);
                MessageBox.Show("Thêm sách thành công!");
                LoadData();
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
                kh.SuaKH(int.Parse(tb_mkh.Text), tb_ten.Text, tb_sdt.Text, tb_dc.Text, cbb_gt.Text);
                MessageBox.Show("Cập nhật sách thành công!");
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
                kh.XoaKH(tb_mkh.Text);
                MessageBox.Show("Xóa sách thành công!");
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

        private void dgv_kh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_kh.Rows[e.RowIndex];
                tb_mkh.Text = row.Cells["MaKhachHang"].Value.ToString();
                tb_ten.Text = row.Cells["HoVaTen"].Value.ToString();
                tb_sdt.Text = row.Cells["SoDienThoai"].Value.ToString();
                tb_dc.Text = row.Cells["DiaChi"].Value.ToString();
                cbb_gt.Text = row.Cells["GioiTinh"].Value.ToString();
            }
        }
    }
}
