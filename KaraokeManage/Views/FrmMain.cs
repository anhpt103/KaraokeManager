using DevExpress.XtraEditors;
using KaraokeManage.Common;
using KaraokeManage.Controllers;
using KaraokeManage.Models;
using System;
using System.Windows.Forms;

namespace KaraokeManage.Views
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
            DisableEnableMenuLogin(true);
        }
        public void DefaultSkins()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Office 2019 Colorful";
        }

        public void DisableEnableMenuLogin(bool e)
        {
            btnLogin.Enabled = e;
            btnBackup.Enabled = !e;
            btnChangePassword.Enabled = !e;
            btnLogout.Enabled = !e;
            btnPhanQuyen.Enabled = !e;
            btnRestore.Enabled = !e;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            DefaultSkins();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = XtraMessageBox.Show("Bạn có muốn thoát ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No) e.Cancel = true;
        }

        private string ValidateLogin(string UserName, string Password)
        {
            LoginModel model = new LoginModel(UserName, Password);
            LoginCtrl loginCtrl = new LoginCtrl();

            string msg = loginCtrl.CheckInfoLogin(model);
            if (msg.Length > 0) return msg;
            return "";
        }

        private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmLogin frmLogin = null;

            CheckLogin:
            if (frmLogin == null || frmLogin.IsDisposed) frmLogin = new FrmLogin();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(frmLogin.txtUserName.Text))
                {
                    XtraMessageBox.Show("Tài khoản không thể trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    goto CheckLogin;
                }
                if (string.IsNullOrEmpty(frmLogin.txtPassword.Text))
                {
                    XtraMessageBox.Show("Mật khẩu không thể trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    goto CheckLogin;
                }

                string UserName = frmLogin.txtUserName.Text.Trim();
                string Password = MD5Encrypt.MD5Hash(frmLogin.txtPassword.Text.Trim());
                string msg = ValidateLogin(UserName, Password);
                if (msg.Length > 0)
                {
                    XtraMessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    goto CheckLogin;
                }
                else
                {
                    DisableEnableMenuLogin(false);
                }
            }
        }

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn đăng xuất ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DisableEnableMenuLogin(true);
                btnLogin_ItemClick(sender, e);
            }
        }
    }
}