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
        public SqlConnection conn;
        public void openConnection()
        {
            conn = new SqlConnection("Server=DESKTOP-8DCO9H8;Database=Quan_Ly_Sua_N8;Integrated Security=True");
            conn.Open();
        }
        public void closeConnection()
        {
            conn.Close();
        }
        public DataTable ReadData(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                openConnection();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
            return dt;
        }
        public void CreateUpdateDelete(string sql, SqlParameter[] sqlParameters = null)
        {
            try
            {
                openConnection();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (sqlParameters != null) cmd.Parameters.AddRange(sqlParameters);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }
        public DataTable ReadData(string sql, SqlParameter[] sqlParameters = null)
        {
            DataTable dt = new DataTable();
            try
            {
                openConnection();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (sqlParameters != null) cmd.Parameters.AddRange(sqlParameters);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
            return dt;
        }
    }
}
