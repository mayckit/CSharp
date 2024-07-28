using System;

namespace ProjetoVeiculos.Veiculos{
    public class Carro : Veiculo{
        private int numPortas;
        private string tipo;
        private string tipoMotor;

        public Carro(string marca, string modelo, int numPortas, string tipo, string tipoMotor) 
            : base(marca, modelo){
            this.numPortas = numPortas;
            this.tipo = tipo;
            this.tipoMotor = tipoMotor;
        }
        public override void mostrar(){
            base.mostrar();
            Console.WriteLine($"Número de Portas: {numPortas}");
            Console.WriteLine($"Tipo: {tipo}");
            Console.WriteLine($"Tipo de Motor: {tipoMotor}");
        }
    }
}