using KaraokeManage.Common;
using KaraokeManage.Models;
using log4net;
using System;

namespace KaraokeManage.Controllers
{
    public class LoginCtrl
    {
        private static readonly ILog log = LogManager.GetLogger(Environment.MachineName);
        public string CheckInfoLogin(LoginModel model)
        {
            if (string.IsNullOrEmpty(model.UserName)) return "Tài khoản không thể trống";
            if (string.IsNullOrEmpty(model.Password)) return "Mật khẩu không thể trống";

            Exec.ExecStore("usp_CheckInfoLogin", new { model.UserName, model.Password }, out string msg);
            if (!string.IsNullOrEmpty(msg)) { log.Error(msg); return msg; }

            return "";
        }
    }
}
