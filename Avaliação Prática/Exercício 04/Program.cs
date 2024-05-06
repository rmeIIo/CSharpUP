public class Program {
    public static void Main(string[] args) {
        Produto produto = new Produto("Notebook", 2500.00m, 10);

        Console.WriteLine($"Nome: {produto.Nome}");
        Console.WriteLine($"Preço: {produto.Preco}");
        Console.WriteLine($"Quantidade em Estoque: {produto.QuantidadeEmEstoque}");

        produto.AdicionarUnidades(5);
        Console.WriteLine($"Quantidade em Estoque após adicionar unidades: {produto.QuantidadeEmEstoque}");

        produto.RemoverUnidades(3);
        Console.WriteLine($"Quantidade em Estoque após remover unidades: {produto.QuantidadeEmEstoque}");

        decimal valorTotal = produto.ValorTotalEmEstoque();
        Console.WriteLine($"Valor total em estoque: {valorTotal}");
    }
}