using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    public class Vehiculo
    {
        //Variables para Vehiculo//
        public string Tipo { get => Tipo; set => Tipo = value; }
        public string Placa { get => Placa; set => Placa = value; }
        public string Marca { get => Marca; set => Marca = value; }

        //Variables para Conductor//
        public string Identificacion { get => Identificacion; set => Identificacion = value; }
        public string Sexo { get => Sexo; set => Sexo = value; }
        public bool Afiliacion { get => Afiliacion; set => Afiliacion = value; }
        public DateTime Hora { get => Hora; set => Hora = value; }

    }
}
