using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Text.Json.Serialization;
using static System.Convert;

namespace Fundamentos;

class Program
{
    #region Prueba Tecnica
    static int multiplicacion(int multiplicando, int multiplicador)
    {
        var result = 0;
        for (int i = 0; i < multiplicador; i++)
        {
            result += multiplicando;
        }
        return result;
    }

    static int mayorque(int[] conjunto)
    {
        int mayor = 0;
        foreach (int numero in conjunto)
        {
            if (mayor < numero)
            {
                mayor = numero;
            }
        }

        return mayor;
    }
    #endregion

    static void Matrices() // Arrays
    {
        // type[] nombreArray;
        // int[] arrayDeEnteros;
        int[] arrayDeEnteros2 = new int[5];
        int[] arrayDeEnteros3 = { 1, 2, 3, 4 };
        int[,] arrayDeEnteros2D = new int[2, 2];
        int[,] arrayDeEnteros2D2 = { { 1, 2 }, { 3, 4 } };
        int[][] arrayDeEnterosEscalonados = new int[6][];
        arrayDeEnterosEscalonados[0] = new int[4] { 3, 6, 7, 2 };
        arrayDeEnterosEscalonados[1] = new int[2] { 1, 3 };

        for (int i = 0; i < arrayDeEnteros3.Length; i++)
        {
            Console.WriteLine(arrayDeEnteros3[i]);
        }

        foreach (var elementos in arrayDeEnteros3)
        {
            Console.WriteLine(elementos);
        }

        for (int i = 0; i < arrayDeEnteros2D2.GetLongLength(0); i++)
        {
            for (int j = 0; j < arrayDeEnteros2D2.GetLongLength(1); j++)
            {
                Console.WriteLine(arrayDeEnteros2D2[i, j]);
            }
        }
        for (int i = 0; i < arrayDeEnterosEscalonados.GetLongLength(0); i++)
        {
            for (int j = 0; j < arrayDeEnterosEscalonados.GetLongLength(1); j++)
            {
                Console.WriteLine(arrayDeEnterosEscalonados[i][j]);
            }
        }

    }
    static void Conversiones() // Casting
    {
        string cadena = "Hola";
        int numero = 12;
        cadena = numero.ToString();

        // Implícitos.
        int numeroEntero = 34543;
        long numeroLong = numeroEntero;

        // Explícitos.
        double numeroDouble = 12.56;
        int numeroEnteroDouble = (int)numeroDouble;
        Console.WriteLine(numeroEnteroDouble);

        // Definidos por el usuario.

        // Con clases de asistentes.
        double doubleValor = 8.45;
        int enterovalor = ToInt32(doubleValor);
        Convert.ToInt64(doubleValor);
    }

    #region Metodos y Funciones
    //* nivelDeAcceso valorDeRetorno Nombre(parametros) { cuerpo }
    public void EstoEsUnMetodo()
    {
        // código
    }

    void Procedimiento() // Ejecutan código sin devolver nada
    {
        Console.Write("Esto es un procedimiento");
    }

    int Funcion() // Una función si retorna un valor
    {
        return 7 + 3;
    }

    public string FullName(string name, string lastName)
    {
        return name + lastName;
    }

    //* Paso por valor
    public static void ChangeForValor(int number)
    {
        number = 10;
    }
    //* Paso por referencia
    public static void ChangeForReference(ref int number)
    {
        number = 10;
    }

    //* Funciones locales
    public static void PrincipalFunction(int number)
    {
        Console.WriteLine("Estamos dentro de la función principal " + number);

        number = number + 10;

        LocalFunction(number);

        void LocalFunction(int localNumber)
        {
            localNumber = localNumber * 15;
            Console.WriteLine(localNumber);
        }
    }
    #endregion

