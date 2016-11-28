using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace Stoper 
{
    class Czas
    {
        private int licznik = 0;   // liczba setnych sekundy
        private Timer timer = new Timer();

        public int hr, mn, sec, misec;

        public void Start()
        {
            timer.Interval = 1; //co ile sie uruchamia
            timer.Elapsed += new ElapsedEventHandler(wypisz); // co sek wywoluje funkcje
            timer.Enabled = true;
            timer.Start();

        }

        public void Stop()
        {
            timer.Stop();

        }

        private void wypisz(object sender, EventArgs e)
        {
            licznik++;
        }

       public void konwertuj()
        {
            var timeSpan = TimeSpan.FromMilliseconds(licznik);
            hr = timeSpan.Hours;
            mn = timeSpan.Minutes;
            sec = timeSpan.Seconds;
            misec = timeSpan.Milliseconds;
        }

        public void reset()
        {
            licznik = 0;
            hr = 0;
            mn = 0;
            sec = 0;
            misec = 0;


        }


    }
}
