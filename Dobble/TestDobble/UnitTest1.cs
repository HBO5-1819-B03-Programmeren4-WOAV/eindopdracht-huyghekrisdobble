using Dobble.Domain;
using Dobble.hulpclasse;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace TestDobble
{
    public class UnitTest1
    {
        // test dat alle cards met elkander matchen
        [Fact]
        public void Matchen_Van_alle_cards()
        {
            var kaarten = new Cards();
            var oplos = new Zoekoplossing();
            bool actual = true;
            for (int a = 0; a < kaarten.lijst.Count; a++)
            {
                for (int i = 0; i < kaarten.lijst.Count; i++) //
                {
                    int kaartnr1 = a;
                    int kaartnr2 = i;
                    Playground playground = new Playground();

                    playground.Cards = new List<Card> { kaarten.lijst.ElementAt(a), kaarten.lijst.ElementAt(i) };

                    string oplossing = oplos.Oplossing(playground);


                    if (oplossing == "Fout")
                    {
                        actual = false;
                    }
                }
            }
            Assert.True(actual);
        }
        // schrijven en lezen van bestanden
        [Fact]
        public void Schrijven_Lezen()
        {
            string teststring = "kom dit erin /n komt het eruit";
            var bestand = new Bestand();
            string bestandsnaam = "test.txt";
              
            bestand.Save(teststring, bestandsnaam);
            string actual = bestand.ReadFile(bestandsnaam);

            Assert.Equal(teststring, actual);
        }

        // schrijven en bijschrijven en dan lezen
        [Fact]
        public void Schrijven_bijschrijven_lezen()
        {
            string teststring = "komt dat /n goed";
            string voegtoe = " ja dat komt goed";
            var bestand = new Bestand();
            string bestandsnaam = "bijschijven.txt";
            bestand.Save(teststring, bestandsnaam);
            bestand.Append (voegtoe, bestandsnaam);
            string actual = teststring + voegtoe;
            string uitput = bestand.ReadFile(bestandsnaam);
            Assert.Equal(uitput, actual);

        }
           
  
    }
}
