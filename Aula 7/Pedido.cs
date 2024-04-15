public class Cliente
{
    public string Cpf { get; set; }
    public string Nome { get; set; }

    public Cliente(string cpf, string nome)
    {
        Cpf = cpf;
        Nome = nome;
    }
}

public class Vendedor
{
    public string Cpf { get; set; }
    public string Nome { get; set; }

    public Vendedor(string cpf, string nome)
    {
        Cpf = cpf;
        Nome = nome;
    }
}

public class Produto
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }

    public Produto(string nome, decimal preco)
    {
        Nome = nome;
        Preco = preco;
    }
}

public class Pedido
{
    public string Data { get; set; }
    public Cliente Cliente { get; set; }
    public Vendedor Vendedor { get; set; }
    public List<Produto> Produtos { get; set; }

    public Pedido(string data, Cliente cliente, Vendedor vendedor, List<Produto> produtos)
    {
        Data = data;
        Cliente = cliente;
        Vendedor = vendedor;
        Produtos = produtos;
    }
}
