/* Faça um programa armazena o nome e idade (inteiro) de 10 pessoas, e mostra o mais velho para o usuário.*/
namespace Programa_04
{
    class Programa_4
    {
        public static void Main(string[] args)
        {
            string[] nomes = new string[3]; //Inicializei os array com menos posições para encurtar a entrada dos dados. A lógica funciona igualmente com n posições.
            int[] idades = new int[3];
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Digite o " + (i + 1) + "º nome: ");
                nomes[i] = Console.ReadLine();
                Console.WriteLine("Digite a " + (i + 1) + "ª idade: ");
                idades[i] = int.Parse(Console.ReadLine());
            }
            for(int j = 0; j < idades.Length; j++)
            {
                if (idades[j] == idades.Max()) 
                {
                    Console.WriteLine("A pessoa mais velha é " + nomes[j] + " e a sua idade é " + idades[j] + " anos.");
                }
            }
        }
    }
}
