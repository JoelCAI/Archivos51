using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos51
{
    public class Validador
    {
        public static string ValidarStringNoVacio(string mensaje)
        {

            string opcion;
            bool valido = false;
            string mensajeValidador = "\n Ejemplo: archivo.txt o ArChivo.txt";
            string mensajeError = "\n Por favor ingrese un valor no vacio, respetando las minúsculas y mayúsculas.";

            do
            {

                Console.WriteLine(mensaje);
                Console.WriteLine(mensajeValidador);

                opcion = Console.ReadLine();

                if (opcion == "")
                {
                    Console.Clear();
                    Console.WriteLine("\n");
                    Console.WriteLine(mensajeError);
                }
                else
                {
                    valido = true;
                }

            } while (!valido);

            return opcion;
        }

        public static void ValidarPath(string str1)
        {


            bool comparacion = File.Exists(str1);

            if (comparacion == true)
            {
                TextReader leerArchivo;
                leerArchivo = new StreamReader(str1);
                Console.WriteLine("\n Usted guardo el archivo " + "\n *" + leerArchivo.ReadToEnd() + "*");

                leerArchivo.Close();
            }
            else
            {

                Console.WriteLine("\n La cadena" + " *" + str1 + "*" + " NO corresponde a un archivo" + "*");
            }
        }
        public static void Bienvenida()
        {
            Console.WriteLine("\n Bienvenido al Programa");
            Console.WriteLine("\n Usted podrá crear un Archivo y verlo en Pantalla. Presione cualquier tecla para continuar.");
            Console.ReadKey();
        }

        public static void Despedida()
        {

            Console.WriteLine("\n Gracias por usar nuestro Sistema presione cualquier teclar para finalizar");
            Console.ReadKey();
        }
    }
}