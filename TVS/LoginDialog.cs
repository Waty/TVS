using System;
using System.Windows.Forms;

namespace TVS
{
    /// <summary>
    ///     A simple dialog containing a username and a password box and a button to login
    /// </summary>
    public partial class LoginDialog : Form
    {
        /// <summary>
        ///     Constructs a new LoginDialog
        /// </summary>
        public LoginDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     The event that gets fired when the user click 'login'
        /// </summary>
        public event EventHandler<LoginEventArgs> Login;

        /// <summary>
        /// Raises the <see cref="Login"/> event, if the event isn't cancelled the dialog gets closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bLogin_Click(object sender, EventArgs e)
        {
            if (Login != null)
            {
                var args = new LoginEventArgs(tbUsername.Text, tbPassword.Text);
                Login.Invoke(this, args);
                if (!args.Cancel)
                {
                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}