using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace Quan_Ly_Sua_N8
{
    public partial class ThuNhapNhanVien : Form
    {
        N8_NhanVien n8_NhanVien = new N8_NhanVien();
        public ThuNhapNhanVien()
        {
            InitializeComponent();
            TaiDuLieu();
        }
        private void TaiDuLieu()
        {
            var nhanVien = n8_NhanVien.GetThuNhapNhanVien();
            nhanVien.Columns.Add("TongThuNhap", typeof(int));

            foreach (DataRow row in nhanVien.Rows)
            {
                int soNgayDiLam = Convert.ToInt32(row["SoNgayDiLam"]);
                row["TongThuNhap"] = TinhTongThuNhap(soNgayDiLam);
            }

            dataGridView1.DataSource = nhanVien;
        }
        int TinhTongThuNhap(int soNgayDiLam)
        {
            int tong = soNgayDiLam * 300000;
            return tong;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }
        private void ExportToExcel()
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Excel.Application excelApp = new Excel.Application();
                    Excel.Workbook workbook = excelApp.Workbooks.Add();
                    Excel.Worksheet worksheet = workbook.Sheets[1];

                    DataTable dt = (DataTable)dataGridView1.DataSource;

                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1] = dt.Columns[i].ColumnName;
                    }

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < dt.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = dt.Rows[i][j];
                        }
                    }

                    workbook.SaveAs(sfd.FileName);

                    Marshal.ReleaseComObject(worksheet);
                    Marshal.ReleaseComObject(workbook);
                    Marshal.ReleaseComObject(excelApp);

                    MessageBox.Show("Xuất dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}