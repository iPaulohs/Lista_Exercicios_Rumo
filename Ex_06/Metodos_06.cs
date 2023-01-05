namespace Ex_06
{
    public class Metodos
    {
        public double litrosDeCombustivelAbastecidos, quilometrosRodados, consumoMedio, litrosDeCombustivelControle, quilometrosRodadosControle, capacidadeDoTanque, capacidadeDoTanqueControle;

        public void leituraLitrosDeCombustivel() //Obtém a informação do combustível
        {
            Console.WriteLine("Informe com quantos litros de combustível você abasteceu o seu veículo: ");
            litrosDeCombustivelControle = double.Parse(Console.ReadLine());
            validacaoLitroCombustivel();
        }

        public void leituraQuilometrosRodados() //Obtém a informação de quantos quilômetros foram percorridos
        {
            Console.WriteLine("Informe quantos quilometros você percorreu com o combustível abastecido: ");
            quilometrosRodadosControle = double.Parse(Console.ReadLine());
            validacaoQuilometragem();
        }
        public void calculaConsumo() //Realiza o cálculo do consumo do veículo
        {
            consumoMedio = litrosDeCombustivelAbastecidos / quilometrosRodados;
            Console.WriteLine("O consumo do seu veículo é de " + consumoMedio + " litro(s)/Km.");
        }
        public void leituraDadosTanque() // Realiza a leitura da capacidade do tanque do veículo
        {
            Console.WriteLine("Escreva qual é a capacidade máxima do tanque do seu carro: ");
            capacidadeDoTanqueControle = double.Parse(Console.ReadLine());
            validacaoTanque();
        }
        public void calculoDeAutonomiaTotalDoVeiculo() //Realiza o cálculo da autonomia do veículo
        {
            double autonomiaDoVeiculo = (consumoMedio * capacidadeDoTanque) * 100;
            Console.WriteLine("A autonomia total do veículo é de " + autonomiaDoVeiculo + "Km.");
        }
        public void validacaoLitroCombustivel() //Valida a informação de combustível
        {
            if (litrosDeCombustivelControle <= 0)
            {
                Console.WriteLine("Você precisa digitar um valor maior do que 0!");
                leituraLitrosDeCombustivel();
            }
            else
            {
                litrosDeCombustivelAbastecidos = litrosDeCombustivelControle;
            }
        }
        public void validacaoQuilometragem() //Valida a informação de quilometragem percorrida
        {
            if (quilometrosRodadosControle <= 0)
            {
                Console.WriteLine("Você precisa digitar um valor maior do que 0!");
                leituraQuilometrosRodados();
            }
            else
            {
                quilometrosRodados = quilometrosRodadosControle;
            }
        }
        public void validacaoTanque() //Valida a informação da capacidade do tanque
        {
            if (capacidadeDoTanqueControle <= 0)
            {
                Console.WriteLine("Você precisa digitar um valor maior do que 0!");
                leituraDadosTanque();
            }
            else
            {
                capacidadeDoTanque = capacidadeDoTanqueControle;
            }
        }
    }
}
