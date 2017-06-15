using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReproductorCutre
{
    class Utiles{

        public static string parseDoubleToSeconds(double parse){
            int hour, min, sec;
            //Calculo del minutero
            min = (int)(parse / 60);
            sec = (int)(parse - min * 60);
            hour = min / 60;
            min = min - hour * 60;
            String shour, smin, ssec;
            if (sec < 10){
                ssec = "0" + sec;
            }else{
                ssec = sec.ToString();
            }
            if (min < 10){
                smin = "0" + min;
            }else{
                smin = min.ToString();
            }
            if (hour < 10){
                shour = "0" + hour;
            }else{
                shour = hour.ToString();
            }
            return shour + ":" + smin + ":" + ssec;
        }

        public static Image ScaleImage(Image image, int maxWidth, int maxHeight){
            var newImage = new Bitmap(maxWidth, maxHeight);
            using (var graphics = Graphics.FromImage(newImage))
                graphics.DrawImage(image, 0, 0, maxWidth, maxHeight);
            return newImage;
        }

        private static int checkFails = 0;

        public static bool chechkFormateValid(string rute, bool globalCheck = true) {
            Console.WriteLine("omprobando " + checkFails + " " + rute);
            //return true;
            if (globalCheck && checkFails > 6) {
                return true;
            }
            if (!checkExtension(rute)) {
                checkFails += 1;
                return false;
            }
            try {
                Console.WriteLine("P1");
                NAudio.Wave.AudioFileReader fil = new NAudio.Wave.AudioFileReader(rute);
                Console.WriteLine("P2");
                fil.Dispose();
                Console.WriteLine("P3");
                fil = null;
                Console.WriteLine("P4");
                if (globalCheck)
                    checkFails = 0;
                return true;
            } catch{
                Console.WriteLine("Se ha comprobado el archivo " + rute + " pero no tiene un formato valido.");
            }
            if (globalCheck)
                checkFails += 1;
            return false;
        }

        private static List<string> prohibited = null;

        public static bool checkExtension(string rute) {
            if (prohibited == null) {
                if (!File.Exists("ext.cfg")) {
                    StreamWriter writer = new StreamWriter("ext.cfg");
                    writer.WriteLine(".php");
                    writer.Dispose();
                    writer.Close();
                }
                StreamReader stream = new StreamReader("ext.cfg");
                string line;
                prohibited = new List<string>();
                while ((line = stream.ReadLine()) != null) {
                    prohibited.Add(line);
                }
                stream.Dispose();
                stream.Close();
            }
            FileSystemInfo info;
            try {
                info = new FileInfo(rute);
            } catch {
                return false;
            }
            foreach (string ext in prohibited) {
                if (ext.Equals(info.Extension))
                    return false;
            }
            return true;
        }
    }
}
