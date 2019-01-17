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
        public void Klik(string figuur)
        {
            Zoekoplossing zoekoplossing = new Zoekoplossing();
            int x = Int32.Parse(figuur);
          
            for (int i = 0 ; i <= 16; i++)
            { // print numbers from 1 to 5
                if (x == i)
                {
                    if (i < playground.card1.picturelist.Count())
                    {
                        zoekoplossing.Antwoord(playground.card1.picturelist[i]);
                    }
                    else
                    {
                        zoekoplossing.Antwoord(playground.card2.picturelist[i - playground.card1.picturelist.Count()]);
                    }
                }
                         
            }
       
 
            Score = Globals.aantal_juist.ToString() + "/" + Globals.aantal_pogingen.ToString() + " Score:" + Globals.Totaalscore;
       

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



      
        Playground playground = new Playground();

        Cards cards = new Cards();


         

        




        public ICommand VolgendeCommand { get; set; }



        public GameViewModel()
        {
            Score = "0/0 Score:0";
            Globals.TeScore = 1000;
            GetFigInfo();

        }
       
     

     
       



        public override void Init(object initData)
        {
           

            
         //   string t = figuren.fig1;
            base.Init(initData);

            


        }
        public void GetFigInfo()
        {
          
            Random rnd = new Random();

            int card1random = rnd.Next(0, cards.lijst.Count - 1);
            int card2random = rnd.Next(0, cards.lijst.Count - 1);


            //voor te voorkomen dat 2 keer dezelfde kaart verschijnt
            while (card1random == card2random)
            {
            
                card2random = rnd.Next(0, cards.lijst.Count - 1);
            }
 

            ////new
            playground.card1 = cards.lijst.ElementAt(card1random);
            playground.card2 = cards.lijst.ElementAt(card2random);

            var oplos = new Zoekoplossing();
            Globals.oplossing = oplos.Oplossing(playground.card1, playground.card2);
           
            string basis = Device.RuntimePlatform == Device.Android ? "a" : "Images/a";
           // string basis = "Images/a";
            string achtervoegsel = Device.RuntimePlatform == Device.Android ? ".png" : ".jpg";
           
            Globals.TeScoren = Convert.ToInt64(Globals.TeScore * 0.8);
            // nodig voor progressbar 
            Globals.TeScore = Globals.TeScoren;

         

            Figur1 = basis + playground.card1.picturelist[0] + achtervoegsel;
            Figur2 = basis + playground.card1.picturelist[1] + achtervoegsel;
            Figur3 = basis + playground.card1.picturelist[2] + achtervoegsel;
            Figur4 = basis + playground.card1.picturelist[3] + achtervoegsel;
            Figur5 = basis + playground.card1.picturelist[4] + achtervoegsel;
            Figur6 = basis + playground.card1.picturelist[5] + achtervoegsel;
            Figur7 = basis + playground.card1.picturelist[6] + achtervoegsel;
            Figur8 = basis + playground.card1.picturelist[7] + achtervoegsel;
            Figur9 = basis + playground.card2.picturelist[0] + achtervoegsel;
            Figur10 = basis + playground.card2.picturelist[1] + achtervoegsel;
            Figur11 = basis + playground.card2.picturelist[2] + achtervoegsel;
            Figur12 = basis + playground.card2.picturelist[3] + achtervoegsel;
            Figur13 = basis + playground.card2.picturelist[4] + achtervoegsel;
            Figur14 = basis + playground.card2.picturelist[5] + achtervoegsel;
            Figur15 = basis + playground.card2.picturelist[6] + achtervoegsel;
            Figur16 = basis + playground.card2.picturelist[7] + achtervoegsel;



            var bewaar = new Bestand();
         //   oplossing = basis + oplossing + achtervoegsel;
          //  Globals.oplossing = oplossing;
            string tijd = DateTime.Now.ToString();
          
        }
       
       
        
    }
}
