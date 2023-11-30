
using System.ComponentModel;
using Sistema_Estacionamento.Models;
using System.Globalization;


namespace Sistema_Estacionamento
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar uma instância de Estacionamento
            Estacionamento estacionamento = new Estacionamento();

            // Chamar o método ExibirMenu
            estacionamento.ExibirMenu();
        }
    }
}

