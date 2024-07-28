using System;
using ProjetoVeiculos.Veiculos;

namespace ProjetoVeiculos.Servicos{
    public interface Seguro{
        void seguroParticular();
    }

    // Implementação da interface Seguro na classe CarroSeguro
    public class CarroSeguro : Veiculo, Seguro{
        public CarroSeguro(string marca, string modelo) : base(marca, modelo){
        }

        // Implementação do método da interface
        public void seguroParticular(){
            Console.WriteLine("Seguro particular para carro.");
        }
    }
}