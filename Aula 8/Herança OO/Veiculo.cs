class Veiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }

    public Veiculo(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
    }

    public virtual void Ligar()
    {
        Console.WriteLine("Veículo ligado");
    }
}

class Carro : Veiculo
{
    public int NumeroPortas { get; set; }

    public Carro(string marca, string modelo, int numeroPortas) : base(marca, modelo)
    {
        NumeroPortas = numeroPortas;
    }

    public override void Ligar()
    {
        Console.WriteLine("Carro ligado");
    }
}

class Moto : Veiculo
{
    public int Cilindrada { get; set; }

    public Moto(string marca, string modelo, int cilindrada) : base(marca, modelo)
    {
        Cilindrada = cilindrada;
    }

    public override void Ligar()
    {
        Console.WriteLine("Moto ligada");
    }
}

class Caminhao : Veiculo
{
    public int CapacidadeCarga { get; set; }

    public Caminhao(string marca, string modelo, int capacidadeCarga) : base(marca, modelo)
    {
        CapacidadeCarga = capacidadeCarga;
    }
}