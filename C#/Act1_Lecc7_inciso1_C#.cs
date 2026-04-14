internal class Program
{
    private static void Main(string[] args)
    {
        double n1, n2, n3, n4, n5, p;
        Console.WriteLine("Escriba sus 5 notas de la clase:");
        n1 = double.Parse(Console.ReadLine());
        n2 = double.Parse(Console.ReadLine());
        n3 = double.Parse(Console.ReadLine());
        n4 = double.Parse(Console.ReadLine());
        n5 = double.Parse(Console.ReadLine());
        p = (n1 + n2 + n3 + n4 + n5) / 5;

        if (p >= 70)
        {
            Console.WriteLine("Ha aprobado la clase");
            Console.WriteLine("Promedio: " + p);
        }
        else {
            Console.WriteLine("Ha reprobado la clase");
            Console.WriteLine("Promedio: " + p);
        }
    }
}