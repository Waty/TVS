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
            Medewerker medewerker = Database.Login(tbUsername.Text, tbPassword.Text);
            Hide();
            switch (medewerker?.Functie)
            {
                case Medewerker.FunctieType.Schoonmaker:
                    new CleanupForm().ShowDialog();
                    break;

                case Medewerker.FunctieType.Technicus:
                    new MaintenanceForm().ShowDialog();
                    break;

                case Medewerker.FunctieType.Bestuurder:
                    new DriversForm().ShowDialog();
                    break;

                case Medewerker.FunctieType.Wagenparkbeheerder:
                    new RemiseForm().ShowDialog();
                    break;

                case Medewerker.FunctieType.Beheerder:
                    MessageBox.Show("Beheerders zijn voor nu nog niet geïmplementeerd!");
                    break;

                default:
                    MessageBox.Show("Failed to login!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            Show();
        }
    }
}