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
        /// <summary>
        ///     Constructor
        /// </summary>
        public RemiseForm()
        {
            InitializeComponent();
        }

        private IEnumerable<Panel> Tracks => Controls.OfType<Panel>().Where(p => p != panel1 && p != panel2);

        private static int GetTrackNumber(Panel p)
        {
            return int.Parse(p.Name.Substring(2));
        }

        private void btnSchoonmaak_Click(object sender, EventArgs e)
        {
            Database.SetVervuild(Convert.ToInt32(tbTramNummer.Text));
        }

        private void btnBlokkeer_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(tbSpoorNr.Text);
            bool blocked = Database.IsRailBlocked(number);
            Database.ToggleRailBlock(number, !blocked);

            Panel track = Tracks.FirstOrDefault(p => GetTrackNumber(p) == number);
            if (track != null)
            {
                track.Enabled = blocked;
            }
        }
    }
}