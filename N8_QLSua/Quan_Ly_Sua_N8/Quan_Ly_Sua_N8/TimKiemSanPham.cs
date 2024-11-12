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
        }

        private void btnThoatTimKiem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
