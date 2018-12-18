using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmers.TestePratico
{
    public class GerenciadorDeTroco
    {
        private readonly List<Dinheiro> cedulasMoedas;

        public GerenciadorDeTroco()
        {
            cedulasMoedas = new List<Dinheiro>
            {
                new Cedula(1, "1 real"),
                new Cedula(5, "5 reais"),
                new Cedula(10, "10 reais"),
                new Cedula(50, "50 reais"),
                new Cedula(100, "100 reais"),
                new Moeda(0.01m, "1 centavo"),
                new Moeda(0.05m, "5 centavos"),
                new Moeda(0.10m, "10 centavos"),
                new Moeda(0.50m, "50 centavos")
            };
        }

        public Troco CalcularTroco(decimal valorTotal, decimal valorPago)
        {
            var troco = new Troco();

            if (valorTotal == valorPago)
                return troco;

            if (valorPago < valorTotal)
                return troco;

            var trocoRestante = valorPago - valorTotal;

            while(trocoRestante > 0)
            {
                var proximoTroco = cedulasMoedas
                                        .Where(c => trocoRestante >= c.Valor)
                                        .OrderByDescending(c => c.Valor)
                                        .FirstOrDefault();

                troco.AdicionarTroco(proximoTroco);

                trocoRestante -= proximoTroco.Valor;
            }

            return troco;
        }
    }
}
