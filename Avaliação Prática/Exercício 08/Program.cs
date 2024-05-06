public class Program {
    public static void Main(string[] args) {
        Curso curso = new CursoIngles();
        curso.Notas.Add(8.5);
        curso.Notas.Add(9.0);
        curso.Notas.Add(7.5);
        double media = curso.CalcularMedia();
        Console.WriteLine($"A média do curso de {curso.Nome} é {media}");
        curso.GerarCertificado();
    }
}