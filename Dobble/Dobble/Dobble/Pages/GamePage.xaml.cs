using Dobble.Domain;
using Dobble.hulpclasse;
using FreshMvvm;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dobble.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GamePage : ContentPage
	{
		public GamePage ()
		{
			InitializeComponent ();
            SizeChanged += (object sender, EventArgs args) =>
            {
                if (this.Width > 0)
                {
                    var links = this.Width - (this.Width / 1.5);
                    var rechts = this.Width / 1.5;
                    var grote = this.Height / 10;

                    grid.Margin = this.Width / 10;
                    Rij1.Height = grote;
                    Rij2.Height = grote;
                    Rij3.Height = grote;
                    Rij4.Height = grote;
                    Rij5.Height = grote;
                    Rij6.Height = grote;
                    Rij7.Height = grote;
                    Col1.Width = grote;
                    Col2.Width = grote;
                    Col3.Width = grote;
                }
                
            };
            Device.StartTimer(TimeSpan.FromMilliseconds(100), () =>
            {
                //while (Globals.TeScoren > 1)
                //{
                if (Globals.TeScoren > 0) Globals.TeScoren--;
                LblTijdmelding.Text = Globals.TeScoren.ToString();
                //}
                               
                return true;
            });
        }
       
    }
}