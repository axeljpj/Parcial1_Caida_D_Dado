namespace Parcial1_Caida_D_Dado.Models
{
    public class CaidaModel
    {
        private static Random random = new Random();
        public double TiempoCaida { get; set; }
        public int NumeroGenerado { get; set; }
        public double Altura { get; set; }
    }
}
