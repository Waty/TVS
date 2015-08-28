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
        private readonly Administration _admin = new Administration();

        /// <summary>
        ///     Constructor
        /// </summary>
        public RemiseForm()
        {
            InitializeComponent();
            ddStatus.DataSource = Enum.GetValues(typeof (Maintenance.MaintenanceType));
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
            int nr = int.Parse(tbTramNummer.Text);
            _admin.AssignSector(Database.GetAllTrams().Single(t => t.Nummer == nr));
        }

        private void LoadAllTracks(object sender, EventArgs e)
        {
            List<Spoor> tracks = Database.GetAllTracks().ToList();
            List<Sector> sectors = Database.GetAllSectors().ToList();

            foreach (Track track in Tracks)
            {
                Spoor result = tracks.FirstOrDefault(t => t.Nummer == track.Number);
                if (result != null)
                {
                    track.Length = result.Lengte;
                    track.Enabled = result.Beschikbaar;
                    track.Sectors = sectors.Where(s => s.SpoorId == result.Id).ToList();
                }
            }
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            var mode = (Maintenance.MaintenanceType) ddStatus.SelectedItem;

            switch (mode)
            {
                case Maintenance.MaintenanceType.Vervuild:
                    Database.SetVervuild(Convert.ToInt32(tbTramNummer.Text));
                    break;

                case Maintenance.MaintenanceType.Onderhouden:
                    Database.SetBroken(Convert.ToInt32(tbTramNummer.Text));
                    break;
            }
        }

        private void tSimulation_Tick(object sender, EventArgs e)
        {
            List<Tram> trams = Database.GetAllTrams().ToList();
            int randomTramId = Database.GetRandomTramIdNotRemise(trams.Count);
            _admin.AssignSector(trams.Single(t => t.Id == randomTramId));
        }

        private void btnSimulation_Click(object sender, EventArgs e)
        {
            tSimulation.Enabled = !tSimulation.Enabled;
        }
    }
}