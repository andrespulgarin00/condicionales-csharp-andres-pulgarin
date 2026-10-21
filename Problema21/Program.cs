using System.Globalization;

Console.OutputEncoding = System.Text.Encoding.UTF8;
CultureInfo.CurrentCulture = new CultureInfo("es-CO");

Console.Write("Cantidad de artículos en el carrito: ");
int cantidad = int.Parse(Console.ReadLine()!);

string mensaje = $"Tienes {cantidad} {(cantidad == 1 ? "artículo" : "artículos")} en el carrito";

Console.WriteLine(mensaje);
