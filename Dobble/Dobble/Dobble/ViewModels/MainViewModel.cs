﻿using Dobble.Domain;
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
        Bestand bestand = new Bestand();
        #region modelbinding 
        private string username;
        public string Username
        {
            set
            {
                if (username != value)
                {
                    username = value;
                    
                    Globals.Username = username;
                    try
                    {
                        bestand.Save(username.ToString(), "Username.txt");
                    }
                    catch
                    {

                    }

                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Username"));

                    }
                }
            }
            get
            {
                Globals.Username = username;
                try
                {
                    bestand.Save(username.ToString(), "Username.txt");
                }
                catch
                {

                }
                return username;
            }
        }
        private bool sound;
        public bool Sound
        {
            set
            {
                if (sound != value)
                {
                    sound = value;
                    Globals.Sound = sound;
                    try
                    {
                        bestand.Save(sound.ToString(), "Sound.txt");
                    }
                    catch
                    {

                    }
                    
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Sound"));
                        
                    }
                }
            }
            get
            {
                Globals.Sound = sound;
                try
                {
                    bestand.Save(sound.ToString(), "Sound.txt");
                }
                catch
                {

                }
                return sound;
            }
        }
        private bool vibrate;
        public bool Vibrate
        {
            set
            {
                if (vibrate != value)
                {
                    vibrate = value;
                    Globals.Vibrate = vibrate;
                    try {
                        bestand.Save(vibrate.ToString(), "Vibrate.txt");
                    }
                    catch
                    {

                    }
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Vibrate"));
                        
                    }
                }
            }
            get
            {
                Globals.Vibrate = vibrate;
                try
                {
                    bestand.Save(vibrate.ToString(), "Vibrate.txt");
                }
                catch
                {

                }
                
                return vibrate;
            }
        }
        #endregion


        public ICommand StartGameCommand { get; private set; }
        public ICommand FlexCommand { get; private set; }
        #region MainViewModel 
        public MainViewModel()
        {
            
            StartGameCommand = new Command(GamePage);
            FlexCommand = new Command(FlexGame);
            try
            {
                var bestand = new Bestand();
                Sound = Boolean.Parse(bestand.ReadFile("Sound.txt"));
                Vibrate = Boolean.Parse(bestand.ReadFile("Vibrate.txt"));
                Username = bestand.ReadFile("Username.txt");
            }
            catch
            {
                Sound = true;
                Vibrate = true;
                Username = "";
            }
            //ListPageCommand = new Command(OpenLijstInfoPage);
        }
        #endregion
        #region gamepage
        private async void GamePage()
        {
            Globals.TeScore = 1000;
            Globals.aantal_juist = 0;
            Globals.aantal_pogingen = 0;
            Globals.TeScoren = 0;
            Globals.Totaalscore = 0;
            await CoreMethods.PushPageModel<GameViewModel>(true);
        }
        #endregion
        #region Flexgame poging om ultieme flex ervaring te ondervinden
        private async void FlexGame()
        {
            Globals.TeScore = 1000;
            Globals.aantal_juist = 0;
            Globals.aantal_pogingen = 0;
            Globals.TeScoren = 0;
            Globals.Totaalscore = 0;
            await CoreMethods.PushPageModel<FlexViewModel>(true);
        }
        #endregion


    }
}
