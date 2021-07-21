using MonitorAeropuerto.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonitorAeropuerto.Observador
{
    public class ObservadorTablero : IObservadorTablero
    {
       // private string nombre;
        private SujetoPanelControl sujetoPanel;

        public ObservadorTablero(SujetoPanelControl sujetoPanel) 
        {
            sujetoPanel = sujetoPanel;
            sujetoPanel.Suscribir(this);
        }

        public string nombre { get; set; }

        public void Update(List<Vuelo> vuelos)
        {
            Console.WriteLine("Tablero {0}", nombre);
        }

        public void Mostrar(List<Vuelo> vuelos) 
        {
            foreach (var item in vuelos)
            {
                Console.WriteLine(" Compañia: {0} , Codigo: {1} , Estado: {2}", item.Compania, item.Codigo, diccionario[item.Estado]);
            }
        }
        /*public enum Estado
        {
            0 = "sin_Informacion" ,
            1 =" demora" ,
            2 = "cerrado" //,
            3 = embarque ,
            4 = última_llamada ,
            5 = confirmado
        }*/
        Dictionary<int, string> diccionario = new Dictionary<int, string>{
            { 0 , "sin_Informacion" },
            {1 , " demora" },
            {2 , "cerrado" },
            {3 , "embarque" },
            {4 , "última_llamada" },
            {5 , "confirmado" }
        };

    }
}
