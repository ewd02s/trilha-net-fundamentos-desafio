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

            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();

        if (string.IsNullOrEmpty(placa))
        {
            Console.WriteLine("Placa inválida. Por favor, insira uma placa válida.");
            return; // Sai do método se a placa for inválida
        }

        // Converter para maiúsculas para comparação
        placa = placa.ToUpper();

        // Verifica se a placa já existe na lista
        if (veiculos.Contains(placa))
        {
            Console.WriteLine("Já existe um veículo com essa placa.");
        }
        else
        {
            veiculos.Add(placa);
            Console.WriteLine("Veículo estacionado com sucesso!");
        }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa

            string placa = Console.ReadLine();

            Console.WriteLine("A placa digitada foi: " + placa);


            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
  
                int horas = Convert.ToInt32(Console.ReadLine());

                double valorTotal = Convert.ToInt32(precoInicial + (precoPorHora * horas));

                // TODO: Remover a placa digitada da lista de veículos
                // *IMPLEMENTE AQUI*

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados

                // Exibir a lista de veículos (opcional)
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
