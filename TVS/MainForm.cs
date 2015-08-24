using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVS
{
    /// <summary>
    /// Main form
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Het inloggen van een gebruiker.
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            lbGebruikersNaam.Visible = false;
            lbWachtwoord.Visible = false;
            tbLoginNaam.Visible = false;
            tbLoginWachtwoord.Visible = false;
            btnLogin.Visible = false;
            btnLoguit.Visible = true;
            lbGebruiker.Visible = true;
            pnMain.Visible = true;
        }
        /// <summary>
        /// Het uitloggen van een gebruiker.
        /// </summary>
        private void btnLoguit_Click(object sender, EventArgs e)
        {
            lbGebruikersNaam.Visible = true;
            lbWachtwoord.Visible = true;
            tbLoginNaam.Visible = true;
            tbLoginWachtwoord.Visible = true;
            btnLogin.Visible = true;
            btnLoguit.Visible = false;
            lbGebruiker.Visible = false;
            pnMain.Visible = false;
        }
    }
}
