using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Estacionamento.Models
{
    public class Veiculo
    {
        public Veiculo(){

        }

        public Veiculo(string placa){
            Placa = placa;
        }

         private string _placa;

         public string Placa{
            get=> _placa.ToUpper();

            set{
                if(value ==""){
                    throw new ArgumentException("A placa não pode ser vazio");
                }

                _placa = value;
            }
         }
    }
}