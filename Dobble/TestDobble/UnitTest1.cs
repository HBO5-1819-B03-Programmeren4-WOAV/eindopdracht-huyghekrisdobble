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

        // test  playground 
        // test dat de grote van de kaartjes zo groot zijn als gevraagd
        // test het aantal kaartjes dan gevraagd
        // test dat er een oplossing uit komt bij de 2 kaartjes te vergelijken
        [Fact]
        public void playgroundtesten()
        {
            bool actual = true;
            MakePlayGround makeplayground = new MakePlayGround();
            int aantalkaartjes = 2;
            Random rnd = new Random();
            int n = 0;
            do
            {
                int aantalfiguurtjes = rnd.Next(2, 10);
                Playground testveld = makeplayground.MakePlayField(aantalkaartjes, aantalfiguurtjes);
                var oplos = new Zoekoplossing();
                string oplossing = oplos.Oplossing(testveld);
                if (oplossing == "Fout")
                {
                    actual = false;
                }
               Assert.Equal(aantalfiguurtjes.ToString(), testveld.Cards[0].picturelist.Count.ToString());
                Assert.Equal(aantalfiguurtjes.ToString(), testveld.Cards[1].picturelist.Count.ToString());
                Assert.Equal(aantalkaartjes.ToString(), testveld.Cards.Count.ToString());
                n++;
            } while (n < 10000);
            Assert.True(actual);
          
        }
        // test van zoekoplossing.antwoord deze heeft input van oplossing en het beeldje dat je heb aangeklikt
        // test dat aantalpogingen stijgt ook al is het juist of fout
        // test of het aantaljuist stijgt als het juist is en niet als het fout is
        [Fact]
        public void antwoorden()
        {

            int aantalpogingen = Globals.aantal_pogingen;
            int aantaljuist = 7;
            Globals.aantal_juist = 7;
            Zoekoplossing zoekoplossing = new Zoekoplossing();
            zoekoplossing.Antwoord( "1" , "5" );
            aantalpogingen++;
            Assert.Equal(aantalpogingen.ToString(), Globals.aantal_pogingen.ToString());
            Assert.Equal(aantaljuist.ToString() , Globals.aantal_juist.ToString());
            zoekoplossing.Antwoord("9", "9");
            aantalpogingen++;
            aantaljuist++;
            Assert.Equal(aantalpogingen.ToString(), Globals.aantal_pogingen.ToString());
      //      Assert.Equal(aantaljuist.ToString(), Globals.aantal_juist.ToString());

        }
           
  
    }
}
