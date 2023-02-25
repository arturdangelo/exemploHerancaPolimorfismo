using System.Globalization;
namespace Secao10_Exercicio_Fixacao1.Entities
{
    class Produto
    {
        public string Nome { get; private set; }
        public double Preco { get; private set; }

        public Produto() 
        {
        }

        public Produto (string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

       public virtual string EtiquetaDePreco() 
        {
            return Nome + " R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
