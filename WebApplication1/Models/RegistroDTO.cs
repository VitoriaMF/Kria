using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Models
{
    public class RegistroDTO 
    {
        public string GUID { get; set; }
        public string CodigoPracaPedagio { get; set; }
        public string CodigoCabine { get; set; }
        public string Instante { get; set; }
        public string Sentido { get; set; }
        public string TipoVeiculo { get; set; }
        public string Isento { get; set; }
        public string Evasao { get; set; }
        public string TipoCobrancaEfetuada { get; set; }
        public string ValorDevido { get; set; }
        public string ValorArrecadado { get; set; }
        public string MultiplicadorTarifa { get; set; }
    }

}
