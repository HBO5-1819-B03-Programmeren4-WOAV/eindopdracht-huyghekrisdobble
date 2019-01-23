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
            Globals.TeScoren = 1500;
            Globals.TeScore = 1500;
            Grid grid = new Grid
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                RowDefinitions =
                {
                    new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(100, GridUnitType.Absolute) }
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = GridLength.Auto },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(100, GridUnitType.Absolute) }
                }
            };

            grid.Children.Add(new Label
            {
                Text = "Grid",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            }, 0, 3, 0, 1);

            grid.Children.Add(new Label
            {
                Text = "Autosized cell",
                TextColor = Color.White,
                BackgroundColor = Color.Blue
            }, 0, 1);

            grid.Children.Add(new BoxView
            {
                Color = Color.Silver,
                HeightRequest = 0
            }, 1, 1);

            grid.Children.Add(new BoxView
            {
                Color = Color.Teal
            }, 0, 2);

            grid.Children.Add(new Label
            {
                Text = "Leftover space",
                TextColor = Color.Purple,
                BackgroundColor = Color.Aqua,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
            }, 1, 2);

            grid.Children.Add(new Label
            {
                Text = "Span two rows (or more if you want)",
                TextColor = Color.Yellow,
                BackgroundColor = Color.Navy,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center
            }, 2, 3, 1, 3);

            grid.Children.Add(new Label
            {
                Text = "Span 2 columns",
                TextColor = Color.Blue,
                BackgroundColor = Color.Yellow,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center
            }, 0, 2, 3, 4);

            grid.Children.Add(new Label
            {
                Text = "Fixed 100x100",
                TextColor = Color.Aqua,
                BackgroundColor = Color.Red,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center
            }, 2, 3);

            // Accomodate iPhone status bar.
            this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

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