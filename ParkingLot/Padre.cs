using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingLot
{
    public partial class Padre : Form
    {
        public Padre()
        {
            InitializeComponent();
        }

        private void Padre_Load(object sender, EventArgs e)
        {
            Parking parking = new Parking
            {
                MdiParent = this
            };
            this.Size = new Size(parking.Size.Width + 20, parking.Size.Height + 43);
            parking.Show();
        }
    }
}
