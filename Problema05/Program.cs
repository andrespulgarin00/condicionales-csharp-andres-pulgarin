using System.Globalization;

Console.OutputEncoding = System.Text.Encoding.UTF8;
CultureInfo.CurrentCulture = new CultureInfo("es-CO");

Console.Write("Primer número: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Segundo número: ");
int b = int.Parse(Console.ReadLine()!);

int mayor = a > b ? a : b;

Console.WriteLine($"El mayor es {mayor}");
