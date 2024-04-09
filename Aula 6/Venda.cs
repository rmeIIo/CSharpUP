using System.Collections.Generic;
using System.Linq;

public class Venda {
    public Vendedor Vendedor {get;}
    public Cliente Cliente {get;}
    public List<Produto> ProdutosVendidos {get;}

    public decimal TotalVendas => ProdutosVendidos?.Sum(p => p.Preco) ?? 0;

    public Venda(Vendedor vendedor, Cliente cliente) {
        Vendedor = vendedor ?? throw new ArgumentNullException(nameof(vendedor));
        Cliente = cliente ?? throw new ArgumentNullException(nameof(cliente));
        ProdutosVendidos = new List<Produto>();
    }

    public void AdicionarProduto(Produto produto) => ProdutosVendidos?.Add(produto);
}