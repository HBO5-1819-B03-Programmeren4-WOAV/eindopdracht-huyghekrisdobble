using Dobble.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dobble.hulpclasse
{
    class MakePlayGround
    {
        public Playground MakePlayField(int cards, int figurs)
        {
            List<int> figuren = new List<int>();
            for (int i = 1; i <= 57; i++)
            {
                figuren.Add(i);
            }
            Playground playground = new Playground();
            playground.Cards = new List<Card> { };
            Random rnd = new Random();
            // een van de 57 figuurtjes
            int oplos = rnd.Next(0, figuren.Count());
            int oplossing = figuren[oplos];
            figuren.RemoveAt(oplos);
            while (cards > 0)
            {
                var lijst = new List<string>();
                lijst.Add(oplossing.ToString());
                for (int i = 0; i < figurs - 1; i++)
                {
                    int toevoeg = rnd.Next(0, figuren.Count());
                    int toevoegen = figuren[toevoeg];
                    lijst.Add(toevoegen.ToString());
                    figuren.RemoveAt(toevoeg);
                }
                // shuffel lijst
                var ShuffelLijst = new List<string>();
                while (lijst.Count != 0)
                {
                    var index = rnd.Next(0, lijst.Count);
                    ShuffelLijst.Add(lijst[index]);
                    lijst.RemoveAt(index);
                }


                Card card = new Card { picturelist = ShuffelLijst };
                playground.Cards.Add(card);


                cards--;
            }
            return playground;
        }
    }
}
