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
    public partial class ThuNhapCuaHang : Form
    {
        private N8_HoaDon n8_HoaDon = new N8_HoaDon();

        public ThuNhapCuaHang()
        {
            InitializeComponent();
            TaiDuLieu();
        }

        private void TaiDuLieu()
        {
            var hoaDonThuNhap = n8_HoaDon.GetHoaDonThuNhap();
            dataGridView1.DataSource = hoaDonThuNhap;
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Tháng")
            {
                var hoaDonThuNhap = n8_HoaDon.GetHoaDonThuNhapTheoThang(textBox1.Text);
                dataGridView1.DataSource = hoaDonThuNhap;
            }
            else if (comboBox1.SelectedItem.ToString() == "Năm")
            {
                var hoaDonThuNhap = n8_HoaDon.GetHoaDonThuNhapTheoNam(textBox1.Text);
                dataGridView1.DataSource = hoaDonThuNhap;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tháng hoặc năm!");
            }
        }

        private void btn_thangtruoc_Click(object sender, EventArgs e)
        {
            string thangTruoc = DateTime.Now.AddMonths(-1).ToString("MM/yyyy");
            MessageBox.Show(thangTruoc);
        }
    }
}