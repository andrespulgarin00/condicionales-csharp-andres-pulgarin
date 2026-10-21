using System.Globalization;

Console.OutputEncoding = System.Text.Encoding.UTF8;
CultureInfo.CurrentCulture = new CultureInfo("es-CO");

Console.Write("Primer número: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Segundo número: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Operador (+, -, *, /): ");
char operador = Console.ReadLine()!.Trim()[0];

try
{
    int resultado = operador switch
    {
        '+' => a + b,
        '-' => a - b,
        '*' => a * b,
        '/' when b == 0 => throw new DivideByZeroException("No se puede dividir entre cero"),
        '/' => a / b,
        _ => throw new InvalidOperationException("Operador no soportado")
    };

    Console.WriteLine($"{a} {operador} {b} = {resultado}");
}
catch (Exception ex)
{
    Console.WriteLine($"Excepción: {ex.Message}");
}
