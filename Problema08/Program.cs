using System.Globalization;

Console.OutputEncoding = System.Text.Encoding.UTF8;
CultureInfo.CurrentCulture = new CultureInfo("es-CO");

Console.Write("Ingrese una letra minúscula: ");
char letra = char.ToLower(Console.ReadLine()!.Trim()[0]);

string resultado = letra switch
{
    'a' or 'e' or 'i' or 'o' or 'u' => "Es vocal",
    >= 'a' and <= 'z' or 'ñ' => "Es consonante",
    _ => "No es una letra"
};

Console.WriteLine(resultado);
