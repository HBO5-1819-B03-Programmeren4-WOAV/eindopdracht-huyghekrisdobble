using Dobble.Domain;
using Dobble.hulpclasse;
using System;
using System.Collections.Generic;
using System.Reflection;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dobble.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TwoPage : ContentPage
	{
        static string basis = Device.RuntimePlatform == Device.Android ? "a" : "Images/a";
        static string achtervoegsel = Device.RuntimePlatform == Device.Android ? ".png" : ".jpg";
        public int bas = basis.Length + 6;
        public int acht = achtervoegsel.Length;
        


        MakePlayGround makeplayground = new MakePlayGround();

        public TwoPage()
        {
            var mainDisplayInfo = DeviceDisplay.MainDisplayInfo;
            double schermhoogte = Device.RuntimePlatform == Device.Android ? mainDisplayInfo.Height / 3 : mainDisplayInfo.Height;
            Globals.Player1 = 0;
            Globals.Player2 = 0;
            
            var hoogte = schermhoogte / 16;
            var makeplayground = new MakePlayGround();
            var playground = makeplayground.MakePlayField(2, Globals.Level + 2);
            raster();
            #region raster
            void raster()
            {
                var rotaties = new List<int>();
                rotaties.Add(0);
                rotaties.Add(90);
                rotaties.Add(-90);
                rotaties.Add(180);
                Random rnd = new Random();




                Grid grid = new Grid { 
                    VerticalOptions = LayoutOptions.FillAndExpand,
                    HorizontalOptions = LayoutOptions.Center,
                    RowDefinitions =
                {
                    new RowDefinition { Height = hoogte * 0.9},
                    new RowDefinition { Height = hoogte},
                    new RowDefinition { Height = hoogte},
                     new RowDefinition { Height = hoogte },
                    new RowDefinition { Height = hoogte * 1.35},
                    new RowDefinition { Height = hoogte},
                     new RowDefinition { Height = hoogte},
                    new RowDefinition { Height = hoogte},
                    new RowDefinition { Height = hoogte * 0.9}
                },
                    ColumnDefinitions =
                {

                    new ColumnDefinition { Width = hoogte },
                    new ColumnDefinition { Width = hoogte },
                    new ColumnDefinition { Width = hoogte }
                }
                };
                var embeddedImage = new Image { Source = ImageSource.FromResource("Dobble.Images.Vierkant.png"), HeightRequest = hoogte * 3, WidthRequest = hoogte * 3 };
                embeddedImage.ScaleX = 1.5;
                embeddedImage.ScaleY = 1.5;
                grid.Children.Add(embeddedImage, 0, 1);
                Grid.SetColumnSpan(embeddedImage, 3);
                Grid.SetRowSpan(embeddedImage, 3);

                var embeddedImage2 = new Image { Source = ImageSource.FromResource("Dobble.Images.Vierkant.png"), HeightRequest = hoogte * 3, WidthRequest = hoogte * 3 };
                embeddedImage2.ScaleX = 1.5;
                embeddedImage2.ScaleY = 1.5;
                grid.Children.Add(embeddedImage2, 0, 5);
                Grid.SetColumnSpan(embeddedImage2, 3);
                Grid.SetRowSpan(embeddedImage2, 3);

                int n = 0;
                int rij = 0;
                int col = 1;
                do
                {
                    var Figuur = basis + playground.Cards[0].picturelist[n] + achtervoegsel;
                    var imageButton = new ImageButton { Source = Figuur, Rotation = rotaties[rnd.Next(0, 4)] };
                    imageButton.Clicked += Player1;
                    grid.Children.Add(imageButton, rij, col);
                    rij++;
                    if (rij > 2)
                    {
                        rij = 0;
                        col++;
                    }
                    n++;
                } while (n < playground.Cards[0].picturelist.Count);

                var scoreLabelplayer1 = new Label { HorizontalOptions = LayoutOptions.Center, Text = Globals.Player1.ToString(), FontSize = hoogte / 2, Rotation = 180 };
      
                grid.Children.Add(scoreLabelplayer1, 1, 0);
        
                var scoreLabelplayer2 = new Label { HorizontalOptions = LayoutOptions.Center, Text = Globals.Player2.ToString(), FontSize = hoogte / 2, Rotation = 0 };
                grid.Children.Add(scoreLabelplayer2, 1, 8);
                            
                n = 0;
                rij = 0;
                col = 5;
                do
                {
                    var Figuur = basis + playground.Cards[1].picturelist[n] + achtervoegsel;
                    var imageButton = new ImageButton { Source = Figuur, Rotation = rotaties[rnd.Next(0, 4)] };
                    imageButton.Clicked += Player2;
                    grid.Children.Add(imageButton, rij, col);
                    rij++;
                    if (rij > 2)
                    {
                        rij = 0;
                        col++;
                    }
                    n++;
                } while (n < playground.Cards[0].picturelist.Count);

                
                
          //      < Image ScaleX = "1.8" ScaleY = "1.8" HorizontalOptions = "FillAndExpand" VerticalOptions = "FillAndExpand" Aspect = "AspectFill" Source = "{extensions:ImageResource Dobble.Images.Circle.png}" Grid.Row = "1" Grid.Column = "1" Grid.RowSpan = "3" Grid.ColumnSpan = "3" />
                   
           //                            < Image ScaleX = "1.8" ScaleY = "1.8" HorizontalOptions = "FillAndExpand" VerticalOptions = "FillAndExpand" Aspect = "AspectFill" Source = "{extensions:ImageResource Dobble.Images.Circle.png}" Grid.Row = "5" Grid.Column = "1" Grid.RowSpan = "3" Grid.ColumnSpan = "3" />


                                                      // Build the page.
                                                      this.Content = grid;
            }
            #endregion
            
            void Player1(object sender, EventArgs e)
            {
                ImageButton btn = (ImageButton)sender;
                spel(btn, "player1");
                
            }
            void Player2(object sender, EventArgs e)
            {
                ImageButton btn = (ImageButton)sender;
                spel(btn, "player2");
               
            }

            #region spel
            void spel(ImageButton btn, string player)
            {
                var gedrukt = btn.Source.ToString();
                int len = gedrukt.Length;
                gedrukt = gedrukt.Substring(bas, len - bas - acht);
                var music = new Music();
                
                Zoekoplossing zoekoplossing = new Zoekoplossing();
                var oplossing = zoekoplossing.Oplossing(playground);
                // DisplayAlert(player, oplossing, gedrukt);
                bool juist = (gedrukt == oplossing) ? true : false;

                MessagingCenter.Send<TwoPage, string>(this, "muziek" , juist.ToString() );
                MessagingCenter.Send<TwoPage, string>(this, player, juist.ToString());
                  
                playground = makeplayground.MakePlayField(2, Globals.Level + 2);
                raster();
            }
            #endregion


        }


    }
}