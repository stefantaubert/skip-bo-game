using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

class Spielfeld
{
    #region Deklarationen
    List<Stapel> stapel = new List<Stapel>();
    public List<Stapel> Stäpel { get { return stapel; } }
    int stapelIndex = 0;
    public int StapelIndex { get { return stapelIndex; } set { stapelIndex = value; } }

    Karte[] deck = { Karte.Herz_Ass, Karte.Herz_Zwei, Karte.Herz_Acht, Karte.Herz_Dame, Karte.Herz_Drei, Karte.Herz_Fünf, Karte.Herz_Junge, Karte.Herz_König, Karte.Herz_Neun, Karte.Herz_Sechs, Karte.Herz_Sieben, Karte.Herz_Vier, Karte.Herz_Zehn, Karte.Karo_Acht, Karte.Karo_Ass, Karte.Karo_Dame, Karte.Karo_Drei, Karte.Karo_Fünf, Karte.Karo_Junge, Karte.Karo_König, Karte.Karo_Neun, Karte.Karo_Sechs, Karte.Karo_Sieben, Karte.Karo_Vier, Karte.Karo_Zehn, Karte.Karo_Zwei, Karte.Kreuz_Acht, Karte.Kreuz_Ass, Karte.Kreuz_Dame, Karte.Kreuz_Drei, Karte.Kreuz_Fünf, Karte.Kreuz_Junge, Karte.Kreuz_König, Karte.Kreuz_Neun, Karte.Kreuz_Sechs, Karte.Kreuz_Sieben, Karte.Kreuz_Vier, Karte.Kreuz_Zehn, Karte.Kreuz_Zwei, Karte.Pik_Acht, Karte.Pik_Ass, Karte.Pik_Dame, Karte.Pik_Drei, Karte.Pik_Fünf, Karte.Pik_Junge, Karte.Pik_König, Karte.Pik_Neun, Karte.Pik_Sechs, Karte.Pik_Sieben, Karte.Pik_Vier, Karte.Pik_Zehn, Karte.Pik_Zwei, Karte.Herz_Acht, Karte.Herz_Ass, Karte.Herz_Dame, Karte.Herz_Drei, Karte.Herz_Fünf, Karte.Herz_Junge, Karte.Herz_König, Karte.Herz_Neun, Karte.Herz_Sechs, Karte.Herz_Sieben, Karte.Herz_Vier, Karte.Herz_Zehn, Karte.Herz_Zwei, Karte.Joker1, Karte.Joker2, Karte.Joker3, Karte.Joker4, Karte.Joker5, Karte.Joker6, Karte.Karo_Acht, Karte.Karo_Ass, Karte.Karo_Dame, Karte.Karo_Drei, Karte.Karo_Fünf, Karte.Karo_Junge, Karte.Karo_König, Karte.Karo_Neun, Karte.Karo_Sechs, Karte.Karo_Sieben, Karte.Karo_Vier, Karte.Karo_Zehn, Karte.Karo_Zwei, Karte.Kreuz_Acht, Karte.Kreuz_Ass, Karte.Kreuz_Dame, Karte.Kreuz_Drei, Karte.Kreuz_Fünf, Karte.Kreuz_Junge, Karte.Kreuz_König, Karte.Kreuz_Neun, Karte.Kreuz_Sechs, Karte.Kreuz_Sieben, Karte.Kreuz_Vier, Karte.Kreuz_Zehn, Karte.Kreuz_Zwei, Karte.Pik_Acht, Karte.Pik_Ass, Karte.Pik_Dame, Karte.Pik_Drei, Karte.Pik_Fünf, Karte.Pik_Junge, Karte.Pik_König, Karte.Pik_Neun, Karte.Pik_Sechs, Karte.Pik_Sieben, Karte.Pik_Vier, Karte.Pik_Zehn, Karte.Pik_Zwei };

    int indexNochVerbleibendSp1 = 0;
    int indexNochVerbleibendSp2 = 0;

    List<Karte> spieler1Stapel = new List<Karte>();
    List<Karte> spieler2Stapel = new List<Karte>();

