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
        ///     Attempts to login at the database and shows the appropriate form when login is successfull
        /// </summary>
        private void bLogin_Click(object sender, EventArgs e)
        {
            string func = Database.Login(tbUsername.Text, tbPassword.Text);
            Hide();
            switch (func)
            {
                case "Schoonmaker":
                    new CleanupForm().ShowDialog();
                    break;

                case "Technicus":
                    new MaintenanceForm().ShowDialog();
                    break;

                case "Bestuurder":
                    new DriversForm().ShowDialog();
                    break;

                case "Wagenparkbeheerder":
                    new MainForm().ShowDialog();
                    break;

                default:
                    MessageBox.Show("Failed to login!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            Show();
        }
    }
}