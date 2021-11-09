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
        private int childFormNumber = 0;

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
            this.Size = new Size(parking.Size.Width + 25, parking.Size.Height + 45);
            parking.Show();
        }
    }
}
