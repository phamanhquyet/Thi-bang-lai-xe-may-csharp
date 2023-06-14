using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2364_PhamAnhQuyet_DOANCANHAN.Models;

namespace _2364_PhamAnhQuyet_DOANCANHAN
{
    internal class LOPDUNGCHUNG
    {
        string strConn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\VSStudio\\Csharp\\2364_PhamAnhQuyet_DOANCANHAN\\2364_PhamAnhQuyet_DOANCANHAN\\2364_PhamAnhQuyet.mdf;Integrated Security=True";
        SqlConnection conn;

        public string StrConn { get => strConn; set => strConn = value; }

        public LOPDUNGCHUNG()
        {
            conn = new SqlConnection(StrConn);
        }

        public DataTable GetDataTable(string sql)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public int ExecuteNonQuery(string sql)
        {
            int result = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                result = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = 0;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public int ExecuteNonQuery(string sql, SqlParameter[] parameters)
        {
            int result = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddRange(parameters);
                conn.Open();
                result = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                result = 0;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public object ExecuteScalar(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            object result = cmd.ExecuteScalar();
            conn.Close();
            return result;
        }

        public object ExecuteScalar(string sql, SqlParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddRange(parameters);
            conn.Open();
            object result = cmd.ExecuteScalar();
            conn.Close();
            return result;
        }
        


    }
}
