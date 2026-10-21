using System.Globalization;

Console.OutputEncoding = System.Text.Encoding.UTF8;
CultureInfo.CurrentCulture = new CultureInfo("es-CO");

Console.Write("¿Tiene empleo? (si/no): ");
bool tieneEmpleo = EsAfirmativo(Console.ReadLine()!);

if (!tieneEmpleo)
{
    Console.WriteLine("Crédito rechazado");
}
else
{
    Console.Write("Ingreso mensual: ");
    decimal ingreso = decimal.Parse(Console.ReadLine()!);

    if (ingreso >= 2500000)
    {
        Console.WriteLine("Crédito alto aprobado");
    }
    else
    {
        Console.WriteLine("Crédito básico aprobado");
    }
}

static bool EsAfirmativo(string respuesta) =>
    respuesta.Trim().ToLower() is "s" or "si" or "sí";
