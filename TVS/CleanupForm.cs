using System;
using System.Windows.Forms;
using System.Linq;

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
            lbSchoonmaak.DataSource = Database.GetVervuild().ToList();
        }
    }
}