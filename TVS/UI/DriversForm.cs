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
                    Database.CreateSector(42, tram.Id);
                }
                else if (Database.IsRailAvailable(43))
                {
                    Database.CreateSector(43, tram.Id);
                }
                else if (Database.IsRailAvailable(44))
                {
                    Database.CreateSector(44, tram.Id);
                }
            }
            if (tram.Defect)
            {
                if (Database.IsRailAvailable(74))
                {
                    Database.CreateSector(74, tram.Id);
                }
                else if (Database.IsRailAvailable(75))
                {
                    Database.CreateSector(75, tram.Id);
                }
                else if (Database.IsRailAvailable(76))
                {
                    Database.CreateSector(76, tram.Id);
                }
                else if (Database.IsRailAvailable(77))
                {
                    Database.CreateSector(77, tram.Id);
                }
            }
            if (tram.TramTypeId == 1)
            {
                if (Database.IsRailAvailable(58))
                {
                    Database.CreateSector(58, tram.Id);
                }
            }
            else
            {
                for (var i = 0; i < 1337; i++)
                {
                    List<Spoor> sporen = Database.GetSelectedTracks(i).ToList();
                    if (sporen.Count != 0)
                    {
                        Spoor spoor = sporen.First();
                        Database.CreateSector(spoor.Id, tram.Id);
                        break;
                    }
                }
            }
        }
    }
}