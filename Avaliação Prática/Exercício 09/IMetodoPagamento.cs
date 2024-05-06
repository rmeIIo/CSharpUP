
public interface IMetodoPagamento {
    void RealizarPagamento();
    void VerificarStatusPagamento();
}

public class CartaoCredito : IMetodoPagamento {
    public void RealizarPagamento() {
        Console.WriteLine("Pagamento realizado com cartão de crédito.");
    }

    public void VerificarStatusPagamento() {
        Console.WriteLine("Status do pagamento com cartão de crédito: Aprovado.");
    }
}

public class BoletoBancario : IMetodoPagamento {
    public void RealizarPagamento() {
        Console.WriteLine("Pagamento realizado com boleto bancário.");
    }

    public void VerificarStatusPagamento() {
        Console.WriteLine("Status do pagamento com boleto bancário: Pendente.");
    }
}

public class TransferenciaBancaria : IMetodoPagamento {
    public void RealizarPagamento() {
        Console.WriteLine("Pagamento realizado com transferência bancária.");
    }

    public void VerificarStatusPagamento() {
        Console.WriteLine("Status do pagamento com transferência bancária: Concluído.");
    }
}