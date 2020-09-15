using DevExpress.XtraEditors;
using KaraokeManage.Controllers;
using KaraokeManage.Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KaraokeManage.Views.UCControl
{
    public partial class UC_LoaiHang : DevExpress.XtraEditors.XtraUserControl
    {
        public UC_LoaiHang()
        {
            InitializeComponent();
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
            grcLoaiHang.ForceInitialize();
        }
    }
}
