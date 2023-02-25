using System.Globalization;
namespace Secao10_Exercicio_Fixacao1.Entities
{
    class ProdutoUsado : Produto
    {
        public DateTime DataFabricacao { get; private set; }

        public ProdutoUsado() 
        {
        }

        public ProdutoUsado(string nome, double preco, DateTime dataFabricacao) :
            base(nome, preco)
        {
            DataFabricacao = dataFabricacao;
        }

        public sealed override string EtiquetaDePreco()
        {
            return Nome
                + "(usado) R$ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + " (data de fabricação: " + DataFabricacao.ToString("dd/MM/yyyy") + ")";
        }
    }
}
