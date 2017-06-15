using System;
using System.Drawing;
using NAudio;
using NAudio.Wave;
using System.IO;

namespace ReproductorCutre{

    enum ESTADO {
        STOP, PLAY, PAUSE, RESUME
    }

    class PlayerControl{

        public static IWavePlayer waveOutDevice = null;
        public static AudioFileReader audioFileReader = null;

        public string rute { get; set;}
        public ESTADO estado { get; set;}

        public Image cover = null;

        public PlayerControl(string ruta) {
            this.rute = rute;
            if (waveOutDevice != null)
                waveOutDevice.Dispose();
            waveOutDevice = new WaveOutEvent();
        }

        public bool play() {
            if (waveOutDevice != null && estadoActual() == ESTADO.PAUSE) {
                waveOutDevice.Play();
                Console.WriteLine("Resume: " + rute);
                return true;
            }
            if (rute != null && rute != String.Empty) {
                //creacion del stream
                try {
                    audioFileReader = new AudioFileReader(rute);
                }catch{
                    Console.WriteLine("ERROR - Imposible abrir archivos, ¿Ruta incorrecta o formato no soportado?");
                    Console.WriteLine("ERROR... " + rute);
                    return false;
                }
                if (waveOutDevice != null) {
                    waveOutDevice.Init(audioFileReader);
                    waveOutDevice.Play();
                    Console.WriteLine("Play init: " + rute);
                    int indice = rute.LastIndexOf(System.IO.Path.DirectorySeparatorChar);
                    if(!PlayerListControl.isInit())
                        PlayerListControl.crear(rute.Substring(0, indice), rute.Substring(indice + 1));
                    TagLib.File file;
                    try{
                        file = TagLib.File.Create(rute);
                    }catch {
                        file = null;
                    }
                    if (file != null && file.Tag.Pictures.Length > 0){
                        MemoryStream ms = new MemoryStream(file.Tag.Pictures[0].Data.Data);
                        cover = Image.FromStream(ms);
                    }else
                        cover = null;
                    return true;
                }
            }
            Console.WriteLine("Play error: " + rute);
            return false;
        }

        public bool stop() {
            Console.WriteLine("Stop: " + rute);
            if (waveOutDevice != null)
                waveOutDevice.Stop();
            return true;
        }
    
        public bool pause() {
            Console.WriteLine("Pause: " + rute);
            if (waveOutDevice != null && waveOutDevice.PlaybackState == PlaybackState.Playing) {
                waveOutDevice.Pause();
            }
            return true;
        }

        public ESTADO estadoActual() {
            if (waveOutDevice == null)
                return ESTADO.STOP;
            switch (waveOutDevice.PlaybackState) {
                case PlaybackState.Playing:
                    return ESTADO.PLAY;
                case PlaybackState.Paused:
                    return ESTADO.PAUSE;
                default:
                    return ESTADO.STOP;
            }
        }

        public double longitudRaw() {
            if (waveOutDevice != null && audioFileReader != null){
                return audioFileReader.TotalTime.TotalSeconds;
            }
            return -1;
        }

        public double positionActualRaw(){
            if (waveOutDevice != null && audioFileReader != null){
                return audioFileReader.CurrentTime.TotalSeconds;
            }
            return -1;
        }

        public string getTitle(){
            TagLib.File file;
            try{
                file = TagLib.File.Create(rute);
            }catch{
                file = null;
            }
            if (file == null || file.Tag.Title == null || file.Tag.Title == String.Empty)
                return rute.Substring(rute.LastIndexOf(System.IO.Path.DirectorySeparatorChar)+1);
            return file.Tag.Title;
        }

        public string getRuteOnly() {
            char sep = System.IO.Path.DirectorySeparatorChar;
            int indi = rute.LastIndexOf(sep);
            return rute.Substring(0, indi + 1);
        }

        public void goToPosition(int second){
            if (audioFileReader != null) {
                TimeSpan time = new TimeSpan(0, 0, second);
                audioFileReader.CurrentTime = time;
            }
        }

        public void setVolumen(float volumen){
            if (audioFileReader != null){
                audioFileReader.Volume = volumen;
            }
        }

        public Image getCover(){
            return cover;
        }

        internal void freeResources(){
            if (waveOutDevice != null)
            {
                waveOutDevice.Stop();
            }
            if (audioFileReader != null)
            {
                audioFileReader.Dispose();
                audioFileReader = null;
            }
            if (waveOutDevice != null)
            {
                waveOutDevice.Dispose();
                waveOutDevice = null;
            }
        }
    }
}
