using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        public DataTable GetSanPham()
        {
            string sql = "SELECT * FROM NhanVien";
            return kn.ReadData(sql);
        }
    }    
}
