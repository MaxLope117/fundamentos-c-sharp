namespace Fundamentos;

class Clase
{
  /* 
   * Cuerpo de la clase puede estar formado por:
   * - Constantes
   * - Métodos
   * - Propiedades
   * - Eventos
   * - Indizadores
   * - Operadores
   * - Constructores
   * - Destructores
   * - Tipos
  */

  //* Campos o Propiedades
  public int Campo;
  // public required string Nombre { get; set; }
  public string? Nombre { get; set; }
  public string? Apellidos { get; set; }
  public int Edad { get; private set; }
  public int Estado = 1;

  // public readonly string Identificador = "XX";
  public readonly string Identificador;

  //* Constructor
  public Clase()
  {
    Identificador = "ABCD";
    Edad = 21;
  }

  public void Metodo()
  {
    Edad = 23;
    // Identificador = "XXX";
  }


}