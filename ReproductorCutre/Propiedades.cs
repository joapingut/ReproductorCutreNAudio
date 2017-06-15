using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReproductorCutre
{
    class Propiedades
    {
        private static Propios.Properties propiedades = null;
        public static String rutaPorDefecto = "";
        public static int dimensionCaratula = 2;
        public static bool autoPlay = false;
        public static bool autoAvance = false;
        public static bool autoAleatorio = false;

        public static void cargar(){
            propiedades = new Propios.Properties(Program.AssemblyDirectory + System.IO.Path.DirectorySeparatorChar + "config.cfg");
            propiedades.load();
            rutaPorDefecto = propiedades.readString("defaultRoute", rutaPorDefecto);
            dimensionCaratula = int.Parse(propiedades.readString("dimension", dimensionCaratula.ToString()));
            autoPlay = bool.Parse(propiedades.readString("autoPlay", autoPlay.ToString()));
            autoAvance = bool.Parse(propiedades.readString("autoAvance", autoAvance.ToString()));
            autoAleatorio = bool.Parse(propiedades.readString("autoAleatorio", autoAleatorio.ToString()));
        }

        public static void salvar() {
            propiedades.putString("defaultRoute", rutaPorDefecto);
            propiedades.putString("dimension", dimensionCaratula.ToString());
            propiedades.putString("autoPlay", autoPlay.ToString());
            propiedades.putString("autoAvance", autoAvance.ToString());
            propiedades.putString("autoAleatorio", autoAleatorio.ToString());
            propiedades.save();
        }

        public static void defaults() {
            rutaPorDefecto = "";
            dimensionCaratula = 2;
            autoPlay = false;
            autoAvance = false;
            autoAleatorio = false;
        }
    }
}
