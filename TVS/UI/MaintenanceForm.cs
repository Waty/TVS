using System;
using System.Windows.Forms;

namespace TVS.UI
{
    public partial class MaintenanceForm : Form
    {
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
                
            }
            else
            {
                MessageBox.Show("Selecteer eerst een tram");
            }
        }
    }
}