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
    public class MainViewModel : FreshBasePageModel
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand StartGameCommand { get; private set; }
    
        public MainViewModel()
        {
          
            StartGameCommand = new Command(GamePage);
            //ListPageCommand = new Command(OpenLijstInfoPage);
        }
        private async void GamePage()
        {
            Globals.aantal_juist = 0;
            Globals.aantal_pogingen = 0;
            Globals.TeScoren = 0;
            Globals.Totaalscore = 0;
            await CoreMethods.PushPageModel<GameViewModel>(true);
        }
      
    
    }
}
