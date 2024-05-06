public class Program {
    public static void Main(string[] args) {
        IMetodoPagamento metodoPagamento = new CartaoCredito();
        metodoPagamento.RealizarPagamento();
        metodoPagamento.VerificarStatusPagamento();

        metodoPagamento = new BoletoBancario();
        metodoPagamento.RealizarPagamento();
        metodoPagamento.VerificarStatusPagamento();

        metodoPagamento = new TransferenciaBancaria();
        metodoPagamento.RealizarPagamento();
        metodoPagamento.VerificarStatusPagamento();
    }
}