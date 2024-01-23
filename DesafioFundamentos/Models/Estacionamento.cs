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

        // metodo 1 - pedir a placa do veiculo e adicionar na lista
        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo que deseja estacionar:");
            string placa = Console.ReadLine();

            // verificando se a entrada está vazia ou nula - outra forma de fazer: if (placa != "" && placa != null)
            if (string.IsNullOrEmpty(placa) || placa.Length != 7)
            {
                Console.WriteLine("Placa inválida. Precisa conter 7 caracteres.");
            }
            else
            {
                veiculos.Add(placa);
            }
        }

        // metodo 2 - pedir a placa do veiculo e remover da lista
        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo que deseja remover:");
            string placa = Console.ReadLine();

            // verificando se o veículo existe e calculo da permanencia no estacionamento
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = precoInicial + (precoPorHora * horas);
                veiculos.Remove(placa);
                string placaMaiuscula = placa;
                Console.WriteLine($"O veículo {placaMaiuscula.ToUpper()} foi removido e o preço total da permanência foi de: R$ {valorTotal}.");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.");
            }
        }

        // metodo 3 - listar os veiculos
        public void ListarVeiculos()
        {
            // verificando se existe veiculos estacionados e listando
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (string v in veiculos)
                {
                    Console.WriteLine(v.ToUpper());
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
