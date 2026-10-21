using System.Globalization;

Console.OutputEncoding = System.Text.Encoding.UTF8;
CultureInfo.CurrentCulture = new CultureInfo("es-CO");

Console.Write("Jugada del jugador 1 (piedra, papel o tijera): ");
string jugada1 = Console.ReadLine()!.Trim().ToLower();
Console.Write("Jugada del jugador 2 (piedra, papel o tijera): ");
string jugada2 = Console.ReadLine()!.Trim().ToLower();

string resultado = (jugada1, jugada2) switch
{
    ("piedra", "piedra") or ("papel", "papel") or ("tijera", "tijera") => "Empate",
    ("piedra", "tijera") or ("tijera", "papel") or ("papel", "piedra") => "Gana el jugador 1",
    ("tijera", "piedra") or ("papel", "tijera") or ("piedra", "papel") => "Gana el jugador 2",
    _ => "Jugada no válida"
};

Console.WriteLine(resultado);
