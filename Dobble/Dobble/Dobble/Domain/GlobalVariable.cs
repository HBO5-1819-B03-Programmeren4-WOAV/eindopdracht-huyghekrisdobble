using System;
using System.Collections.Generic;
using System.Text;

namespace Dobble.hulpclasse
{
    static class Globals
    {
        
        public static int aantal_pogingen = 0;
        public static int aantal_juist = 0;
        public static string oplossing { get; set; }
        public static double TeScoren { get; set; }
        public static double TeScore = 1500;
        public static double Totaalscore = 0;
        public static double MaxScore = 0;
        public static bool Sound { get; set; }
        public static bool Vibrate { get; set; }
        public static string Username { get; set; }
    }
}
