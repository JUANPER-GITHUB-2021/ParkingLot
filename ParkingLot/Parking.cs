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
        public Dictionary<int, Vehiculo> parqueaderovehiculos;

        public Parking(Dictionary<int, Vehiculo> parqueadero)
        {
            InitializeComponent();
            parqueaderovehiculos = parqueadero;
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    if (parqueaderovehiculos[i].Placa == null)
                    {
                        if (i == 0)
                        {
                            //sin el signo peso toma todo como texto, y se requiere que ejecute esa instruccion//
                            Lblnombre1.Text = $"Slot ocupado\n  {parqueaderovehiculos[i].Marca}\n";
                            Lblplaca1.Text = $"Slot ocupado\n  {parqueaderovehiculos[i].Placa}\n";
                            Lbltipo1.Text = $"Slot ocupado\n  {parqueaderovehiculos[i].Tipo}\n";
                        }
                        if (i == 1)
                        {
                            //sin el signo peso toma todo como texto, y se requiere que ejecute esa instruccion//
                            Lblnombre2.Text = $"Slot ocupado\n  {parqueaderovehiculos[i].Marca}\n";
                            Lblplaca2.Text = $"Slot ocupado\n  {parqueaderovehiculos[i].Placa}\n";
                            Lbltipo2.Text = $"Slot ocupado\n  {parqueaderovehiculos[i].Tipo}\n";
                        }
                        if (i == 2)
                        {
                            //sin el signo peso toma todo como texto, y se requiere que ejecute esa instruccion//
                            Lblnombre3.Text = $"Slot ocupado\n  {parqueaderovehiculos[i].Marca}\n";
                            Lblplaca3.Text = $"Slot ocupado\n  {parqueaderovehiculos[i].Placa}\n";
                            Lbltipo3.Text = $"Slot ocupado\n  {parqueaderovehiculos[i].Tipo}\n";
                        }
                        if (i == 3)
                        {
                            //sin el signo peso toma todo como texto, y se requiere que ejecute esa instruccion//
                            Lblnombre4.Text = $"Slot ocupado\n  {parqueaderovehiculos[i].Marca}\n";
                            Lblplaca4.Text = $"Slot ocupado\n  {parqueaderovehiculos[i].Placa}\n";
                            Lbltipo4.Text = $"Slot ocupado\n  {parqueaderovehiculos[i].Tipo}\n";
                        }
                        if (i == 4)
                        {
                            //sin el signo peso toma todo como texto, y se requiere que ejecute esa instruccion//
                            Lblnombre5.Text = $"Slot ocupado\n  {parqueaderovehiculos[i].Marca}\n";
                            Lblplaca5.Text = $"Slot ocupado\n  {parqueaderovehiculos[i].Placa}\n";
                            Lbltipo5.Text = $"Slot ocupado\n  {parqueaderovehiculos[i].Tipo}\n";
                        }
                        if (i == 5)
                        {
                            //sin el signo peso toma todo como texto, y se requiere que ejecute esa instruccion//
                            Lblnombre6.Text = $"Slot ocupado\n  {parqueaderovehiculos[i].Marca}\n";
                            Lblplaca6.Text = $"Slot ocupado\n  {parqueaderovehiculos[i].Placa}\n";
                            Lbltipo6.Text = $"Slot ocupado\n  {parqueaderovehiculos[i].Tipo}\n";
                        }
                        if (i == 6)
                        {
                            //sin el signo peso toma todo como texto, y se requiere que ejecute esa instruccion//
                            Lblnombre7.Text = $"Slot ocupado\n  {parqueaderovehiculos[i].Marca}\n";
                            Lblplaca7.Text = $"Slot ocupado\n  {parqueaderovehiculos[i].Placa}\n";
                            Lbltipo7.Text = $"Slot ocupado\n  {parqueaderovehiculos[i].Tipo}\n";
                        }
                        if (i == 7)
                        {
                            //sin el signo peso toma todo como texto, y se requiere que ejecute esa instruccion//
                            Lblnombre8.Text = $"Slot ocupado\n  {parqueaderovehiculos[i].Marca}\n";
                            Lblplaca8.Text = $"Slot ocupado\n  {parqueaderovehiculos[i].Placa}\n";
                            Lbltipo8.Text = $"Slot ocupado\n  {parqueaderovehiculos[i].Tipo}\n";
                        }
                        if (i == 8)
                        {
                            //sin el signo peso toma todo como texto, y se requiere que ejecute esa instruccion//
                            Lblnombre9.Text = $"Slot ocupado\n  {parqueaderovehiculos[i].Marca}\n";
                            Lblplaca9.Text = $"Slot ocupado\n  {parqueaderovehiculos[i].Placa}\n";
                            Lbltipo9.Text = $"Slot ocupado\n  {parqueaderovehiculos[i].Tipo}\n";
                        }
                        if (i == 9)
                        {
                            //sin el signo peso toma todo como texto, y se requiere que ejecute esa instruccion//
                            Lblnombre10.Text = $"Slot ocupado\n  {parqueaderovehiculos[i].Marca}\n";
                            Lblplaca10.Text = $"Slot ocupado\n  {parqueaderovehiculos[i].Placa}\n";
                            Lbltipo10.Text = $"Slot ocupado\n  {parqueaderovehiculos[i].Tipo}\n";
                        }
                    }
                }
                catch
                {
                    continue;
                }
            }
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
            Ingreso ingreso = new Ingreso(parqueaderovehiculos)
            {
                MdiParent = this.MdiParent
            };
            this.MdiParent.Size = new Size(ingreso.Size.Width + 25, ingreso.Size.Height + 45);
            ingreso.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Retiro retiro = new Retiro
            {
                MdiParent = this.MdiParent
            };
            this.MdiParent.Size = new Size(retiro.Size.Width + 25, retiro.Size.Height + 45);
            retiro.Show();
            this.Close();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
