using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Estacionamento.Models
{
   public class Estacionamento
    {
        public List<Veiculo> Veiculos { get; set; }

        public Estacionamento()
        {
            // Inicializa a lista de Veiculos no construtor
            Veiculos = new List<Veiculo>();
        }

        public void ExibirMenu()
        {
            int escolha;

            do
            {
                Console.WriteLine("1. Adicionar Veículo");
                Console.WriteLine("2. Remover Veículo");
                Console.WriteLine("3. Listar Veículos");
                Console.WriteLine("0. Sair");

                Console.Write("Escolha uma opção: ");

                while (!int.TryParse(Console.ReadLine(), out escolha))
                {
                    Console.Write("Entrada inválida. Por favor, insira um número válido: ");
                }

                ProcessarEscolha(escolha);

            } while (escolha != 0);
        }

        public void AdicionarVeiculo()
        {
            Console.Write("Digite a placa do veículo: ");
            string placa = Console.ReadLine();

            Veiculo novoVeiculo = new Veiculo(placa);
            Veiculos.Add(novoVeiculo);
        }

        public void RemoverVeiculo()
        {
            Console.Write("Digite a placa do veículo a ser removido: ");
            string placa = Console.ReadLine().ToUpper();

            Veiculo veiculoRemover = Veiculos.Find(v => v.Placa == placa);

            if (veiculoRemover != null)
            {
                Veiculos.Remove(veiculoRemover);
                Console.WriteLine("Veículo removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Veículo não encontrado.");
            }
        }

        public void ListarVeiculos()
        {
            for (int count = 0; count < Veiculos.Count; count++)
            {
                string mensagemListando = $"Veiculo {count + 1}: {Veiculos[count].Placa} ";
                Console.WriteLine(mensagemListando);
            }
        }

        public void ProcessarEscolha(int escolha)
        {
            switch (escolha)
            {
                case 1:
                    AdicionarVeiculo();
                    break;
                case 2:
                    RemoverVeiculo();
                    break;
                case 3:
                    ListarVeiculos();
                    break;
                case 0:
                    Console.WriteLine("Saindo do menu. Até mais!");
                    break;
                default:
                    Console.WriteLine("Escolha inválida. Tente novamente.");
                    break;
            }
        }
    }

}