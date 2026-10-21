using System.Globalization;

Console.OutputEncoding = System.Text.Encoding.UTF8;
CultureInfo.CurrentCulture = new CultureInfo("es-CO");

object[] datos = { "SENA", 42, 3.14, true, 'x' };

foreach (object dato in datos)
{
    string descripcion = dato switch
    {
        string texto => $"Texto de {texto.Length} caracteres",
        int entero => $"Entero: {entero}",
        double decimalValor => $"Decimal: {decimalValor}",
        bool booleano => $"Booleano: {booleano}",
        _ => "Tipo no reconocido"
    };

    Console.WriteLine(descripcion);
}
