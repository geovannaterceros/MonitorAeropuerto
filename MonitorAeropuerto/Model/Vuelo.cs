
namespace MonitorAeropuerto.Model
{
    public abstract class Vuelo
    {
        public string Compania { get; set; }
      
        public int Estado { get; set; }

        public string Codigo { get; set; }
    }
}
