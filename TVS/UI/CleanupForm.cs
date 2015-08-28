using System;
using System.Linq;
using System.Windows.Forms;
using TVS.Models;

namespace TVS.UI
{
    /// <summary>
    ///     The form for the people that need to clean the tram
    /// </summary>
    public partial class CleanupForm : Form
    {
        /// <summary>
        ///     Constructs the default CleanupForm
        /// </summary>
        public CleanupForm()
        {
            InitializeComponent();
            ddbCleanupType.DataSource = Enum.GetValues(typeof (Schoonmaak.SchoonmaakType));
            FormClosed += (sender, args) => tRefreshData.Enabled = false;
        }


        /// <summary>
        ///     Updates the listbox with the most recent data from the database
        /// </summary>
        private void LoadCleanupData(object sender, EventArgs e)
        {
            // Store selectedIndex
            int selectedIndex = lbCleanupTasks.SelectedIndex;

            // get new data
            lbCleanupTasks.DataSource = Database.GetAllTrams().Where(tram => tram.Vervuild).ToList();

            // Restore selectedIndex
            lbCleanupTasks.SelectedIndex = selectedIndex >= lbCleanupTasks.Items.Count ? -1 : selectedIndex;

            // Get all 'schoonmakers'
            ddbEmployees.DataSource = Database.GetAllMedewerkers()
                .Where(medewerker => medewerker.Functie == Medewerker.FunctieType.Schoonmaker)
                .ToList();

            lbGeschiedenis.DataSource = Database.GetCleaningHistory().ToList();
        }

        /// <summary>
        ///     Saves a new cleanup to the database and refreshes the cleanup list
        /// </summary>
        private void btnRegisterCleanup_Click(object sender, EventArgs e)
        {
            var medewerker = ddbEmployees.SelectedItem as Medewerker;
            if (medewerker == null)
            {
                MessageBox.Show("Please select a valid employee!");
                return;
            }

            var tram = lbCleanupTasks.SelectedItem as Tram;
            if (tram == null)
            {
                MessageBox.Show("Please select a valid Tram!");
                return;
            }

            var type = (Schoonmaak.SchoonmaakType) ddbCleanupType.SelectedItem;
            DateTime date = dtpCleanupDate.Value;
            int max = type == Schoonmaak.SchoonmaakType.KleineBeurt ? 3 : 2;

            if (Database.CountCleaningService(date, type) < max)
            {
                var schoonmaak = new Schoonmaak(medewerker, date, tram, type);

                Database.SaveCleanup(schoonmaak);
            }
            else
            {
                MessageBox.Show($"Er kan geen {type} meer gepland worden op die dag.");
                return;
            }

            LoadCleanupData(sender, e);
        }
    }
}