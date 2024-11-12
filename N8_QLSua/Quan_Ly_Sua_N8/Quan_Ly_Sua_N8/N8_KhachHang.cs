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
            return kn.ReadData(sql);
        }
        public void ThemKH(int ma, string ten,string sdt, string diachi )
        {
            string sql = "INSERT INTO KhachHang (MaKhachHang,HoVaTen,SoDienThoai,DiaChi) VALUES (@MaKhachHang,@HoVaTen,@SoDienThoai,@DiaChi)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@MaKhachHang", ma),
                new SqlParameter("@HoVaTen", ten),
                new SqlParameter("@SoDienThoai", sdt),
                new SqlParameter("@DiaChi", diachi)
            };
            kn.CreateUpdateDelete(sql, sqlParameters);
        }
    }
}
