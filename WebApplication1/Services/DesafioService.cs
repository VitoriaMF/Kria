using System.Net.Http.Json;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class DesafioService
    {
        string DeparaSentido(int valor) => valor == 1 ? "Crescente" : "Decrescente";
        string DeparaTipoVeiculo(int valor) => valor switch { 1 => "Passeio", 2 => "Comercial", 3 => "Moto", _ => "Desconhecido" };
        string DeparaIsento(int valor) => valor == 1 ? "Sim" : "Não";
        string DeparaEvasao(int valor) => valor == 1 ? "Sim" : "Não";
        string DeparaTipoCobranca(int valor) => valor switch { 1 => "Manual", 2 => "TAG", 3 => "OCR/Placa", _ => "Desconhecido" };

        decimal CalcularMultiplicador(int tipoVeiculo, int isento)
        {
            return tipoVeiculo switch
            {
                3 when isento == 1 => 0m,
                3 when isento == 2 => 0.5m,
                1 => 1.0m, // ou lógica para 1.5 / 2.0
                2 => 2.0m, // ou lógica para 2–20
                _ => 1.0m
            };
        }

        public async Task<string> EnviarDesafioAsync(List<TabTransacao> transacoes)
        {
            var registros = transacoes.Select(t => new RegistroDTO
            {
                GUID = t.Id, // ou t.GUID se disponível
                CodigoPracaPedagio = t.CodigoPracaPedagio,
                CodigoCabine = t.CodigoCabine.ToString(),
                Instante = t.Instante,
                Sentido = DeparaSentido(t.Sentido),
                TipoVeiculo = DeparaTipoVeiculo(t.TipoVeiculo),
                Isento = DeparaIsento(t.Isento),
                Evasao = DeparaEvasao(t.Evasao),
                TipoCobrancaEfetuada = DeparaTipoCobranca(t.TipoCobranca),
                ValorDevido = t.ValorDevido.ToString(),
                ValorArrecadado = t.ValorArrecadado.ToString(),
                MultiplicadorTarifa = CalcularMultiplicador(t.TipoVeiculo, t.Isento).ToString()
            }).ToList();

            var envelope = new
            {
                Candidato = "Vitória Mariano Fernandez",
                DataReferencia = DateTime.Now.ToString("dd/MM/yyyy"),
                Motivo = 1,
                CnpjConcessionaria = "12345678000190",
                NumeroArquivo = 1,
                Registros = registros
            };

            using var client = new HttpClient();
            var response = await client.PostAsJsonAsync("https://contratacaosirapi.azurewebsites.net/Candidato/PublicarDesafio", envelope);
            return await response.Content.ReadAsStringAsync();
        }
    }
}
