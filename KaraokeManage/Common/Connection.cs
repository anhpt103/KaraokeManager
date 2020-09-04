using System.Configuration;

namespace KaraokeManage.Common
{
    public static class Connection
    {
        public static string SetDBConnection()
        {
            string connString = ConfigurationManager.ConnectionStrings["KaraokeManageConnection"].ToString();
            Exec.ConnectionString = connString;
            return connString;
        }
    }
}
