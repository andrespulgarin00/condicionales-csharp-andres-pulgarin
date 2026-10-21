using System.Globalization;

Console.OutputEncoding = System.Text.Encoding.UTF8;
CultureInfo.CurrentCulture = new CultureInfo("es-CO");

Console.Write("Ingrese un año: ");
int anio = int.Parse(Console.ReadLine()!);

bool esBisiesto = (anio % 4 == 0 && anio % 100 != 0) || anio % 400 == 0;

if (esBisiesto)
{
    Console.WriteLine("Bisiesto");
}
else
{
    Console.WriteLine("No bisiesto");
}
