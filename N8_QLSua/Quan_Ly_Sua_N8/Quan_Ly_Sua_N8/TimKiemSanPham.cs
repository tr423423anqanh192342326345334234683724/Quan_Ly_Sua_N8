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
    public partial class TimKiemSanPham : Form
    {
        N8_SanPham sp = new N8_SanPham();
        public TimKiemSanPham()
        {
            InitializeComponent();
            InitializeComboBox();
            LoadData();
        }

        private void InitializeComboBox()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new string[] {
                "Mã Sản Phẩm",
                "Tên Sản Phẩm"
            });
            comboBox1.SelectedIndex = 0; // Chọn "Mã Sản Phẩm" làm mặc định
        }

        public void LoadData()
        {
            if (string.IsNullOrEmpty(txtTimKiem.Text))
            {
                dataGridView1.DataSource = sp.LayDuLieu();
            }
            else
            {
                string loaiTimKiem = comboBox1.SelectedItem?.ToString() ?? "Mã Sản Phẩm";
                dataGridView1.DataSource = sp.TimKiemSanPham(txtTimKiem.Text, loaiTimKiem);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm");
                return;
            }

            LoadData();

            // Kiểm tra nếu có dữ liệu trong bảng kết quả
            if (dataGridView1.Rows.Count > 0)
            {
                // Lấy dữ liệu ảnh từ dòng đầu tiên của kết quả
                byte[] imageData = dataGridView1.Rows[0].Cells["HinhAnh"].Value as byte[];

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
                    ptbanh.Image = null; // Xóa ảnh hiện tại nếu không có ảnh mới
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm.");
                ptbanh.Image = null;
            }
        }

        private void btnThoatTimKiem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
