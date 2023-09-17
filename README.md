# ArticPolar.Dev.TTS
Text to Speech using C# (NET Framework 4.7.1)

# Example
````
using ArticPolar.Dev.TTS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTSConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var tts = new TTS())
            {
                tts.SetVoice("Microsoft Maria Desktop - Portuguese (Brazil)");
                tts.SetRate(0); // Normal rate
                tts.SetVolume(100); // Max volume

                tts.Speak("Olá, este é um exemplo de conversão de texto em fala.");
                tts.Speak("Você pode controlar vários aspectos da síntese de fala com esta classe.");

                Console.WriteLine("Press Enter to exit...");
                Console.ReadLine();
            }
        }
    }
}

````
