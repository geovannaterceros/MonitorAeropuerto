using MonitorAeropuerto.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonitorAeropuerto.Observador { 
    public interface IObservadorTablero
    {
        public void Update(List<Vuelo> vuelos);

        public void Mostrar(List<Vuelo> vuelos);
    }

}
