namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTADO!*
            string placaAdicionar = "";
            Console.WriteLine("Digite a placa do veículo a estacionar:");
            placaAdicionar = Console.ReadLine();
            if (veiculos.Any(x => x.ToUpper() == placaAdicionar.ToUpper()))
            {
                Console.WriteLine("Desculpe, esse veículo já está estacionado aqui. Confira se digitou a placa corretamente.");
            }
            else
            {
                veiculos.Add(placaAdicionar);
                Console.WriteLine($"O veículo placa {placaAdicionar} foi estacionado, obrigado.");
            }
        }

        public void RemoverVeiculo()
        {
            //Console.WriteLine("Digite a placa do veículo para remover:");
            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTADO!*
            if (veiculos.Count.Equals(0))
            {
                Console.WriteLine("Não há nenhum veículo estacionado neste momento.");
            }
            else
            {
                string placaRemover = "";
                Console.WriteLine("Digite a placa do veículo a remover:");
                placaRemover = Console.ReadLine();

                // Verifica se o veículo existe
                if (veiculos.Any(y => y.ToUpper() == placaRemover.ToUpper()))
                {
                    //Console.WriteLine("Digite a quantidade de horas que o veículo placa permaneceu estacionado:");
                    // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                    // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                    // *IMPLEMENTADO!*
                    int horas = 0;
                    decimal valorTotal = 0;
                    Console.WriteLine($"Digite a quantidade de horas que o veículo placa {placaRemover} permaneceu estacionado:");
                    horas = Convert.ToInt32(Console.ReadLine());
                    valorTotal = precoInicial + (precoPorHora * horas);


                    // TODO: Remover a placa digitada da lista de veículos
                    // *IMPLEMENTADO!*
                    if(veiculos.Remove(placaRemover))
                    {
                        Console.WriteLine($"O veículo {placaRemover} foi removido e o preço total foi de: R$ {valorTotal}");
                    }
                    else
                    {
                        Console.WriteLine($"O veículo {placaRemover} não foi removido, tente novamente.");
                    }
                }
                else
                {
                    Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                }
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTADO!*
                foreach (string veiculoEstacionado in veiculos)
                {
                    Console.WriteLine($"Placa {veiculoEstacionado}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
