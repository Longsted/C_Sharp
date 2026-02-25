using System;
using System.Threading;

namespace Events
{
    internal delegate void AktieEventHandler(object sender, AktieEventArgs e);
    internal class Aktie
    {
        public event AktieEventHandler AktieKursSteget;

        private int kurs = 100;

        public int Kurs
        {
            get
            {
                return kurs;
            }
            set
            {
                int stigning = value - kurs;
                kurs = value;
                Console.WriteLine("kurs:" + kurs + ", stigning:" + stigning);
                if (stigning > 5)
                {
                    onAktieKursStiger(stigning);
                }
            }
        }
        public virtual void onAktieKursStiger(int stigning)
        {
            AktieKursSteget?.Invoke(this, new AktieEventArgs(Kurs, stigning));
        }
        //public void AddListener(AktieEventHandler listener)
        //{
        //    AktieKursSteget += listener;
        //}
        public void run()
        {
            while (true)
            {
                Thread.Sleep(1000);
                Random rnd = new Random();
                int stigning = rnd.Next(1, 10);
                Kurs += stigning;
            }
        }
    }
}
