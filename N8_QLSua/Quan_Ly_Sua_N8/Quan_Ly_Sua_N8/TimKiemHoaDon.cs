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
    public partial class TimKiemHoaDon : Form
    {
        private N8_HoaDon hd = new N8_HoaDon();
        public TimKiemHoaDon()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TimKiemHoaDon_Load(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(txtTimKiem.Text, out int mahd))
                {
                    DataTable dt = hd.TimKiemHoaDon(mahd);
                    dgvhd.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy phiếu nhập với mã phiếu này.");
                    }
                }
                else
                {
                    MessageBox.Show("Mã phiếu không hợp lệ.");
                }
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
    }
}
