using System.Globalization;

Console.OutputEncoding = System.Text.Encoding.UTF8;
CultureInfo.CurrentCulture = new CultureInfo("es-CO");

Console.Write("Nota 1 (0 a 100): ");
double nota1 = double.Parse(Console.ReadLine()!);
Console.Write("Nota 2 (0 a 100): ");
double nota2 = double.Parse(Console.ReadLine()!);
Console.Write("Nota 3 (0 a 100): ");
double nota3 = double.Parse(Console.ReadLine()!);

double promedio = (nota1 + nota2 + nota3) / 3;

string letra = promedio switch
{
    >= 90 => "A",
    >= 80 => "B",
    >= 70 => "C",
    >= 60 => "D",
    _ => "F"
};

string retroalimentacion = letra switch
{
    "A" => "Desempeño excelente",
    "B" or "C" => "Buen desempeño, sigue así",
    "D" => "Aprobado, refuerza los temas",
    _ => "Debe presentar plan de mejoramiento"
};

string estado = promedio >= 60 ? "Aprobado" : "Reprobado";

Console.WriteLine($"Promedio: {promedio:0.0} | Letra: {letra} | {retroalimentacion} | {estado}");

if (promedio == 100)
{
    Console.WriteLine("¡Mención de honor!");
}
