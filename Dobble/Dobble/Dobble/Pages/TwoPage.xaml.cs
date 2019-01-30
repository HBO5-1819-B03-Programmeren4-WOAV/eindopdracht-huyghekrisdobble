using Dobble.Domain;
using Dobble.hulpclasse;
using System;
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
            int player1 = 0;
            int player2 = 0;
            var hoogte = schermhoogte / 16;
            var makeplayground = new MakePlayGround();
            var playground = makeplayground.MakePlayField(2, Globals.Level + 2);
            raster();
            void raster()
            {



                Grid grid = new Grid
                {
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
                var scoreLabel = new Label { Text = player1.ToString() + "/" + player2.ToString() };
                grid.Children.Add(scoreLabel, 0, 4);
                int n = 0;
                int rij = 0;
                int col = 1;
                do
                {
                    var Figuur = basis + playground.Cards[0].picturelist[n] + achtervoegsel;
                    var imageButton = new ImageButton { Source = Figuur };
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

                n = 0;
                rij = 0;
                col = 5;
                do
                {
                    var Figuur = basis + playground.Cards[1].picturelist[n] + achtervoegsel;
                    var imageButton = new ImageButton { Source = Figuur };
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

                          

                // Build the page.
                this.Content = grid;
            }



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
            void spel(ImageButton btn, string player)
            {
                var gedrukt = btn.Source.ToString();
                int len = gedrukt.Length;
                gedrukt = gedrukt.Substring(bas, len - bas - acht);
                // Score.Title
                
                

                Zoekoplossing zoekoplossing = new Zoekoplossing();
                var oplossing = zoekoplossing.Oplossing(playground);
                // DisplayAlert(player, oplossing, gedrukt);
                if (player == "player1")
                {
                    player1 = (gedrukt != oplossing) ? player1 - 1 : player1 + 1; 
                }
                else
                {
                    player2 = (gedrukt != oplossing) ? player2 - 1 : player2 + 1;
                }
                playground = makeplayground.MakePlayField(2, Globals.Level + 2);
                if (player1 > 9 || player2 > 9)
                {
                    string antwoordstring = (player1 > player2) ? "Player1 won the game:" + player1.ToString() + "/" + player2.ToString() : "Player2 won the game:" + player1.ToString() + "/" + player2.ToString();
                    DisplayAlert("Score", antwoordstring, "ok");
                    player1 = 0;
                    player2 = 0;
                }
                else
                {
                    raster();
                }
                

            }



        }


    }
}