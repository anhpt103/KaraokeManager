namespace KaraokeManage.Views
{
    partial class FrmLogin
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
            this.grbInfoLogin = new DevExpress.XtraEditors.GroupControl();
            this.ckbRemember = new DevExpress.XtraEditors.CheckEdit();
            this.hyperLinkSignup = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.lblPassword = new DevExpress.XtraEditors.LabelControl();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.lblUserName = new DevExpress.XtraEditors.LabelControl();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grbInfoLogin)).BeginInit();
            this.grbInfoLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckbRemember.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInfoLogin
            // 
            this.grbInfoLogin.Controls.Add(this.ckbRemember);
            this.grbInfoLogin.Controls.Add(this.hyperLinkSignup);
            this.grbInfoLogin.Controls.Add(this.labelControl1);
            this.grbInfoLogin.Controls.Add(this.txtPassword);
            this.grbInfoLogin.Controls.Add(this.lblPassword);
            this.grbInfoLogin.Controls.Add(this.txtUserName);
            this.grbInfoLogin.Controls.Add(this.lblUserName);
            this.grbInfoLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbInfoLogin.Location = new System.Drawing.Point(0, 0);
            this.grbInfoLogin.Name = "grbInfoLogin";
            this.grbInfoLogin.Size = new System.Drawing.Size(399, 195);
            this.grbInfoLogin.TabIndex = 0;
            this.grbInfoLogin.Text = "Thông tin tài khoản đăng nhập";
            // 
            // ckbRemember
            // 
            this.ckbRemember.Location = new System.Drawing.Point(135, 129);
            this.ckbRemember.Name = "ckbRemember";
            this.ckbRemember.Properties.Caption = "Ghi nhớ đăng nhập";
            this.ckbRemember.Size = new System.Drawing.Size(114, 20);
            this.ckbRemember.TabIndex = 5;
            // 
            // hyperLinkSignup
            // 
            this.hyperLinkSignup.Location = new System.Drawing.Point(255, 163);
            this.hyperLinkSignup.Name = "hyperLinkSignup";
            this.hyperLinkSignup.Size = new System.Drawing.Size(87, 13);
            this.hyperLinkSignup.TabIndex = 4;
            this.hyperLinkSignup.Text = "Đăng ký tài khoản";
            this.hyperLinkSignup.Click += new System.EventHandler(this.hyperLinkSignup_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(135, 163);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(114, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Bạn chưa có tài khoản ?";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(135, 91);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(187, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Appearance.Options.UseFont = true;
            this.lblPassword.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lblPassword.ImageOptions.Image = global::KaraokeManage.Properties.Resources.user_password_icon_16px;
            this.lblPassword.Location = new System.Drawing.Point(24, 91);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(71, 20);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Mật khẩu";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(135, 54);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Properties.Appearance.Options.UseFont = true;
            this.txtUserName.Size = new System.Drawing.Size(187, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // lblUserName
            // 
            this.lblUserName.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Appearance.Options.UseFont = true;
            this.lblUserName.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lblUserName.ImageOptions.Image = global::KaraokeManage.Properties.Resources.User_Group_icon_16px;
            this.lblUserName.Location = new System.Drawing.Point(24, 54);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(105, 20);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Tên đăng nhập";
            // 
            // btnExit
            // 
            this.btnExit.ImageOptions.Image = global::KaraokeManage.Properties.Resources.Button_Close_icon_16px;
            this.btnExit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnExit.Location = new System.Drawing.Point(216, 211);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.ImageOptions.Image = global::KaraokeManage.Properties.Resources.secrecy_icon_16px;
            this.btnLogin.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnLogin.Location = new System.Drawing.Point(126, 211);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(84, 23);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 253);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.grbInfoLogin);
            this.IconOptions.Image = global::KaraokeManage.Properties.Resources.Admin_icon_32px;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP HỆ THỐNG";
            ((System.ComponentModel.ISupportInitialize)(this.grbInfoLogin)).EndInit();
            this.grbInfoLogin.ResumeLayout(false);
            this.grbInfoLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ckbRemember.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grbInfoLogin;
        private DevExpress.XtraEditors.LabelControl lblPassword;
        private DevExpress.XtraEditors.LabelControl lblUserName;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperLinkSignup;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit ckbRemember;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        public DevExpress.XtraEditors.TextEdit txtPassword;
        public DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
    }
}