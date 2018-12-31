using Dobble.hulpclasse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dobble.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
            Device.StartTimer(TimeSpan.FromMilliseconds(1000), () =>
            {


                AantalJuist.Text = "Juist:" + Globals.aantal_juist.ToString() + "/" + Globals.aantal_pogingen.ToString();
                Score.Text = "  Score:" + Globals.Totaalscore;
                MaxScore.Text = "Max score:" + Globals.MaxScore;
                return true;
            });
            var bestand = new Bestand();
            int m = 0;
            try
            {
                m = Int32.Parse(bestand.ReadFile("maxScore.txt"));
            }
            catch (FormatException e)
            {
                
            }
            Globals.MaxScore = m;
             
        }
	}
}