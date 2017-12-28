using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Spieler
    {
        public event Action<Spieler> AktionBeendet;

        List<Karte> _hand = new List<Karte>();
        List<Karte> _ablage = new List<Karte>();
        List<Karte> _home = new List<Karte>();

        public List<Karte> Hand { get { return _hand; } }
        public List<Karte> Ablage { get { return _ablage; } }
        public List<Karte> Home { get { return _home; } }

        public Spieler()
        {
            //Get10KartenHome(karten);
            //Get5KartenSpieler(karten);
        }

        public void ZieheKarten()
        {

        }

        public void ZieheHomeKarten()
        {

        }

        private void Get10KartenHome(Kartenhaufen karten)
        {
            for (int i = 0; i < 10; i++)
                _home.Add(karten.GetCard());
        }
        private void Get5KartenSpieler(Kartenhaufen karten)
        {
            int lenght = 0;
            List<Karte> tmp;
            tmp = _hand;

            foreach (var item in tmp)
                if (item != Karte.Leer) lenght++;
            if (karten.Count > 5)
                for (int i = 0; i < 5 - lenght; i++)
                {
                    tmp.Remove(Karte.Leer);
                    tmp.Add(karten.GetCard());
                }
        }

        public void RemoveCard(Kartenquelle kartenQuelle, int index)
        {
            List<Karte> list;
            switch (kartenQuelle)
            {
                case Kartenquelle.Hand:
                    list = _hand;
                    list.RemoveAt(index);
                    list.Insert(index, Karte.Leer);
                    break;
                case Kartenquelle.Ablage:
                    list = _ablage;
                    list.RemoveAt(index);
                    break;
                default:
                    list = _home;
                    if (list.Count - 1 > 0)
                        list.RemoveAt(list.Count - 1);
                    else
                        MessageBox.Show("Sie haben gewonnen");
                    break;
            }

        }
        public Karte GetCard(Kartenquelle kartenQuelle, int index)
        {
            switch (kartenQuelle)
            {
                case Kartenquelle.Hand:
                    return _hand[index];
                case Kartenquelle.Ablage:
                    return _ablage[index];
                default:
                    if (_home.Count - 1 > 0)
                        return _home[_home.Count - 1];
                    else
                        MessageBox.Show("Sie haben gewonnen");
                    return Karte.Leer;
            }
        }
        public bool InsertCard(int indexOfHand, Kartenhaufen karten)
        {
            if (_hand[indexOfHand] != Karte.Leer)
            {
                _ablage.Add(_hand[indexOfHand]);
                RemoveCard(Kartenquelle.Hand, indexOfHand);
                Get5KartenSpieler(karten);
                return true;
            }
            else
            {
                MessageBox.Show("Diese Karte kann nicht in die Ablage gelegt werden!");
                return false;
            }
        }
    }
}
public enum Kartenquelle
{
    Hand,
    Ablage,
    Home
}
