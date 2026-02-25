using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class Program
    {
        private static Aktie k;
        static void Main(string[] args)
        {
            k = new Aktie();
            //k.AddListener(K_AktieKursSteget);
            k.AktieKursSteget += K_AktieKursSteget;
            //eller vha lambda expression:
            //k.AddListener((sender, e) => Console.WriteLine("Aktie steget:" + e.Stigning));
            k.AktieKursSteget += (sender, e) => Console.WriteLine("Aktie steget:" + e.Stigning);


            k.run();
            //Illegal: 
            //nyansat udvikler
            //k.AktieKursSteget.Invoke(null, null);
            //Eller hvad med denne?
            //k.AktieKursSteget = null;
        }

        private static void K_AktieKursSteget(object sender, AktieEventArgs e)
        {
            Console.WriteLine("Aktie steget:" + e.Stigning);
        }
    }
}
