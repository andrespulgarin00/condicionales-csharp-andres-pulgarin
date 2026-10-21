using System.Globalization;

Console.OutputEncoding = System.Text.Encoding.UTF8;
CultureInfo.CurrentCulture = new CultureInfo("es-CO");

Console.Write("Valor de la compra: ");
decimal compra = decimal.Parse(Console.ReadLine()!);
Console.Write("¿Es cliente frecuente? (si/no): ");
bool esFrecuente = EsAfirmativo(Console.ReadLine()!);

int descuento;

if (compra >= 500000)
{
    descuento = 15;
}
else if (compra >= 200000)
{
    descuento = 10;
}
else if (compra >= 100000)
{
    descuento = 5;
}
else
{
    descuento = 0;
}


if (esFrecuente && compra >= 100000)
{
    descuento += 5;
}

decimal total = compra - compra * descuento / 100;

Console.WriteLine($"Valor de la compra: ${compra:N0}");
Console.WriteLine($"Descuento total: {descuento} %");
Console.WriteLine($"Total a pagar: ${total:N0}");

static bool EsAfirmativo(string respuesta) =>
    respuesta.Trim().ToLower() is "s" or "si" or "sí";
