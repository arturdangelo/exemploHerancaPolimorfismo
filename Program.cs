using Secao10_Exercicio_Fixacao1.Entities;
using System.Globalization;

namespace Secao10_Exercicio_Fixacao1
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o número de produtos: ");
            int n = int.Parse(Console.ReadLine());

            List<Produto> prod = new List<Produto>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados do produto {i}:");

                Console.Write("Comum, usado ou importado (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'u') 
                {
                    Console.Write("Data de fabricação (DD/MM/YYYY): ");
                    DateTime data = DateTime.Parse(Console.ReadLine());

                    prod.Add(new ProdutoUsado(nome, preco, data));
                }

                else if (ch == 'i') 
                {
                    Console.Write("Taxas alfandegárias: ");
                    double taxa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    prod.Add(new ProdutoImportado(nome, preco, taxa));
                }

                else 
                {
                    prod.Add(new Produto(nome, preco));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Etiqueta de preços:");
            foreach(Produto p in prod) 
            {
                Console.WriteLine(p.EtiquetaDePreco());
            }
        }
    }
}