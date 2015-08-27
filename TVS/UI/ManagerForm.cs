using System.Windows.Forms;

namespace TVS.UI
{
    /// <summary>
    ///     The form for the manager
    /// </summary>
    public partial class ManagerForm : Form
    {
        /// <summary>
        ///     Initializes the UI and hooks up the events
        /// </summary>
        public ManagerForm()
        {
            InitializeComponent();
            btnCleanup.Click += (sender, args) => new CleanupForm().ShowDialog();
            btnMaintenance.Click += (sender, args) => new MaintenanceForm().ShowDialog();
            btnDriver.Click += (sender, args) => new DriversForm().ShowDialog();
            btnRemise.Click += (sender, args) => new RemiseForm().ShowDialog();
        }
    }
}