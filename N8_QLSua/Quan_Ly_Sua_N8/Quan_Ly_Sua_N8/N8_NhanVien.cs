using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Sua_N8
{
    internal class N8_NhanVien
    {
        private KetNoi kn;
        public N8_NhanVien()
        {
            kn = new KetNoi();
        }
        public DataTable LayDSNV()
        {
            string sql = "SELECT * FROM NhanVien";
            return kn.Readdata(sql);
        }
        public void CreateNV(string HoTen, DateTime NgaySinh, string GioiTinh, string DiaChi, string SoDienThoai, byte[] HinhAnh, decimal SoNgayDiLam)
        {
            string sql = "INSERT INTO NhanVien (HoTen, NgaySinh, GioiTinh, DiaChi, SoDienThoai, HinhAnh, SoNgayDiLam) VALUES (@a, @b, @c, @d, @e, @h, @n)";


            SqlParameter[] sp = new SqlParameter[]
            {
                 new SqlParameter("@a", HoTen),
                 new SqlParameter("@b", NgaySinh),
                 new SqlParameter("@c", GioiTinh),
                 new SqlParameter("@d", DiaChi),
                 new SqlParameter("@e", SoDienThoai),
                 new SqlParameter("@h", (object)HinhAnh ?? DBNull.Value),
                 new SqlParameter("@n", SoNgayDiLam)


            };
            kn.CreateUpdateDelete(sql, sp);
        }




        public void UpdateNV(int MaNhanVien, string HoTen, DateTime NgaySinh, string GioiTinh, string DiaChi, string SoDienThoai, byte[] HinhAnh, decimal SoNgayDiLam)
        {
            string sql = "UPDATE NhanVien SET HoTen=@a,NgaySinh=@b,GioiTinh=@c,DiaChi=@d,SoDienThoai=@e, HinhAnh = @h, SoNgayDiLam = @n WHERE MaNhanVien = @f";
            SqlParameter[] sp = new SqlParameter[]
                 {
                 new SqlParameter("@a", HoTen),
                 new SqlParameter("@b", NgaySinh),
                 new SqlParameter("@c", GioiTinh),
                 new SqlParameter("@d", DiaChi),
                 new SqlParameter("@e", SoDienThoai),
                 new SqlParameter("@f", MaNhanVien),
                  new SqlParameter("@h", (object)HinhAnh ?? DBNull.Value),
                 new SqlParameter("@n", SoNgayDiLam)

                 };
            kn.CreateUpdateDelete(sql, sp);

        }
        public void XoaNV(string MaNhanVien)
        {
            string sql = "DELETE FROM NhanVien WHERE MaNhanVien = @MaNhanVien";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
            new SqlParameter("@MaNhanVien", MaNhanVien)
            };
            kn.CreateUpdateDelete(sql, sqlParameters);
        }
        public DataTable TimKiemMa(string MaNhanVien)
        {
            string sql = "SELECT * FROM NhanVien WHERE MaNhanVien = @MaNhanVien";
            SqlParameter[] sp = new SqlParameter[]
            {
            new SqlParameter("@MaNhanVien", MaNhanVien)
            };
            return kn.Readdata(sql, sp);
        }
        public DataTable TimKiemTen(string HoTen)
        {
            string sql = "SELECT * FROM NhanVien WHERE HoTen LIKE @HoTen";
            SqlParameter[] sp = new SqlParameter[]
            {
            new SqlParameter("@HoTen", "%" + HoTen + "%")
            };
            return kn.Readdata(sql,sp);
        }
        public DataTable GetThuNhapNhanVien()
        {
            string query = "SELECT MaNhanVien, HoTen, DiaChi,SoNgayDiLam  FROM NhanVien";
            return kn.Readdata(query);
        }

    }
}
