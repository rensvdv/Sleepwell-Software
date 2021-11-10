using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sleepwell
{
    public class sleepSession
    {
        // de get set haalt de atributen op waar de sleepsession uit bestaat
        
        public int User_id { get; set; }

        public double Sleep_duration { get; set; }
        public int Avg_BPM { get; set; }

        DateTime Date { get; set; }

        public sleepSession(int user_id, double sleep_duration, int avg_bpm, DateTime date)
        {
            //als je de class aanroept heeft de sleepsession deze variabelen nodig
            this.User_id = user_id;
            this.Sleep_duration = sleep_duration;
            this.Avg_BPM = avg_bpm;
            this.Date = date;
        }
    }
}
