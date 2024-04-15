// TODO:
/* Implemente uma classe Estudante com os seguintes atributos:- Matricula (string): número de matrícula no sistema de dados acadêmicos- Nome (string) o nome do estudante- Idade (int): idade em anos do estudanteAltere o construtor da classe Estudante para receber a matrícula, o nome e a idade comoargumentos.
Implemente um procedimento no programa principal que imprima os dados do objetoEstudante construído.*/

public class Estudante {
    public string Matricula {get; set;}
    public string Nome {get; set;}
    public int Idade {get; set;}

    public Estudante(string matricula, string nome, int idade) {
        Matricula = matricula;
        Nome = nome;
        Idade = idade;
    }

    public override string ToString() {
        return $"Matrícula: {Matricula}, Nome: {Nome}, Idade: {Idade}";
    }
}