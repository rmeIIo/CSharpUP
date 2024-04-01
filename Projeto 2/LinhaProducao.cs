public class LinhaProducao {
    public int NumeroLinha { get; set; }
    public string TipoProduto { get; set; }
    public int Capacidade { get; set; }
    public List<Maquina> Maquinas;
    public Produto ProdutoProduzido { get; set; }

    public LinhaProducao(int numeroLinha, string tipoProduto, int capacidade) {
        NumeroLinha = numeroLinha;
        TipoProduto = tipoProduto;
        Capacidade = capacidade;
        Maquinas = new List<Maquina>();
    }
    public void ExibirDetalhes() {
        Console.WriteLine($"Detalhes da Linha de Produção {NumeroLinha}:");
        Console.WriteLine($"Tipo: {TipoProduto}");
        Console.WriteLine($"Capacidade: {Capacidade} produtos por hora\n");
        if (ProdutoProduzido != null) {
            Console.WriteLine($"Produto Produzido: {ProdutoProduzido.NomeProduto}");
            Console.WriteLine($"Preço: R${ProdutoProduzido.Preco}\n");
        }
    }

    public void AdicionarMaquina(Maquina maquina) {
        Maquinas.Add(maquina);
    }
}