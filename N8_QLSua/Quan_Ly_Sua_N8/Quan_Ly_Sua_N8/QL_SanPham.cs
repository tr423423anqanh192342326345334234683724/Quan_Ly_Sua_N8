using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Quan_Ly_Sua_N8
{   
    
    public partial class QL_SanPham : Form
    {
        N8_SanPham sanPham = new N8_SanPham();
        private byte[] imageData = null;
        public QL_SanPham()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            dataGridView1.DataSource = sanPham.LayDuLieu();
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sanPham.ThemSP(
                    txtHangSanXuat.Text, 
                    dateHanSuDung.Value,
                    txtMoTa.Text, 
                    decimal.Parse(txtGia.Text), 
                    int.Parse(txtSoLuong.Text), 
                    txtLoaiSanPham.Text,
                    imageData
                );
                LoadData();
                MessageBox.Show("Thêm sản phẩm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int maSanPham = int.Parse(txtMaSanPham.Text);
                byte[] imageData = null;
                if (pictureBox1.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                        imageData = ms.ToArray();
                    }
                }
                sanPham.SuaSP(
                    maSanPham,
                    txtHangSanXuat.Text, 
                    dateHanSuDung.Value,
                    txtMoTa.Text, 
                    decimal.Parse(txtGia.Text), 
                    int.Parse(txtSoLuong.Text), 
                    txtLoaiSanPham.Text,
                    imageData
                );
                LoadData();
                MessageBox.Show("Sửa sản phẩm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    
        private void button3_Click(object sender, EventArgs e)
        {
            int maSanPham;
            if (int.TryParse(txtMaSanPham.Text, out maSanPham))
            {
                sanPham.XoaSP(maSanPham);
                LoadData();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm hợp lệ");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TimKiemSanPham timKiemSanPham = new TimKiemSanPham();
            timKiemSanPham.ShowDialog();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtMaSanPham.Text = row.Cells["maSanPham"].Value?.ToString() ?? "";
                txtHangSanXuat.Text = row.Cells["hangSanXuat"].Value?.ToString() ?? "";
                
                if (row.Cells["hanSuDung"].Value != null && row.Cells["hanSuDung"].Value != DBNull.Value)
                {
                    dateHanSuDung.Value = Convert.ToDateTime(row.Cells["hanSuDung"].Value);
                }
                else
                {
                    dateHanSuDung.Value = DateTime.Now;
                }
                
                txtMoTa.Text = row.Cells["moTa"].Value?.ToString() ?? "";
                txtGia.Text = row.Cells["gia"].Value?.ToString() ?? "";
                txtSoLuong.Text = row.Cells["soLuong"].Value?.ToString() ?? "";
                txtLoaiSanPham.Text = row.Cells["loaiSanPham"].Value?.ToString() ?? "";

                if (row.Cells["hinhAnh"].Value != null && row.Cells["hinhAnh"].Value != DBNull.Value)
                {
                    byte[] imageData = (byte[])row.Cells["hinhAnh"].Value;
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                    imageData = File.ReadAllBytes(ofd.FileName);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
