/*4.    Faça um programa que calcule o total de lucro por produto vendido
a.    O usuário precisa informar quando parar
b.    E preciso armazenar na matriz Produto, Quantidade, Preço Compra e Preço de Venda
c.    O cálculo retorna o lucro e soma em uma variável fora do loop para então exibir para o funcionário.*/
using System.Globalization;
namespace Ex_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char novoProduto = 's';


            List<string> nomeProduto = new List<string>();

            List<int> quantidadeProduto = new List<int>();

            List<double> precoDeCompra = new List<double>();

            List<double> precoDeVenda = new List<double>();

            Console.WriteLine("Olá! Este é um programa para calcular a margem de lucro de produtos. Digite as informações abaixo para realizar o cálculo.");

            while (novoProduto == 's' || novoProduto == 'S')
            {
                Console.WriteLine("Digite o nome do produto: ");
                string nomeProdutoControle = Console.ReadLine();
                nomeProduto.Add(nomeProdutoControle);

                Console.WriteLine("Digite a quantidade no estoque: ");
                int quantidadeProdutoControle = int.Parse(Console.ReadLine());
                quantidadeProduto.Add(quantidadeProdutoControle);

                Console.WriteLine("Digite o preço de compra do produto: ");
                double precoCompraControle = double.Parse(Console.ReadLine());
                precoDeCompra.Add(precoCompraControle);

                Console.WriteLine("Digite o preço de venda do produto: ");
                double precoVendaControle = double.Parse(Console.ReadLine());
                precoDeVenda.Add(precoVendaControle);

                Console.WriteLine("Deseja adicionar um novo produto? s/n");
                char novoProdutoControle = char.Parse(Console.ReadLine());
                if (novoProdutoControle == 's' || novoProdutoControle == 'S')
                {
                    novoProduto = novoProdutoControle;
                }
                else
                {
                    break;
                }
            }
            char novoProdutoLucro = 's';

            while (novoProdutoLucro == 's' || novoProdutoLucro == 'S')
            {
                Console.WriteLine("Lista de produtos cadastrados: ");
                for (int i = 0; i < nomeProduto.Count; i++)
                {
                    Console.WriteLine((i + 1) + " - " + nomeProduto[i]);
                }
                Console.WriteLine("De qual produto deseja calcular o lucro?");
                int index;
                index = int.Parse(Console.ReadLine());

                Console.WriteLine("Quantas unidades do produto foram vendidas?");
                int quantidadeVendida;
                quantidadeVendida = int.Parse(Console.ReadLine());

                double lucro;

                double calculaLucro()
                {
                    lucro = (precoDeVenda[index - 1] - precoDeCompra[index - 1]) * quantidadeVendida;
                    return lucro;
                }


                calculaLucro();

                Console.WriteLine("O lucro do produto " + nomeProduto[index - 1] + " foi de R$" + lucro.ToString("F2", CultureInfo.InvariantCulture));

                Console.WriteLine("Deseja calcular o lucro de outro produto? s/n");

                char novoProdutoLucroControle;
                novoProdutoLucroControle = char.Parse(Console.ReadLine());

                if (novoProdutoLucroControle == 's' || novoProdutoLucroControle == 'S')
                {
                    novoProdutoLucro = novoProdutoLucroControle;
                }
                else
                {
                    Console.WriteLine("Fim do programa!");
                    break;
                }
            }
        }

    }
}