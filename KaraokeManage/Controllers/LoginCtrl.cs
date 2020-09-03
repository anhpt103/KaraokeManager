using KaraokeManage.Common;
using KaraokeManage.Models;

namespace KaraokeManage.Controllers
{
    public class LoginCtrl
    {
        public string CheckInfoLogin(LoginModel model)
        {
            if (string.IsNullOrEmpty(model.UserName)) return "Tài khoản không thể trống";
            if (string.IsNullOrEmpty(model.Password)) return "Mật khẩu không thể trống";

            Exec.ExecStore("usp_CheckInfoLogin", new { model.UserName, model.Password }, out string msg);
            if (msg.Length > 0) return msg;
            return "";
        }
    }
}
