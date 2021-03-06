﻿namespace KaraokeManage.Views
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.imgCollection_32px = new DevExpress.Utils.ImageCollection(this.components);
            this.btnLogin = new DevExpress.XtraBars.BarButtonItem();
            this.btnChangePassword = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhanQuyen = new DevExpress.XtraBars.BarButtonItem();
            this.btnBackup = new DevExpress.XtraBars.BarButtonItem();
            this.btnRestore = new DevExpress.XtraBars.BarButtonItem();
            this.skinGalleryItems = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.itemComputerName = new DevExpress.XtraBars.BarListItem();
            this.itemDatabaseName = new DevExpress.XtraBars.BarListItem();
            this.itemIpAddress = new DevExpress.XtraBars.BarListItem();
            this.btnLoaiHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhomHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnHangHoa = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemHypertextLabel1 = new DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel();
            this.rbStatus = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.xtraTabMain = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCollection_32px)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHypertextLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabMain)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Images = this.imgCollection_32px;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnLogin,
            this.btnChangePassword,
            this.btnLogout,
            this.btnPhanQuyen,
            this.btnBackup,
            this.btnRestore,
            this.skinGalleryItems,
            this.barHeaderItem1,
            this.itemComputerName,
            this.itemDatabaseName,
            this.itemIpAddress,
            this.btnLoaiHang,
            this.btnNhomHang,
            this.btnHangHoa});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 16;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage4});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHypertextLabel1});
            this.ribbon.Size = new System.Drawing.Size(1258, 158);
            this.ribbon.StatusBar = this.rbStatus;
            // 
            // imgCollection_32px
            // 
            this.imgCollection_32px.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imgCollection_32px.ImageStream")));
            this.imgCollection_32px.Images.SetKeyName(0, "Action-view-icon_32px.png");
            this.imgCollection_32px.Images.SetKeyName(1, "add-icon_32px.png");
            this.imgCollection_32px.Images.SetKeyName(2, "Admin-icon_32px.png");
            this.imgCollection_32px.Images.SetKeyName(3, "back-icon_32px.png");
            this.imgCollection_32px.Images.SetKeyName(4, "Backup-Folder-icon_32px.png");
            this.imgCollection_32px.Images.SetKeyName(5, "bin-red-icon_32px.png");
            this.imgCollection_32px.Images.SetKeyName(6, "Calculator-icon_32px.png");
            this.imgCollection_32px.Images.SetKeyName(7, "cart-icon_32px.png");
            this.imgCollection_32px.Images.SetKeyName(8, "cash-register-icon_32px.png");
            this.imgCollection_32px.Images.SetKeyName(9, "chat-icon_32px.png");
            this.imgCollection_32px.Images.SetKeyName(10, "Control-Panel-icon_32px.png");
            this.imgCollection_32px.Images.SetKeyName(11, "credit-card-icon_32px.png");
            this.imgCollection_32px.Images.SetKeyName(12, "cryptography-icon_32px.png");
            this.imgCollection_32px.Images.SetKeyName(13, "Database-icon_32px.png");
            this.imgCollection_32px.Images.SetKeyName(14, "Downloads-Folder-icon_32px.png");
            this.imgCollection_32px.Images.SetKeyName(15, "edit-icon_32px.png");
            this.imgCollection_32px.Images.SetKeyName(16, "folder-images-icon_32px.png");
            this.imgCollection_32px.Images.SetKeyName(17, "forward-icon_32px.png");
            this.imgCollection_32px.Images.SetKeyName(18, "Go-icon_32px.png");
            this.imgCollection_32px.Images.SetKeyName(19, "headset-icon_32px.png");
            this.imgCollection_32px.Images.SetKeyName(20, "Help-icon_32px.png");
            this.imgCollection_32px.Images.SetKeyName(21, "history-icon_32px.png");
            this.imgCollection_32px.Images.SetKeyName(22, "info-icon_32px.png");
            this.imgCollection_32px.Images.SetKeyName(23, "invoice-icon_32px.png");
            this.imgCollection_32px.Images.SetKeyName(24, "Login-icon_32px.png");
            this.imgCollection_32px.Images.SetKeyName(25, "Logoff-icon_32px.png");
            this.imgCollection_32px.Images.SetKeyName(26, "Logout-icon_32px.png");
            this.imgCollection_32px.Images.SetKeyName(27, "Mail-icon_32px.png");
            this.imgCollection_32px.Images.SetKeyName(28, "options-icon_32px.png");
            this.imgCollection_32px.Images.SetKeyName(29, "Reboot-icon_32px.png");
            this.imgCollection_32px.Images.SetKeyName(30, "Register-icon_32.png");
            this.imgCollection_32px.Images.SetKeyName(31, "reload-icon_32px.png");
            this.imgCollection_32px.Images.SetKeyName(32, "Save-icon_32px.png");
            this.imgCollection_32px.Images.SetKeyName(33, "Search-icon_32px.png");
            this.imgCollection_32px.Images.SetKeyName(34, "secrecy-icon_32px.png");
            this.imgCollection_32px.Images.SetKeyName(35, "Sex-Male-Female-icon_32px.png");
            this.imgCollection_32px.Images.SetKeyName(36, "Shutdown-icon_32px.png");
            this.imgCollection_32px.Images.SetKeyName(37, "sound-icon_2_32px.png");
            this.imgCollection_32px.Images.SetKeyName(38, "sound-icon_32px.png");
            this.imgCollection_32px.Images.SetKeyName(39, "Standby-icon_32px.png");
            this.imgCollection_32px.Images.SetKeyName(40, "Stop-icon_32px.png");
            this.imgCollection_32px.Images.SetKeyName(41, "Trash-icon_32px.png");
            this.imgCollection_32px.Images.SetKeyName(42, "undo-icon_32px.png");
            this.imgCollection_32px.Images.SetKeyName(43, "User-password-icon_32px.png");
            // 
            // btnLogin
            // 
            this.btnLogin.Caption = "Đăng nhập";
            this.btnLogin.Id = 1;
            this.btnLogin.ImageOptions.ImageIndex = 43;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogin_ItemClick);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Caption = "Đổi mật khẩu";
            this.btnChangePassword.Id = 2;
            this.btnChangePassword.ImageOptions.ImageIndex = 34;
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChangePassword_ItemClick);
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "Đăng xuất";
            this.btnLogout.Id = 3;
            this.btnLogout.ImageOptions.ImageIndex = 26;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogout_ItemClick);
            // 
            // btnPhanQuyen
            // 
            this.btnPhanQuyen.Caption = "Phân quyền";
            this.btnPhanQuyen.Id = 4;
            this.btnPhanQuyen.ImageOptions.ImageIndex = 2;
            this.btnPhanQuyen.Name = "btnPhanQuyen";
            this.btnPhanQuyen.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // btnBackup
            // 
            this.btnBackup.Caption = "Sao lưu dữ liệu";
            this.btnBackup.Id = 5;
            this.btnBackup.ImageOptions.ImageIndex = 13;
            this.btnBackup.Name = "btnBackup";
            // 
            // btnRestore
            // 
            this.btnRestore.Caption = "Phục hồi dữ liệu";
            this.btnRestore.Id = 6;
            this.btnRestore.ImageOptions.ImageIndex = 4;
            this.btnRestore.Name = "btnRestore";
            // 
            // skinGalleryItems
            // 
            this.skinGalleryItems.Caption = "skinRibbonGalleryBarItem1";
            this.skinGalleryItems.Id = 7;
            this.skinGalleryItems.Name = "skinGalleryItems";
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "barHeaderItem1";
            this.barHeaderItem1.Id = 8;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // itemComputerName
            // 
            this.itemComputerName.Id = 10;
            this.itemComputerName.ImageOptions.Image = global::KaraokeManage.Properties.Resources.Computer_icon_16px;
            this.itemComputerName.Name = "itemComputerName";
            // 
            // itemDatabaseName
            // 
            this.itemDatabaseName.Id = 11;
            this.itemDatabaseName.ImageOptions.Image = global::KaraokeManage.Properties.Resources.Database_Active_icon_16px;
            this.itemDatabaseName.Name = "itemDatabaseName";
            // 
            // itemIpAddress
            // 
            this.itemIpAddress.Id = 12;
            this.itemIpAddress.ImageOptions.Image = global::KaraokeManage.Properties.Resources.ip_icon_16px;
            this.itemIpAddress.Name = "itemIpAddress";
            // 
            // btnLoaiHang
            // 
            this.btnLoaiHang.Caption = "Loại hàng";
            this.btnLoaiHang.Id = 13;
            this.btnLoaiHang.ImageOptions.Image = global::KaraokeManage.Properties.Resources.Type_multiple_correct_icon_16px;
            this.btnLoaiHang.Name = "btnLoaiHang";
            this.btnLoaiHang.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnLoaiHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLoaiHang_ItemClick);
            // 
            // btnNhomHang
            // 
            this.btnNhomHang.Caption = "Nhóm hàng";
            this.btnNhomHang.Id = 14;
            this.btnNhomHang.ImageOptions.Image = global::KaraokeManage.Properties.Resources.group_icon_16px;
            this.btnNhomHang.Name = "btnNhomHang";
            this.btnNhomHang.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // btnHangHoa
            // 
            this.btnHangHoa.Caption = "Hàng hóa";
            this.btnHangHoa.Id = 15;
            this.btnHangHoa.ImageOptions.Image = global::KaraokeManage.Properties.Resources.product_icon_16px;
            this.btnHangHoa.Name = "btnHangHoa";
            this.btnHangHoa.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup6,
            this.ribbonPageGroup7});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLogin);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnChangePassword);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLogout);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPhanQuyen);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Hệ thống";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnBackup);
            this.ribbonPageGroup6.ItemLinks.Add(this.btnRestore);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Dữ liệu";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.skinGalleryItems);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "Giao diện người dùng";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Quản lý";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnLoaiHang);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnNhomHang);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnHangHoa);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Quản lý hàng hóa";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Trợ giúp";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "ribbonPageGroup5";
            // 
            // repositoryItemHypertextLabel1
            // 
            this.repositoryItemHypertextLabel1.Name = "repositoryItemHypertextLabel1";
            // 
            // rbStatus
            // 
            this.rbStatus.ItemLinks.Add(this.itemComputerName);
            this.rbStatus.ItemLinks.Add(this.itemDatabaseName);
            this.rbStatus.ItemLinks.Add(this.itemIpAddress);
            this.rbStatus.Location = new System.Drawing.Point(0, 567);
            this.rbStatus.Name = "rbStatus";
            this.rbStatus.Ribbon = this.ribbon;
            this.rbStatus.Size = new System.Drawing.Size(1258, 24);
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "ribbonPage3";
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "ribbonPage5";
            // 
            // xtraTabMain
            // 
            this.xtraTabMain.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeaderAndOnMouseHover;
            this.xtraTabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabMain.Location = new System.Drawing.Point(0, 158);
            this.xtraTabMain.Name = "xtraTabMain";
            this.xtraTabMain.Size = new System.Drawing.Size(1258, 409);
            this.xtraTabMain.TabIndex = 5;
            this.xtraTabMain.CloseButtonClick += new System.EventHandler(this.xtraTabMain_CloseButtonClick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 591);
            this.Controls.Add(this.xtraTabMain);
            this.Controls.Add(this.rbStatus);
            this.Controls.Add(this.ribbon);
            this.Name = "FrmMain";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.rbStatus;
            this.Text = "Quản lý cửa hàng Karaoke";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCollection_32px)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHypertextLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar rbStatus;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.BarButtonItem btnLogin;
        private DevExpress.XtraBars.BarButtonItem btnChangePassword;
        private DevExpress.XtraBars.BarButtonItem btnLogout;
        private DevExpress.XtraBars.BarButtonItem btnPhanQuyen;
        private DevExpress.XtraBars.BarButtonItem btnBackup;
        private DevExpress.XtraBars.BarButtonItem btnRestore;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinGalleryItems;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.Utils.ImageCollection imgCollection_32px;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel repositoryItemHypertextLabel1;
        private DevExpress.XtraBars.BarListItem itemComputerName;
        private DevExpress.XtraBars.BarListItem itemDatabaseName;
        private DevExpress.XtraBars.BarListItem itemIpAddress;
        private DevExpress.XtraBars.BarButtonItem btnLoaiHang;
        private DevExpress.XtraBars.BarButtonItem btnNhomHang;
        private DevExpress.XtraBars.BarButtonItem btnHangHoa;
        private DevExpress.XtraTab.XtraTabControl xtraTabMain;
    }
}