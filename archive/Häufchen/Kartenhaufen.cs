using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApplication1
{
    class Kartenhaufen
    {
        Karte[] _blatt = { Karte.Herz_Ass, Karte.Herz_Zwei, Karte.Herz_Acht, Karte.Herz_Dame, Karte.Herz_Drei, Karte.Herz_Fünf, Karte.Herz_Junge, Karte.Herz_König, Karte.Herz_Neun, Karte.Herz_Sechs, Karte.Herz_Sieben, Karte.Herz_Vier, Karte.Herz_Zehn, Karte.Karo_Acht, Karte.Karo_Ass, Karte.Karo_Dame, Karte.Karo_Drei, Karte.Karo_Fünf, Karte.Karo_Junge, Karte.Karo_König, Karte.Karo_Neun, Karte.Karo_Sechs, Karte.Karo_Sieben, Karte.Karo_Vier, Karte.Karo_Zehn, Karte.Karo_Zwei, Karte.Kreuz_Acht, Karte.Kreuz_Ass, Karte.Kreuz_Dame, Karte.Kreuz_Drei, Karte.Kreuz_Fünf, Karte.Kreuz_Junge, Karte.Kreuz_König, Karte.Kreuz_Neun, Karte.Kreuz_Sechs, Karte.Kreuz_Sieben, Karte.Kreuz_Vier, Karte.Kreuz_Zehn, Karte.Kreuz_Zwei, Karte.Pik_Acht, Karte.Pik_Ass, Karte.Pik_Dame, Karte.Pik_Drei, Karte.Pik_Fünf, Karte.Pik_Junge, Karte.Pik_König, Karte.Pik_Neun, Karte.Pik_Sechs, Karte.Pik_Sieben, Karte.Pik_Vier, Karte.Pik_Zehn, Karte.Pik_Zwei, Karte.Herz_Acht, Karte.Herz_Ass, Karte.Herz_Dame, Karte.Herz_Drei, Karte.Herz_Fünf, Karte.Herz_Junge, Karte.Herz_König, Karte.Herz_Neun, Karte.Herz_Sechs, Karte.Herz_Sieben, Karte.Herz_Vier, Karte.Herz_Zehn, Karte.Herz_Zwei, Karte.Joker1, Karte.Joker2, Karte.Joker3, Karte.Joker4, Karte.Joker5, Karte.Joker6, Karte.Karo_Acht, Karte.Karo_Ass, Karte.Karo_Dame, Karte.Karo_Drei, Karte.Karo_Fünf, Karte.Karo_Junge, Karte.Karo_König, Karte.Karo_Neun, Karte.Karo_Sechs, Karte.Karo_Sieben, Karte.Karo_Vier, Karte.Karo_Zehn, Karte.Karo_Zwei, Karte.Kreuz_Acht, Karte.Kreuz_Ass, Karte.Kreuz_Dame, Karte.Kreuz_Drei, Karte.Kreuz_Fünf, Karte.Kreuz_Junge, Karte.Kreuz_König, Karte.Kreuz_Neun, Karte.Kreuz_Sechs, Karte.Kreuz_Sieben, Karte.Kreuz_Vier, Karte.Kreuz_Zehn, Karte.Kreuz_Zwei, Karte.Pik_Acht, Karte.Pik_Ass, Karte.Pik_Dame, Karte.Pik_Drei, Karte.Pik_Fünf, Karte.Pik_Junge, Karte.Pik_König, Karte.Pik_Neun, Karte.Pik_Sechs, Karte.Pik_Sieben, Karte.Pik_Vier, Karte.Pik_Zehn, Karte.Pik_Zwei };
        Queue<Karte> _karten = new Queue<Karte>();
        public int Count { get { return _karten.Count; } }

        public Kartenhaufen()
        {
            // Geben und Mischen aller Karten
            KartenGeben();
            //Mischen();
        }

        private void Shuffle<T>(IList<T> ilist)
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
        private void KartenGeben()
        {
            _karten.Clear();
            foreach (var item in _blatt)
                _karten.Enqueue(item);
        }
        public void Mischen()
        {
            Karte[] d = new Karte[_karten.Count];
            d = _karten.ToArray();
            Shuffle<Karte>(d);
            _karten.Clear();
            foreach (var item in d)
                _karten.Enqueue(item);
        }

        public void KarteEinfügen(Karte karte)
        {
            _karten.Enqueue(karte);
        }

        public Karte GetCard()
        {
            return _karten.Dequeue();
        }
    }
}
