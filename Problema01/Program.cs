using System.Globalization;

Console.OutputEncoding = System.Text.Encoding.UTF8;
CultureInfo.CurrentCulture = new CultureInfo("es-CO");

Console.Write("Ingrese la edad: ");
int edad = int.Parse(Console.ReadLine()!);

if (edad >= 16)
{
    Console.WriteLine("Puede votar");
}
else
{
    Console.WriteLine("Aún no puede votar");
}
