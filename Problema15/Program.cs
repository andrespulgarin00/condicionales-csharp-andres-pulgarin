using System.Globalization;

Console.OutputEncoding = System.Text.Encoding.UTF8;
CultureInfo.CurrentCulture = new CultureInfo("es-CO");

Console.Write("Peso en kg: ");
double peso = double.Parse(Console.ReadLine()!);
Console.Write("Estatura en metros (ej. 1,75): ");
double estatura = double.Parse(Console.ReadLine()!);

double imc = peso / (estatura * estatura);
string categoria;

if (imc < 18.5)
{
    categoria = "Bajo peso";
}
else if (imc < 25)
{
    categoria = "Peso normal";
}
else if (imc < 30)
{
    categoria = "Sobrepeso";
}
else
{
    categoria = "Obesidad";
}

Console.WriteLine($"IMC: {imc:0.0} - {categoria}");
