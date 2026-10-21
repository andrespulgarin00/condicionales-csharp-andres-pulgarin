using System.Globalization;

Console.OutputEncoding = System.Text.Encoding.UTF8;
CultureInfo.CurrentCulture = new CultureInfo("es-CO");

Console.Write("Peso del paquete en kg (ej. 0,5): ");
double peso = double.Parse(Console.ReadLine()!);

int tarifa;

if (peso <= 0)
{
    tarifa = 0;
    Console.WriteLine("Peso inválido");
}
else if (peso < 1)
{
    tarifa = 8000;
}
else if (peso < 5)
{
    tarifa = 15000;
}
else if (peso < 20)
{
    tarifa = 32000;
}
else
{
    tarifa = 60000;
}

Console.WriteLine($"Tarifa: ${tarifa:N0}");
