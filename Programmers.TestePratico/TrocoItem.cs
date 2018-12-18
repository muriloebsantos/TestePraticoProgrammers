namespace Programmers.TestePratico
{
    public class TrocoItem
    {
        public TrocoItem(Dinheiro dinheiro, int quantidade)
        {
            Dinheiro = dinheiro;
            Quantidade = quantidade;
        }

        public Dinheiro Dinheiro { get; private set; }
        public int Quantidade { get; private set; }

        public void IncrementarQuantidade()
        {
            Quantidade++;
        }
    }
}
