using System;
using System.Linq;
using System.Windows.Forms;
using TVS.Models;

namespace TVS.UI
{
    public partial class NewTramForm : Form
    {
        private readonly Administration _admin = new Administration();

        /// <summary>
        ///     Form for a new tram
        /// </summary>
        public NewTramForm()
        {
            InitializeComponent();
            cbType.DataSource = _admin.GeTramTypes().ToList();
        }

        private void btnNieuw_Click(object sender, EventArgs e)
        {
            if (Database.GetAllTrams().ToList().Any(tram => tram.Nummer == Convert.ToInt32(tbNummer.Text)))
            {
                MessageBox.Show("Tram nummer bestaat al");
                return;
            }

            int typeId = ((TramType) cbType.SelectedItem).Id;
            int beschikbaar = cbBeschikbaar.Checked ? 1 : 0;
            int geschikt = cbConducteur.Checked ? 1 : 0;


            _admin.NewTram(Convert.ToInt32(tbRemiseId.Text), typeId, Convert.ToInt32(tbNummer.Text),
                Convert.ToInt32(tbLengte.Text), geschikt, beschikbaar);
            MessageBox.Show("De Tram is aangemaakt!");
            DialogResult = DialogResult.OK;
        }
    }
}