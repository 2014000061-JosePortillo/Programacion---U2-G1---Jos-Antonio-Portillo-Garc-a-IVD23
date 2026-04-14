internal class Program
{
    private static void Main(string[] args)
    {
        double edad;
        Console.WriteLine("Escriba su edad:");
        edad = double.Parse(Console.ReadLine());

        if (edad>=18)
        {
            Console.WriteLine("Usted es mayor de edad");
        }
        else
        {
            Console.WriteLine("Usted es menor de edad");
        }
    }
}