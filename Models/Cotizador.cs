namespace Cotizador.Api.Models
{
    public class Cotizador
    {
        public int Monto { get; set; }
        public int Plazo { get; set; }
        public double Interes {  get; set; }
        public  double TasaInteres { get; set; }
        public string Periodo {  get; set; }
        public string MontoRecibir {  get; set; }

    }
}
