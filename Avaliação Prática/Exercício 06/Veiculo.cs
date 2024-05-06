public abstract class Veiculo {
    public string Marca {get; set;}
    public string Modelo {get; set;}

    public Veiculo(string marca, string modelo) {
        Marca = marca;
        Modelo = modelo;
    }
}

public class Carro : Veiculo {
    public int NumeroDePortas {get; set;}

    public Carro(string marca, string modelo, int numeroDePortas) : base(marca, modelo) {
        NumeroDePortas = numeroDePortas;
    }
}

public class Moto : Veiculo {
    public int Cilindrada {get; set;}

    public Moto(string marca, string modelo, int cilindrada) : base(marca, modelo) {
        Cilindrada = cilindrada;
    }
}

public class Bicicleta : Veiculo {
    public int NumeroDeMarchas {get; set;}

    public Bicicleta(string marca, string modelo, int numeroDeMarchas) : base(marca, modelo) {
        NumeroDeMarchas = numeroDeMarchas;
    }
}

