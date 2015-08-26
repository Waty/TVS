using System;
using System.Linq;
using System.Windows.Forms;

namespace TVS
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
        }


        /// <summary>
        ///     Updates the listbox with the most recent data from the database
        /// </summary>
        private void LoadCleanupData(object sender, EventArgs e)
        {
            lbCleanupTasks.DataSource = Database.GetAllTrams().Where(tram => tram.Vervuild).ToList();
            ddbEmployees.DataSource = Database.GetAllMedewerkers()
                .Where(medewerker => medewerker.Functie == Medewerker.FunctieType.Schoonmaker)
                .ToList();
        }

        /// <summary>
        ///     Saves a new cleanup to the database and refreshes the cleanup list
        /// </summary>
        private void btnRegisterCleanup_Click(object sender, EventArgs e)
        {
            if (!(ddbEmployees.SelectedItem is Medewerker))
            {
                MessageBox.Show("Please select a valid employee!");
                return;
            }

            if (!(lbCleanupTasks.SelectedItem is Tram))
            {
                MessageBox.Show("Please select a valid Tram!");
                return;
            }

            var c = new Schoonmaak((Medewerker) ddbEmployees.SelectedItem,
                dtpCleanupDate.Value,
                (Tram) lbCleanupTasks.SelectedItem,
                (Schoonmaak.SchoonmaakType) ddbCleanupType.SelectedItem);

            Database.SaveCleanup(c);

            LoadCleanupData(sender, e);
        }
    }
}