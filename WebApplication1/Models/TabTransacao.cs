using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WebApplication1.Models
{
    [BsonIgnoreExtraElements] // Ignora campos não mapeados
    public class TabTransacao
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("IdTransacao")]
        public int IdTransacao { get; set; }

        [BsonElement("DtCriacao")]
        public DateTime DtCriacao { get; set; }

        [BsonElement("CodigoPracaPedagio")]
        public string CodigoPracaPedagio { get; set; }

        [BsonElement("CodigoCabine")]
        public int CodigoCabine { get; set; }

        [BsonElement("Instante")]
        public string Instante { get; set; }

        [BsonElement("Sentido")]
        public int Sentido { get; set; }

        [BsonElement("QuantidadeEixosVeiculo")]
        public int QuantidadeEixosVeiculo { get; set; }

        [BsonElement("Rodagem")]
        public int Rodagem { get; set; }

        [BsonElement("Isento")]
        public int Isento { get; set; }

        [BsonElement("MotivoIsencao")]
        public int MotivoIsencao { get; set; }

        [BsonElement("Evasao")]
        public int Evasao { get; set; }

        [BsonElement("EixoSuspenso")]
        public int EixoSuspenso { get; set; }

        [BsonElement("QuantidadeEixosSuspensos")]
        public int QuantidadeEixosSuspensos { get; set; }

        [BsonElement("TipoCobranca")]
        public int TipoCobranca { get; set; }

        [BsonElement("Placa")]
        public string Placa { get; set; }

        [BsonElement("LiberacaoCancela")]
        public int LiberacaoCancela { get; set; }

        [BsonElement("ValorDevido")]
        public decimal ValorDevido { get; set; }

        [BsonElement("ValorArrecadado")]
        public decimal ValorArrecadado { get; set; }

        [BsonElement("CnpjAmap")]
        public string CnpjAmap { get; set; }

        [BsonElement("MultiplicadorTarifa")]
        public decimal? MultiplicadorTarifa { get; set; }

        [BsonElement("VeiculoCarregado")]
        public int VeiculoCarregado { get; set; }

        [BsonElement("IdTag")]
        public string IdTag { get; set; }

        [BsonElement("TipoVeiculo")]
        public int TipoVeiculo { get; set; }
    }
}