using System;
using System.Collections.Generic;
using System.Text;

namespace Dobble.Domain
{
    public class DataOverDracht
    {
        public string username { get; set; }
        public DateTimeOffset tijd { get; set; }
        public int aantal_pogingen { get; set; }
        public int aantal_juist { get; set; }
        public double Totaalscore { get; set; }
        public double MaxScore { get; set; }
        public int Level { get; set; }
     
    }
}
