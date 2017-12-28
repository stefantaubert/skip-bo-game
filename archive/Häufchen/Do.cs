using System;
using System.Collections.Generic;
using System.Text;

static public class Do
{
    public static void Shuffle<T>(IList<T> ilist)
    {
        Random rand = new Random(0);
        int iIndex;
        T tTmp;
        for (int i = 1; i < ilist.Count; ++i)
        {
            iIndex = rand.Next(i + 1);
            tTmp = ilist[i];
            ilist[i] = ilist[iIndex];
            ilist[iIndex] = tTmp;
        }
    }
    public static bool IsAss(Karten karte)
    {
        string rang = karte.ToString();
        return (rang == "Ass" || rang.Contains("Joker"));
    }

    public static void Mischen(ref Queue<Karten> kart)
    {
        Karten[] d = new Karten[kart.Count];
        d = kart.ToArray();
        Shuffle<Karten>(d);
        kart.Clear();
        foreach (var item in d)
            kart.Enqueue(item);
    }
    public static void GetKarten(ref Queue<Karten> haufen, ref Queue<Karten> liste, int anz)
    {
        while (liste.Count < anz)
            if (haufen.Count > 0)
                liste.Enqueue(haufen.Dequeue());
            else throw new Exception("Karten alle!");
    }
}
