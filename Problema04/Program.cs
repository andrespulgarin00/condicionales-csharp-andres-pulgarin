using System.Globalization;

Console.OutputEncoding = System.Text.Encoding.UTF8;
CultureInfo.CurrentCulture = new CultureInfo("es-CO");

Console.Write("Nivel de batería (%): ");
int bateria = int.Parse(Console.ReadLine()!);

if (bateria < 15)
{
    Console.WriteLine("Batería baja: conecte el cargador");
}

Console.WriteLine($"Nivel actual: {bateria} %");
