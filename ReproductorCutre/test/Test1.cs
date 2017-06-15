using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReproductorCutre.test
{
    class Test1{/*
        public static void prueba() {
            // init BASS using the default output device 
            if (Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero))
            {
                // create a stream channel from a file 
                //int stream = Bass.BASS_StreamCreateFile("D:\\Anime 2.0\\01 - Kakushinteki Metamaruphose!.flac", 0, 0, BASSFlag.BASS_DEFAULT);
                int stream = Bass.BASS_StreamCreateFile("D:\\Anime 2.0\\mm\\Pokemon   All End Credit Themes.mp4", 0, 0, BASSFlag.BASS_DEFAULT);
                if (stream != 0)
                {
                    // play the stream channel 
                    Bass.BASS_ChannelPlay(stream, false);
                    TAG_INFO tagInfo = BassTags.BASS_TAG_GetFromFile("D:\\Anime 2.0\\01 - Kakushinteki Metamaruphose!.flac");
                    if (tagInfo != null)
                    {
                        // display the tags... 
                        Console.WriteLine(tagInfo.artist);
                        Console.WriteLine(tagInfo.title);
                    }
                }
                else
                {
                    // error creating the stream 
                    Console.WriteLine("Stream error: {0}", Bass.BASS_ErrorGetCode());
                }

                // wait for a key 
                Console.WriteLine("Press any key to exit");
                Console.ReadKey(false);

                // free the stream 
                Bass.BASS_StreamFree(stream);
                // free BASS 
                Bass.BASS_Free();
            }
        }*/
    }
}
