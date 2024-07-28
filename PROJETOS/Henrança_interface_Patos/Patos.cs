using System;
namespace PraticaPato{  
public abstract class Pato{
    
    public void swim(){
        Console.WriteLine("sei nadar");
    }
    public void display(){
        Console.WriteLine("Existindo");
    }
}

public class MallardDuck : Pato, IFlyable, IQuackable{

    public void fly(){
        Console.WriteLine("VOA");
    }
    public void quack(){
        Console.WriteLine("QUAAAAACK");
    }
}

public class RedHeadDuck : Pato, IFlyable, IQuackable{

    public void fly(){
        Console.WriteLine("VOA");
    }
    public void quack(){
        Console.WriteLine("QUACK");
    }

}

public class RubberDuck : Pato, IQuackable{

    public void quack(){
        Console.WriteLine("QUACK QUACK");
    }
}

}