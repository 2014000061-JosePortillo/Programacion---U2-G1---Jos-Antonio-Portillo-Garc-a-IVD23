internal class Program
{
    private static void Main(string[] args)
    {
        int nota;
        Console.WriteLine("===Calificaciones===");
        Console.WriteLine("Escriba su nota:");
        nota = int.Parse(Console.ReadLine());

        if (nota >= 0 && nota <= 20) {
            Console.WriteLine("Su nota es deficiente");
        }
        else if (nota >= 21 && nota <= 40)
        {
            Console.WriteLine("Su nota es regular");
        }
        else if (nota >= 41 && nota <= 60)
        {
            Console.WriteLine("Su nota esta bien");
        }
        else if (nota >= 61 && nota <= 80)
        {
            Console.WriteLine("Su nota esta muy bien");
        }
        else if (nota >= 81 && nota <= 100)
        {
            Console.WriteLine("Su nota es excelente");
        }
    }
}