namespace Programmers.TestePratico
{
    public class Moeda : Dinheiro
    {
        public Moeda(decimal valor, string descricao) : base (valor, descricao)
        {
            Valor = valor;
        }
    }
}
