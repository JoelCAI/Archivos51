using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivos51 
{
    public class Sistema
    {
        public void MenuPrincipal()
        {
            Validador.Bienvenida();

            Console.Clear();
            /* Creo variable de tipo Archivo */
            TextWriter archivo;

            string ruta = "Holamundo.txt";

            /* La inicializo y la instancio. Digo que se va a llamar en la pc un archivo con este nombre "HolaMundo.txt" */
            archivo = new StreamWriter(ruta);

            string mensaje = Validador.ValidarStringNoVacio("\n Ingrese el texto que será guardado");

            archivo.WriteLine(mensaje);

            archivo.Close();

            StreamWriter archivoDos = File.AppendText("Holamundo.txt");

            List<string> lista = new List<string>();
            ConsoleKeyInfo cki;

            string mensajeDos;
            do
            {
                Console.Clear();
                mensajeDos = Validador.ValidarStringNoVacio("\n Ingrese una cadena que se agregará al archivo");

                lista.Add(mensajeDos);
                archivoDos.WriteLine(mensajeDos);

                Console.WriteLine("\n Presione la tecla " + "*" + "End" + "*" + " si desea salir.");
                Console.WriteLine("\n Si presiona otra tecla continuará agregando cadenas al archivo");
                cki = Console.ReadKey();
                

            } while (cki.Key != ConsoleKey.End);

                        
            archivoDos.Close();

            TextReader leerArchivo;
            leerArchivo = new StreamReader(ruta);
            Console.WriteLine("\n Usted guardo el archivo " + "\n *" + leerArchivo.ReadToEnd() + "*");

            Validador.Despedida();



        }

        public void Iniciar()
        {
            MenuPrincipal();
        }
    }
}