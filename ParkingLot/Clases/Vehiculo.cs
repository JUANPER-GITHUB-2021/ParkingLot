using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot
{
    class Vehiculo
    {
        //Variables para Vehiculo//
        public string tipo { get => tipo; set => tipo = value; }
        public string placa { get => placa; set => placa = value; }
        public string marca { get => marca; set => marca = value; }

        //Variables para Conductor//
        public string identificacion { get => identificacion; set => identificacion = value; }
        public string sexo { get => sexo; set => sexo = value; }
        public bool afiliacion { get => afiliacion; set => afiliacion = value; }

    }
}
