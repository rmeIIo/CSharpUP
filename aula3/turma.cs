// ./turma.cs
public class Turma
{
    public int anoFormacao { get; set; }
    public string turno { get; set; }
    public string sala { get; set; }

    public List<Estudante> estudantes = new List<Estudante>();
    // Metdodo adicionar estudante
    // Recebe estudante e adiciona na lista de estudantes

    public void AdicionarEstudante(Estudante e)
    {
        this.estudantes.Add(e);
    }
}