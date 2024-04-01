public class Maquina {
    public int IdMaquina {get; set;}
    public string Marca {get; set;}
    public string Modelo {get; set;}
    public Produto ProdutoProduzido {get; set;}

    public Maquina(int idMaquina, string marca, string modelo) {
        IdMaquina = idMaquina;
        Marca = marca;
        Modelo = modelo;
    }

    public void ExibirInformacoes() {
        Console.WriteLine($"Informações da Máquina {IdMaquina}:");
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        if (ProdutoProduzido != null) {
            Console.WriteLine($"Produto Produzido: {ProdutoProduzido.NomeProduto}");
            Console.WriteLine($"Preço: R${ProdutoProduzido.Preco}");
        }
    }

    public void IniciarProducao() {
        Console.WriteLine($"Máquina {IdMaquina} iniciou a produção\n");
    }
}