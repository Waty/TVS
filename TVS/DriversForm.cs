using System;
using System.Windows.Forms;

namespace TVS
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

        private void btnVerzend_Click(object sender, System.EventArgs e)
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