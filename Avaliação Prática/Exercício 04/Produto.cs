public class Produto {
    public string Nome {get; set;}
    public decimal Preco {get; set;}
    public int QuantidadeEmEstoque {get; private set;}

    public Produto(string nome, decimal preco, int quantidadeEmEstoque) {
        Nome = nome;
        Preco = preco;
        QuantidadeEmEstoque = quantidadeEmEstoque;
    }

    public void AdicionarUnidades(int quantidade) {
        QuantidadeEmEstoque += quantidade;
    }

    public void RemoverUnidades(int quantidade) {
        if(quantidade <= QuantidadeEmEstoque) {
            QuantidadeEmEstoque -= quantidade;
        } else {
            throw new InvalidOperationException("Quantidade em estoque insuficiente");
        }
    }

    public decimal ValorTotalEmEstoque() {
        return Preco * QuantidadeEmEstoque;
    }
}
