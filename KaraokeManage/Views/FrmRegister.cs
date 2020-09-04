using DevExpress.XtraEditors;
using KaraokeManage.Common;
using KaraokeManage.Controllers;
using KaraokeManage.Models;
using System.Windows.Forms;

namespace KaraokeManage.Views
{
    public partial class FrmRegister : XtraForm
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private string ValidateForm()
        {
            if (string.IsNullOrEmpty(txtFullName.Text)) return "Tên đầy đủ không thể trống";
            if (string.IsNullOrEmpty(txtUserName.Text)) return "Tên đăng nhập không thể trống";
            if (string.IsNullOrEmpty(txtPassword.Text)) return "Mật khẩu không thể trống";
            if (string.IsNullOrEmpty(txtRePassword.Text)) return "Xác minh mật khẩu không thể trống";

            if (txtFullName.Text.Length > 50) return "Tên đầy đủ không thể lớn hơn 50 ký tự";
            if (txtUserName.Text.Length > 50) return "Tên đăng nhập không thể lớn hơn 50 ký tự";
            if (txtPassword.Text.Length > 50) return "Mật khẩu không thể lớn hơn 50 ký tự";
            if (txtRePassword.Text.Length > 50) return "Xác minh mật khẩu không thể lớn hơn 50 ký tự";

            return "";
        }

        private void btnRegister_Click(object sender, System.EventArgs e)
        {
            string msg = ValidateForm();
            if (msg.Length > 0) { XtraMessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            string FullName = txtFullName.Text;
            string UserName = txtUserName.Text;
            string Password = txtPassword.Text.ToLower();
            string RePassword = txtRePassword.Text.ToLower();
            int Sex = Convertor.ToNumber(radioGroupSex.EditValue, 0);
            if (Password != RePassword) { XtraMessageBox.Show("Mật khẩu và xác minh mật khẩu không giống nhau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            string PasswordMd5 = MD5Encrypt.MD5Hash(Password);
            RegisterCtrl registerCtrl = new RegisterCtrl();
            RegisterModel model = new RegisterModel(FullName, UserName, PasswordMd5, Sex);
            msg = registerCtrl.RegisterUser(model);
            if (msg.Length > 0) { XtraMessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            XtraMessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}