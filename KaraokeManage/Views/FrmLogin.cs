using DevExpress.XtraEditors;

namespace KaraokeManage.Views
{
    public partial class FrmLogin : XtraForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void hyperLinkSignup_Click(object sender, System.EventArgs e)
        {
            FrmRegister frmRegister = new FrmRegister();
            frmRegister.ShowDialog();
        }
    }
}