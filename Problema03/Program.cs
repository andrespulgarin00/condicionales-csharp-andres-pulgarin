using System.Globalization;

Console.OutputEncoding = System.Text.Encoding.UTF8;
CultureInfo.CurrentCulture = new CultureInfo("es-CO");

Console.WriteLine("1. Consultar saldo");
Console.WriteLine("2. Retirar");
Console.WriteLine("3. Depositar");
Console.WriteLine("4. Salir");
Console.Write("Digite una opción: ");
int opcion = int.Parse(Console.ReadLine()!);

switch (opcion)
{
    case 1:
        Console.WriteLine("Ha seleccionado: Consultar saldo");
        break;
    case 2:
        Console.WriteLine("Ha seleccionado: Retirar");
        break;
    case 3:
        Console.WriteLine("Ha seleccionado: Depositar");
        break;
    case 4:
        Console.WriteLine("Ha seleccionado: Salir");
        break;
    default:
        Console.WriteLine("Opción no válida");
        break;
}
