public class Program {
    public static void Main(string[] args) {
        Filme filme = new Filme("The Idea of You", "Romance", 115);
        filme.VerificarDisponibilidade();
        filme.RegistrarLocacao();
        filme.VerificarDisponibilidade();
        filme.RegistrarDevolucao();
        filme.VerificarDisponibilidade();
    }
}