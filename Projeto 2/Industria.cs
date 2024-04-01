public class Industria {
    public string NomeIndustria { get; set; }
    public string Localizacao { get; set; }
    public int AnoFundacao { get; set; }
    public List<LinhaProducao> LinhasProducao;

    public Industria(string nomeIndustria, string localizacao, int anoFundacao) {
        NomeIndustria = nomeIndustria;
        Localizacao = localizacao;
        AnoFundacao = anoFundacao;
        LinhasProducao = new List<LinhaProducao>();
    }

    public void ExibirInformacoes() {
        Console.WriteLine("---Informações da Industria---");
        Console.WriteLine($"Nome Industria: {NomeIndustria}");
        Console.WriteLine($"Localização: {Localizacao}");
        Console.WriteLine($"Ano Fundação: {AnoFundacao}\n");
    }

    public void AdicionarLinhaProducao(LinhaProducao linhaProducao) {
        LinhasProducao.Add(linhaProducao);
    }

}