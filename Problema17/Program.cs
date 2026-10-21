using System.Globalization;

Console.OutputEncoding = System.Text.Encoding.UTF8;
CultureInfo.CurrentCulture = new CultureInfo("es-CO");

Console.Write("Comando (play, pause, stop, next): ");
string comando = Console.ReadLine()!.Trim().ToLower();

switch (comando)
{
    case "play":
        Console.WriteLine("Reproduciendo...");
        break;
    case "pause":
        Console.WriteLine("En pausa");
        break;
    case "stop":
        Console.WriteLine("Detenido");
        break;
    case "next":
        Console.WriteLine("Siguiente canción");
        break;
    default:
        Console.WriteLine("Comando no reconocido");
        break;
}
