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
        private Administration admin = new Administration();

        /// <summary>
        ///     Constructs the default CleanupForm
        /// </summary>
        public CleanupForm()
        {
            InitializeComponent();
            ddbCleanupType.DataSource = Enum.GetValues(typeof (Schoonmaak.SchoonmaakType));
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

            var services = 0;


            switch (type)
            {
                case Schoonmaak.SchoonmaakType.GroteBeurt:
                    services = Database.CountCleaningService(dtpCleanupDate.Value, Schoonmaak.SchoonmaakType.GroteBeurt);
                    if (services < 3)
                    {
                        var schoonmaak = new Schoonmaak(medewerker, dtpCleanupDate.Value, tram, type);

                        Database.SaveCleanup(schoonmaak);
                    }
                    else
                    {
                        MessageBox.Show("Er kan geen grote service beurt meer gepland worden op die dag.");
                    }
                    break;
                case Schoonmaak.SchoonmaakType.KleineBeurt:
                    services = Database.CountCleaningService(dtpCleanupDate.Value, Schoonmaak.SchoonmaakType.KleineBeurt);
                    if (services < 4)
                    {
                        var schoonmaak = new Schoonmaak(medewerker, dtpCleanupDate.Value, tram, type);

                        Database.SaveCleanup(schoonmaak);
                    }
                    else
                    {
                        MessageBox.Show("Er kan geen kleine service beurt meer gepland worden op die dag.");
                    }
                    break;
            }


            LoadCleanupData(sender, e);
        }
    }
}