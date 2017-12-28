using System;
using System.Collections.Generic;
using System.Text;

namespace SkipBo.Core
{
    static public class Kartenverwaltung
    {
        static Random _rnd = new Random();
        static List<Karten> rangordnung = new List<Karten>(){
                Karten.Ass, Karten.Zwei,Karten.Drei,Karten.Vier,Karten.Fünf,
                Karten.Sechs,Karten.Sieben,Karten.Acht,Karten.Neun,Karten.Zehn,
                Karten.Bube,Karten.Dame,Karten.König};

        static Queue<Karten> ZiehStapel = new Queue<Karten>();
        static List<Karten> SpielfeldStapel = new List<Karten>();
        static public Karten ObersteKarte { get { return SpielfeldStapel.Count > 0 ? SpielfeldStapel[SpielfeldStapel.Count - 1] : Karten.Keine; } }

        static public event Action<Karten> OberstekarteChanged;

        static private List<T> Mischen<T>(List<T> ilist)
        {
            List<T> ausg = new List<T>(ilist);
            int iIndex;
            T tTmp;
            for (int i = 1; i < ausg.Count; ++i)
            {
                iIndex = _rnd.Next(i + 1);
                tTmp = ausg[i];
                ausg[i] = ausg[iIndex];
                ausg[iIndex] = tTmp;
            }
            return ausg;
        }

        static internal bool IsMöglichAufStapel(Karten karte) // nur wenn ich das mit dem enablebutton machen will
        {
            // Wenn Ass oder die Karte vorher passt
            return ((SpielfeldStapel.Count == 0 && karte == Karten.Ass)
                || (SpielfeldStapel.Count > 0 && rangordnung.IndexOf(SpielfeldStapel[SpielfeldStapel.Count - 1]) == rangordnung.IndexOf(karte) - 1));
        }

        static internal bool AddToStapel(Karten karte)
        {
            int ind = rangordnung.IndexOf(karte);
            // Wenn Ass oder die Karte vorher passt
            bool möglich = ((SpielfeldStapel.Count == 0 && ind == 0) ||
                (SpielfeldStapel.Count > 0 && rangordnung.IndexOf(SpielfeldStapel[SpielfeldStapel.Count - 1]) == ind - 1));
            if (möglich)
            {
                if (SpielfeldStapel.Count + 1 == rangordnung.Count) // wenn König gelegt wurde/wird
                    SpielfeldStapel.Clear();
                else
                    SpielfeldStapel.Add(karte);

                if (OberstekarteChanged != null)
                    if (SpielfeldStapel.Count == 0)
                        OberstekarteChanged(Karten.Keine);
                    else
                        OberstekarteChanged(SpielfeldStapel[SpielfeldStapel.Count - 1]);
            }
            return möglich;
        }
        static internal List<Karten> GetKarten(int anz)
        {
            List<Karten> ausg = new List<Karten>();
            while (anz > ZiehStapel.Count) // sicherstellen dass genug karten zum ziehen da sind
                foreach (var item in Mischen<Karten>(rangordnung))
                    ZiehStapel.Enqueue(item);

            for (int i = 0; i < anz; i++)
                if (ZiehStapel.Count > 0)
                    ausg.Add(ZiehStapel.Dequeue());
                else throw new Exception("Karten alle!"); // darf eig nie eintreten
            return ausg;
        }
    }
}
