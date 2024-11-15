using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            decimal tongTien = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                tongTien += Convert.ToDecimal(row.Cells["TongTien"].Value);
            }
            MessageBox.Show("Tổng thu nhập: " + tongTien.ToString("C"));
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string luaChon = comboBox1.SelectedItem.ToString();
                DataTable hoaDonThuNhap = null;

                if (luaChon == "Tháng")
                {
                    hoaDonThuNhap = n8_HoaDon.GetHoaDonThuNhapTheoThang(textBox1.Text);
                }
                else if (luaChon == "Năm")
                {
                    hoaDonThuNhap = n8_HoaDon.GetHoaDonThuNhapTheoNam(textBox1.Text);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn tháng hoặc năm!");
                    return;
                }

                dataGridView1.DataSource = hoaDonThuNhap;

                // Tính tổng tiền
                decimal tongTien = hoaDonThuNhap.AsEnumerable().Sum(row => row.Field<decimal>("TongTien"));
                MessageBox.Show("Tổng thu nhập: " + tongTien.ToString("C"));
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tháng hoặc năm!");
            }
        }

        private void btn_thangtruoc_Click(object sender, EventArgs e)
        {
            string thangTruoc = DateTime.Now.AddMonths(-1).ToString("MM/yyyy");
            MessageBox.Show("Tháng trước: " + thangTruoc);
        }
    }
}