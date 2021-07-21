using MonitorAeropuerto.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonitorAeropuerto.Model
{
    public class VueloLlegada : Vuelo
    {
       public string HoraLlegada { get; set; }

        public string Origen { get; set; }

    }
}
