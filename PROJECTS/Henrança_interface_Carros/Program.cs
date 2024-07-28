using System;
using ProjetoVeiculos.Veiculos;
using ProjetoVeiculos.Servicos;

class Program{
static void Main(string[] args){
    
    Carro c1 = new Carro("Toyota", "Corolla", 4, "SUV", "V6");
    Carro c2 = new Carro("Honda", "Civic", 4, "Sedan", "V4");
    Sedan s1 = new Sedan("BMW", "Serie 3", 4, "Sedan", "V6");
    Sedan s2 = new Sedan("Mercedes", "Classe C", 4, "Sedan", "V8");
    Esportivo e1 = new Esportivo("Ferrari PuroSangue", "F8 Tributo", 2, "Esportivo", "V8");
    Esportivo e2 = new Esportivo("Mercedes", "AMG GT", 2, "Esportivo", "V8");


        c1.mostrar();
        Console.WriteLine();
        c2.mostrar();
        Console.WriteLine();
        s1.mostrar();
        Console.WriteLine();
        s2.mostrar();
        Console.WriteLine();
        e1.mostrar();
        Console.WriteLine();
        e2.mostrar();
        Console.WriteLine();

   
        Carro seguroCarro = new Carro("Ford", "Fusion", 4, "Sedan", "V6");
        ((Seguro)seguroCarro).seguroParticular();
    }
}