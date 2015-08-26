using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVS.Models;

namespace TVS.UI
{
    public partial class NewTramForm : Form
    {
        Administration admin = new Administration();
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
            TramType type = (TramType) cbType.SelectedItem;
            int typeId = type.Id;
            int beschikbaar = 0;
            int geschikt = 0;

            if (cbBeschikbaar.Checked)
            {
                beschikbaar = 1;
            }

            if (cbConducteur.Checked)
            {
                geschikt = 1;
            }

            admin.NewTram(Convert.ToInt32(tbRemiseId.Text), typeId, Convert.ToInt32(tbNummer.Text), Convert.ToInt32(tbLengte.Text), geschikt, beschikbaar);
         
        }
    }
}
