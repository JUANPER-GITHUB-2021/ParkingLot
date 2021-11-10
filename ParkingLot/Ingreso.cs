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
    public partial class Ingreso : Form
    {
        public Dictionary<int, Vehiculo> save;
        public Ingreso(Dictionary<int, Vehiculo> guardar)
        {
            InitializeComponent();
            save = guardar;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int f = 0; f < 10; f++)
            {
                try
                {
                    if (save.Count == 0)
                    {
                        save.Add(f, new Vehiculo { Marca = TBMarca.Text, Placa = TBPlaca.Text, Tipo = ComboBoxTipo.Text, Sexo = TBSexo.Text, Identificacion = TBIdentificacion.Text, Afiliacion = checkBox1.Checked, Hora = DateTime.Now });
                        break;
                    }
                    if (save[f].Placa != null)
                    {
                        continue;
                    }
                }
                catch
                {
                    save.Add(f, new Vehiculo { Marca = TBMarca.Text, Placa = TBPlaca.Text, Tipo = ComboBoxTipo.Text, Sexo = TBSexo.Text, Identificacion = TBIdentificacion.Text, Afiliacion = checkBox1.Checked, Hora = DateTime.Now });
                    break;
                }
            }
        }
    }
}
