using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TVS.Models;

namespace TVS.UI
{
    /// <summary>
    ///     Form for the driver
    /// </summary>
    public partial class DriversForm : Form
    {
        private readonly Administration _admin = new Administration();
        private readonly Tram _tram;

        /// <summary>
        ///     On launch we get pick a tram from the list which is the one being ridden by the driver.
        /// </summary>
        public DriversForm()
        {
            InitializeComponent();


            List<Tram> tramList = Database.GetAllTrams().ToList();
            int id = Database.GetRandomTramIdNotRemise(tramList.Count);
            _tram = tramList.First(t => t.Id == id);
            tbTramNummer.Text = _tram.Nummer.ToString();
            lbTramNummer.Text = _tram.Nummer.ToString();
        }

        /// <summary>
        ///     The driver reports the condition of the tram and the system returns a track and sector.
        /// </summary>
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

            int nr = Convert.ToInt32(tbTramNummer.Text);
            _admin.AssignSector(Database.GetAllTrams().Single(t => t.Nummer == nr));
            Sector s = _admin.GetSector(_tram.Id);
            lbSectorNummer.Text = s.Nummer.ToString();
            lbSpoorNummer.Text = _admin.GetTracks(s.SpoorId).ToString();
        }
    }
}