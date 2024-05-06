public interface IProcessamento {
    bool ProcessarPagamento(decimal valor);
}

public class CartaoCreditoProcessamento : IProcessamento {
    public bool ProcessarPagamento(decimal valor) {
        Console.WriteLine("Pagamento processado com cartão de crédito.");
        return true;
    }
}

public class CartaoDebitoProcessamento : IProcessamento {
    public bool ProcessarPagamento(decimal valor) {
        Console.WriteLine("Pagamento processado com cartão de débito.");
        return true;
    }
}

public class Checkout {
    private IProcessamento _processamento;

    public Checkout(IProcessamento processamento) {
        _processamento = processamento;
    }

    public void FinalizarCompra(decimal valor) {
        bool pagamentoSucedido = _processamento.ProcessarPagamento(valor);
    
        if (pagamentoSucedido) {
            Console.WriteLine("Compra finalizada com sucesso.");
        } else {
            Console.WriteLine("Falha ao processar pagamento.");
        }
    
    }
}

