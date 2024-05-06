public class Program {
    public static void Main(string[] args) {
        Carro carro = new Carro("Ford", "Fiesta", 4);
        Moto moto = new Moto("Honda", "CBR", 1000);
        Bicicleta bicicleta = new Bicicleta("Caloi", "Sport", 18);

        Console.WriteLine("Carro:");
        Console.WriteLine($"Marca: {carro.Marca}");
        Console.WriteLine($"Modelo: {carro.Modelo}");
        Console.WriteLine($"Número de Portas: {carro.NumeroDePortas}");

        Console.WriteLine("Moto:");
        Console.WriteLine($"Marca: {moto.Marca}");
        Console.WriteLine($"Modelo: {moto.Modelo}");
        Console.WriteLine($"Cilindrada: {moto.Cilindrada}");

        Console.WriteLine("Bicicleta:");
        Console.WriteLine($"Marca: {bicicleta.Marca}");
        Console.WriteLine($"Modelo: {bicicleta.Modelo}");
        Console.WriteLine($"Número de Marchas: {bicicleta.NumeroDeMarchas}");
    }
}