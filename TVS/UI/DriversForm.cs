using System;
using System.Windows.Forms;
using TVS.Models;

namespace TVS.UI
{
    /// <summary>
    /// </summary>
    public partial class DriversForm : Form
    {
        /// <summary>
        /// </summary>
        public DriversForm()
        {
            InitializeComponent();
        }

        private void btnVerzend_Click(object sender, EventArgs e)
        {
            if (cbVervuild.Checked)
            {
                Database.SetVervuild(Convert.ToInt32(tbTramNummer.Text));
            }
            if (cbDefect.Checked)
            {
                Database.SetBroken(Convert.ToInt32(tbTramNummer.Text));
            }
        }
    }
}