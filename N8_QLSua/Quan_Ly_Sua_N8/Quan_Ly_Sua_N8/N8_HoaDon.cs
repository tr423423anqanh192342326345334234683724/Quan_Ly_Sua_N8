using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Sua_N8
{
    internal class N8_HoaDon
    {
        KetNoi kn;
        public N8_HoaDon()
        {
            kn = new KetNoi();
        }
        public DataTable GetHoaDon()
        {
            string sql = "SELECT * FROM HoaDon";
            return kn.Readdata(sql);
        }
        public void ThemHD(DateTime ngayban, int manv, int makh, int masp, int soluong, Decimal tongtien)
        {
            string sql = "INSERT INTO HoaDon (NgayBan, MaNhanVien, MaKhachHang, MaSanPham, SoLuong, TongTien) VALUES (@NgayBan, @MaNhanVien, @MaKhachHang, @MaSanPham, @SoLuong, @TongTien )";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@NgayBan", ngayban),
                new SqlParameter("@MaNhanVien", manv),
                new SqlParameter("@MaKhachHang", makh),
                new SqlParameter("@MaSanPham", masp),
                new SqlParameter("@SoLuong", soluong),
                new SqlParameter("@TongTien", tongtien)
            };
            kn.CreateUpdateDelete(sql, sqlParameters);
        }
        public void SuaHD(int mahd, DateTime ngayban, int manv, int makh, int masp, int soluong, Decimal tongtien)
        {
            string sql = "UPDATE HoaDon SET NgayBan = @NgayBan, MaNhanVien = @MaNhanVien, MaKhachHang = @MaKhachHang, MaSanPham = @MaSanPham, SoLuong = @SoLuong, TongTien = @TongTien WHERE MaHoaDon = @MaHoaDon";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@MaHoaDon", mahd),
                new SqlParameter("@NgayBan", ngayban),
                new SqlParameter("@MaNhanVien", manv),
                new SqlParameter("@MaKhachHang", makh),
                new SqlParameter("@MaSanPham", masp),
                new SqlParameter("@SoLuong", soluong),
                new SqlParameter("@TongTien", tongtien)
            };
            kn.CreateUpdateDelete(sql, sqlParameters);
        }
        public void XoaHD(string mahd)
        {
            string sql = "DELETE FROM HoaDon WHERE MaHoaDon = @MaHoaDon";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@MaHoaDon", mahd)
            };
            kn.CreateUpdateDelete(sql, sqlParameters);
        }
    }
}
