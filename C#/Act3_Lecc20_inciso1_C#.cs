internal class Program
{
    private static void Main(string[] args)
    {
        int dia;
        Console.WriteLine("Ingrese un dia de la semana:");
        dia = int.Parse(Console.ReadLine());

        if (dia == 6 || dia == 7) {
            Console.WriteLine("Es Fin de Semana");
        }
        else
        {
            Console.WriteLine("Es Entre Semana");
        }
    }
}