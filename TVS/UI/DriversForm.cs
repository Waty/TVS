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
            lbTramNummer.Text = tramList.First(t => t.Id == tramId).Nummer.ToString();
            tbTramNummer.Text = tramList.First(t => t.Id == tramId).Nummer.ToString();
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
        }
    }
}