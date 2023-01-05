/*1. Faça um programa que leia o nome de um vendedor, o seu salário fixo e o total de vendas 
efetuadas por ele no mês (em dinheiro).
Sabendo que este vendedor ganha 15% de comissão sobre suas vendas efetuadas,  informar o seu nome, 
o salário fixo e salário final do mês.
 */

using System.Globalization;

namespace Programa_01
{
    class Programa_1
    {
        public static void Main(String[] args)
        {
            string nomeVendedor;
            double salarioFixo, vendasNoMesEmReais, salarioMaisComissao;

            Console.WriteLine("Olá! Este é um programa que calcula o salário de um vendedor após ser adicionada a comissão. Por favor, digite os dados abaixo.");

            Console.WriteLine("Qual é nome do vendedor? ");
            nomeVendedor = Console.ReadLine();
            Console.WriteLine("Qual é o salário fixo do vendedor? R$");
            salarioFixo = double.Parse(Console.ReadLine());
            Console.WriteLine("Quanto, em reais, o " + nomeVendedor + " vendeu no mês? R$");
            vendasNoMesEmReais = double.Parse(Console.ReadLine());

            salarioMaisComissao = salarioFixo + (vendasNoMesEmReais * 0.15);

            Console.WriteLine("O vendedor " + nomeVendedor + " vendeu um montante de R$" + vendasNoMesEmReais.ToString("F2", CultureInfo.InvariantCulture) + " e o seu salário, " +
                "adicionada a comissão é de R$" + salarioMaisComissao.ToString("F2", CultureInfo.InvariantCulture) + ". O salário base é de R$" + salarioFixo.ToString("F2", CultureInfo.InvariantCulture) + ".");
        }
    }
}



