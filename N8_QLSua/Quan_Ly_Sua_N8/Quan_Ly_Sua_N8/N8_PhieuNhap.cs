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
        private KetNoi kn;

        public N8_PhieuNhap()
        {
            kn = new KetNoi();
        }

        public DataTable LayDuLieu()
        {
            string sql = "SELECT * FROM PhieuNhap";
            return kn.Readdata(sql);
        }

        public void ThemPhieu(int manhanvien, int masanpham, DateTime ngaynhap, string tenncc, int soluong)
        {
            string sql = "INSERT INTO PhieuNhap (MaNhanVien, MaSanPham, NgayNhap, TenNCC, SoLuong) VALUES (@MaNhanVien, @MaSanPham, @NgayNhap, @TenNCC, @SoLuong)";
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@MaNhanVien", manhanvien),
                new SqlParameter("@MaSanPham", masanpham),
                new SqlParameter("@NgayNhap", ngaynhap),
                new SqlParameter("@TenNCC", tenncc),
                new SqlParameter("@SoLuong", soluong)
            };
            kn.CreateUpdateDelete(sql, sqlParams);
        }

        public void SuaPhieu(int maphieu, int manhanvien, int masanpham, DateTime ngaynhap, string tenncc, int soluong)
        {
            string sql = "UPDATE PhieuNhap SET MaNhanVien = @MaNhanVien, MaSanPham = @MaSanPham, NgayNhap = @NgayNhap, TenNCC = @TenNCC, SoLuong = @SoLuong WHERE MaPhieu = @MaPhieu";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@MaPhieu", maphieu),
                new SqlParameter("@MaNhanVien", manhanvien),
                new SqlParameter("@MaSanPham", masanpham),
                new SqlParameter("@NgayNhap", ngaynhap),
                new SqlParameter("@TenNCC", tenncc),
                new SqlParameter("@SoLuong", soluong)
            };
            kn.CreateUpdateDelete(sql, sqlParameters);
        }

        public void XoaPN(int maphieu)
        {
            string sql = "DELETE FROM PhieuNhap WHERE MaPhieu = @MaPhieu";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@MaPhieu", maphieu)
            };
            kn.CreateUpdateDelete(sql, sqlParameters);
        }

        public DataTable TimKiemPhieu(int maphieu)
        {
            string sql = "SELECT * FROM PhieuNhap WHERE MaPhieu = @MaPhieu";
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@MaPhieu", maphieu)
            };
            return kn.Readdata(sql, sqlParams);
        }

    }
}