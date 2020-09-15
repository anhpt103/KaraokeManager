using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using KaraokeManage.Common;
using KaraokeManage.Controllers;
using KaraokeManage.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KaraokeManage.Views.UCControl
{
    public partial class UC_LoaiHang : XtraUserControl
    {
        public UC_LoaiHang()
        {
            InitializeComponent();
            grvLoaiHang.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void UC_LoaiHang_Load(object sender, System.EventArgs e)
        {
            LoaiHangCtrl loaiHangCtrl = new LoaiHangCtrl();
            string msg = loaiHangCtrl.GetDataLoaiHang(out List<LoaiHangModel> oListLoaiHang);
            if (msg.Length > 0) XtraMessageBox.Show(msg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            grcLoaiHang.DataSource = oListLoaiHang;
            grvLoaiHang.RefreshData();
            grcLoaiHang.RefreshDataSource();

            repositoryItemIsDelete.Items.AddRange(EnumData.ListIsDelete);
            this.grcLoaiHang.RepositoryItems.Add(this.repositoryItemIsDelete);
            IsDelete_Text.ColumnEdit = repositoryItemIsDelete;

        }

        private void btnAddNewRow_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grvLoaiHang.AddNewRow();
            grvLoaiHang.SetRowCellValue(GridControl.NewItemRowHandle, grvLoaiHang.Columns["IsDelete"], 0);
            grvLoaiHang.SetRowCellValue(GridControl.NewItemRowHandle, grvLoaiHang.Columns["IsDelete_Text"], "Sử dụng");
        }
    }
}
