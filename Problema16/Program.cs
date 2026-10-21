using System.Globalization;

Console.OutputEncoding = System.Text.Encoding.UTF8;
CultureInfo.CurrentCulture = new CultureInfo("es-CO");

Console.Write("Coordenada X: ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Coordenada Y: ");
int y = int.Parse(Console.ReadLine()!);

var posicion = (X: x, Y: y);

string ubicacion = posicion switch
{
    (0, 0) => "Origen",
    (0, _) or (_, 0) => "Sobre un eje",
    (> 0, > 0) => "Primer cuadrante",
    (< 0, > 0) => "Segundo cuadrante",
    (< 0, < 0) => "Tercer cuadrante",
    _ => "Cuarto cuadrante" 
};

Console.WriteLine(ubicacion);
