using System;
using PraticaPato;

  Pato mallard = new MallardDuck();
        Pato redhead = new RedHeadDuck();
        Pato rubber = new RubberDuck();

        Console.WriteLine("Mallard Duck:");
        mallard.swim();
        mallard.display();
        ((IFlyable)mallard).fly();
        ((IQuackable)mallard).quack();
        Console.WriteLine();

        Console.WriteLine("RedHead Duck:");
        redhead.swim();
        redhead.display();
        ((IFlyable)redhead).fly();
        ((IQuackable)redhead).quack();
        Console.WriteLine();

        Console.WriteLine("Rubber Duck:");
        rubber.swim();
        rubber.display();
        ((IQuackable)rubber).quack();
        Console.WriteLine();