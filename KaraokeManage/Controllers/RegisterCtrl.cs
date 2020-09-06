using KaraokeManage.Common;
using KaraokeManage.Models;
using log4net;
using System;

namespace KaraokeManage.Controllers
{
    public class RegisterCtrl
    {
        private static readonly ILog log = LogManager.GetLogger(Environment.MachineName);
        public string RegisterUser(RegisterModel model)
        {
            if (string.IsNullOrEmpty(model.FullName)) return "Tên đầy đủ không thể trống";
            if (string.IsNullOrEmpty(model.UserName)) return "Tên đăng nhập không thể trống";
            if (string.IsNullOrEmpty(model.Password)) return "Mật khẩu không thể trống";

            string msg = Exec.ExecStore("usp_RegisterUser", new { model.FullName, model.UserName, model.Password, model.Sex }, out string result);
            if (!string.IsNullOrEmpty(msg)) { log.Error(msg); return msg; }
            if (!string.IsNullOrEmpty(result)) return result;

            return "";
        }
    }
}
