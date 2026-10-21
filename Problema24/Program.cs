using System.Globalization;

Console.OutputEncoding = System.Text.Encoding.UTF8;
CultureInfo.CurrentCulture = new CultureInfo("es-CO");

Console.Write("Número del día (1 = lunes ... 7 = domingo): ");
int dia = int.Parse(Console.ReadLine()!);

string tipoDia = dia switch
{
    >= 1 and <= 5 => "Día hábil",
    6 or 7 => "Fin de semana",
    _ => "Día inválido"
};

Console.WriteLine(tipoDia);
