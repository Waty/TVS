using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            cbType.DataSource = admin.GeTramTypes().Select(t => t.Omschrijving).ToList();
          
            
        }

        private void btnNieuw_Click(object sender, EventArgs e)
        {

        }
    }
}
