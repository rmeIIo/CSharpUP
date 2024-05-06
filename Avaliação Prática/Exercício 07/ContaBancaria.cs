public abstract class ContaBancaria {
    public string NumeroConta {get; set;}
    public decimal Saldo {get; set;}

    public ContaBancaria(string numeroConta) {
        NumeroConta = numeroConta;
    }

    public virtual void Depositar(decimal valor) {
        Saldo += valor;
    }

    public abstract void Sacar(decimal valor);
}

public class ContaCorrente : ContaBancaria {
    public ContaCorrente(string numeroConta) : base(numeroConta) {}

    public override void Sacar(decimal valor) {
        if(Saldo >= valor) {
            Saldo -= valor;
        } else {
            Console.WriteLine("Saldo insuficiente.");
        }
    }
}

public class ContaPoupanca : ContaBancaria {
    private decimal TaxaJuros {get; set;}

    public ContaPoupanca(string numeroConta, decimal taxaJuros) : base(numeroConta) {
        TaxaJuros = taxaJuros;
    }

    public override void Sacar(decimal valor) {
        if(Saldo >= valor) {
            Saldo -= valor;
        } else {
            Console.WriteLine("Saldo insuficiente.");
        }
    }

    public void CalcularJuros() {
        Saldo += Saldo * TaxaJuros;
    }
}

public class ContaEmpresarial : ContaBancaria {
    private decimal SaldoMinimo {get; set;}

    public ContaEmpresarial(string numeroConta, decimal saldoMinimo) : base(numeroConta) {
        SaldoMinimo = saldoMinimo;
    }

    public override void Sacar(decimal valor) {
        if(Saldo - valor >= SaldoMinimo) {
            Saldo -= valor;
        } else {
            Console.WriteLine("Saldo insuficiente.");
        }
    }
}

