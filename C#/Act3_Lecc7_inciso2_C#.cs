internal class Program
{
    private static void Main(string[] args)
    {
        int a1, a2, a3;
        Console.WriteLine("Triangulos");
        Console.WriteLine("Ingrese los angulos del triangulo:");
        a1 = int.Parse(Console.ReadLine());
        a2 = int.Parse(Console.ReadLine());
        a3 = int.Parse(Console.ReadLine());

        if (a1 == 60 && a2 == 60 && a3 == 60)
        {
            Console.WriteLine("Es un triangulo equilatero");
        }
        else if (a1 == a2 && a3 != a1 || a1 == a3 && a2 != a1 || a2 == a3 && a1 != a2)
        {
            Console.WriteLine("El triangulo es isoceles");
        }
        else if (a1 != a2 && a1 != a3 && a2 != a3)
        {
            Console.WriteLine("Es un triangulo escaleno");
        }
    }
}