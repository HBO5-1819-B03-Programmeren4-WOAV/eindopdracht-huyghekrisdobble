using Dobble.Domain;
using Microsoft.AspNetCore.SignalR.Client;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Dobble.hulpclasse
{
    // methode om via signalR gegevens te pushen naar chathup hup die je dan dan uitlezen op webpagina http://localhost:56376
    // basis voorbeeld van het internet naar mijn hand gezet
    public class SentPlayInfo 
    {
        public async Task<bool> PlayInfo()
        {
            bool connected = false;
            
            try
            {
                var Connection = new HubConnectionBuilder()
                        .WithUrl("http://localhost:56376/ChatHub/")
                       .Build();

                await Connection.StartAsync();
                string verbinding = Connection.State.ToString();
                DateTime now = DateTime.Now;
                DateTimeOffset local_offset = new DateTimeOffset(now);
                DateTimeOffset utc_offset = local_offset.ToUniversalTime();

                var data = new DataOverDracht();
                data.tijd = utc_offset;
                data.username = Globals.Username;
                data.MaxScore = Globals.MaxScore;
                data.Level = Globals.Level;
                data.aantal_juist = Globals.aantal_juist;
                data.aantal_pogingen = Globals.aantal_pogingen;
                data.Totaalscore = Globals.Totaalscore;


                //string message = Globals.Username.ToString() + " GMT:" + utc_offset.ToString() + " De totaalscore is:" + Globals.Totaalscore.ToString() + " Aantal juist:" + Globals.aantal_juist.ToString() + "/" + Globals.aantal_pogingen.ToString() + " MaxScoreOnDevice:" + Globals.MaxScore.ToString();
                string message = JsonConvert.SerializeObject(data);

                if (verbinding == "Connected") 
                {
                    await Connection.InvokeAsync("SendMessage", Device.RuntimePlatform , message);
                }
               
             
                return connected;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error");
                return false;
            }
        }

        private async void Connection_Closed()
        {

            // specify a retry duration
            TimeSpan retryDuration = TimeSpan.FromSeconds(30);
            DateTime retryTill = DateTime.UtcNow.Add(retryDuration);

            while (DateTime.UtcNow < retryTill)
            {
                bool connected = await PlayInfo();
                if (connected)
                    return;
            }
            Console.WriteLine("Connection closed");


        }

    }
    
}
