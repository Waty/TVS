using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TVS.Models;

namespace TVS.UI
{
    /// <summary>
    ///     Main form
    /// </summary>
    public partial class RemiseForm : Form
    {
        private readonly Administration admin = new Administration();

        /// <summary>
        ///     Constructor
        /// </summary>
        public RemiseForm()
        {
            InitializeComponent();
        }

        private IEnumerable<Track> Tracks => Controls.OfType<Track>();


        private void btnSchoonmaak_Click(object sender, EventArgs e)
        {
            Database.SetVervuild(Convert.ToInt32(tbTramNummer.Text));
        }

        private void btnBlokkeer_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(tbSpoorNr.Text);
            bool blocked = Database.IsRailBlocked(number);
            Database.ToggleRailBlock(number, !blocked);

            Track track = Tracks.FirstOrDefault(p => p.Number == number);
            if (track != null)
            {
                track.Enabled = blocked;
            }
        }

        private void btnNieuw_Click(object sender, EventArgs e)
        {
            new NewTramForm().ShowDialog();
        }

        private void btnInvoer_Click(object sender, EventArgs e)
        {
            admin.AssignSector(Convert.ToInt32(tbTramNummer.Text));
        }
    }
}