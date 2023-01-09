/*Faça um algoritmo que receba 15 números e exiba somente os positivos para o usuário*/
namespace Programa_03
{
    class Programa_3
    {
        public static void Main(string[] args)
        {
            double[] numeros = new double[15];
            double controle;
            Console.WriteLine("Olá! Este é um programa que recebe 15 números e mostra os positivos. Preencha os números abaixo: ");

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Digite o " + (i + 1) + "º número: ");
                controle = double.Parse(Console.ReadLine());
                if (controle > 0)
                {
                    numeros[i] += controle;
                }
            }
            Console.WriteLine("Números positivos: ");
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > 0)
                {
                    Console.WriteLine(numeros[i]);
                }
            }
        }
    }
}