    #region Cadenas/Strings
    static void Cadenas()
    {
        Console.WriteLine("\n===================================");
        Console.WriteLine("\nFormatear Cadenas\n");
        Console.WriteLine("===================================\n");

        string miCadena = "";
        string miCadena1 = string.Empty;
        string miCadena2 = "Hola Mundo!";

        int numero = 7;
        string numberToString = numero.ToString();

        Console.WriteLine("{0}{1}Soy Max", miCadena2, miCadena);

        FormatDates();

        Concatenar();

        // TODO: StringBuilder

        Operations();

        void FormatDates()
        {
            Console.WriteLine("\n===================================");
            Console.WriteLine("Formatear Fechas");
            Console.WriteLine("===================================\n");
            DateTime date = new DateTime();
            date = DateTime.Now;
            Console.WriteLine("ToLocalTime: " + date.ToLocalTime());
            Console.WriteLine("ToLongTimeString: " + date.ToLongTimeString());
            Console.WriteLine("ToLongDateString: " + date.ToLongDateString());
            Console.WriteLine("ToOADate: " + date.ToOADate());
            Console.WriteLine("ToShortDateString: " + date.ToShortDateString());
            Console.WriteLine("ToShortTimeString: " + date.ToShortTimeString());
            Console.WriteLine("ToString: " + date.ToString());
            Console.WriteLine("ToUniversalTime: " + date.ToUniversalTime());
            Console.ReadLine();

            string dateString = String.Format("La fecha de hoy es: {0:dddd mm yyyy}", DateTime.Now);
            Console.WriteLine(dateString);
            Console.ReadLine();
        }

        void Concatenar()
        {
            Console.WriteLine("\n===================================");
            Console.WriteLine("\nConcatenar cadenas\n");
            Console.WriteLine("===================================\n");
            string superhero = "Superman";
            string from = "Kripton";
            string superpower = "súper fuerza";

            string todosDatos = superhero + " procede de " + from + " y tiene " + superpower;
            string todosDatosConcat = string.Concat(superhero, " procede de", from, " y tiene ", superpower);
            string todosDatosInterpolation = $"{superhero} procede de {from} y tiene {superpower}";

            Console.WriteLine(todosDatos);
            Console.ReadLine();

            Console.WriteLine(todosDatosConcat);
            Console.ReadLine();
        }

        // TODO: StringBuilder

        void Operations()
        {
            Console.WriteLine("\n===================================");
            Console.WriteLine("Operaciones con cadenas");
            Console.WriteLine("===================================\n");

            string villano = "Gru";
            string esbirros = "Minions";
            string frase = "Los minions ayudan a Gru a conquistar el mundo";

            // Concatenar cadenas
            string concatenar = String.Concat(villano, " tiene ", esbirros);

            // Encontrar cadena
            if (villano.Contains("Gru"))
            {
                Console.WriteLine($"{villano} pertenece a la película de mi Villano Favorito");
            }
            else
            {
                Console.WriteLine($"{villano} pertenece a una película desconocida");
            }

            if (villano.Contains("Mini"))
            {
                Console.WriteLine($"{esbirros} quizá pertenece a la película de mi Villano Favorito");
            }

            // Obtener subcadena
            string subcadena = frase.Substring(4, 7);
            Console.WriteLine(subcadena);
            Console.ReadLine();

            // Una cadena acaba en...
            if (frase.EndsWith("mundo"))
            {
                Console.WriteLine("Quizá domine el mundo");
            }
        }
    }
    #endregion

    #region Colecciones
    static void Colecciones()
    {
        Console.WriteLine("\n===================================");
        Console.WriteLine("Colecciones");
        Console.WriteLine("===================================\n");

        // ArrayList
        Listas();

        // Pila o Stack
        Pila();

        // Cola o Queue
        Cola();

        // Hastable
        HashTable();

        void Listas()
        {
            ArrayList lista = new ArrayList();
            lista.Add(1);
            lista.Add("Batman");

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            var element = lista[0];
            var element1 = lista[1];

            Console.WriteLine(element);
            Console.WriteLine(element1);

            int contador = lista.Count;
            Console.WriteLine($"El número de elementos de la lista es {contador}");

            lista.Insert(1, "Superman");
            Console.WriteLine($"Superman fue instertado en la lista en la posición 1");
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            Console.WriteLine($"Fue removidola posición 1 de la lista (Superman)");
            lista.RemoveAt(1);
            Console.ReadLine();
        }

        void Pila()
        {
            //* LIFO = last in first out => Primero que entra, último que sale.
            Stack pila = new Stack();

            pila.Push(1);
            pila.Push(5);
            pila.Push(10);
            pila.Push(3);
            // 3 => 10 => 5 => 1

            Console.WriteLine("Remover un elemento con Pop.");
            var number = pila.Pop();
            Console.WriteLine(number);
            Console.ReadLine();

            foreach (var item in pila)
            {
                Console.WriteLine(item);
                Console.ReadLine();
            }

            Console.WriteLine("Contar el número de elementos.");
            int contador = pila.Count;
            Console.WriteLine(contador);

            Console.WriteLine("Saber si la pila contiene cierto elemento (un 10 en este ejemplo).");
            if (pila.Contains(10))
            {
                Console.WriteLine("La Pila sí contiene un 10.");
            }
            else
            {
                Console.WriteLine("La Pila no contiene un 10.");
            }

            Console.WriteLine("Limpiar la pila");
            pila.Clear();

        }

        void Cola()
        {
            //* FIFO => First In First Out => Sale el primero que entra.
            Queue cola = new Queue();

            cola.Enqueue(3);
            cola.Enqueue(5);
            cola.Enqueue(1);

            cola.Enqueue(15);
            cola.Enqueue(13);

            //* Cantidad de elementos en la cola
            Console.WriteLine("Cantidad de elementos en la cola");
            int numberOfElementsInQueue = cola.Count;
            Console.WriteLine(numberOfElementsInQueue);
            Console.ReadLine();

            //* Extraer valores de la cola
            Console.WriteLine("Extraer valores de la cola");
            var valorCola = cola.Dequeue();
            Console.WriteLine(valorCola);
            Console.ReadLine();

            //* Para observar el valor en la cola sin sacarlo
            Console.WriteLine("Para observar el valor");
            valorCola = cola.Peek();
            Console.WriteLine(valorCola);
            Console.ReadLine();

            //* Comprobar si existe un valor
            Console.WriteLine("Comprobar si existe un valor");
            if (cola.Contains(5))
            {
                Console.WriteLine(valorCola);
            }
            Console.ReadLine();

            //* Recorrer una cola
            Console.WriteLine("Recorrer una cola");
            foreach (var item in cola)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            //* Borrar valores en cola
            Console.WriteLine("Borrar valores en cola");
            cola.Clear();
            Console.WriteLine(valorCola);
            Console.ReadLine();

        }

        void HashTable()
        {
            Hashtable hastable = new Hashtable();

            //* Añadir valores.
            hastable.Add("Alejandro", 1.22);
            hastable.Add("Rodrigo", 5.21);
            hastable.Add("Miriam", 9.62);

            //* Recorrer Hashtable
            foreach (DictionaryEntry item in hastable)
            {
                Console.WriteLine(item.Value + " " + item.Key);
            }

            //* Obtener valor del Hashtable
            var valor = hastable["Alejandro"];
            Console.WriteLine(valor);
            Console.ReadLine();

            //* Cuántos elementos hay
            var cuantos = hastable.Count;
            Console.WriteLine(cuantos);
            Console.ReadLine();

            //* Buscar elementos
            if (hastable.ContainsKey("Alejandro"))
            {
                // código
            }
            if (hastable.ContainsValue(9.62))
            {
                // código
            }

            //* Eliminar elemento
            hastable.Remove("Alejandro");

            //* Limpiar Hashtable
            hastable.Clear();
        }
    }

