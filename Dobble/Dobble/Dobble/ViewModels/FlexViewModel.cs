using Dobble.Domain;
using Dobble.hulpclasse;
using FreshMvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Dobble.ViewModels
{
    class FlexViewModel : FreshBasePageModel, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        Playground playground = new Playground();
        public string oplossing;
        //lijst met vast aantal kaarten
        Cards cards = new Cards();
        #region databinding MvvM

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
        private string figur17;
        public string Figur17
        {
            set
            {
                if (figur17 != value)
                {
                    figur17 = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Figur17"));
                    }
                }
            }
            get
            {
                return figur17;
            }
        }
        private string figur18;
        public string Figur18
        {
            set
            {
                if (figur18 != value)
                {
                    figur18 = value;

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Figur18"));
                    }
                }
            }
            get
            {
                return figur18;
            }
        }
        private string _Score;
        public string Score
        {
            set
            {
                if (_Score != value)
                {
                    _Score = value;

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
        
        bool visible1;
        public bool Visible1
        {
            get
            {
                return visible1;
            }
            set
            {
                visible1 = value;
                RaisePropertyChanged("Visible1");
            }
        }
        bool visible2;
        public bool Visible2
        {
            get
            {
                return visible2;
            }
            set
            {
                visible2 = value;
                RaisePropertyChanged("Visible2");
            }
        }
        bool visible3;
        public bool Visible3
        {
            get
            {
                return visible3;
            }
            set
            {
                visible3 = value;
                RaisePropertyChanged("Visible3");
            }
        }
        bool visible4;
        public bool Visible4
        {
            get
            {
                return visible4;
            }
            set
            {
                visible4 = value;
                RaisePropertyChanged("Visible4");
            }
        }
        bool visible5;
        public bool Visible5
        {
            get
            {
                return visible5;
            }
            set
            {
                visible5 = value;
                RaisePropertyChanged("Visible5");
            }
        }
        bool visible6;
        public bool Visible6
        {
            get
            {
                return visible6;
            }
            set
            {
                visible6 = value;
                RaisePropertyChanged("Visible6");
            }
        }
        bool visible7;
        public bool Visible7
        {
            get
            {
                return visible7;
            }
            set
            {
                visible7 = value;
                RaisePropertyChanged("Visible7");
            }
        }
        bool visible8;
        public bool Visible8
        {
            get
            {
                return visible8;
            }
            set
            {
                visible8 = value;
                RaisePropertyChanged("Visible8");
            }
        }
        bool visible9;
        public bool Visible9
        {
            get
            {
                return visible9;
            }
            set
            {
                visible9 = value;
                RaisePropertyChanged("Visible9");
            }
        }
        bool visible10;
        public bool Visible10
        {
            get
            {
                return visible10;
            }
            set
            {
                visible10 = value;
                RaisePropertyChanged("Visible10");
            }
        }
        bool visible11;
        public bool Visible11
        {
            get
            {
                return visible11;
            }
            set
            {
                visible11 = value;
                RaisePropertyChanged("Visible11");
            }
        }
        bool visible12;
        public bool Visible12
        {
            get
            {
                return visible12;
            }
            set
            {
                visible12 = value;
                RaisePropertyChanged("Visible12");
            }
        }
        bool visible13;
        public bool Visible13
        {
            get
            {
                return visible13;
            }
            set
            {
                visible13 = value;
                RaisePropertyChanged("Visible13");
            }
        }
        bool visible14;
        public bool Visible14
        {
            get
            {
                return visible14;
            }
            set
            {
                visible14 = value;
                RaisePropertyChanged("Visible14");
            }
        }
        bool visible15;
        public bool Visible15
        {
            get
            {
                return visible15;
            }
            set
            {
                visible15 = value;
                RaisePropertyChanged("Visible15");
            }
        }
        bool visible16;
        public bool Visible16
        {
            get
            {
                return visible16;
            }
            set
            {
                visible16 = value;
                RaisePropertyChanged("Visible16");
            }
        }
        bool visible17;
        public bool Visible17
        {
            get
            {
                return visible17;
            }
            set
            {
                visible17= value;
                RaisePropertyChanged("Visible17");
            }
        }
        bool visible18;
        public bool Visible18
        {
            get
            {
                return visible18;
            }
            set
            {
                visible18 = value;
                RaisePropertyChanged("Visible18");
            }
        }
        #endregion


        #region als op een figuur geklikt wordt komt dit in werking
        public ICommand KlikCommand
        {
            get
            {
                return new Command<string>((x) => Klik(x));
            }
        }
        public void Klik(string figuur)
        {
            Zoekoplossing zoekoplossing = new Zoekoplossing();
            oplossing = zoekoplossing.Oplossing(playground);
            int x = Int32.Parse(figuur);

            for (int i = 0; i <= 20; i++)
            { 
                if (x == i)
                {
                    if (i < playground.Cards[0].picturelist.Count())
                    {
                        zoekoplossing.Antwoord(playground.Cards[0].picturelist[i], oplossing);
                    }
                    else
                    {
                        zoekoplossing.Antwoord(playground.Cards[1].picturelist[i - 9], oplossing);
                    }
                }

            }
            Score = Globals.aantal_juist.ToString() + "/" + Globals.aantal_pogingen.ToString() + " Score:" + Globals.Totaalscore;
            if (Globals.TeScoren < 0.01)
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
                string ScoreTekst = "";
                if (Globals.Username == "")
                {
                    ScoreTekst = Score;
                }
                else
                {
                    ScoreTekst = Globals.Username + " you did a nice game \n" + Score;
                }

                CoreMethods.DisplayAlert("Scores", ScoreTekst, "OK");
                CoreMethods.PopPageModel();

            }
            else
            {
                GetFigInfo();
            }

        }
        #endregion
        #region Gameviewmodel
        int aantalfiguren { get; set; }
        public FlexViewModel()
        {
            aantalfiguren = Globals.Level + 2;
            Score = "0/0 Score:0";
            
            GetFigInfo();

        }
        #endregion

        #region init
        public override void Init(object initData)
        {
            base.Init(initData);
        }
        #endregion
        #region Speelveld bepalen figuren toevoegen
      
        public void GetFigInfo()
        {

            //  playground.Cards = new List<Card> { cards.lijst.ElementAt(card1random), cards.lijst.ElementAt(card2random) };
            var makeplayground = new MakePlayGround();
            playground = makeplayground.MakePlayField(2, aantalfiguren);


            string basis = Device.RuntimePlatform == Device.Android ? "a" : "Images/a";
            // string basis = "Images/a";
            string achtervoegsel = Device.RuntimePlatform == Device.Android ? ".png" : ".jpg";

            
            Globals.TeScoren = Globals.TeScoren < 100 ? Globals.TeScoren : Convert.ToInt64(Globals.TeScore * 0.8);
            // nodig voor progressbar 
            Globals.TeScore = Globals.TeScoren;





            Figur1 = basis + playground.Cards[0].picturelist[0] + achtervoegsel;
            Visible1 = true;
            if (aantalfiguren > 1)
            {
                Figur2 = basis + playground.Cards[0].picturelist[1] + achtervoegsel;
                Visible2 = true;
            }
            
            if (aantalfiguren > 2)
            {
                Figur3 = basis + playground.Cards[0].picturelist[2] + achtervoegsel;
                Visible3 = true;
            }
            if (aantalfiguren > 3)
            {
                Figur4 = basis + playground.Cards[0].picturelist[3] + achtervoegsel;
                Visible4 = true;
            }
            if (aantalfiguren > 4)
            {
                Figur5 = basis + playground.Cards[0].picturelist[4] + achtervoegsel;
                Visible5 = true;
            }
            if (aantalfiguren > 5)
            {
                Figur6 = basis + playground.Cards[0].picturelist[5] + achtervoegsel;
                Visible6 = true;
            }
            if (aantalfiguren > 6)
            {
                Figur7 = basis + playground.Cards[0].picturelist[6] + achtervoegsel;
                Visible7 = true;
            }
            if (aantalfiguren > 7)
            {
                Figur8 = basis + playground.Cards[0].picturelist[7] + achtervoegsel;
                Visible8 = true;
            }
            if (aantalfiguren > 8)
            {
                Figur9 = basis + playground.Cards[0].picturelist[8] + achtervoegsel;
                Visible9 = true;
            }
            
            // Onderste kaart 

            Figur10 = basis + playground.Cards[1].picturelist[0] + achtervoegsel;
            Visible10 = true;
            if (aantalfiguren > 1)
            {
                Figur11 = basis + playground.Cards[1].picturelist[1] + achtervoegsel;
                Visible11 = true;
            }
            

            if (aantalfiguren > 2)
            {
                Figur12 = basis + playground.Cards[1].picturelist[2] + achtervoegsel;
                Visible12 = true;
            }
            if (aantalfiguren > 3)
            {
                Figur13 = basis + playground.Cards[1].picturelist[3] + achtervoegsel;
                Visible13 = true;
            }
            if (aantalfiguren > 4)
            {
                Figur14 = basis + playground.Cards[1].picturelist[4] + achtervoegsel;
                Visible14 = true;
            }
            if (aantalfiguren > 5)
            {
                Figur15 = basis + playground.Cards[1].picturelist[5] + achtervoegsel;
                Visible15 = true;
            }
            if (aantalfiguren > 6)
            {
                Figur16 = basis + playground.Cards[1].picturelist[6] + achtervoegsel;
                Visible16 = true;
            }
            if (aantalfiguren > 7)
            {
                Figur17 = basis + playground.Cards[1].picturelist[7] + achtervoegsel;
                Visible17 = true;
            }
            if (aantalfiguren > 8)
            {
                Figur18 = basis + playground.Cards[1].picturelist[8] + achtervoegsel;
                Visible18 = true;
            }
          

        }
        #endregion



    }
}


