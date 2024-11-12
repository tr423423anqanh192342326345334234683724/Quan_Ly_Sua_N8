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
    internal class N8_SanPham
    {
        KetNoi kn;
        public N8_SanPham() 
        {
            kn = new KetNoi();
        }

        public DataTable LayDuLieu()
        {
            string sql = "SELECT * FROM SanPham";
            return kn.ReadData(sql);
        }
        
        public void ThemSP(string HangSanXuat, DateTime HanSuDung, string MoTa, decimal Gia, int SoLuong, string LoaiSanPham, byte[] HinhAnh)
        {
            string sql = "INSERT INTO SanPham (HangSanXuat,HanSuDung,MoTa,Gia,SoLuong,LoaiSanPham,HinhAnh) VALUES (@HangSanXuat,@HanSuDung,@MoTa,@Gia,@SoLuong,@LoaiSanPham,@HinhAnh)";
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@HangSanXuat", HangSanXuat),
                new SqlParameter("@HanSuDung", HanSuDung),
                new SqlParameter("@MoTa", MoTa),
                new SqlParameter("@Gia", Gia),
                new SqlParameter("@SoLuong", SoLuong),
                new SqlParameter("@LoaiSanPham", LoaiSanPham),
                new SqlParameter("@HinhAnh", (object)HinhAnh ?? DBNull.Value)
            };
            kn.CreateUpdateDelete(sql, sqlParams);
        }
        public void SuaSP(int MaSanPham, string HangSanXuat, DateTime HanSuDung, string MoTa, decimal Gia, int SoLuong, string LoaiSanPham, byte[] HinhAnh)
        {
            string sql = "UPDATE SanPham SET HangSanXuat=@HangSanXuat, HanSuDung=@HanSuDung, MoTa=@MoTa, Gia=@Gia, SoLuong=@SoLuong, LoaiSanPham=@LoaiSanPham, HinhAnh=@HinhAnh WHERE MaSanPham=@MaSanPham";
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@MaSanPham", MaSanPham),
                new SqlParameter("@HangSanXuat", HangSanXuat),
                new SqlParameter("@HanSuDung", HanSuDung),
                new SqlParameter("@MoTa", MoTa),
                new SqlParameter("@Gia", Gia),
                new SqlParameter("@SoLuong", SoLuong),
                new SqlParameter("@LoaiSanPham", LoaiSanPham),
                new SqlParameter("@HinhAnh", (object)HinhAnh ?? DBNull.Value)
            };
            kn.CreateUpdateDelete(sql, sqlParams);
        }
        public void XoaSP(int MaSanPham)
        {
            string sql = "DELETE FROM SanPham WHERE MaSanPham=@MaSanPham";
            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@MaSanPham", MaSanPham)
            };
            kn.CreateUpdateDelete(sql, sqlParams);
        }

        internal void SuaSP(int maSanPham, string text1, DateTime value, string text2, decimal v1, int v2, string text3, Image image)
        {
            throw new NotImplementedException();
        }
        public DataTable TimKiemSanPham(string tuKhoa, string loaiTimKiem)
        {
            string sql = "";
            switch (loaiTimKiem)
            {
                case "Mã Sản Phẩm":
                    sql = "SELECT * FROM SanPham WHERE MaSanPham LIKE @TuKhoa";
                    break;
                case "Tên Sản Phẩm":
                    sql = "SELECT * FROM SanPham WHERE HangSanXuat LIKE @TuKhoa";
                    break;
                default:
                    sql = "SELECT * FROM SanPham WHERE MaSanPham LIKE @TuKhoa OR HangSanXuat LIKE @TuKhoa";
                    break;
            }

            SqlParameter[] sqlParams = new SqlParameter[]
            {
                new SqlParameter("@TuKhoa", "%" + tuKhoa + "%")
            };

            return kn.ReadData(sql, sqlParams);
        }
    }    
}
