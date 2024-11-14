using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Sua_N8
{
    internal class KetNoi
    {
        SqlConnection conn;
        string kn = @"Data Source=Khanh;Initial Catalog=Quan_Ly_Sua_N8;Integrated Security=True";
        public void ketnoi()
        {
            conn = new SqlConnection(kn);
            conn.Open();
        }
        public void dongkn()
        {
            conn.Close();
        }

        //CRUD
        public DataTable Readdata(string sql, SqlParameter[] sqlParameters = null)
        {
            DataTable dt = new DataTable();
            try
            {
                ketnoi();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (sqlParameters != null)
                    {
                        cmd.Parameters.AddRange(sqlParameters);
                    }
                    using (SqlDataReader sr = cmd.ExecuteReader())
                    {
                        dt.Load(sr);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dongkn();
            }
            return dt;
        }

        public void CreateUpdateDelete(string table, SqlParameter[] sqlParameters = null)
        {
            try
            {
                ketnoi();
                using (SqlCommand cmd = new SqlCommand(table, conn))
                {
                    if (sqlParameters != null)
                    {
                        cmd.Parameters.AddRange(sqlParameters);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dongkn();
            }
        }
    }
}
