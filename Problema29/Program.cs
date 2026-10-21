using System.Globalization;

Console.OutputEncoding = System.Text.Encoding.UTF8;
CultureInfo.CurrentCulture = new CultureInfo("es-CO");

Console.Write("Rol (admin, instructor, aprendiz): ");
string rol = Console.ReadLine()!.Trim().ToLower();
Console.Write("Hora de llegada (0 a 23): ");
int hora = int.Parse(Console.ReadLine()!);

bool puedeEntrar = (rol, hora) switch
{
    ("admin", _) => true,
    ("instructor", >= 6 and <= 21) => true,
    ("aprendiz", >= 6 and <= 18) => true,
    _ => false
};

Console.WriteLine(puedeEntrar ? "Acceso permitido" : "Acceso denegado");
