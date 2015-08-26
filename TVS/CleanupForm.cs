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
        }


        /// <summary>
        ///     Updates the listbox with the most recent data from the database
        /// </summary>
        private void LoadCleanupData(object sender, EventArgs e)
        {
            lbCleanupTasks.DataSource = Database.GetAllTrams().Where(tram => tram.Vervuild).ToList();
        }

        /// <summary>
        ///     Saves a new cleanup to the database and refreshes the cleanup list
        /// </summary>
        private void btnRegisterCleanup_Click(object sender, EventArgs e)
        {
            //TODO: save the cleanup in the database
            LoadCleanupData(sender, e);
        }
    }
}