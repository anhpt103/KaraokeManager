using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace KaraokeManage.Views
{
    public partial class FrmLogin : XtraForm
    {
        public delegate void LoginHandler();
        public LoginHandler OnClickLoginMethod;

        public FrmLogin()
        {
            InitializeComponent();
            txtUserName.KeyPress += new KeyPressEventHandler(CheckEnterKeyPress);
            txtPassword.KeyPress += new KeyPressEventHandler(CheckEnterKeyPress);
        }

        private void hyperLinkSignup_Click(object sender, System.EventArgs e)
        {
            FrmRegister frmRegister = new FrmRegister();
            frmRegister.ShowDialog();
        }

        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (OnClickLoginMethod != null) OnClickLoginMethod();
                
            }
        }
    }
}