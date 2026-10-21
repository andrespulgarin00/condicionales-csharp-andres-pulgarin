using System.Globalization;

Console.OutputEncoding = System.Text.Encoding.UTF8;
CultureInfo.CurrentCulture = new CultureInfo("es-CO");

Console.Write("Índice de calidad del aire (ICA): ");
int ica = int.Parse(Console.ReadLine()!);

string categoria = ica switch
{
    < 0 => "Valor inválido",
    <= 50 => "Buena",
    <= 100 => "Moderada",
    <= 150 => "Dañina para grupos sensibles",
    <= 200 => "Dañina",
    _ => "Muy dañina"
};

Console.WriteLine(categoria);
