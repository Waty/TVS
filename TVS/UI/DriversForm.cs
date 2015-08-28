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
        private readonly Administration _admin = new Administration();
        private readonly int _tramId;
        /// <summary>
        /// </summary>
        public DriversForm()
        {
            InitializeComponent();


            List<Tram> tramList = Database.GetAllTrams().ToList();
            var r = new Random();
            _tramId = r.Next(1, tramList.Count);
            while (Database.IsInRemise(_tramId))
            {
                _tramId = r.Next(1, tramList.Count);
            }
            tbTramNummer.Text = lbTramNummer.Text = tramList.First(t => t.Id == _tramId).Nummer.ToString();
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

            _admin.AssignSector(Convert.ToInt32(tbTramNummer.Text));
            Sector s = _admin.GetSector(_tramId);
            lbSectorNummer.Text = s.Nummer.ToString();
        }
    }
}