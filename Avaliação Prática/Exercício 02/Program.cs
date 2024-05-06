public class Program {
    public static void Main(string[] args) {
        IProcessamento processamento = new CartaoCreditoProcessamento();
        Checkout checkout = new Checkout(processamento);

        decimal valorCompra = 100.00m;
        checkout.FinalizarCompra(valorCompra);
    }
}