public abstract class Curso {
    public string Nome {get; set;}
    public List<double> Notas {get; set;}

    public Curso(string nome) {
        Nome = nome;
        Notas = new List<double>();
    }

    public abstract double CalcularMedia();
    public abstract void GerarCertificado();
}

public class CursoIngles : Curso {
    public CursoIngles() : base("Inglês") {}

    public override double CalcularMedia() { // A media deve ter 1 casa decimal
        return Math.Round(Notas.Average(), 1);
    }

    public override void GerarCertificado() {
        Console.WriteLine($"Certificado de conclusão do curso de {Nome} gerado.");
    }
}

public class CursoEspanhol : Curso {
    public CursoEspanhol() : base("Espanhol") {}

    public override double CalcularMedia() {
        return Math.Round(Notas.Average(), 1);
    }

    public override void GerarCertificado() {
        Console.WriteLine($"Certificado de conclusão do curso de {Nome} gerado.");
    }
}

public class CursoFrances : Curso {
    public CursoFrances() : base("Francês") {}

    public override double CalcularMedia() {
        return Math.Round(Notas.Average(), 1);
    }

    public override void GerarCertificado() {
        Console.WriteLine($"Certificado de conclusão do curso de {Nome} gerado.");
    }
}