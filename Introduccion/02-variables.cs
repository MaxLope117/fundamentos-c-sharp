namespace Introduccion;

public class Variables
{
  public static void AboutVariables()
  {
    string? mensaje = Console.ReadLine();
    string? hola = null; // Puede ser nula para ello el '?'

    // int edad = 10;
    // bool verdadero = true;

    int edad = default; // 0
    bool verdadero = default; // false

    edad = edad + 5;

    if (hola == null && verdadero)
    {
      // do something
      Console.WriteLine("Hola Mundo");
    }

    DateTime? fecha = new DateTime();
    Console.WriteLine(fecha);
    fecha = null;
    int? dia = fecha?.Day;
    Console.WriteLine(dia);

    Console.Write(mensaje);
    Console.Write(edad);
    Console.ReadLine();
  }
}
