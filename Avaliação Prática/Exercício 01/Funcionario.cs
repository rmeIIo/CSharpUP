public class Funcionario {
    public string Nome { get; set; }
    public string ID { get; set; }

    public Funcionario(string nome, string id) {
        Nome = nome;
        ID = id;
    }

    public virtual void Trabalhar() {
        Console.WriteLine("O funcionário está trabalhando.");
    }
}

public class Gerente : Funcionario {
    public Gerente(string nome, string id) : base(nome, id) { }

    public override void Trabalhar() {
        Console.WriteLine("O gerente está gerenciando a equipe.");
    }
}

public class Engenheiro : Funcionario {
    public Engenheiro(string nome, string id) : base(nome, id) { }

    public override void Trabalhar() {
        Console.WriteLine("O engenheiro está projetando um produto.");
    }
}
