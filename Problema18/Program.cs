using System.Globalization;

Console.OutputEncoding = System.Text.Encoding.UTF8;
CultureInfo.CurrentCulture = new CultureInfo("es-CO");

Console.Write("Estatura en metros (ej. 1,50): ");
double estatura = double.Parse(Console.ReadLine()!);
Console.Write("Edad: ");
int edad = int.Parse(Console.ReadLine()!);
Console.Write("¿Va acompañado por un adulto? (si/no): ");
bool conAdulto = EsAfirmativo(Console.ReadLine()!);

if (estatura >= 1.40 && (edad >= 12 || conAdulto))
{
    Console.WriteLine("Puede subir");
}
else
{
    Console.WriteLine("No puede subir");
}

static bool EsAfirmativo(string respuesta) =>
    respuesta.Trim().ToLower() is "s" or "si" or "sí";
