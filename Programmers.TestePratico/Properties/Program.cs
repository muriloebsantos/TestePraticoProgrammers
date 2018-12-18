using System;

namespace Programmers.TestePratico.Properties
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Entre com o valor total da compra:");
            var valorCompra = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Entre com o valor pago:");
            var valorPago = Convert.ToDecimal(Console.ReadLine());

            var troco = new GerenciadorDeTroco().CalcularTroco(valorCompra, valorPago);

            if(troco.TotalTroco > 0)
            {
                Console.WriteLine("============ TROCO =============");

                foreach(var trocoItem in troco.TrocoItens)
                {
                    Console.WriteLine($"{trocoItem.Dinheiro.Valor} X {trocoItem.Quantidade}");
                }
            }
            else
            {
                Console.WriteLine("Não há troco");
            }

            Console.WriteLine("Pressione uma tecla para sair");
            Console.ReadKey();
        }
    }
}
