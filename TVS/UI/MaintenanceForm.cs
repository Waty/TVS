using System;
using System.Linq;
using System.Windows.Forms;
using TVS.Models;

namespace TVS.UI
{
    public partial class MaintenanceForm : Form
    {
        /// <summary>
        ///     Constructs the form with all of its controls and loads the trams from the db
        /// </summary>
        public MaintenanceForm()
        {
            InitializeComponent();
            RefreshDatasource();
            cbStatus.DataSource = Enum.GetValues(typeof (Maintenance.MaintenanceType));
        }

        /// <summary>
        ///     Retrieves a fresh copy of all the trams and stores it in the listbox
        /// </summary>
        private void RefreshDatasource()
        {
            lbDefectTrams.DataSource = Database.GetAllTrams().Where(t => t.Defect).ToList();
            ddbEmployees.DataSource = Database.GetAllMedewerkers()
                .Where(m => m.Functie == Medewerker.FunctieType.Technicus).
                ToList();
            lbGeschiedenis.DataSource = Database.GetMaintenanceHistory().ToList();
        }

        /// <summary>
        ///     Updates the selected tram and adds the maintenance to the history
        /// </summary>
        private void btnOnderhoud_Click(object sender, EventArgs e)
        {
            var medewerker = ddbEmployees.SelectedItem as Medewerker;
            var tram = lbDefectTrams.SelectedItem as Tram;
            var mode = (Maintenance.MaintenanceType) cbStatus.SelectedItem;

            if (medewerker == null)
            {
                MessageBox.Show("Please select a valid employee!");
                return;
            }

            if (tram == null)
            {
                MessageBox.Show("Please select a valid Tram!");
                return;
            }


            switch (mode)
            {
                case Maintenance.MaintenanceType.Vervuild:
                    tram.Vervuild = true;
                    tram.Defect = false;
                    break;

                case Maintenance.MaintenanceType.Onderhouden:
                    tram.Defect = false;
                    break;
            }

            Database.UpdateTram(tram);
            RefreshDatasource();

            var c = new Maintenance(medewerker, dtpOnderhoud.Value, tram, mode);
            Database.SaveMaintenance(c);

            RefreshDatasource();
        }
    }
}