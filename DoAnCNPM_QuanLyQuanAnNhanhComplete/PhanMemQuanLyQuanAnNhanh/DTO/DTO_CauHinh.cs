using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_CauHinh
    {
        public int check_Config()
        {
            if (Properties.Settings.Default.QL_QuanAnNhanhConnectionString == string.Empty)
                return 0;//Chuỗi cấu hình không tồn tại
            SqlConnection _sqlConn = new SqlConnection(Properties.Settings.Default.QL_QuanAnNhanhConnectionString);
            try
            {
                if (_sqlConn.State == System.Data.ConnectionState.Closed)
                    _sqlConn.Open();
                return 1; //Kết nối thành công
            }
            catch (Exception)
            {
                return 2; //Chuỗi cấu hình không hợp lệ
            }

        }

        //public enum LoginResult {Invalid, Disable, Success}

        //Lấy danh sách severname
        public DataTable GetServerName()
        {
            DataTable dt = SqlDataSourceEnumerator.Instance.GetDataSources();
            return dt;
        }
        public string GetDBNameByUser(string pServer, string pUser, string pPass, ref DataTable dt)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select name from sys.Databases",
                "Data Source=" + pServer + ";Initial Catalog=master;User ID=" + pUser + ";pwd = " +
                pPass + "");
                da.Fill(dt);
                return "1";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }

        }
        public string GetDBNameByWindows(string pServer, ref DataTable dt)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select name from sys.Databases",
           "Data Source=" + pServer + ";Initial Catalog=master;Integrated Security = True");
                da.Fill(dt);
                return "1";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }


        }
        public string SaveConfigUser(string pServer, string pUser, string pPass, string pDBName)
        {
            try
            {
                DTO.Properties.Settings.Default.QL_QuanAnNhanhConnectionString = "Data source = " + pServer
               + ";Initial Catalog=" + pDBName + ";User ID = " + pUser + ";pwd= " + pPass + "";
                DTO.Properties.Settings.Default.Save();
                return "1";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
        public string SaveConfigWindows(string pServer, string pDBName)
        {
            try
            {
                DTO.Properties.Settings.Default.QL_QuanAnNhanhConnectionString = "Data source = " + pServer
                + ";Initial Catalog=" + pDBName + ";Integrated Security = True";
                DTO.Properties.Settings.Default.Save();
                return "1";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
    }
}
