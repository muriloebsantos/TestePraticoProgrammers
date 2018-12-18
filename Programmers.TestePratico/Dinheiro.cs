namespace Programmers.TestePratico
{
    public abstract class Dinheiro
    {
        public Dinheiro(decimal valor, string descricao)
        {
            Valor = valor;
            Descricao = descricao;
        }

        public decimal Valor { get; set; }
        public string Descricao { get; private set; }
    }
}
