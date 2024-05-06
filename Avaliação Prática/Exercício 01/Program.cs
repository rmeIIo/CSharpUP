class Program {
    static void Main(string[] args) {
        Carro carro = new Carro("Ford", "Mustang", 2);
        Moto moto = new Moto("Honda", "CBR", 600);
        Caminhao caminhao = new Caminhao("Volvo", "FH16", 50000);

        Veiculo[] veiculos = { carro, moto, caminhao };

        foreach (Veiculo veiculo in veiculos) {
            veiculo.Ligar();
        }
    }
}