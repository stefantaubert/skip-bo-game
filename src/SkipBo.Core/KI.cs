using System;
using System.Collections.Generic;
using System.Text;

namespace SkipBo.Core
{
    static class KI
    {
        static Random _rnd = new Random();
        //public static int Schwierigkeit { get; set; }
        public static void DoWork()
        {
            for (int i = 0; i < Controller.aktuellerSpieler.Cards.Count; i++)
                for (int j = 0; j < Controller.aktuellerSpieler.Cards[i].Count; j++)
                {//Controller.aktuellerSpieler.Cards[i].Count - 1 -
                    Karten k = Controller.aktuellerSpieler.Cards[i][j]; // letzte karte nicht mehr sondern erste is ja eig wayne aber so is einfacher
                    if (Kartenverwaltung.IsMöglichAufStapel(k))
                    {//Controller.aktuellerSpieler.Cards[i].Count - 1 -
                        Controller.LegeAb(i, j, false);
                        // System.Threading.Thread.Sleep(1000); // als Zeitlimit damit man auch den Spielzug sieht im Spiel dann, nur temporär
                        DoWork();
                        return;
                    }
                    if (i == Controller.IndHome) break;
                }
            //System.Threading.Thread.Sleep(1000);
            Controller.LegeAb(Controller.IndHand, _rnd.Next(0, Controller.aktuellerSpieler.Cards[Controller.IndHand].Count), true);
        }

    }
}
