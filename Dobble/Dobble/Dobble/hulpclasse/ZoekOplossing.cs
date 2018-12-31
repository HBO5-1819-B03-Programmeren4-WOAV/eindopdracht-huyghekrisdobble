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
            

            List<string> list1 = new List<string>();
            list1.Add(kaart1.picture1);
            list1.Add(kaart1.picture2);
            list1.Add(kaart1.picture3);
            list1.Add(kaart1.picture4);
            list1.Add(kaart1.picture5);
            list1.Add(kaart1.picture6);
            list1.Add(kaart1.picture7);
            list1.Add(kaart1.picture8);

            List<string> list2 = new List<string>();
            list2.Add(kaart2.picture1);
            list2.Add(kaart2.picture2);
            list2.Add(kaart2.picture3);
            list2.Add(kaart2.picture4);
            list2.Add(kaart2.picture5);
            list2.Add(kaart2.picture6);
            list2.Add(kaart2.picture7);
            list2.Add(kaart2.picture8);

            for (int i = 0; i <= 7; i++)
            {
                string k1 = list1[i];
                for (int a = 0; a <= 7; a++)
                {
                    if (k1 == list2[a])
                    {
                        oplossing = list2[a];
                        
                    }
                }
            }
           
            return oplossing;
        }
        public string  Antwoord(String beeld)
        {
            //  string beeld = image.Source.ToString().Substring(6);

            var bestand = new Bestand();
            //string oplossing = bestand.ReadFile("oplossing.txt");
            string oplossing = Globals.oplossing;

            string tijd = bestand.ReadFile("tijd.txt");
            DateTime begintijd = Convert.ToDateTime(tijd);
          
            TimeSpan span = (DateTime.Now - begintijd);
            string antwoord = "Fout";
            var muziek = new Music();
            Globals.aantal_pogingen++;

            // Zend via signalR info naar iedereen maar enkel de webapplicatie leest de info,
            SentPlayInfo sentPlayInfo = new SentPlayInfo();
            sentPlayInfo.PlayInfo();
            if (oplossing == beeld)
            {
                //  antwoord = "Juist \nBinnen de tijd van \n" + span.ToString() ;
                muziek.play("Correct.mp3");
                Globals.aantal_juist++;
                Globals.Totaalscore += Globals.TeScoren;
            }
            else
            {
                muziek.play("Wrong.mp3");
                try
                {
                    // Use default vibration length
                    Vibration.Vibrate();

                    // Or use specified time
                    var duration = TimeSpan.FromSeconds(1);
                    Vibration.Vibrate(duration);
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
            
            return antwoord;
        }
    }
}
