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
            dgvpn.DataSource = pn.LayDuLieu();
        }
        private void LoadData()
        {
            dgvpn.DataSource = pn.LayDuLieu();
        }

        private void QL_PhieuNhap_Load(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                pn.ThemPhieu(
                     int.Parse(tb_manv.Text),
                    dt_ngaynhap.Value,
                    tb_nhacungcap.Text,
                    decimal.Parse(tb_tongg.Text)
                   
                   
                );
                LoadData();
                MessageBox.Show("Thêm sản phẩm thành công!");
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
                     dt_ngaynhap.Value,
                   tb_nhacungcap.Text,
                    decimal.Parse(tb_tongg.Text)
                    );
                MessageBox.Show("Cập nhật sách thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvpn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
          
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dgvpn.Rows[e.RowIndex];
                tb_maphieu.Text = row.Cells["MaPhieu"].Value.ToString();
                tb_manv.Text = row.Cells["MaNhanVien"].Value.ToString();
                dt_ngaynhap.Text = row.Cells["NgayNhap"].Value.ToString();
                tb_nhacungcap.Text = row.Cells["TenNCC"].Value.ToString();
                tb_tongg.Text = row.Cells["Tong"].Value.ToString();
                }
            

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                pn.XoaPN(tb_maphieu.Text);
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
    }
}