    List<Karte> spieler1Ablage = new List<Karte>();
    List<Karte> spieler2Ablage = new List<Karte>();

    List<Karte> spieler1Hand = new List<Karte>();
    List<Karte> spieler2Hand = new List<Karte>();
    Queue<Karte> restDeck;

    public int StapelIndexSp1 { get { return indexNochVerbleibendSp1; } }
    public int StapelIndexSp2 { get { return indexNochVerbleibendSp2; } }

    public List<Karte> Spieler1Stapel { get { return spieler1Stapel; } }
    public List<Karte> Spieler2Stapel { get { return spieler2Stapel; } }

    public Karte[] Spieler1Ablage { get { return spieler1Ablage.ToArray(); } }
    public Karte[] Spieler2Ablage { get { return spieler2Ablage.ToArray(); } }

    public Karte[] Spieler1Hand { get { return spieler1Hand.ToArray(); } }
    public Karte[] Spieler2Hand { get { return spieler2Hand.ToArray(); } }

    public int StapelKarten { get { return restDeck.Count; } }
    #endregion

    public void Inizialize()
    {
        KartenGeben();
        // Mischen();
        Get5KartenSpieler(true);
        Get5KartenSpieler(false);
        Get10Karten();
    }

    #region Geben der Karten
    private void Shuffle<T>(IList<T> ilist)
    {
        Random rand = new Random();
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
    public void Mischen()
    {
        Karte[] d = restDeck.ToArray();
        Shuffle<Karte>(d);
        restDeck.Clear();
        foreach (var item in d)
            restDeck.Enqueue(item);
    }
    private void KartenGeben()
    {
        restDeck = new Queue<Karte>();
        for (int j = 0; j < 2; j++)
            for (int i = 0; i < deck.Length; i++)
                restDeck.Enqueue(deck[i]);
    }

    private void Get10Karten()
    {
        for (int i = 0; i < 10; i++)
        {
            spieler1Stapel.Add(restDeck.Dequeue());
            spieler2Stapel.Add(restDeck.Dequeue());
        }
    }

    public void Get5KartenSpieler(bool spieler1)
    {
        int lenght = 0;
        List<Karte> tmp;
        if (spieler1) tmp = spieler1Hand;
        else tmp = spieler2Hand;
        foreach (var item in tmp)
            if (item != Karte.Leer) lenght++;
        if (restDeck.Count > 5)
            for (int i = 0; i < 5 - lenght; i++)
            {
                tmp.Remove(Karte.Leer);
                tmp.Add(restDeck.Dequeue());
            }
    }
    #endregion

    public void KarteAblegen(int ablagenIndex, int stapelIndex, bool spieler1)
    {
        Karte karte;
        List<Karte> kartenBlock;

        if (spieler1 && spieler1Ablage.Count != 0)
        {
            kartenBlock = spieler1Ablage;
            karte = spieler1Ablage[ablagenIndex];
        }
        else if (!spieler1 && spieler2Ablage.Count != 0)
        {
            kartenBlock = spieler2Ablage;
            karte = spieler2Ablage[ablagenIndex];
        }
        else
        {
            MessageBox.Show("Sie haben keine Karten in der Ablage!");
            return;
        }

        if (stapel.Count == 0)
            stapel.Add(new Stapel());
        switch (stapel[stapelIndex].AddKarte(karte))
        {
            case Stapel.Aktion.Passend:
                kartenBlock.RemoveAt(ablagenIndex);
                break;
            case Stapel.Aktion.Unpassend:
                MessageBox.Show("Diese Karte kann nicht auf diesen Stapel gelegt werden!");
                break;
            case Stapel.Aktion.Voll:
                for (int i = 0; i < stapel[stapelIndex].StapelProperty.Count; i++)
                {
                    restDeck.Enqueue(stapel[stapelIndex].StapelProperty[i]);
                    stapel[stapelIndex].StapelProperty.RemoveAt(i);
                }
                kartenBlock.RemoveAt(ablagenIndex);
                Mischen();
                MessageBox.Show("Der Stapel ist voll. Er wurde nun entfernt und eingemischt.");
                break;
            case Stapel.Aktion.NeuerStapel:
                if (stapel[0].StapelProperty.Count != 1)
                {
                    stapel.Add(new Stapel());
                    stapel[stapel.Count - 1].AddKarte(karte);
                }
                kartenBlock.RemoveAt(ablagenIndex);
                break;
        }
    }

    public void KarteAblegen(int handIndex, int stapelIndex, bool spieler1, bool inAblage)
    {
        Karte karte;
        List<Karte> kartenBlock;

        #region kartenBlock zuweisen
        if (spieler1 && handIndex == 5)
        {
            kartenBlock = spieler1Stapel;
            karte = spieler1Stapel[indexNochVerbleibendSp1];
            indexNochVerbleibendSp1++;
        }
        else if (spieler1 && handIndex != 5)
        {
            kartenBlock = spieler1Hand;
            karte = spieler1Hand[handIndex];
        }
        else if (!spieler1 && handIndex == 5)
        {
            kartenBlock = spieler2Stapel;
            karte = spieler2Stapel[indexNochVerbleibendSp2];
            indexNochVerbleibendSp2++;
        }
        else if (!spieler1 && handIndex != 5)
        {
            kartenBlock = spieler2Hand;
            karte = spieler2Hand[handIndex];
        }
        else return;
        #endregion

        if (!inAblage)
        {
            #region normales Legen
            if (stapel.Count == 0)
                stapel.Add(new Stapel());
            switch (stapel[stapelIndex].AddKarte(karte))
            {
                case Stapel.Aktion.Passend:
                    kartenBlock.RemoveAt(handIndex);
                    kartenBlock.Insert(handIndex, Karte.Leer);
                    break;
                case Stapel.Aktion.Unpassend:
                    if (inAblage)
                        if (spieler1)
                            indexNochVerbleibendSp1--;
                        else
                            indexNochVerbleibendSp2--;
                    MessageBox.Show("Diese Karte kann nicht auf diesen Stapel gelegt werden!");
                    break;
                case Stapel.Aktion.Voll:
                    MessageBox.Show("Der Stapel ist voll und wird nun entfernt und wieder eingemischt.");
                    for (int i = 0; i < stapel[stapelIndex].StapelProperty.Count; i++)
                    {
                        restDeck.Enqueue(stapel[stapelIndex].StapelProperty[i]);
                        stapel[stapelIndex].StapelProperty.RemoveAt(i);
                    }
                    kartenBlock.RemoveAt(handIndex);
                    kartenBlock.Insert(handIndex, Karte.Leer);
                    Mischen();
                    break;
                case Stapel.Aktion.NeuerStapel:
                    if (stapel[0].StapelProperty.Count != 1)
                    {
                        stapel.Add(new Stapel());
                        stapel[stapel.Count - 1].AddKarte(karte);
                    }
                    kartenBlock.RemoveAt(handIndex);
                    kartenBlock.Insert(handIndex, Karte.Leer);
                    break;
            }
            // wenn 5 Karten abgelegt werden wird neu gezogen
            int zähler = 0;
            foreach (var item in kartenBlock)
                if (item == Karte.Leer)
                    zähler++;
            if (zähler == 5)
                Get5KartenSpieler(spieler1);
            #endregion
        }
        else
        {
            #region in die Ablage legen
            if (karte != Karte.Leer && handIndex != 5)
            {
                if (spieler1)
                {
                    spieler1Ablage.Add(karte);
                    kartenBlock.RemoveAt(handIndex);
                    kartenBlock.Insert(handIndex, Karte.Leer);
                }
                else
                {
                    spieler2Ablage.Add(karte);
                    kartenBlock.RemoveAt(handIndex);
                    kartenBlock.Insert(handIndex, Karte.Leer);
                }
                Get5KartenSpieler(spieler1);
            }
            else if (handIndex == 5)
            {
                if (inAblage)
                    if (spieler1)
                        indexNochVerbleibendSp1--;
                    else
                        indexNochVerbleibendSp2--;
                MessageBox.Show("Sie können keine Karte aus ihrem Häufchen ablegen!");
            }
            else
                MessageBox.Show("Sie können keine leeres Feld ablegen!");
            #endregion
        }
    }
}