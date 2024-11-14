using System;
using System.Data;
using System.Data.SqlClient;

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
            string sql = @"SELECT pn.MaPhieu, pn.MaNhanVien, pn.MaSanPham, pn.NgayNhap, pn.TenNCC, pn.SoLuong,
                           sp.Gia, (pn.SoLuong * sp.Gia) AS Tong
                           FROM PhieuNhap pn
                           JOIN SanPham sp ON pn.MaSanPham = sp.MaSanPham";
            return kn.Readdata(sql);
        }

       
        public void ThemPhieu(int manhanvien, int masanpham, DateTime ngaynhap, string tenncc, int soluong)
        {
           
            string sqlGia = "SELECT Gia FROM SanPham WHERE MaSanPham = @MaSanPham";
            SqlParameter[] paramGia = new SqlParameter[]
            {
                new SqlParameter("@MaSanPham", masanpham)
            };
            DataTable dtGia = kn.Readdata(sqlGia, paramGia);

            if (dtGia.Rows.Count > 0)
            {
                decimal gia = Convert.ToDecimal(dtGia.Rows[0]["Gia"]);
                decimal tong = soluong * gia;

               
                string sql = "INSERT INTO PhieuNhap (MaNhanVien, MaSanPham, NgayNhap, TenNCC, SoLuong, TongTien) VALUES (@MaNhanVien, @MaSanPham, @NgayNhap, @TenNCC, @SoLuong, @TongTien)";
                SqlParameter[] sqlParams = new SqlParameter[]
                {
                    new SqlParameter("@MaNhanVien", manhanvien),
                    new SqlParameter("@MaSanPham", masanpham),
                    new SqlParameter("@NgayNhap", ngaynhap),
                    new SqlParameter("@TenNCC", tenncc),
                    new SqlParameter("@SoLuong", soluong),
                    new SqlParameter("@TongTien", tong),
                };
                kn.CreateUpdateDelete(sql, sqlParams);
            }
        }

       
        public void SuaPhieu(int maphieu, int manhanvien, int masanpham, DateTime ngaynhap, string tenncc, int soluong)
        {
            
            string sqlGia = "SELECT Gia FROM SanPham WHERE MaSanPham = @MaSanPham";
            SqlParameter[] paramGia = new SqlParameter[]
            {
                new SqlParameter("@MaSanPham", masanpham)
            };
            DataTable dtGia = kn.Readdata(sqlGia, paramGia);

            if (dtGia.Rows.Count > 0)
            {
                decimal gia = Convert.ToDecimal(dtGia.Rows[0]["Gia"]);
                decimal tong = soluong * gia;

              
                string sql = "UPDATE PhieuNhap SET MaNhanVien = @MaNhanVien, MaSanPham = @MaSanPham, NgayNhap = @NgayNhap, TenNCC = @TenNCC, SoLuong = @SoLuong, TongTien = @TongTien WHERE MaPhieu = @MaPhieu";
                SqlParameter[] sqlParams = new SqlParameter[]
                {
                    new SqlParameter("@MaPhieu", maphieu),
                    new SqlParameter("@MaNhanVien", manhanvien),
                    new SqlParameter("@MaSanPham", masanpham),
                    new SqlParameter("@NgayNhap", ngaynhap),
                    new SqlParameter("@TenNCC", tenncc),
                    new SqlParameter("@SoLuong", soluong),
                    new SqlParameter("@TongTien", tong),
                };
                kn.CreateUpdateDelete(sql, sqlParams);
            }
        }

       
        public void XoaPN(int maphieu)
        {
            string sql = "DELETE FROM PhieuNhap WHERE MaPhieu = @MaPhieu";
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@MaPhieu", maphieu)
            };
            kn.CreateUpdateDelete(sql, sqlParams);
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
