namespace Cotizador.Api.DTO
{
    public class CotizadorDTO
    {
        public double Interes { get; set; }
        public double TasaInteres { get; set; }
        public string Periodo { get; set; }
        public double MontoRecibir { get; set; }
        public int Monto { get; set; }
        public int Plazo { get; set; }
        public string Msj { get; set; }
    }
}
