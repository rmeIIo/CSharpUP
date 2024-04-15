// TODO:
// Crie uma classe chamada Pessoa que possua uma coleção de objetos da classe Livro. A classePessoa deve conter os seguintes atributos:- Cpf (string): o cpf da pessoa.- Nome (string): o nome da pessoa.Livro deve ter os seguintes atributos:- Titulo (string): o título do livro.- Autor (string): o autor do livro.A classe pessoa deve possuir um método para receber os livros.No programa principal: Implemente uma rotina que imprima os dados dos livros da pessoa noconsole.

class Livro {
    public string Titulo {get; set;}
    public string Autor {get; set;}
}

class Pessoa {
    public string Cpf {get; set;}
    public string Nome {get; set;}
    public List<Livro> Livros {get; set;}

    public void ReceberLivros(List<Livro> livros) {
        Livros = livros;
    }
}