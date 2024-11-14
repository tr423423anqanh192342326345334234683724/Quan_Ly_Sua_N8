using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Sua_N8
{
    internal class N8_PhieuNhap
    {
        KetNoi kn;
        public N8_PhieuNhap()
        {
            kn = new KetNoi();
        }

        public DataTable LayDuLieu()
        {
            string sql = "SELECT * FROM PhieuNhap";
            return kn.ReadData(sql);
        }
        public void ThemPhieu(int manhanvien, DateTime ngaynhap, string tenncc, decimal tong)
        {
            string sql = "INSERT INTO PhieuNhap (MaNhanVien,NgayNhap,TenNCC,Tong) VALUES (@MaNhanVien,@NgayNhap,@TenNCC,@Tong)";
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@MaNhanVien", manhanvien),
                new SqlParameter("@NgayNhap", ngaynhap),
                new SqlParameter("@TenNCC", tenncc),
                new SqlParameter("@Tong", tong),
               
            };
            kn.CreateUpdateDelete(sql, sqlParams);
        }

       
        public void SuaPhieu(int maphieu,int manhanvien, DateTime ngaynhap, string tenncc, decimal tong)
        {
            string sql = "UPDATE PhieuNhap SET MaNhanVien = @MaNhanVien, NgayNhap = @NgayNhap, TenNCC = @TenNCC, Tong = @Tong WHERE MaPhieu = @MaPhieu";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@MaPhieu", maphieu),
                 new SqlParameter("@MaNhanVien", manhanvien),
                new SqlParameter("@NgayNhap",  ngaynhap),
                new SqlParameter("@TenNCC",  tenncc),
                new SqlParameter("@Tong", tong),
            };
            kn.CreateUpdateDelete(sql, sqlParameters);
        }
        public void XoaPN(string maphieu)
        {
            string sql = "DELETE FROM PhieuNhap WHERE MaPhieu = @MaPhieu";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@MaPhieu", maphieu)
            };
            kn.CreateUpdateDelete(sql, sqlParameters);
        }
    }
}
