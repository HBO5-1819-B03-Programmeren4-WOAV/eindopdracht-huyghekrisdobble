using Dobble.Domain;
using Dobble.hulpclasse;
using System;

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
       
        public TwoPage ()
		{
            var makeplayground = new MakePlayGround();
            var playground = makeplayground.MakePlayField(2, Globals.Level + 2);
            raster();
            void raster ()
            {
                


                Grid grid = new Grid
                {
                    VerticalOptions = LayoutOptions.FillAndExpand,
                    RowDefinitions =
                {
                    new RowDefinition { Height = 40},
                    new RowDefinition { Height = 40},
                    new RowDefinition { Height = 40 },
                     new RowDefinition { Height = 40 },
                    new RowDefinition { Height = 40},
                    new RowDefinition { Height = 40},
                     new RowDefinition { Height = 40},
                    new RowDefinition { Height = 40},
                    new RowDefinition { Height = 40 }
                },
                    ColumnDefinitions =
                {
                    new ColumnDefinition { Width = 40 },
                    new ColumnDefinition { Width = 40 },
                    new ColumnDefinition { Width = 40 }
                }
                };
                int n = 0;
                int rij = 0;
                int col = 0;
                do
                {
                    var Figuur = basis + playground.Cards[0].picturelist[n] + achtervoegsel;
                    var imageButton = new ImageButton { HeightRequest = 20, Source = Figuur };
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
                    var imageButton = new ImageButton { HeightRequest = 20, Source = Figuur };
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
                
                var gedrukt = btn.Source.ToString();
                int len = gedrukt.Length;
                gedrukt = gedrukt.Substring(bas, len - bas - acht);

                Zoekoplossing zoekoplossing = new Zoekoplossing();
                var oplossing = zoekoplossing.Oplossing(playground);
                DisplayAlert("player1", oplossing, gedrukt);
                playground = makeplayground.MakePlayField(2, Globals.Level + 2);
                raster();
            }
            void Player2(object sender, EventArgs e)
            {
                ImageButton btn = (ImageButton)sender;
                
                var gedrukt = btn.Source.ToString();
                int len = gedrukt.Length;
                gedrukt = gedrukt.Substring(bas, len - bas - acht);

                Zoekoplossing zoekoplossing = new Zoekoplossing();
                var oplossing = zoekoplossing.Oplossing(playground);
                DisplayAlert("player2", oplossing, gedrukt);
                playground = makeplayground.MakePlayField(2, Globals.Level + 2);
                raster();
            }




        }


    }
}