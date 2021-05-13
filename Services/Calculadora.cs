using Microsoft.Extensions.Logging;

namespace SD.ModuloVIII.Services
{
    public class Calculadora : ICalculadora
    {
        private readonly ILogger<Calculadora> _logger;

        public Calculadora(ILogger<Calculadora> logger)
        {
            _logger = logger;
        }

        public double Dividir(int x, int y)
        {
            var resultado = x / (double)y;

            _logger.LogInformation($"Respondendo com {resultado}");

            return resultado;
        }

        public int Multiplicar(int x, int y)
        {
            var resultado = x * y;

            _logger.LogInformation($"Respondendo com {resultado}");

            return resultado;
        }

        public int Somar(int x, int y)
        {
            var resultado = x + y;

            _logger.LogInformation($"Respondendo com {resultado}");

            return resultado;
        }

        public int Subtrair(int x, int y)
        {
            var resultado = x - y;

            _logger.LogInformation($"Respondendo com {resultado}");

            return resultado;
        }
    }
}
