using System.Globalization;

Console.OutputEncoding = System.Text.Encoding.UTF8;
CultureInfo.CurrentCulture = new CultureInfo("es-CO");

Console.Write("Categoría del vehículo (M, A, B, C): ");
char categoria = char.ToUpper(Console.ReadLine()!.Trim()[0]);

try
{
    int tarifa = categoria switch
    {
        'M' => 0,
        'A' => 12000,
        'B' => 25000,
        'C' => 38000,
        _ => throw new ArgumentException("Categoría desconocida")
    };

    Console.WriteLine($"Categoría {categoria} - Tarifa: ${tarifa:N0}");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Excepción: {ex.Message}");
}
