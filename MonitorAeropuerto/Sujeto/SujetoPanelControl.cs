using MonitorAeropuerto.Observador;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonitorAeropuerto.Model
{
    public class SujetoPanelControl
    {
        private List<IObservadorTablero> observadores = new List<IObservadorTablero>();
       
        private Random random = new Random();
        private int numero = 0;

        public List<Vuelo> vuelos { get; set; }

        public void Suscribir(IObservadorTablero observador) 
        {
            observadores.Add(observador);
        }

        private void Notificar() 
        {
            foreach (var item in observadores) 
            {
                item.Update(vuelos);
                item.Mostrar(vuelos);
            }
        }

        public void MostrarPanelControl() 
        {
            foreach (var item in observadores)
            {
                item.Mostrar(vuelos);
            }
        }

        public void Trabajo() 
        {
            

            foreach (var item in vuelos) 
            {
                numero = random.Next(5);
                item.Estado = numero;
            }
            Notificar();

        }

       
    }
}
