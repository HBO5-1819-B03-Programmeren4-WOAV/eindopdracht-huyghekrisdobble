using Dobble.Domain;
using Dobble.hulpclasse;
using FreshMvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Dobble.ViewModels
{
    public class GameViewModel : FreshBasePageModel, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        

        private string figur1;
        public string Figur1
        {
            set
            {
                if (figur1 != value)
                {
                    figur1 = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Figur1"));
                    }
                }
            }
            get
            {
                return figur1;
            }
        }
        private string figur2;
        public string Figur2
        {
            set
            {
                if (figur2 != value)
                {
                    figur2 = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Figur2"));
                    }
                }
            }
            get
            {
                return figur2;
            }
        }
        private string figur3;
        public string Figur3
        {
            set
            {
                if (figur3 != value)
                {
                    figur3 = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Figur3"));
                    }
                }
            }
            get
            {
                return figur3;
            }
        }
        private string figur4;
        public string Figur4
        {
            set
            {
                if (figur4 != value)
                {
                    figur4 = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Figur4"));
                    }
                }
            }
            get
            {
                return figur4;
            }
        }
        private string figur5;
        public string Figur5
        {
            set
            {
                if (figur5 != value)
                {
                    figur5 = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Figur5"));
                    }
                }
            }
            get
            {
                return figur5;
            }
        }
        private string figur6;
        public string Figur6
        {
            set
            {
                if (figur6 != value)
                {
                    figur6 = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Figur6"));
                    }
                }
            }
            get
            {
                return figur6;
            }
        }
        private string figur7;
        public string Figur7
        {
            set
            {
                if (figur7 != value)
                {
                    figur7 = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Figur7"));
                    }
                }
            }
            get
            {
                return figur7;
            }
        }
        private string figur8;
        public string Figur8
        {
            set
            {
                if (figur8 != value)
                {
                    figur8 = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Figur8"));
                    }
                }
            }
            get
            {
                return figur8;
            }
        }
        private string figur9;
        public string Figur9
        {
            set
            {
                if (figur9 != value)
                {
                    figur9 = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Figur9"));
                    }
                }
            }
            get
            {
                return figur9;
            }
        }
        private string figur10;
        public string Figur10
        {
            set
            {
                if (figur10 != value)
                {
                    figur10 = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Figur10"));
                    }
                }
            }
            get
            {
                return figur10;
            }
        }
        private string figur11;
        public string Figur11
        {
            set
            {
                if (figur11 != value)
                {
                    figur11 = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Figur11"));
                    }
                }
            }
            get
            {
                return figur11;
            }
        }
        private string figur12;
        public string Figur12
        {
            set
            {
                if (figur12 != value)
                {
                    figur12 = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Figur12"));
                    }
                }
            }
            get
            {
                return figur12;
            }
        }
        private string figur13;
        public string Figur13
        {
            set
            {
                if (figur13 != value)
                {
                    figur13 = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Figur13"));
                    }
                }
            }
            get
            {
                return figur13;
            }
        }
        private string figur14;
        public string Figur14
        {
            set
            {
                if (figur14 != value)
                {
                    figur14 = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Figur14"));
                    }
                }
            }
            get
            {
                return figur14;
            }
        }
        private string figur15;
        public string Figur15
        {
            set
            {
                if (figur15 != value)
                {
                    figur15 = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Figur15"));
                    }
                }
            }
            get
            {
                return figur15;
            }
        }
        private string figur16;
        public string Figur16
        {
            set
            {
                if (figur16 != value)
                {
                    figur16 = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Figur16"));
                    }
                }
            }
            get
            {
                return figur16;
            }
        }
        private string _Score;
        public string Score
        {
            set
            {
                if (_Score != value)
                {
                    _Score= value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Score"));
                    }
                }
            }
            get
            {
                return _Score;
            }
        }
        
        public ICommand KlikCommand
        {
            get
            {
                return new Command<string>((x) => Klik(x));
            }
        }
        public void Klik(string x)
        {
            if (x == "1") { string antwoord = new Zoekoplossing().Antwoord(figuren.fig1); }
            if (x == "2") { string antwoord = new Zoekoplossing().Antwoord(figuren.fig2); }
            if (x == "3") { string antwoord = new Zoekoplossing().Antwoord(figuren.fig3); }
            if (x == "4") { string antwoord = new Zoekoplossing().Antwoord(figuren.fig4); }
            if (x == "5") { string antwoord = new Zoekoplossing().Antwoord(figuren.fig5); }
            if (x == "6") { string antwoord = new Zoekoplossing().Antwoord(figuren.fig6); }
            if (x == "7") { string antwoord = new Zoekoplossing().Antwoord(figuren.fig7); }
            if (x == "8") { string antwoord = new Zoekoplossing().Antwoord(figuren.fig8); }
            if (x == "9") { string antwoord = new Zoekoplossing().Antwoord(figuren.fig9); }
            if (x == "10") { string antwoord = new Zoekoplossing().Antwoord(figuren.fig10); }
            if (x == "11") { string antwoord = new Zoekoplossing().Antwoord(figuren.fig11); }
            if (x == "12") { string antwoord = new Zoekoplossing().Antwoord(figuren.fig12); }
            if (x == "13") { string antwoord = new Zoekoplossing().Antwoord(figuren.fig13); }
            if (x == "14") { string antwoord = new Zoekoplossing().Antwoord(figuren.fig14); }
            if (x == "15") { string antwoord = new Zoekoplossing().Antwoord(figuren.fig15); }
            if (x == "16") { string antwoord = new Zoekoplossing().Antwoord(figuren.fig16); }
            //handle parameter x to say "Hello " + x
            Score = "Juist:" + Globals.aantal_juist.ToString() + "/" + Globals.aantal_pogingen.ToString() + " Totaal score:" + Globals.Totaalscore;
            if (Globals.TeScoren < 1)
            {
                var bestand = new Bestand();
                int m = 0;
                try
                {
                    m = Int32.Parse(bestand.ReadFile("maxScore.txt"));
                }
                catch (FormatException e)
                {

                }
                if (m < Globals.Totaalscore)
                { 
                    bestand.Save(Globals.Totaalscore.ToString(), "maxScore.txt");
                    Globals.MaxScore = Globals.Totaalscore;
                }

                CoreMethods.DisplayAlert("Scorebord",Score , "OK");
               CoreMethods.PopPageModel();
            
            }
            else
            {
                figuren = GetFigInfo();
            }
            
            
        }



      
        Playground playground = new Playground();

        Cards cards = new Cards();

        // Figuren figuren = new Figuren();

        public Figuren figuren { set; get; }
         

        




        public ICommand VolgendeCommand { get; set; }



        public GameViewModel()
        {
            Score = "Totaal Score:0";
            figuren = GetFigInfo();

        }
       
     

     
       



        public override void Init(object initData)
        {
           

            
         //   string t = figuren.fig1;
            base.Init(initData);

            


        }
        public Figuren GetFigInfo()
        {
          
            Random rnd = new Random();
            int card1random = rnd.Next(0, cards.list.Count - 1);
            int card2random = rnd.Next(0, cards.list.Count - 1);
            //voor te voorkomen dat 2 keer dezelfde kaart verschijnt
            while (card1random == card2random)
            {
                card2random = rnd.Next(0, cards.list.Count - 1);
            }
            playground.card2 = cards.list.ElementAt(card1random);
            playground.card1 = cards.list.ElementAt(card2random);
            var oplos = new Zoekoplossing();
            string oplossing = oplos.Oplossing(playground.card1, playground.card2);
           
            string basis = Device.RuntimePlatform == Device.Android ? "a" : "Images/a";
           // string basis = "Images/a";
            string achtervoegsel = Device.RuntimePlatform == Device.Android ? ".png" : ".jpg";
            Figuren info = new Figuren
            {
                fig1 = basis + playground.card1.picture1 + achtervoegsel,
                fig2 = basis + playground.card1.picture2 + achtervoegsel,
                fig3 = basis + playground.card1.picture3 + achtervoegsel,
                fig4 = basis + playground.card1.picture4 + achtervoegsel,
                fig5 = basis + playground.card1.picture5 + achtervoegsel,
                fig6 = basis + playground.card1.picture6 + achtervoegsel,
                fig7 = basis + playground.card1.picture7 + achtervoegsel,
                fig8 = basis + playground.card1.picture8 + achtervoegsel,
                fig9 = basis + playground.card2.picture1 + achtervoegsel,
                fig10 = basis + playground.card2.picture2 + achtervoegsel,
                fig11 = basis + playground.card2.picture3 + achtervoegsel,
                fig12 = basis + playground.card2.picture4 + achtervoegsel,
                fig13 = basis + playground.card2.picture5 + achtervoegsel,
                fig14 = basis + playground.card2.picture6 + achtervoegsel,
                fig15 = basis + playground.card2.picture7 + achtervoegsel,
                fig16 = basis + playground.card2.picture8 + achtervoegsel,
                oplossing = basis + oplossing + achtervoegsel,
                grote = 60,
               
            };
            
            Globals.TeScoren = 3000 - (100 * Globals.aantal_pogingen) ;
      
            Figur1 = basis + playground.card1.picture1 + achtervoegsel;
            Figur2 = basis + playground.card1.picture2 + achtervoegsel;
            Figur3 = basis + playground.card1.picture3 + achtervoegsel;
            Figur4 = basis + playground.card1.picture4 + achtervoegsel;
            Figur5 = basis + playground.card1.picture5 + achtervoegsel;
            Figur6 = basis + playground.card1.picture6 + achtervoegsel;
            Figur7 = basis + playground.card1.picture7 + achtervoegsel;
            Figur8 = basis + playground.card1.picture8 + achtervoegsel;
            Figur9 = basis + playground.card2.picture1 + achtervoegsel;
            Figur10 = basis + playground.card2.picture2 + achtervoegsel;
            Figur11 = basis + playground.card2.picture3 + achtervoegsel;
            Figur12 = basis + playground.card2.picture4 + achtervoegsel;
            Figur13 = basis + playground.card2.picture5 + achtervoegsel;
            Figur14 = basis + playground.card2.picture6 + achtervoegsel;
            Figur15 = basis + playground.card2.picture7 + achtervoegsel;
            Figur16 = basis + playground.card2.picture8 + achtervoegsel;
            var bewaar = new Bestand();
            oplossing = basis + oplossing + achtervoegsel;
            Globals.oplossing = oplossing;
            string tijd = DateTime.Now.ToString();
            bewaar.Save(tijd, "tijd.txt");
            return info;
        }
       
       
        
    }
}
