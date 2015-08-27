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

        private void btnNieuw_Click(object sender, EventArgs e)
        {
            new NewTramForm().ShowDialog();
        }

        private void btnInvoer_Click(object sender, EventArgs e)
        {
            Tram tram = Database.GetAllTrams().First(t => t.Id == Convert.ToInt32(tbTramNummer.Text));

            if (tram.Vervuild)
            {
                if (Database.IsRailAvailable(41)) {}
                else if (Database.IsRailAvailable(42))
                {
                    // stuur tram naar 42
                }
                else if (Database.IsRailAvailable(43))
                {
                    // stuur tram naar 43
                }
                else if (Database.IsRailAvailable(44))
                {
                    // stuur tram naar 44
                }
            }
            if (tram.Defect)
            {
                if (Database.IsRailAvailable(74))
                {
                    // stuur tram naar 74
                }
                else if (Database.IsRailAvailable(75))
                {
                    // stuur tram naar 75
                }
                else if (Database.IsRailAvailable(76))
                {
                    // stuur tram naar 76
                }
                else if (Database.IsRailAvailable(77))
                {
                    // stuur tram naar 77
                }
            }
            if (tram.TramTypeId == 1)
            {
                if (Database.IsRailAvailable(58))
                {
                    // stuur naar 58
                }
            }
            else
            {
                int lijn = Database.GetLine(tram.Id);
            }
        }
    }
}