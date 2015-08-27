using System;
using System.Collections.Generic;
using System.Linq;
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


            List<Tram> tramList = Database.GetAllTrams().ToList();
            var r = new Random();
            int tramId = r.Next(1, tramList.Count);
            while (Database.IsInRemise(tramId))
            {
                tramId = r.Next(1, tramList.Count);
            }
            tbTramNummer.Text = lbTramNummer.Text = tramList.First(t => t.Id == tramId).Nummer.ToString();
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

            Tram tram = Database.GetAllTrams().First(t => t.Nummer == Convert.ToInt32(tbTramNummer.Text));

            if (tram.Vervuild)
            {
                if (Database.IsRailAvailable(41))
                {
                    Database.CreateSector(41, tram.Id);
                }

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