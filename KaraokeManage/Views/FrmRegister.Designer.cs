namespace KaraokeManage.Views
{
    partial class FrmRegister
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
            this.txtFullName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtRePassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.lblPassword = new DevExpress.XtraEditors.LabelControl();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.lblUserName = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.radioGroupSex = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.grbInfoLogin)).BeginInit();
            this.grbInfoLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupSex.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInfoLogin
            // 
            this.grbInfoLogin.Controls.Add(this.labelControl7);
            this.grbInfoLogin.Controls.Add(this.labelControl6);
            this.grbInfoLogin.Controls.Add(this.labelControl5);
            this.grbInfoLogin.Controls.Add(this.labelControl4);
            this.grbInfoLogin.Controls.Add(this.labelControl3);
            this.grbInfoLogin.Controls.Add(this.radioGroupSex);
            this.grbInfoLogin.Controls.Add(this.txtFullName);
            this.grbInfoLogin.Controls.Add(this.labelControl2);
            this.grbInfoLogin.Controls.Add(this.txtRePassword);
            this.grbInfoLogin.Controls.Add(this.labelControl1);
            this.grbInfoLogin.Controls.Add(this.txtPassword);
            this.grbInfoLogin.Controls.Add(this.lblPassword);
            this.grbInfoLogin.Controls.Add(this.txtUserName);
            this.grbInfoLogin.Controls.Add(this.lblUserName);
            this.grbInfoLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbInfoLogin.Location = new System.Drawing.Point(0, 0);
            this.grbInfoLogin.Name = "grbInfoLogin";
            this.grbInfoLogin.Size = new System.Drawing.Size(407, 227);
            this.grbInfoLogin.TabIndex = 3;
            this.grbInfoLogin.Text = "Thông tin đăng ký";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(171, 46);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Properties.Appearance.Options.UseFont = true;
            this.txtFullName.Size = new System.Drawing.Size(187, 20);
            this.txtFullName.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl2.ImageOptions.Image = global::KaraokeManage.Properties.Resources.name_card_icon_16px;
            this.labelControl2.Location = new System.Drawing.Point(23, 46);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(84, 20);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Tên đầy đủ";
            // 
            // txtRePassword
            // 
            this.txtRePassword.Location = new System.Drawing.Point(171, 154);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRePassword.Properties.Appearance.Options.UseFont = true;
            this.txtRePassword.Properties.PasswordChar = '*';
            this.txtRePassword.Size = new System.Drawing.Size(187, 20);
            this.txtRePassword.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl1.ImageOptions.Image = global::KaraokeManage.Properties.Resources.user_password_icon_16px;
            this.labelControl1.Location = new System.Drawing.Point(23, 154);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(125, 20);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Xác minh mật khẩu";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(171, 118);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(187, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Appearance.Options.UseFont = true;
            this.lblPassword.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lblPassword.ImageOptions.Image = global::KaraokeManage.Properties.Resources.user_password_icon_16px;
            this.lblPassword.Location = new System.Drawing.Point(23, 118);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(71, 20);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Mật khẩu";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(171, 81);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Properties.Appearance.Options.UseFont = true;
            this.txtUserName.Size = new System.Drawing.Size(187, 20);
            this.txtUserName.TabIndex = 2;
            // 
            // lblUserName
            // 
            this.lblUserName.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Appearance.Options.UseFont = true;
            this.lblUserName.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lblUserName.ImageOptions.Image = global::KaraokeManage.Properties.Resources.User_Group_icon_16px;
            this.lblUserName.Location = new System.Drawing.Point(23, 81);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(105, 20);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Tên đăng nhập";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(111, 48);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(8, 18);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "*";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(132, 81);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(8, 18);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "*";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(98, 118);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(8, 18);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "*";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(152, 154);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(8, 18);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "*";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl7.ImageOptions.Image = global::KaraokeManage.Properties.Resources.sex_icon_16px;
            this.labelControl7.Location = new System.Drawing.Point(23, 191);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(65, 20);
            this.labelControl7.TabIndex = 11;
            this.labelControl7.Text = "Giới tính";
            // 
            // btnExit
            // 
            this.btnExit.ImageOptions.Image = global::KaraokeManage.Properties.Resources.Button_Close_icon_16px;
            this.btnExit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnExit.Location = new System.Drawing.Point(216, 246);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.ImageOptions.Image = global::KaraokeManage.Properties.Resources.Register_icon_16px;
            this.btnLogin.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnLogin.Location = new System.Drawing.Point(126, 246);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(84, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Đăng ký";
            // 
            // radioGroupSex
            // 
            this.radioGroupSex.EditValue = KaraokeManage.Enums.Sex.Male;
            this.radioGroupSex.Location = new System.Drawing.Point(171, 189);
            this.radioGroupSex.Name = "radioGroupSex";
            this.radioGroupSex.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.radioGroupSex.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(KaraokeManage.Enums.Sex.Male, "Nam"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(KaraokeManage.Enums.Sex.Female, "Nữ")});
            this.radioGroupSex.Size = new System.Drawing.Size(121, 25);
            this.radioGroupSex.TabIndex = 6;
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 286);
            this.Controls.Add(this.grbInfoLogin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.IconOptions.Image = global::KaraokeManage.Properties.Resources.secrecy_icon_32px;
            this.Name = "FrmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG KÝ TÀI KHOẢN";
            ((System.ComponentModel.ISupportInitialize)(this.grbInfoLogin)).EndInit();
            this.grbInfoLogin.ResumeLayout(false);
            this.grbInfoLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroupSex.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grbInfoLogin;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.LabelControl lblPassword;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.LabelControl lblUserName;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.TextEdit txtRePassword;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtFullName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.RadioGroup radioGroupSex;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}