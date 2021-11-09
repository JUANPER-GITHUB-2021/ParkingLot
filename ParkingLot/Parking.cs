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
    public partial class Parking : Form
    {
        public Parking()
        {
            InitializeComponent();
        }

        Dictionary<int, Vehiculo> parking = new Dictionary<int, Vehiculo>();
        Vehiculo[] carros = { new Vehiculo(), new Vehiculo(), new Vehiculo(), new Vehiculo(), new Vehiculo(), new Vehiculo(), new Vehiculo(), new Vehiculo(), new Vehiculo(), new Vehiculo() };
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Ingreso ingreso = new Ingreso
            {
                MdiParent = this.MdiParent

            };
            this.MdiParent.Size = new Size(ingreso.Size.Width + 25, ingreso.Size.Height + 45);
            ingreso.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
