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

            string msg = Exec.GetOne("usp_CheckInfoLogin", new { model.UserName, model.Password }, out string result);
            if (msg.Length > 0) { log.Error(msg); return msg; }
            if (!string.IsNullOrEmpty(result)) return result;

            return "";
        }
    }
}
