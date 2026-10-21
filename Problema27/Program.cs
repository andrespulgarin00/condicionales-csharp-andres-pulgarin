using System.Globalization;

Console.OutputEncoding = System.Text.Encoding.UTF8;
CultureInfo.CurrentCulture = new CultureInfo("es-CO");

Console.Write("Día de la semana (lunes ... domingo): ");
string dia = Console.ReadLine()!.Trim().ToLower();
Console.Write("¿Es estudiante? (si/no): ");
bool esEstudiante = EsAfirmativo(Console.ReadLine()!);

try
{
    int precio = (dia, esEstudiante) switch
    {
        ("martes", _) => 7000,
        ("sábado" or "sabado" or "domingo", _) => 15000,
        ("lunes" or "miércoles" or "miercoles" or "jueves" or "viernes", true) => 9000,
        ("lunes" or "miércoles" or "miercoles" or "jueves" or "viernes", false) => 12000,
        _ => throw new ArgumentException("Día no válido")
    };

    Console.WriteLine($"Precio de la boleta: ${precio:N0}");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Excepción: {ex.Message}");
}

static bool EsAfirmativo(string respuesta) =>
    respuesta.Trim().ToLower() is "s" or "si" or "sí";
