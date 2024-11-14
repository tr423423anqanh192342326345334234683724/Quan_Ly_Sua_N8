using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            // Biến lưu dữ liệu tìm kiếm
            DataTable ketQua;

            if (giatri == "MaKhachHang")
            {
                ketQua = nv.TimKiemMa(tim);
            }
            else if (giatri == "HoVaTen")
            {
                ketQua = nv.TimKiemTen(tim);
            }
            else
            {
                return;
            }

            // Hiển thị dữ liệu lên DataGridView
            dgvDSNV.DataSource = ketQua;

            // Kiểm tra nếu có dữ liệu tìm thấy
            if (ketQua.Rows.Count > 0)
            {
                // Lấy dữ liệu ảnh từ dòng đầu tiên của kết quả
                byte[] imageData = (byte[])ketQua.Rows[0]["HinhAnh"];

                if (imageData != null)
                {
                    // Chuyển đổi byte[] thành Image và hiển thị trong PictureBox
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        ptbanh.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    ptbanh.Image = null; // Nếu không có ảnh thì xóa ảnh trong PictureBox
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên!");
                ptbanh.Image = null;
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
