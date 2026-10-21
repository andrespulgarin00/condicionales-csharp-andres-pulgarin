using System.Globalization;

Console.OutputEncoding = System.Text.Encoding.UTF8;
CultureInfo.CurrentCulture = new CultureInfo("es-CO");

Console.Write("Velocidad medida (km/h): ");
double velocidad = double.Parse(Console.ReadLine()!);

string sancion = velocidad switch
{
    < 0 => "Lectura inválida",
    <= 50 => "Sin infracción",
    <= 70 => "Multa leve",
    <= 90 => "Multa grave",
    _ => "Multa gravísima e inmovilización"
};

Console.WriteLine(sancion);
