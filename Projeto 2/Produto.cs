public class Produto {
    public string NomeProduto {get; set;}
    public int Codigo {get; set;}
    public float Preco {get; set;}

    public Produto(string nomeProduto, int codigo, float preco) {
        NomeProduto = nomeProduto;
        Codigo = codigo;
        Preco = preco;
    }

    public void ExibirDetalhes() {
        Console.WriteLine($"Nome: {NomeProduto}, Código: {Codigo}, Preço: {Preco}");
        Console.WriteLine($"Código: {Codigo}");
        Console.WriteLine($"Preço: {Preco}");
    }

    public void AtualizarPreco(float novoPreco) {
        Preco = novoPreco;
        Console.WriteLine($"Preço do produto {NomeProduto} atualizado para R${Preco}");
    }
}