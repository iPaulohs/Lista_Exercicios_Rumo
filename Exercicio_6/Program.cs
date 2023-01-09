using Ex_06;
namespace Programa_06
{
    class Programa_6
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Olá! Este é um programa para calcular o consumo médio e a automomia de um veículo. As instruções serão dadas a seguir.");

            Metodos Metodos = new Metodos();

            Metodos.leituraLitrosDeCombustivel();
            Metodos.leituraQuilometrosRodados();
            Metodos.calculaConsumo();
            Console.WriteLine("Agora, vamos calcular a autonomia total do seu veículo totalmente abastecido.");
            Metodos.leituraDadosTanque();
            Metodos.calculoDeAutonomiaTotalDoVeiculo();

        }
    }
}