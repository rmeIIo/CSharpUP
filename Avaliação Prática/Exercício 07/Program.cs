public class Program {
    public static void Main(string[] args) {
        ContaCorrente contaCorrente = new ContaCorrente("123456");
        contaCorrente.Depositar(1000);
        contaCorrente.Sacar(500);
        Console.WriteLine($"Saldo da conta corrente: {contaCorrente.Saldo}");

        ContaPoupanca contaPoupanca = new ContaPoupanca("789012", 0.05m);
        contaPoupanca.Depositar(2000);
        contaPoupanca.Sacar(1000);
        contaPoupanca.CalcularJuros();
        Console.WriteLine($"Saldo da conta poupança: {contaPoupanca.Saldo}");

        ContaEmpresarial contaEmpresarial = new ContaEmpresarial("345678", 5000);
        contaEmpresarial.Depositar(10000);
        contaEmpresarial.Sacar(8000);
        Console.WriteLine($"Saldo da conta empresarial: {contaEmpresarial.Saldo}");
    }
}