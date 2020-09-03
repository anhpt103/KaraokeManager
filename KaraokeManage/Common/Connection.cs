using System.Configuration;

namespace KaraokeManage.Common
{
    public static class Connection
    {
        public static string SetDBConnection(string Datasource, string Database, string UserName, string Password)
        {
            string connString = @"Data Source=" + Datasource + ";Initial Catalog=" + Database + ";Persist Security Info=True;User ID=" + UserName + ";Password=" + Password;
            string msg = Exec.ConnectionString = connString;
            return msg;
        }

        public static string SetDBConnection()
        {
            string Datasource = ConfigurationManager.AppSettings.Get("Datasource");
            string Database = ConfigurationManager.AppSettings.Get("Database");
            string UserName = ConfigurationManager.AppSettings.Get("UserName");
            string Password = ConfigurationManager.AppSettings.Get("Password");

            return SetDBConnection(Datasource, Database, UserName, Password);
        }
    }
}
