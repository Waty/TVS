using System;
using System.Linq;
using System.Windows.Forms;
using TVS.Models;

namespace TVS.UI
{
    public partial class NewTramForm : Form
    {
        private readonly Administration admin = new Administration();

        /// <summary>
        ///     Form for a new tram
        /// </summary>
        public NewTramForm()
        {
            InitializeComponent();
            cbType.DataSource = admin.GeTramTypes().ToList();
        }

        private void btnNieuw_Click(object sender, EventArgs e)
        {
            var type = (TramType) cbType.SelectedItem;
            int typeId = type.Id;
            var beschikbaar = 0;
            var geschikt = 0;

            if (cbBeschikbaar.Checked)
            {
                beschikbaar = 1;
            }

            if (cbConducteur.Checked)
            {
                geschikt = 1;
            }

            admin.NewTram(Convert.ToInt32(tbRemiseId.Text), typeId, Convert.ToInt32(tbNummer.Text),
                Convert.ToInt32(tbLengte.Text), geschikt, beschikbaar);
        }
    }
}