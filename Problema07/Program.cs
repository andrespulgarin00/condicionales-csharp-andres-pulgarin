using System.Globalization;

Console.OutputEncoding = System.Text.Encoding.UTF8;
CultureInfo.CurrentCulture = new CultureInfo("es-CO");

Console.Write("Ingrese un número entero: ");
int numero = int.Parse(Console.ReadLine()!);

if (numero > 0)
{
    Console.WriteLine("Positivo");
}
else if (numero < 0)
{
    Console.WriteLine("Negativo");
}
else
{
    Console.WriteLine("Cero");
}
