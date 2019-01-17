using Dobble.hulpclasse;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dobble.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GamePage : ContentPage
	{
		public GamePage ()
		{
           
            InitializeComponent();
           
            SizeChanged += (object sender, EventArgs args) =>
            {
                if (this.Width > 0)
                {
                   
                    var grote = this.Height / 11;

                    Rij0.Height = grote * 0.9;
                    Rij1.Height = grote;
                    Rij2.Height = grote;
                    Rij3.Height = grote;
                    Rij4.Height = grote * 1.35;  
                    Rij5.Height = grote;
                    Rij6.Height = grote;
                    Rij7.Height = grote;
                    Rij8.Height = grote * 0.9;
                    Col0.Width = grote;
                    Col1.Width = grote;
                    Col2.Width = grote;
                    Col3.Width = grote;
                    Col4.Width = grote;
                }
                
            };
            Device.StartTimer(TimeSpan.FromMilliseconds(100), () =>
            {
              
                if (Globals.TeScoren > 0) Globals.TeScoren--;
               
                if (Globals.TeScore != 0)
                {
                    Progres.Progress = 1 - (Globals.TeScoren / Globals.TeScore);
                }
                else
                {
                    Progres.Progress = 1;
                }
               
                               
                return true;
            });
        }
       
    }
}