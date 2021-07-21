using MonitorAeropuerto.Model;
using MonitorAeropuerto.Observador;
using System;
using System.Collections.Generic;

namespace MonitorAeropuerto
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Inicio!");

            Console.WriteLine("==========Mostrar el Tablero Salidas================== ");
            
            List<Vuelo> vueloSalida = CargarVuelosSalidas();
            SujetoPanelControl panelControlSalida = new SujetoPanelControl() {
                vuelos = vueloSalida
            };
            ObservadorTablero tableroSalida = new ObservadorTablero(panelControlSalida) 
            {
                nombre = "SALIDA"
            };
            panelControlSalida.Trabajo();

            Console.WriteLine("==========Mostrar el Tablero Llegadas==================");

            List<Vuelo> vuelollegada = CargarVuelosLlegadas();
            SujetoPanelControl panelControlLlegada = new SujetoPanelControl()
            {
                vuelos = vuelollegada
            };
            ObservadorTablero tableroLlegada = new ObservadorTablero(panelControlLlegada)
            { 
                nombre = "LLEGADA"
            };
            panelControlLlegada.Trabajo();

            Console.WriteLine("==========Mostrar los Tableros==================");
            panelControlSalida.MostrarPanelControl();
            panelControlLlegada.MostrarPanelControl();

        }

        public static List<Vuelo> CargarVuelosSalidas() 
        {
            //Vuelos de salida
            VueloSalida vueloSalida1 = new VueloSalida()
            {   Compania = "Aerosur",
                Codigo = "ASUR-001",
                HoraSalida = "08:00",
                Destino = "La Santa Cruz",
                Estado = 1
            };
            VueloSalida vueloSalida2 = new VueloSalida()
            {
                Compania = "Boa",
                Codigo = "BOA-001",
                HoraSalida = "10:00",
                Destino = "La Paz",
                Estado = 3
            };
            VueloSalida vueloSalida3 = new VueloSalida()
            {
                Compania = "Aerosur",
                Codigo = "ASUR-002",
                HoraSalida = "14:00",
                Destino = "Pando",
                Estado = 5
            };

            //Vuelos de llegada

            List<Vuelo> vuelosSalida = new List<Vuelo>();
            vuelosSalida.Add(vueloSalida1);
            vuelosSalida.Add(vueloSalida2);
            vuelosSalida.Add(vueloSalida3);

            return vuelosSalida;
        }

        public static List<Vuelo> CargarVuelosLlegadas()
        {
            //Vuelos de Llegada
            VueloLlegada vueloLlegada1 = new VueloLlegada()
            {
                Compania = "Aerosur",
                Codigo = "ASUR-101",
                HoraLlegada = "09:00",
                Origen = "Potosi",
                Estado = 1
            };
            VueloLlegada vueloLlegada2 = new VueloLlegada()
            {
                Compania = "Boa",
                Codigo = "BOA-101",
                HoraLlegada = "10:30",
                Origen = "Tarija",
                Estado = 3
            };
            VueloLlegada vueloLlegada3 = new VueloLlegada()
            {
                Compania = "Aerosur",
                Codigo = "ASUR-102",
                HoraLlegada = "14:00",
                Origen = "Sucre",
                Estado = 5
            };

            //Vuelos de llegada

            List<Vuelo> vuelosLlegada = new List<Vuelo>();
            vuelosLlegada.Add(vueloLlegada1);
            vuelosLlegada.Add(vueloLlegada2);
            vuelosLlegada.Add(vueloLlegada3);

            return vuelosLlegada;
        }
    }
}
