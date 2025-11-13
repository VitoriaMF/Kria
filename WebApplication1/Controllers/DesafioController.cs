using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;

public class DesafioController : Controller
{
    private readonly MongoService _mongo;
    private readonly DesafioService _desafio;

    public DesafioController(MongoService mongo, DesafioService desafio)
    {
        _mongo = mongo;
        _desafio = desafio;
    }

    public async Task<IActionResult> Index()
    {
        var transacoes = _mongo.ObterTransacoes();
        var resultado = await _desafio.EnviarDesafioAsync(transacoes);
        ViewBag.Mensagem = resultado;
        return View(transacoes);
    }
}
