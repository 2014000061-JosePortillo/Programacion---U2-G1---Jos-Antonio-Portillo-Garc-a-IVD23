internal class Program
{
    private static void Main(string[] args)
    {
        int num;
        Console.WriteLine("Servicio Hotel Camino Real");
        Console.WriteLine("Escriba un numero");
        num = int.Parse(Console.ReadLine());

        switch (num)
        {
            case 1:
                Console.WriteLine("Llamar a recepcion");
                break;
            case 2:
                Console.WriteLine("Llamar a vigilancia");
                break;
            case 3:
                Console.WriteLine("Llamar a mantenimiento");
                break;
            case 4:
                Console.WriteLine("Llamar a restaurante");
                break;
            default:
                Console.WriteLine("Error, numero invalido");
                break;  
        }
    }
}