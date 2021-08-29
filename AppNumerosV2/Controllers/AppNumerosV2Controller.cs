using AppNumerosV2.Dominio.Argumentos;
using AppNumerosV2.Dominio.Servicos;
using Microsoft.AspNetCore.Mvc;

namespace AppNumerosV2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppNumerosController : ControllerBase
    {
        // GET: api/AppNumerosV2/5
        [HttpGet("{numero}", Name = "Get")]
        public AppNumerosResponse Calcula(string numero)
        {
            AppNumerosResponse resultado = ServicoAppNumeros.Calcula(numero);
            return resultado;
        }
    }
}
