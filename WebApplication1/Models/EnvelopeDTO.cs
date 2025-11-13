using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Models
{
    public class EnvelopeDTO
    {
        public string Candidato { get; set; }
        public string DataReferencia { get; set; }
        public int NumeroArquivo { get; set; }
        public int Motivo { get; set; }
        public string CnpjConcessionaria { get; set; }
        public List<RegistroDTO> Registros { get; set; }
    }

}
