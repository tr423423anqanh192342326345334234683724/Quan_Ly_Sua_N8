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
    public partial class QL_HoaDon : Form
    {
        N8_HoaDon hd = new N8_HoaDon();
        public QL_HoaDon()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            DataTable dt = hd.GetHoaDon();

            if (!dt.Columns.Contains("TongTien"))
            {
                dt.Columns.Add("TongTien", typeof(decimal));
                foreach (DataRow row in dt.Rows)
                {
                    int soLuong = Convert.ToInt32(row["SoLuong"]);
                    decimal donGia = Convert.ToDecimal(row["DonGia"]);
                    row["TongTien"] = soLuong * donGia;
                }
            }
            dgv_hd.DataSource = dt;

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                hd.ThemHD(dt_ngayban.Value,int.Parse(tb_mnv.Text), int.Parse(tb_mkh.Text), int.Parse(tb_msp.Text), int.Parse(tb_sl.Text), decimal.Parse(tb_dongia.Text));
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
                hd.SuaHD(int.Parse(tb_mhd.Text), dt_ngayban.Value, int.Parse(tb_mnv.Text), int.Parse(tb_mkh.Text), int.Parse(tb_msp.Text), int.Parse(tb_sl.Text), decimal.Parse(tb_dongia.Text));
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
                hd.XoaHD(tb_mhd.Text);
                MessageBox.Show("Xóa sách thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
