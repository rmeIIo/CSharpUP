using System;

class Program {
    static void Main() {
        Cliente cliente = new Cliente("123.456.789-10", "Roger");
        Vendedor vendedor = new Vendedor(1, "987.654.321-00", "Maria");
        Produto produto1 = new Produto(1, "Camiseta", 50.00m);
        Produto produto2 = new Produto(2, "Calça", 80.00m);

        Venda venda = new Venda(vendedor, cliente);

        venda.AdicionarProduto(produto1);
        venda.AdicionarProduto(produto2);

        Console.WriteLine($"Venda realizada por {venda.Vendedor.Nome} para o cliente {venda.Cliente.Nome}");
        foreach(var produto in venda.ProdutosVendidos) {
            Console.WriteLine($"Produto: {produto.Nome} - Preço: R${produto.Preco}");
        }

        Console.WriteLine($"Total da Venda: R${venda.TotalVendas}");
    }
}