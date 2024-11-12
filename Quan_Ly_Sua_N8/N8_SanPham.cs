using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quan_Ly_Sua_N8
{
    Ketnoi ketnoi = new Ketnoi();
    internal class N8_SanPham
    {
        public int MaSanPham { get; set; }
        public string HangSanXuat { get; set; }
        public DateTime HanSuDung { get; set; }
        public string MoTa { get; set; }
        public decimal Gia { get; set; }
        public int SoLuong { get; set; }
        public string LoaiSanPham { get; set; }
    }
    public void ThemSanPham(N8_SanPham sanPham)
    {
        string sql = "INSERT INTO SanPham (HangSanXuat, HanSuDung, MoTa, Gia, SoLuong, LoaiSanPham) VALUES (@HangSanXuat, @HanSuDung, @MoTa, @Gia, @SoLuong, @LoaiSanPham)";
        ketnoi.CreateUpdateDelete(sql, new SqlParameter("@HangSanXuat", sanPham.HangSanXuat), new SqlParameter("@HanSuDung", sanPham.HanSuDung), new SqlParameter("@MoTa", sanPham.MoTa), new SqlParameter("@Gia", sanPham.Gia), new SqlParameter("@SoLuong", sanPham.SoLuong), new SqlParameter("@LoaiSanPham", sanPham.LoaiSanPham));
    }
    public void SuaSanPham(N8_SanPham sanPham)
    {
        string sql = "UPDATE SanPham SET HangSanXuat = @HangSanXuat, HanSuDung = @HanSuDung, MoTa = @MoTa, Gia = @Gia, SoLuong = @SoLuong, LoaiSanPham = @LoaiSanPham WHERE MaSanPham = @MaSanPham";
        ketnoi.CreateUpdateDelete(sql, new SqlParameter("@HangSanXuat", sanPham.HangSanXuat), new SqlParameter("@HanSuDung", sanPham.HanSuDung), new SqlParameter("@MoTa", sanPham.MoTa), new SqlParameter("@Gia", sanPham.Gia), new SqlParameter("@SoLuong", sanPham.SoLuong), new SqlParameter("@LoaiSanPham", sanPham.LoaiSanPham), new SqlParameter("@MaSanPham", sanPham.MaSanPham));
    }
    public void XoaSanPham(int maSanPham)
    {
        string sql = "DELETE FROM SanPham WHERE MaSanPham = @MaSanPham";
        ketnoi.CreateUpdateDelete(sql, new SqlParameter("@MaSanPham", maSanPham));
    }
    
}