    #endregion

    static void Main(string[] args)
    {
        Console.WriteLine("\n===================================");
        Console.WriteLine("Multiplicación sin *");
        Console.WriteLine("===================================\n");
        Console.WriteLine(multiplicacion(5, 2));

        int[] conjunto = [8, 59, 1, 3, 9, 10, 117];
        // Console.WriteLine(conjunto.Length);
        Console.WriteLine("\n===================================");
        Console.WriteLine("Numero mayor que sin LINQ");
        Console.WriteLine("===================================\n");
        Console.WriteLine("El número mayor del conjunto de números es: " + mayorque(conjunto));


        Console.WriteLine("\n===================================");
        Console.WriteLine("Paso por referencia o valor");
        Console.WriteLine("===================================\n");
        //* Cambiar el valor
        int number = 25;
        Console.WriteLine("El número original es: " + number);

        //* Paso por valor
        ChangeForValor(number);
        Console.WriteLine("El número ahora es (ChangeForValor): " + number);
        //* Paso por referencia
        ChangeForReference(ref number);
        Console.WriteLine("El número ahora es (ChangeForReference): " + number);

        //* Funciones locales
        // PrincipalFunction(number);
        // // LocalFunction(number);

        Console.WriteLine("\n===================================");
        Console.WriteLine("Tipo de List (object)");
        Console.WriteLine("===================================\n");
        List<int> lista = new List<int>();
        lista.Add(4);
        lista.Add(7);
        lista.Add(9);

        Console.WriteLine("La lista de números es la siguiente: ");
        foreach (int num in lista)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine("El tipo de dato es: " + GetTypeCode(lista));

        Cadenas();
        Colecciones();
        Console.ReadLine();


        Console.WriteLine("\n===================================");
        Console.WriteLine(" Estructura vs Clase ");
        Console.WriteLine("===================================\n");

        Console.Clear();
        Console.WriteLine("\nLa diferencia entre una estructura y una clase es la siguiente: ");
        Console.WriteLine("- Las estructuras son tipos por valor.");
        Console.WriteLine("- Las clases son tipos por referencia.");

        Console.ReadLine();

        Point punto = new Point();
        punto.X = 10;
        punto.Y = 8;

        PointStruct puntoStruct = new PointStruct();
        puntoStruct.X = 20;
        puntoStruct.Y = 7;

        Console.WriteLine("Coordenadas antes del método de suma.");
        Console.WriteLine($"Suma de coordenadas clase: X={punto.X} Y={punto.Y}");
        Console.WriteLine($"Suma de coordenadas struct: X={puntoStruct.X} Y={puntoStruct.Y}");

        SumaCoordenadasClase(punto);
        SumaCoordenadasEstructura(puntoStruct);

        Console.WriteLine("Coordenadas después del método de suma.");
        Console.WriteLine($"Suma de coordenadas clase: X={punto.X} Y={punto.Y}");
        Console.WriteLine($"Suma de coordenadas struct: X={puntoStruct.X} Y={puntoStruct.Y}");
        Console.ReadKey();

        Clase clase = new Clase();
        clase.Campo = 12;
        clase.Nombre = "Ian";
        clase.Apellidos = "López Serrano";
        // clase.Edad = 12;
        Console.WriteLine(clase.Edad);
        Console.ReadLine();

        Console.Clear();

    }

    public static void SumaCoordenadasClase(Point point)
    {
        point.X = point.X + 10;
        point.Y = point.Y + 10;
    }
    public static void SumaCoordenadasEstructura(PointStruct pointStruct)
    {
        pointStruct.X = pointStruct.X + 10;
        pointStruct.Y = pointStruct.Y + 10;
    }

}
