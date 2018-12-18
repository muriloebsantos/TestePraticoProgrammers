using System.Collections.Generic;
using System.Linq;

namespace Programmers.TestePratico
{
    public class Troco
    {
        public Troco()
        {
            TrocoItens = new List<TrocoItem>();
        }

        public List<TrocoItem> TrocoItens { get; private set; }
        public decimal TotalTroco => TrocoItens.Sum(itens => itens.Dinheiro.Valor * itens.Quantidade);

        public void AdicionarTroco(Dinheiro dinheiro)
        {
            var trocoItem = TrocoItens.FirstOrDefault(item => item.Dinheiro.Valor == dinheiro.Valor);

            if(trocoItem == null)
            {
                trocoItem = new TrocoItem(dinheiro, 0);
                TrocoItens.Add(trocoItem);
            }

            trocoItem.IncrementarQuantidade();
        }
    }
}
