using System.Globalization;

Console.OutputEncoding = System.Text.Encoding.UTF8;
CultureInfo.CurrentCulture = new CultureInfo("es-CO");

Console.Write("Nota final (0 a 5, ej. 3,5): ");
double nota = double.Parse(Console.ReadLine()!);

string estado = nota >= 3.0 ? "Aprobado" : "Reprobado";

Console.WriteLine($"Nota: {nota:0.0} - {estado}");
