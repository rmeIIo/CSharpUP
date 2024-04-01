Industria minhaIndustria = new Industria("Leitura Ilimitada Ltda.", "São Paulo, Brasil", 2010);

Produto livroFiccao = new Produto("Livro de Ficção", 1, 29.90f);
Produto livroDidatico = new Produto("Livro Didático", 2, 39.99f);

LinhaProducao linhaFiccao = new LinhaProducao(1, "Livro de Ficção", 1000);
linhaFiccao.AdicionarMaquina(new Maquina(1, "Impressora Ficção", "Livro de Ficção") { ProdutoProduzido = livroFiccao });
linhaFiccao.AdicionarMaquina(new Maquina(2, "Encadernadora Ficção", "Livro de Ficção") { ProdutoProduzido = livroFiccao });

LinhaProducao linhaDidatico = new LinhaProducao(2, "Livro Didático", 800);
linhaDidatico.AdicionarMaquina(new Maquina(3, "Impressora Didático", "Livro Didático") { ProdutoProduzido = livroDidatico });
linhaDidatico.AdicionarMaquina(new Maquina(4, "Encadernadora Didático", "Livro Didático") { ProdutoProduzido = livroDidatico });

minhaIndustria.AdicionarLinhaProducao(linhaFiccao);
minhaIndustria.AdicionarLinhaProducao(linhaDidatico);

minhaIndustria.ExibirInformacoes();

foreach (var linha in minhaIndustria.LinhasProducao)
{
    linha.ExibirDetalhes();
    foreach (var maquina in linha.Maquinas)
    {
        maquina.ExibirInformacoes();
        maquina.IniciarProducao();
    }
}
