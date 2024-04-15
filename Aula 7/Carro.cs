// TODO: 
// Crie uma classe simples chamada Carro com os seguintes atributos:- Marca (string): a marca do carro.- Modelo (string): o modelo do carro.- Ano (int): o ano de fabricação do carro.

public class Carro {
    public string Marca {get; set;}
    public string Modelo {get; set;}
    public int Ano {get; set;}

    public Carro(string marca, string modelo, int ano) {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
    }
}
