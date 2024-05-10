using EjercicioClase1Modulo2.Ejercicio_1;
using EjercicioClase1Modulo2.Ejercicio_2;
using EjercicioClase1Modulo2.Ejercicio_3;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace EjercicioClase1Modulo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio clase 1 modulo 2");
            // Consigna:
            // En la ruta principal del proyecto hay 3 archivos json, para cada uno de ellos crear las clases que consideren necesarias para poder deserializar correctamente
            // Uso: JsonSerializer.Deserialize<ClaseCreada>(data);

            var pathEjercicio1 = $"{AppDomain.CurrentDomain.BaseDirectory}/Ejercicio1.json";
            var pathEjercicio2 = $"{AppDomain.CurrentDomain.BaseDirectory}/Ejercicio2.json";
            var pathEjercicio3 = $"{AppDomain.CurrentDomain.BaseDirectory}/Ejercicio3.json";

            var dataEjercicio1 = File.ReadAllText(pathEjercicio1);
            var dataEjercicio2 = File.ReadAllText(pathEjercicio2);
            var dataEjercicio3 = File.ReadAllText(pathEjercicio3);

            #region Ejercicio1

            Console.WriteLine("\n\n Ejercicio 1 ");
            Console.WriteLine("--------------------------\n");

            var usuario1 = JsonSerializer.Deserialize<Usuario>(dataEjercicio1);

            var retornarusuario1 = JsonSerializer.Serialize(usuario1);

            Console.WriteLine(retornarusuario1);

            #endregion

            #region Ejercicio2

            Console.WriteLine("\n\n Ejercicio 2 ");
            Console.WriteLine("--------------------------\n");

            var juego1 = JsonSerializer.Deserialize<Juego>(dataEjercicio2);

            var retornarjuego1 = JsonSerializer.Serialize(juego1);

            Console.WriteLine(retornarjuego1);


            #endregion


            #region Ejercicio3

            Console.WriteLine("\n\n Ejercicio 3 ");
            Console.WriteLine("--------------------------\n");

            var listProd1 = JsonSerializer.Deserialize<ListadoProductos>(dataEjercicio3);

            var retornarListProd = JsonSerializer.Serialize(listProd1);

            Console.WriteLine(retornarListProd);

            #endregion

            Console.WriteLine("\n\n\n");


        }
    }
}