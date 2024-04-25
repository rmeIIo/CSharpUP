public abstract class FiguraGeometrica
{
    public abstract double CalcularArea();
    public abstract double CalcularPerimetro();
}

public class Quadrado : FiguraGeometrica
{
    private double lado;

    public Quadrado(double lado)
    {
        this.lado = lado;
    }

    public override double CalcularArea()
    {
        return lado * lado;
    }

    public override double CalcularPerimetro()
    {
        return 4 * lado;
    }
}

public class Circulo : FiguraGeometrica
{
    private double raio;

    public Circulo(double raio)
    {
        this.raio = raio;
    }

    public override double CalcularArea()
    {
        return Math.PI * raio * raio;
    }

    public override double CalcularPerimetro()
    {
        return 2 * Math.PI * raio;
    }
}

public class Triangulo : FiguraGeometrica
{
    private double baseTriangulo;
    private double altura;

    public Triangulo(double baseTriangulo, double altura)
    {
        this.baseTriangulo = baseTriangulo;
        this.altura = altura;
    }

    public override double CalcularArea()
    {
        return (baseTriangulo * altura) / 2;
    }

    public override double CalcularPerimetro()
    {
        // Não é possível calcular o perímetro de um triângulo apenas com a base e altura fornecidas
        throw new NotImplementedException();
    }
}

public class Retangulo : FiguraGeometrica
{
    private double baseRetangulo;
    private double altura;

    public Retangulo(double baseRetangulo, double altura)
    {
        this.baseRetangulo = baseRetangulo;
        this.altura = altura;
    }

    public override double CalcularArea()
    {
        return baseRetangulo * altura;
    }

    public override double CalcularPerimetro()
    {
        return 2 * (baseRetangulo + altura);
    }
}