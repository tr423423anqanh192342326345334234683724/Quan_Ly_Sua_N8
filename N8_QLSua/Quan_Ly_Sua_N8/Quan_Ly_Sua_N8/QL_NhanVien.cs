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
    public partial class QL_NhanVien : Form
    {
        N8_NhanVien nv = new N8_NhanVien();
        private byte[] imageData = null;

        public QL_NhanVien()
        {
            InitializeComponent();
            dgvDSNV.DataSource = nv.LayDSNV();
        }
        private void LoadData()
        {
            dgvDSNV.DataSource = nv.LayDSNV();
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDSNV.Rows[e.RowIndex];
                txtMNV.Text = row.Cells["MaNhanVien"].Value.ToString();
                txtHT.Text = row.Cells["HoTen"].Value.ToString();
                dtNS.Text = row.Cells["NgaySinh"].Value.ToString();
                cbGT.Text = row.Cells["GioiTinh"].Value.ToString();
                txtDC.Text = row.Cells["DiaChi"].Value.ToString();
                txtSDT.Text = row.Cells["SoDienThoai"].Value.ToString();
                if (row.Cells["hinhAnh"].Value != null && row.Cells["hinhAnh"].Value != DBNull.Value)
                {
                    byte[] imageData = (byte[])row.Cells["hinhAnh"].Value;
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        ptbanh.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    ptbanh.Image = null;
                }
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            try
            {
                nv.CreateNV(
                    txtHT.Text,
                    dtNS.Value,
                    cbGT.Text,
                    txtDC.Text,
                    txtSDT.Text,
                    imageData,
                    decimal.Parse(txtsndl.Text)
                    );
                
                MessageBox.Show("Thêm thành công!");
                

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                nv.UpdateNV(
                    int.Parse(txtMNV.Text),
                    txtHT.Text, dtNS.Value,
                    cbGT.Text, txtDC.Text,
                    txtSDT.Text, imageData,
                    decimal.Parse(txtsndl.Text)
                    );
                MessageBox.Show("Cập nhật sách thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                nv.XoaNV(txtMNV.Text);
                MessageBox.Show("Xóa sách thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnchonanh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ptbanh.Image = Image.FromFile(ofd.FileName);
                    imageData = File.ReadAllBytes(ofd.FileName);
                }
            }
        }

        private void ptbanh_Click(object sender, EventArgs e)
        {
            this.ptbanh.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
