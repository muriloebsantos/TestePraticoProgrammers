using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Programmers.TestePratico.Tests
{
    public class GerenciadorTrocoTeste
    {
        private readonly GerenciadorDeTroco gerenciadorTroco;

        public GerenciadorTrocoTeste()
        {
            gerenciadorTroco = new GerenciadorDeTroco();
        }

        [Theory]
        [InlineData(1, 1)]
        [InlineData(100, 100)]
        [InlineData(120.50, 120.50)]
        public void Deve_Retornar_Troco_Zero_Se_Valor_Total_Igual_Valor_Pago(decimal valorTotal, decimal valorPago)
        {
            var troco = gerenciadorTroco.CalcularTroco(valorTotal, valorPago);

            Assert.Equal(0, troco.TotalTroco);
        }

        [Theory]
        [InlineData(1, 0)]
        [InlineData(100, 99)]
        [InlineData(120.50, 120.49)]
        public void Deve_Retornar_Troco_Zero_Se_Valor_Pago_Menor_Que_Valor_Total(decimal valorTotal, decimal valorPago)
        {
            var troco = gerenciadorTroco.CalcularTroco(valorTotal, valorPago);

            Assert.Equal(0, troco.TotalTroco);
        }

        [Fact]
        public void Deve_Retornar_Tres_Notas_De_Cem()
        {
            var troco = gerenciadorTroco.CalcularTroco(100, 400);

            var troco100 = troco.TrocoItens.FirstOrDefault(item => item.Dinheiro.Valor == 100);

            Assert.Equal(3, troco100.Quantidade);
        }

        [Fact]
        public void Deve_Retornar_Uma_Nota_De_Cinquenta_E_Uma_Nota_De_Cem()
        {
            var troco = gerenciadorTroco.CalcularTroco(100, 250);

            var troco100 = troco.TrocoItens.FirstOrDefault(item => item.Dinheiro.Valor == 100);
            var troco50 = troco.TrocoItens.FirstOrDefault(item => item.Dinheiro.Valor == 50);

            Assert.Equal(1, troco100.Quantidade);
            Assert.Equal(1, troco50.Quantidade);
        }
    }
}
