using System;
using System.Windows.Forms;
using TVS.Models;

namespace TVS.UI
{
    public partial class MaintenanceForm : Form
    {
        Tram _tram = new Tram();
        /// <summary>
        /// </summary>
        public MaintenanceForm()
        {
            InitializeComponent();
        }

        private void btnOnderhoudLijst_Click(object sender, EventArgs e)
        {

        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            if (lbOnderhoud.SelectedItem != null)
            {
                string tram = lbOnderhoud.SelectedItem.ToString();
                _tram = Database.GetTram(Convert.ToInt32(tram));
                if (cbStatus.SelectedIndex == 0)
                {
                    _tram.Vervuild = true;
                    _tram.Beschikbaar = false;
                    _tram.Defect = false;
                }
                else if (cbStatus.SelectedIndex == 1)
                {
                    _tram.Vervuild = false;
                    _tram.Beschikbaar = true;
                    _tram.Defect = false;
                }
                else
                {
                    MessageBox.Show("Selecteer een status");
                }
            }
            else
            {
                MessageBox.Show("Selecteer eerst een tram");
            }
        }
    }
}