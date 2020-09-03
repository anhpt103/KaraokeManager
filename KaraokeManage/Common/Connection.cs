using log4net;
using System;
using System.Configuration;
using System.Data.SqlClient;

namespace KaraokeManage.Common
{
    public static class Connection
    {
        private static readonly ILog log = LogManager.GetLogger(Environment.MachineName);
        public static string SetDBConnection()
        {
            string connString = ConfigurationManager.ConnectionStrings["KaraokeManageConnection"].ToString();
            Exec.ConnectionString = connString;

            string msg = "";
            SqlConnection connection = new SqlConnection(connString);
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                log.Error(msg);
            }

            return msg;
        }
    }
}
