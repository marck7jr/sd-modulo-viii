using Microsoft.AspNetCore.Mvc;
using SD.ModuloVIII.Services;

namespace SD.ModuloVIII.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculadoraController : ControllerBase
    {
        private readonly ICalculadora _calculadora;

        public CalculadoraController(ICalculadora calculadora)
        {
            _calculadora = calculadora;
        }

        [HttpGet("somar")]
        public ActionResult<object> Somar([FromQuery] int x, [FromQuery] int y)
        {
            var resultado = _calculadora.Somar(x, y);

            return resultado;
        }

        [HttpGet("subtrair")]
        public ActionResult<object> Subtrair([FromQuery] int x, [FromQuery] int y)
        {
            var resultado = _calculadora.Subtrair(x, y);

            return resultado;
        }

        [HttpGet("multiplicar")]
        public ActionResult<object> Multiplicar([FromQuery] int x, [FromQuery] int y)
        {
            var resultado = _calculadora.Multiplicar(x, y);

            return resultado;
        }

        [HttpGet("dividir")]
        public ActionResult<object> Dividir([FromQuery] int x, [FromQuery] int y)
        {
            var resultado = _calculadora.Dividir(x, y);

            return resultado;
        }
    }
}
