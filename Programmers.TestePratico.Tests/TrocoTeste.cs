using Xunit;

namespace Programmers.TestePratico.Tests
{
    public class TrocoTeste
    {
        [Fact]
        public void Deve_Retornar_Total_Troco_Zero_Lista_Vazia()
        {
            // arrange
            var troco = new Troco();

            // act
            var valorTroco = troco.TotalTroco;

            // assert
            Assert.Equal(0, valorTroco);
        }

        [Fact]
        public void Deve_Retornar_Valor_Troco()
        {
            // arrange
            var troco = new Troco();
            troco.TrocoItens.Add(new TrocoItem(new Cedula(5, "5 reais"), quantidade: 2));
            troco.TrocoItens.Add(new TrocoItem(new Cedula(1, "1 real"), quantidade: 1));
            troco.TrocoItens.Add(new TrocoItem(new Moeda(0.05m, "5 centavos"), quantidade: 2));
            troco.TrocoItens.Add(new TrocoItem(new Moeda(0.01m, "1 centavo"), quantidade: 1));

            // act
            var valorTroco = troco.TotalTroco;
            var totalEsperado = (5 * 2) + 1 + (0.05m * 2) + 0.01m;

            // assert
            Assert.Equal(totalEsperado, valorTroco);
        }
    }
}
