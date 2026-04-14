internal class Program
{
    private static void Main(string[] args)
    {

        int num;
        Console.WriteLine("=== Buzon de vos de: Constru Herrera ===");
        Console.WriteLine("Ingrese uno los siguientes numeros si quiere comunicarse con:");
        Console.WriteLine("1: Ventas");
        Console.WriteLine("2: Recepcion");
        Console.WriteLine("3: Direccion");
        Console.WriteLine("4: Compras");
        num = int.Parse(Console.ReadLine());

        switch (num) {
            case 1:
                Console.WriteLine("Bienvenido al departamento de: VENTAS");
                Console.WriteLine("Correo del responsable: cherrera@gmail.com");
                break;
            case 2:
                Console.WriteLine("Bienvenido al departamento de: RECEPCION");
                Console.WriteLine("Correo del responsable: angeliagarcia@gmail.com");
                break;
            case 3:
                Console.WriteLine("Bienvenido al departamento de: DIRECCION");
                Console.WriteLine("Correo del responsable: jjose1976@gmail.com");
                break;
            case 4:
                Console.WriteLine("Bienvenido al departamento de: COMPRAS");
                Console.WriteLine("Correo del responsable: rramirez08@gmail.com");
                break;
            default:
                Console.WriteLine("Ingrese un numero valido");
                break;

        }

    }
}