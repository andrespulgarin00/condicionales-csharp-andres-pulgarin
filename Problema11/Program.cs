using System.Globalization;

Console.OutputEncoding = System.Text.Encoding.UTF8;
CultureInfo.CurrentCulture = new CultureInfo("es-CO");

Console.Write("Estado del semáforo (Rojo, Amarillo, Verde): ");
string? texto = Console.ReadLine();

if (Enum.TryParse<Semaforo>(texto, true, out Semaforo estado) && Enum.IsDefined(estado))
{
    string instruccion = estado switch
    {
        Semaforo.Rojo => "Deténgase",
        Semaforo.Amarillo => "Precaución, prepárese para detenerse",
        Semaforo.Verde => "Avance",
        _ => "Estado desconocido"
    };

    Console.WriteLine(instruccion);
}
else
{
    Console.WriteLine("Estado no válido");
}

enum Semaforo
{
    Rojo,
    Amarillo,
    Verde
}
