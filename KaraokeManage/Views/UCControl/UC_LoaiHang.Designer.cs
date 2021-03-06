﻿namespace KaraokeManage.Views.UCControl
{
    partial class UC_LoaiHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_LoaiHang));
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.grcLoaiHang = new DevExpress.XtraGrid.GridControl();
            this.loaiHangModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grvLoaiHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenLoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MoTa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IsDelete_Text = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemIsDelete = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.IsDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mainRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaveAndClose = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaveAndNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnReset = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.mainRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.mainRibbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnAddNewRow = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcLoaiHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiHangModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvLoaiHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemIsDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowCustomization = false;
            this.dataLayoutControl1.Controls.Add(this.grcLoaiHang);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 100);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup;
            this.dataLayoutControl1.Size = new System.Drawing.Size(800, 500);
            this.dataLayoutControl1.TabIndex = 0;
            // 
            // grcLoaiHang
            // 
            this.grcLoaiHang.DataSource = this.loaiHangModelBindingSource;
            this.grcLoaiHang.Location = new System.Drawing.Point(12, 12);
            this.grcLoaiHang.MainView = this.grvLoaiHang;
            this.grcLoaiHang.MenuManager = this.mainRibbonControl;
            this.grcLoaiHang.Name = "grcLoaiHang";
            this.grcLoaiHang.Size = new System.Drawing.Size(776, 476);
            this.grcLoaiHang.TabIndex = 4;
            this.grcLoaiHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvLoaiHang});
            // 
            // loaiHangModelBindingSource
            // 
            this.loaiHangModelBindingSource.DataSource = typeof(KaraokeManage.Models.LoaiHangModel);
            // 
            // grvLoaiHang
            // 
            this.grvLoaiHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.TenLoai,
            this.MoTa,
            this.IsDelete_Text,
            this.IsDelete});
            this.grvLoaiHang.GridControl = this.grcLoaiHang;
            this.grvLoaiHang.Name = "grvLoaiHang";
            this.grvLoaiHang.OptionsView.ColumnAutoWidth = false;
            this.grvLoaiHang.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden;
            // 
            // ID
            // 
            this.ID.AppearanceHeader.Options.UseTextOptions = true;
            this.ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ID.Caption = "STT";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            this.ID.Width = 80;
            // 
            // TenLoai
            // 
            this.TenLoai.Caption = "Tên loại hàng";
            this.TenLoai.FieldName = "TenLoai";
            this.TenLoai.Name = "TenLoai";
            this.TenLoai.Visible = true;
            this.TenLoai.VisibleIndex = 1;
            this.TenLoai.Width = 200;
            // 
            // MoTa
            // 
            this.MoTa.Caption = "Mô tả";
            this.MoTa.FieldName = "MoTa";
            this.MoTa.Name = "MoTa";
            this.MoTa.Visible = true;
            this.MoTa.VisibleIndex = 2;
            this.MoTa.Width = 200;
            // 
            // IsDelete_Text
            // 
            this.IsDelete_Text.Caption = "Trạng thái";
            this.IsDelete_Text.ColumnEdit = this.repositoryItemIsDelete;
            this.IsDelete_Text.FieldName = "IsDelete_Text";
            this.IsDelete_Text.Name = "IsDelete_Text";
            this.IsDelete_Text.Visible = true;
            this.IsDelete_Text.VisibleIndex = 3;
            this.IsDelete_Text.Width = 100;
            // 
            // repositoryItemIsDelete
            // 
            this.repositoryItemIsDelete.AutoHeight = false;
            this.repositoryItemIsDelete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemIsDelete.Name = "repositoryItemIsDelete";
            // 
            // IsDelete
            // 
            this.IsDelete.Caption = "IsDelete";
            this.IsDelete.FieldName = "IsDelete";
            this.IsDelete.Name = "IsDelete";
            // 
            // mainRibbonControl
            // 
            this.mainRibbonControl.ExpandCollapseItem.Id = 0;
            this.mainRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mainRibbonControl.ExpandCollapseItem,
            this.mainRibbonControl.SearchEditItem,
            this.btnSave,
            this.btnSaveAndClose,
            this.btnSaveAndNew,
            this.btnReset,
            this.btnDelete,
            this.btnClose,
            this.btnAddNewRow});
            this.mainRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.mainRibbonControl.MaxItemId = 11;
            this.mainRibbonControl.Name = "mainRibbonControl";
            this.mainRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mainRibbonPage});
            this.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.mainRibbonControl.Size = new System.Drawing.Size(800, 100);
            this.mainRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Lưu lại";
            this.btnSave.Id = 2;
            this.btnSave.ImageOptions.ImageUri.Uri = "Save";
            this.btnSave.Name = "btnSave";
            // 
            // btnSaveAndClose
            // 
            this.btnSaveAndClose.Caption = "Lưu lại và đóng";
            this.btnSaveAndClose.Id = 3;
            this.btnSaveAndClose.ImageOptions.ImageUri.Uri = "SaveAndClose";
            this.btnSaveAndClose.Name = "btnSaveAndClose";
            // 
            // btnSaveAndNew
            // 
            this.btnSaveAndNew.Caption = "Lưu lại và tạo mới";
            this.btnSaveAndNew.Id = 4;
            this.btnSaveAndNew.ImageOptions.ImageUri.Uri = "SaveAndNew";
            this.btnSaveAndNew.Name = "btnSaveAndNew";
            // 
            // btnReset
            // 
            this.btnReset.Caption = "Đặt lại thay đổi";
            this.btnReset.Id = 5;
            this.btnReset.ImageOptions.ImageUri.Uri = "Reset";
            this.btnReset.Name = "btnReset";
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Xóa";
            this.btnDelete.Id = 6;
            this.btnDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.btnDelete.Name = "btnDelete";
            // 
            // btnClose
            // 
            this.btnClose.Caption = "Đóng";
            this.btnClose.Id = 7;
            this.btnClose.ImageOptions.ImageUri.Uri = "Close";
            this.btnClose.Name = "btnClose";
            this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick);
            // 
            // mainRibbonPage
            // 
            this.mainRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.mainRibbonPageGroup});
            this.mainRibbonPage.MergeOrder = 0;
            this.mainRibbonPage.Name = "mainRibbonPage";
            this.mainRibbonPage.Text = "Loại hàng";
            // 
            // mainRibbonPageGroup
            // 
            this.mainRibbonPageGroup.AllowTextClipping = false;
            this.mainRibbonPageGroup.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.mainRibbonPageGroup.ItemLinks.Add(this.btnSave);
            this.mainRibbonPageGroup.ItemLinks.Add(this.btnSaveAndClose);
            this.mainRibbonPageGroup.ItemLinks.Add(this.btnSaveAndNew);
            this.mainRibbonPageGroup.ItemLinks.Add(this.btnReset);
            this.mainRibbonPageGroup.ItemLinks.Add(this.btnDelete);
            this.mainRibbonPageGroup.ItemLinks.Add(this.btnClose);
            this.mainRibbonPageGroup.ItemLinks.Add(this.btnAddNewRow);
            this.mainRibbonPageGroup.Name = "mainRibbonPageGroup";
            this.mainRibbonPageGroup.Text = "Chức năng";
            // 
            // layoutControlGroup
            // 
            this.layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup.GroupBordersVisible = false;
            this.layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup.Name = "layoutControlGroup";
            this.layoutControlGroup.Size = new System.Drawing.Size(800, 500);
            this.layoutControlGroup.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grcLoaiHang;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(780, 480);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // btnAddNewRow
            // 
            this.btnAddNewRow.Caption = "Thêm";
            this.btnAddNewRow.Id = 10;
            this.btnAddNewRow.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.btnAddNewRow.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.btnAddNewRow.Name = "btnAddNewRow";
            this.btnAddNewRow.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddNewRow_ItemClick);
            // 
            // UC_LoaiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.mainRibbonControl);
            this.Name = "UC_LoaiHang";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.UC_LoaiHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcLoaiHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiHangModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvLoaiHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemIsDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
        private DevExpress.XtraBars.Ribbon.RibbonControl mainRibbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage mainRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup mainRibbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnSaveAndClose;
        private DevExpress.XtraBars.BarButtonItem btnSaveAndNew;
        private DevExpress.XtraBars.BarButtonItem btnReset;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraGrid.GridControl grcLoaiHang;
        private DevExpress.XtraGrid.Views.Grid.GridView grvLoaiHang;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn TenLoai;
        private DevExpress.XtraGrid.Columns.GridColumn MoTa;
        private DevExpress.XtraGrid.Columns.GridColumn IsDelete_Text;
        private System.Windows.Forms.BindingSource loaiHangModelBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn IsDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemIsDelete;
        private DevExpress.XtraBars.BarButtonItem btnAddNewRow;
    }
}
