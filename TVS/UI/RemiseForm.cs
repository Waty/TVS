using System;
using System.Windows.Forms;
using TVS.Models;

namespace TVS.UI
{
    /// <summary>
    ///     Main form
    /// </summary>
    public partial class RemiseForm : Form
    {
        /// <summary>
        ///     Constructor
        /// </summary>
        public RemiseForm()
        {
            InitializeComponent();
        }

        private void btnSchoonmaak_Click(object sender, EventArgs e)
        {
            Database.SetVervuild(Convert.ToInt32(tbTramNummer.Text));
        }

        private void btnBlokkeer_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(lbSpoor.Text);
            bool blocked = Database.IsRailBlocked(number);

            if (!blocked)
            {
                Database.BlockRail(number);
            }
            else
            {
                Database.ReleaseRail(number);
            }
        }
    }
}