using Dobble.hulpclasse;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dobble.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TwoPage : ContentPage
	{
		public TwoPage ()
		{
            var makeplayground = new MakePlayGround();
            var playground = makeplayground.MakePlayField(2, Globals.Level + 2);
            string basis = Device.RuntimePlatform == Device.Android ? "a" : "Images/a";
            string achtervoegsel = Device.RuntimePlatform == Device.Android ? ".png" : ".jpg";

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
                
                grid.Children.Add(new ImageButton { HeightRequest = 20, IsVisible = true, Source = Figuur }, rij, col);
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

                grid.Children.Add(new ImageButton { HeightRequest = 20, IsVisible = true, Source = Figuur }, rij, col);
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
            

            SizeChanged += (object sender, EventArgs args) =>
            {
                if (this.Width > 0)
               {
                   
                    var grote = this.Height / 11;

            //        Rij0.Height = grote * 0.9;
            //        Rij1.Height = grote;
            //        Rij2.Height = grote;
            //        Rij3.Height = grote;
            //        Rij4.Height = grote * 1.35;  
            //        Rij5.Height = grote;
            //        Rij6.Height = grote;
            //        Rij7.Height = grote;
            //        Rij8.Height = grote * 0.9;
            //        Col0.Width = grote;
            //        Col1.Width = grote;
            //        Col2.Width = grote;
            //        Col3.Width = grote;
            //        Col4.Width = grote;
                }

            };
            
        }

        
    }
}