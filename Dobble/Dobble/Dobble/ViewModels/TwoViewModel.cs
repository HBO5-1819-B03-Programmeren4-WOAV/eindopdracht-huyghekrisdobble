using Dobble.Domain;
using Dobble.hulpclasse;
using Dobble.Pages;
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
    public class TwoViewModel : FreshBasePageModel, INotifyPropertyChanged
    {
        public TwoViewModel()
        {

            MessagingCenter.Subscribe<TwoPage, string>(this, "muziek", (sender, arg) => {
                var music = new Music();
                if (Globals.Sound == true)
                {
                    if (bool.Parse(arg) == true)
                    { music.play("Correct.mp3"); }
                    else { music.play("Wrong.mp3"); };


                }
            });
            MessagingCenter.Subscribe<TwoPage, string>(this, "player1", (sender, arg) => {
                Globals.Player1 = (bool.Parse(arg) == true) ? Globals.Player1 + 1 : Globals.Player1 - 1;
                spel();
            });
            MessagingCenter.Subscribe<TwoPage, string>(this, "player2", (sender, arg) => {
                Globals.Player2 = (bool.Parse(arg) == true) ? Globals.Player2 + 1 : Globals.Player2 - 1;
                spel();
            });
            void spel()
            {
                if (Globals.Player1 > 9 || Globals.Player2 > 9)
                {
                    string antwoordstring = (Globals.Player1 > Globals.Player2) ? "Player 1 won the game:" + Globals.Player1.ToString() + "/" + Globals.Player2.ToString() : "Player 2 won the game:" + Globals.Player1.ToString() + "/" + Globals.Player2.ToString();
                    App.Current.MainPage.DisplayAlert("Score", antwoordstring, "ok");
                    Globals.Player1 = 0;
                    Globals.Player2 = 0;
                }
            }


        }



    }
}


