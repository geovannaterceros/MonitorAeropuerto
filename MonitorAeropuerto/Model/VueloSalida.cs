using MonitorAeropuerto.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonitorAeropuerto.Model
{
    public class VueloSalida : Vuelo
    {
        public string HoraSalida { get; set; }
        public string Destino { get; set; }
    }
}
