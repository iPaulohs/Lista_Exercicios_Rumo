/*1.Faça um programa que calcula a média das notas de provas de uma turma.*/

namespace Programa_02
{
    class Programa_2
    {
        public static void Main(string[] args)
        {
            int numeroDeNotas;
            double somaDasnotas = 0;
            Console.WriteLine("Este é um programa para calcular a média das notas dos alunos de uma sala. De quantas notas você deseja calcular a média?");
            numeroDeNotas = int.Parse(Console.ReadLine());
            double[] notas = new double[numeroDeNotas];

            for (int i = 0; i < numeroDeNotas; i++)
            {
                Console.WriteLine("Digite a " + (i + 1) + "ª nota: ");
                notas[i] = double.Parse(Console.ReadLine());
            }

            for(int j = 0; j < numeroDeNotas; j++) 
            {
                somaDasnotas += notas[j];
            }

            double media = somaDasnotas / numeroDeNotas;
            Console.WriteLine("A média das notas declaradas é: " + media);
        }
    }
}
