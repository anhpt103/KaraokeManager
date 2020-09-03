using KaraokeManage.Common;
using KaraokeManage.Models;

namespace KaraokeManage.Controllers
{
    public class RegisterCtrl
    {
        public string RegisterUser(RegisterModel model)
        {
            if (string.IsNullOrEmpty(model.UserName)) return "Tên đầy đủ không thể trống";
            if (string.IsNullOrEmpty(model.UserName)) return "Tài khoản không thể trống";
            if (string.IsNullOrEmpty(model.Password)) return "Mật khẩu không thể trống";
            if (string.IsNullOrEmpty(model.RePassword)) return "Mật khẩu xác minh không thể trống";

            Exec.ExecStore("usp_RegisterUser", new { model.UserName, model.Password }, out string msg);
            if (msg.Length > 0) return msg;
            return "";
        }
    }
}
