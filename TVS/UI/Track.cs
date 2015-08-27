using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TVS.Models;

namespace TVS.UI
{
    /// <summary>
    ///     :wut:
    /// </summary>
    public partial class Track : UserControl
    {
        private int _length;
        private int _number;
        private int _sectorHeight = 20;
        private IReadOnlyCollection<Sector> _sectors = new List<Sector>();

        /// <summary>
        ///     Initializes a new Track
        /// </summary>
        public Track()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     The sectors for the current track
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public IReadOnlyCollection<Sector> Sectors
        {
            get { return _sectors; }
            set
            {
                _sectors = value;
                Refresh();
            }
        }

        /// <summary>
        ///     The height of the drawn sectors
        /// </summary>
        public int SectorHeight
        {
            get { return _sectorHeight; }
            set
            {
                _sectorHeight = value;
                lbNumber.Height = value;
                Refresh();
            }
        }

        /// <summary>
        ///     The distance between sectors
        /// </summary>
        public int SectorPadding { get; set; } = 5;

        /// <summary>
        ///     The Number of the track
        /// </summary>
        public int Number
        {
            get { return _number; }
            set
            {
                _number = value;
                lbNumber.Text = value.ToString();
            }
        }


        /// <summary>
        ///     The amount of sectors on this track
        /// </summary>
        public int Length
        {
            get { return _length; }
            set
            {
                _length = value;
                Refresh();
            }
        }

        /// <summary>
        ///     Raises the <see cref="E:System.Windows.Forms.Control.Paint" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs" /> that contains the event data. </param>
        protected override void OnPaint(PaintEventArgs e)
        {
            for (var i = 1; i <= Length; i++)
            {
                var rect = new Rectangle
                {
                    X = 0,
                    Y = i*(SectorHeight + SectorPadding),
                    Height = SectorHeight,
                    Width = e.ClipRectangle.Width - 1
                };
                e.Graphics.DrawRectangle(Pens.Black, rect);
            }
        }
    }
}