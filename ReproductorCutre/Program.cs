using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReproductorCutre
{
    static class Program
    {
        public static string AssemblyDirectory
        {
            get
            {
                string codeBase = Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(){
            string[] args = Environment.GetCommandLineArgs();
            /*foreach (string s in args) {
                Console.WriteLine("Argumento: " + s);
            }*/
            string argumento = null;
            if(args.Length > 1){
                argumento = args[1];
            }
            Propiedades.cargar();
            //test.Test1.prueba();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Player(argumento));

        }
    }
}
