using Dobble.Domain;
using System;
using System.Collections.Generic;
using Xamarin.Essentials;


namespace Dobble.hulpclasse
{
    //zoekt de oplossing bij een speelveld van 2 kaartjes 
    public class Zoekoplossing 
    {
        // om oplossing te bepalen
        #region Oplossing resultaat is het figuur dat matched
        public string Oplossing(Playground playground)
        {
            string oplossing = "Fout";
            List<string> list1 = playground.Cards[0].picturelist;
            List<string> list2 = playground.Cards[1].picturelist;


            for (int i = 0; i < playground.Cards[0].picturelist.Count; i++)
            {
                string k1 = list1[i];
                for (int a = 0; a < playground.Cards[1].picturelist.Count; a++)
                {
                    if (k1 == list2[a])
                    {
                        oplossing = list2[a];
                        
                    }
                }
            }
           
            return oplossing;
        }
        #endregion
        #region Antwoord beoordeeld het antwoord en vergelijkt het met de oplossing 
        public async void   Antwoord(String beeld, string oplossing)
        {
            //  string beeld = image.Source.ToString().Substring(6);

            var bestand = new Bestand();
            //string oplossing = bestand.ReadFile("oplossing.txt");
           // string oplossing = Globals.oplossing;

   
            
            var muziek = new Music();
            Globals.aantal_pogingen++;

            // Zend via signalR info naar iedereen maar enkel de webapplicatie leest de info,
            SentPlayInfo sentPlayInfo = new SentPlayInfo();
       
            // door deze await werkt de unittest niet voor aantal++
            await sentPlayInfo.PlayInfo();
            if (oplossing == beeld)
            {
                //  antwoord = "Juist \nBinnen de tijd van \n" + span.ToString() ;
                if (Globals.Sound == true)
                {
                    muziek.play("Correct.mp3");
                }
                
                Globals.aantal_juist++;
                Globals.Totaalscore += Globals.TeScoren;
            }
            else
            {
                if (Globals.Sound == true)
                {
                    muziek.play("Wrong.mp3");
                }
                
                try
                {
                    // Use default vibration length
                    if (Globals.Vibrate == true)
                    {
                        var duration = TimeSpan.FromSeconds(1);
                        Vibration.Vibrate(duration);
                        
                    }

                    

                    // Or use specified time
                    
                }
                catch (FeatureNotSupportedException ex)
                {
                    // Feature not supported on device
                }
                catch (Exception ex)
                {
                    // Other error has occurred.
                }
            }
            
          
        }
        #endregion
    }
}
