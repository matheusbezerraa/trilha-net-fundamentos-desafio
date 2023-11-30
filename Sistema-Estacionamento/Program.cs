
using System.ComponentModel;
using Sistema_Estacionamento.Models;
using System.Globalization;


namespace Sistema_Estacionamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Estacionamento estacionamento = new Estacionamento();

            estacionamento.ExibirMenu();
        }
    }
}

