using System;

interface IContaBancaria
{
    void Depositar(decimal valor);
    void Sacar(decimal valor);
}

class ContaCorrente : IContaBancaria
{
    public int NumeroConta { get; set; }
    public decimal Saldo { get; set; }

    public void Depositar(decimal valor)
    {
        Saldo += valor;
    }

    public void Sacar(decimal valor)
    {
        if (valor <= Saldo)
        {
            Saldo -= valor;
        }
        else
        {
            Console.WriteLine("Saldo insuficiente.");
        }
    }
}

class ContaPoupanca : IContaBancaria
{
    public int NumeroConta { get; set; }
    public decimal Saldo { get; set; }

    public void Depositar(decimal valor)
    {
        Saldo += valor;
    }

    public void Sacar(decimal valor)
    {
        if (valor <= Saldo)
        {
            Saldo -= valor;
        }
        else
        {
            Console.WriteLine("Saldo insuficiente.");
        }
    }
}

class Transacao
{
    public string Tipo { get; set; }
    public decimal Valor { get; set; }

    public void ExibirDetalhes()
    {
        Console.WriteLine("Tipo: " + Tipo);
        Console.WriteLine("Valor: " + Valor);
    }
}

class Program
{
    static void Main(string[] args)
    {
        IContaBancaria contaCorrente = new ContaCorrente();
        contaCorrente.Depositar(1000);
        contaCorrente.Sacar(500);
        Console.WriteLine("Saldo da conta corrente: " + ((ContaCorrente)contaCorrente).Saldo);

        IContaBancaria contaPoupanca = new ContaPoupanca();
        contaPoupanca.Depositar(2000);
        contaPoupanca.Sacar(1000);
        Console.WriteLine("Saldo da conta poupança: " + ((ContaPoupanca)contaPoupanca).Saldo);

        Transacao transacao = new Transacao();
        transacao.Tipo = "Depósito";
        transacao.Valor = 100;
        transacao.ExibirDetalhes();
    }
}