using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using KaraokeManage.Common;
using KaraokeManage.Controllers;
using KaraokeManage.Models;
using KaraokeManage.Views.UCControl;
using System;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace KaraokeManage.Views
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
            SetBottomInfo();
            DisableEnableMenuLogin(true);
        }

        public void DefaultSkins()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Office 2019 Colorful";
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        private string GetDatabaseName()
        {
            Regex regex = new Regex(@"Initial\s+Catalog\=(.\\)?([^;]+)");
            Match match = regex.Match(ConfigurationManager.ConnectionStrings["KaraokeManageConnection"].ToString());
            if (match == null || match.Groups.Count == 0 || match.Length == 0) return "Not Found";
            return match.Groups[2].Value;
        }

        private void SetBottomInfo()
        {
            itemComputerName.Caption = "Máy chủ: " + Environment.MachineName;
            itemDatabaseName.Caption = "Tên cơ sở dữ liệu: " + GetDatabaseName();
            itemIpAddress.Caption = "IP: " + GetLocalIPAddress();
        }

        public void DisableEnableMenuLogin(bool e)
        {
            btnLogin.Enabled = e;
            btnBackup.Enabled = !e;
            btnChangePassword.Enabled = !e;
            btnLogout.Enabled = !e;
            btnPhanQuyen.Enabled = !e;
            btnRestore.Enabled = !e;
            btnLoaiHang.Enabled = !e;
            btnNhomHang.Enabled = !e;
            btnHangHoa.Enabled = !e;
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

        private void btnChangePassword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmChangePassword frmChangePassword = new FrmChangePassword();
            frmChangePassword.ShowDialog();
        }

        private void AddNewTabPage(string Name, string Text, UserControl ucContent)
        {
            XtraTabPage newTabPage = new XtraTabPage();
            newTabPage.Name = Name;
            newTabPage.Text = Text;
            newTabPage.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
            foreach (XtraTabPage tabpage in xtraTabMain.TabPages)
            {
                if (tabpage.Name == newTabPage.Name)
                {
                    xtraTabMain.SelectedTabPage = tabpage;
                    return;
                }
            }
            xtraTabMain.TabPages.Add(newTabPage);
            xtraTabMain.SelectedTabPageIndex = xtraTabMain.TabPages.Count - 1;
            newTabPage.Appearance.PageClient.BackColor = System.Drawing.Color.Cyan;
            newTabPage.Appearance.PageClient.Options.UseBackColor = true;
            ucContent.Dock = DockStyle.Fill;
            newTabPage.Controls.Add(ucContent);
        }

        private void CloseTabPage()
        {
            if (xtraTabMain.SelectedTabPageIndex != 0)
            {
                int index = xtraTabMain.SelectedTabPageIndex;
                xtraTabMain.TabPages.RemoveAt(index);
                xtraTabMain.SelectedTabPageIndex = index - 1;
            }
        }

        private void btnLoaiHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_LoaiHang uC_LoaiHang = new UC_LoaiHang();
            AddNewTabPage("LoaiHang", "Loại hàng", uC_LoaiHang);
        }

        private void xtraTabMain_CloseButtonClick(object sender, EventArgs e)
        {
            CloseTabPage();
        }
    }
}