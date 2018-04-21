using System;
using System.Globalization;
using System.Speech.Synthesis;

namespace Text2Speech
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the Language that is being used in the computer
            CultureInfo ci = CultureInfo.InstalledUICulture;

            Console.WriteLine("Default Language Info:");
            Console.WriteLine("* Name: {0}", ci.Name);
            
            // Initialize a new instance of the SpeechSynthesizer.
            SpeechSynthesizer synth = new SpeechSynthesizer();

            // Configure the audio output. 
            synth.SetOutputToDefaultAudioDevice();

            var text = "";
            // Speak a string.
            if (ci.Name.Equals("pt-BR"))
            {
                synth.Speak("Este exemplo demosntra um uso básico sobre o Sintetizador de fala");
                synth.Speak("Gostaria que eu falasse algo para você? Por favor, responda com S ou N no console");
                Console.WriteLine("Aguardando sua resposta...");
                text = Console.ReadLine();
            }
            else
            {
                synth.Speak("This example demonstrates a basic use of Speech Synthesizer");
                synth.Speak("Would you like me to say something to you? Please respond with Y or N in the cosole");
                Console.WriteLine("Waiting for your Awnser...");
                text = Console.ReadLine();
            }
            
            if (text.ToLower().Equals("s") || text.ToLower().Equals("y")) {
                if (ci.Name.Equals("pt-BR"))
                {
                    Console.WriteLine("O que gostaria que eu falasse?");
                    synth.Speak("O que gostaria que eu falasse?");
                    text = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("What woud you like for me to say?");
                    synth.Speak("What woud you like for me to say?");
                    text = Console.ReadLine();
                }

                synth.Speak(text);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
