using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReproductorCutre
{
    class PlayerListControl{
        private static int actual;
        private static int tamDir = -1;
        private static List<string> ficheros;
        private static String directorio;
        private static Random randoni;
        private static HashSet<int> usados;
        private static bool firstInit = false;

        public static bool isInit() {
            return firstInit;
        }

        public static void crear(String ruta, String nombre)
        {
            int vervose = -1;
            List<string> aux = new List<string>();
            if (Directory.Exists(ruta)){
                directorio = ruta;
                foreach (string fichero in Directory.GetFiles(ruta)){
                    if (Directory.Exists(fichero) || !Utiles.chechkFormateValid(fichero, false)){
                        continue;
                    }
                    vervose = vervose + 1;
                    if (fichero.Substring(fichero.LastIndexOf(System.IO.Path.DirectorySeparatorChar) + 1).Equals(nombre)){
                        actual = vervose;
                    }
                    aux.Add(fichero);
                }
                tamDir = Directory.GetFiles(ruta).Length;
                Console.WriteLine(aux);
                ficheros = aux;
                randoni = new Random();
                usados = new HashSet<int>();
                if (nombre == null){
                    actual = randoni.Next();
                }
                Console.WriteLine(vervose);
                firstInit = true;
            }
            else{
                Console.WriteLine("FALLO: desactivado directorios");
            }
        }

        public static String siguiente()
        {
            refrescar(false);
            int siguiente = actual + 1;
            if (siguiente >= ficheros.Count){
                siguiente = 0;
            }
            actual = siguiente;
            string rut = ficheros[siguiente];
            if (Utiles.chechkFormateValid(rut))
                return rut;
            else
                return PlayerListControl.siguiente();
        }

        public static String anterior()
        {
            refrescar(false);
            int siguiente = actual - 1;
            if (siguiente < 0)
            {
                siguiente = ficheros.Count - 1;
            }
            actual = siguiente;
            string rut = ficheros[siguiente];
            if (Utiles.chechkFormateValid(rut))
                return rut;
            else
                return anterior();
        }

        public static String aleatorio()
        {
            refrescar(false);
            int ran = actual;
            Console.WriteLine("CMP: " + usados.Count + ":" + ficheros.Count);
            if (usados.Count >= ficheros.Count){
                usados.Clear();
                Console.WriteLine("CLEAR: " + usados.Count + ":" + ficheros.Count);
            }
            while (ran == actual || usados.Contains(ran)){
                ran = randoni.Next(ficheros.Count);
            }
            usados.Add(ran);
            actual = ran;
            Console.WriteLine(usados);
            string rut = ficheros[ran];
            if (Utiles.chechkFormateValid(rut))
                return rut;
            else
                return aleatorio();
        }

        public static String getDirectorioActual()
        {
            return directorio;
        }

        public static void refrescar(bool forzar)
        {
            int directori = Directory.GetFiles(directorio).Length;
            Console.WriteLine("CMP: " + tamDir + ":" + directori);
            if (forzar || directori != tamDir){
                crear(directorio, ficheros[actual].Substring(ficheros[actual].LastIndexOf(System.IO.Path.DirectorySeparatorChar) + 1));
            }
        }

        public static String cadenaInfo()
        {
            String res;
            int mal = 28;
            int oxi = actual - 1;
            if (oxi < 0)
            {
                oxi = ficheros.Count - 1;
            }
            String aux = ficheros[oxi].Substring(ficheros[oxi].LastIndexOf(System.IO.Path.DirectorySeparatorChar) + 1);
            if (aux.Length < 29)
            {
                mal = aux.Length;
                res = aux.Substring(0, mal) + "    || ";
            }
            else
            {
                res = aux.Substring(0, mal) + "... || ";
            }
            oxi = actual + 1;
            if (oxi >= ficheros.Count)
            {
                oxi = 0;
            }
            aux = ficheros[oxi].Substring(ficheros[oxi].LastIndexOf(System.IO.Path.DirectorySeparatorChar) + 1);
            if (aux.Length < 29)
            {
                mal = aux.Length;
                res = res + aux.Substring(0, mal);
            }
            else
            {
                mal = 29;
                aux = ficheros[oxi].Substring(ficheros[oxi].LastIndexOf(System.IO.Path.DirectorySeparatorChar) + 1);
                res = res + aux.Substring(0, mal) + "...";
            }
            return res;
        }
    }
}
