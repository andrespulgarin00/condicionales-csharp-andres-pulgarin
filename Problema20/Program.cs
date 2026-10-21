using System.Globalization;

Console.OutputEncoding = System.Text.Encoding.UTF8;
CultureInfo.CurrentCulture = new CultureInfo("es-CO");

Console.Write("Número del mes (1 a 12): ");
int mes = int.Parse(Console.ReadLine()!);

string resultado = mes switch
{
    1 or 3 or 5 or 7 or 8 or 10 or 12 => "31 días",
    4 or 6 or 9 or 11 => "30 días",
    2 => "28 días",
    _ => "Mes inválido"
};

Console.WriteLine(resultado);
