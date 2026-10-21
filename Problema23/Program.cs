using System.Globalization;

Console.OutputEncoding = System.Text.Encoding.UTF8;
CultureInfo.CurrentCulture = new CultureInfo("es-CO");

Console.Write("Usuario: ");
string usuario = Console.ReadLine()!;

if (usuario == "aprendiz")
{
    Console.Write("Contraseña: ");
    string contrasena = Console.ReadLine()!;

    if (contrasena == "Sena2026")
    {
        Console.WriteLine("Bienvenido");
    }
    else
    {
        Console.WriteLine("Contraseña incorrecta");
    }
}
else
{
    Console.WriteLine("Usuario no encontrado");
}
