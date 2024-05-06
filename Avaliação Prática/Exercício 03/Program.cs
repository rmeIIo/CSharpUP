public class Program {
    public static void Main(string[] args) {

        // Sobrecarga de Métodos
        Sobrecarga sobrecarga = new Sobrecarga();
        
        int result1 = sobrecarga.Soma(2, 3);
        Console.WriteLine("Resultado da soma de inteiros: " + result1);
        
        double result2 = sobrecarga.Soma(2.5, 3.7);
        Console.WriteLine("Resultado da soma de doubles: " + result2);

        // Sobreposição de Métodos
        Sobreposicao obj1 = new Sobreposicao();
        Derivada obj2 = new Derivada();

        obj1.Metodo(); // Output: "Método da classe base"
        obj2.Metodo(); // Output: "Método da classe derivada"
    }
}