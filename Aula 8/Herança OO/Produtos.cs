public class Produto
{
    public string? Nome { get; set; }
    public decimal Preco { get; set; }
}

public class Eletronico : Produto
{
    public string? Marca { get; set; }
}

public class Alimento : Produto
{
    public DateTime DataValidade { get; set; }
}

public class Vestuario : Produto
{
    public string? Tamanho { get; set; }
}