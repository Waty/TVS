using System;
using System.Linq;
using System.Windows.Forms;

namespace TVS
{
    /// <summary>
    /// </summary>
    public partial class CleanupForm : Form
    {
        /// <summary>
        /// </summary>
        public CleanupForm()
        {
            InitializeComponent();
        }

        private void Schoonmaak_Load(object sender, EventArgs e) {}

        private void btnSchoonmaakLijst_Click(object sender, EventArgs e)
        {
            lbSchoonmaak.DataSource = Database.GetAllTrams().Where(tram => tram.Vervuild).ToList();
        }
    }
}