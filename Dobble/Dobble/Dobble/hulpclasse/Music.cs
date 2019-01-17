using System.IO;
using System.Reflection;


namespace Dobble.hulpclasse
{
    //muziekclasse muziek afspelen
    public class Music
    {
        public void play(string muziekbestand)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;
            Stream audioStream = assembly.GetManifestResourceStream("Dobble.Music." + muziekbestand);
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            // als er nog een muziekje aan het spelen is gaat het niets afspelen
            try
            {
                player.Load(audioStream);
                player.Play();
            }
            catch
            {

            }
        }
        
    }
}
