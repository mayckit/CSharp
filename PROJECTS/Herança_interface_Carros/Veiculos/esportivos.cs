using System;

namespace ProjetoVeiculos.Veiculos{
    public class Esportivo : Carro{

        private string tipo;

        public Esportivo(string marca, string modelo, int numPortas, string tipo, string tipoMotor) 
            : base(marca, modelo, numPortas, tipo, tipoMotor){
            this.tipo = tipo;
        }

        public override void mostrar(){
            base.mostrar();
        }
    }
}