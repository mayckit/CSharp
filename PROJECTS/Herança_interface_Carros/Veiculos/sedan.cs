using System;
using ProjetoVeiculos.Veiculos;

namespace ProjetoVeiculos.Veiculos{
    public class Sedan : Carro{

        private string tipo;

        public Sedan(string marca, string modelo, int numPortas, string tipo, string tipoMotor) 
            : base(marca, modelo, numPortas, tipo, tipoMotor){
            this.tipo = tipo;
        }

        public override void mostrar(){
            base.mostrar();
        }
    }
}