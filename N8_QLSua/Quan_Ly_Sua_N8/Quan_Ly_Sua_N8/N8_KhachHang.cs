using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Quan_Ly_Sua_N8
{
    internal class N8_KhachHang
    {
        KetNoi kn;
        public N8_KhachHang()
        {
            kn = new KetNoi();
        }
        public DataTable GetKhachHang()
        {
            string sql = "SELECT * FROM KhachHang";
            return kn.Readdata(sql);
        }
        public void ThemKH(string ten, string sdt, string diachi, string gioitinh)
        {
            string sql = "INSERT INTO KhachHang (HoVaTen, SoDienThoai, DiaChi, GioiTinh) VALUES (@HoVaTen, @SoDienThoai, @DiaChi, @GioiTinh)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@HoVaTen", ten),
                new SqlParameter("@SoDienThoai", sdt),
                new SqlParameter("@DiaChi", diachi),
                new SqlParameter("@GioiTinh", gioitinh),
            };
            kn.CreateUpdateDelete(sql, sqlParameters);
        }
        public void SuaKH(int ma, string ten, string sdt, string diachi, string gioitinh)
        {
            string sql = "UPDATE KhachHang SET HoVaTen = @HoVaTen, SoDienThoai = @SoDienThoai, DiaChi = @DiaChi, GioiTinh = @GioiTinh WHERE MaKhachHang = @MaKhachHang";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@MaKhachHang", ma),
                new SqlParameter("@HoVaTen", ten),
                new SqlParameter("@SoDienThoai", sdt),
                new SqlParameter("@DiaChi", diachi),
                new SqlParameter("@GioiTinh", gioitinh),
            };
            kn.CreateUpdateDelete(sql, sqlParameters);
        }
        public void XoaKH(string makh)
        {
            string sql = "DELETE FROM KhachHang WHERE MaKhachHang = @MaKhachHang";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@MaKhachHang", makh)
            };
            kn.CreateUpdateDelete(sql, sqlParameters);
        }

        public DataTable TimKiemMa(string Makh)
        {
            string sql = "SELECT * FROM KhachHang WHERE MaKhachHang = @MaKhachHang";
            SqlParameter[] sp = new SqlParameter[]
            {
        new SqlParameter("@MaKhachHang", Makh)
            };
            return kn.Readdata(sql, sp);
        }

        public DataTable TimKiemTen(string Tenkh)
        {
            string sql = "SELECT * FROM KhachHang WHERE HoVaTen LIKE @HoVaTen";
            SqlParameter[] sp = new SqlParameter[]
            {
        new SqlParameter("@HoVaTen", "%" + Tenkh + "%")
            };
            return kn.Readdata(sql,sp);
        }
    }
}
