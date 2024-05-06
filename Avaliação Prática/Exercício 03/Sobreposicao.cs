public class Sobreposicao {
    public virtual void Metodo() {
        Console.WriteLine("Método da classe base");
    }
}

public class Derivada : Sobreposicao {
    public override void Metodo() {
        Console.WriteLine("Método da classe derivada");
    }
}

