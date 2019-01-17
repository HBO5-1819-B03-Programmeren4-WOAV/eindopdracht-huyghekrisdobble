using Dobble.Domain;
using Dobble.ViewModels;
using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Dobble.hulpclasse
{
    public class Zoekoplossing 
    {
        public string Oplossing(Card kaart1, Card kaart2)
        {
            string oplossing = "Fout";
            List<string> list1 = kaart1.picturelist;
            List<string> list2 = kaart2.picturelist;


            for (int i = 0; i < kaart1.picturelist.Count; i++)
            {
                string k1 = list1[i];
                for (int a = 0; a < kaart2.picturelist.Count; a++)
                {
                    if (k1 == list2[a])
                    {
                        oplossing = list2[a];
                        
                    }
                }
            }
           
            return oplossing;
        }
        public void  Antwoord(String beeld)
        {
            //  string beeld = image.Source.ToString().Substring(6);

            var bestand = new Bestand();
            //string oplossing = bestand.ReadFile("oplossing.txt");
            string oplossing = Globals.oplossing;

            string tijd = bestand.ReadFile("tijd.txt");
            DateTime begintijd = Convert.ToDateTime(tijd);
          
            TimeSpan span = (DateTime.Now - begintijd);
            
            var muziek = new Music();
            Globals.aantal_pogingen++;

            // Zend via signalR info naar iedereen maar enkel de webapplicatie leest de info,
            SentPlayInfo sentPlayInfo = new SentPlayInfo();
            sentPlayInfo.PlayInfo();
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
    }
}
