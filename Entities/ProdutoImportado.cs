
using System.Globalization;
namespace Secao10_Exercicio_Fixacao1.Entities
{
    class ProdutoImportado : Produto
    {
        public double TaxaAlfandegaria { get; private set; }

        public ProdutoImportado() 
        {
        }

        public ProdutoImportado (string nome, double preco, double taxaAlfandegaria) :
            base (nome, preco)
        {
            TaxaAlfandegaria = taxaAlfandegaria;
        }

        public double PrecoTotal() 
        {
            return Preco + TaxaAlfandegaria;
        }

        public sealed override string EtiquetaDePreco()
        {
            return Nome
                + " R$ " + PrecoTotal().ToString("F2", CultureInfo.InvariantCulture)
                + " (Taxas alfandegárias: R$ " + TaxaAlfandegaria.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
        }
    }
}
