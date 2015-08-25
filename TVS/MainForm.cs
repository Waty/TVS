using System;
using System.Linq;
using System.Windows.Forms;

namespace TVS
{
    /// <summary>
    ///     Main form
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        ///     Constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Het inloggen van een gebruiker.
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            ToggleLoggedInState(true);
        }

        /// <summary>
        ///     Het uitloggen van een gebruiker.
        /// </summary>
        private void btnLoguit_Click(object sender, EventArgs e)
        {
            ToggleLoggedInState(false);
        }

        /// <summary>
        ///     Changes the UI to reflect the logged in state
        /// </summary>
        /// <param name="loggedIn">if true the login box is hidden</param>
        private void ToggleLoggedInState(bool loggedIn)
        {
            lbGebruikersNaam.Visible = !loggedIn;
            lbWachtwoord.Visible = !loggedIn;
            tbLoginNaam.Visible = !loggedIn;
            tbLoginWachtwoord.Visible = !loggedIn;
            btnLogin.Visible = !loggedIn;
            btnLoguit.Visible = loggedIn;
            lbGebruiker.Visible = loggedIn;
            pnMain.Visible = loggedIn;
        }
    }
}