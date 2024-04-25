using System;

public class Animal
{
    public virtual void EmitirSom()
    {
        Console.WriteLine("Som do animal");
    }
}

public class Cachorro : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("Au Au");
    }
}

public class Gato : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("Miau");
    }
}