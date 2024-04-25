public class Funcionario
{
    public string? Nome { get; set; }
    public decimal Salario { get; set; }
}

public class Gerente : Funcionario
{
    public decimal Comissao { get; set; }
}

public class Vendedor : Funcionario
{
    public string? AreaAtuacao { get; set; }
}

public class Analista : Funcionario
{
    public int NivelExperiencia { get; set; }
}