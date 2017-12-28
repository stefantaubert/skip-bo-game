using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class SpielfeldHäufchen
    {
        // Aktueller Spieler
        int _playerIndex = -1;
        Spieler _aktPlayer;
        public Spieler AktuellerSpieler { get { return _aktPlayer; } }

        // Spieler
        // Häufchen
        // Kartenstapel
        List<Spieler> _player = new List<Spieler>();
        Kartenhaufen _karten = new Kartenhaufen();
        List<Häufchen> _häufchen = new List<Häufchen>();
        public Kartenhaufen Kartenstapel { get { return _karten; } }
        public List<Häufchen> Häufchen { get { return _häufchen; } }

        public SpielfeldHäufchen()
        {
            // Spieler1
         //   _player.Add(new Spieler(_karten));
            // Spieler2
           // _player.Add(new Spieler(_karten));
        //    NächsterSpieler();
        }

        private void NächsterSpieler()
        {
            _playerIndex++;
            if (_playerIndex >= _player.Count)
                _playerIndex = 0;
            _aktPlayer = _player[_playerIndex];
        }
        private bool IsAss(Karte karte)
        {
            string rang = karte.ToString().Substring(karte.ToString().IndexOf("_") + 1, karte.ToString().Length - karte.ToString().IndexOf("_") - 1);
            if (rang == "Ass" || rang.Contains("Joker"))
                return true;
            else return false;
        }

        public Aktion KarteAblegen(Kartenquelle kartenquelle, int index, int indexHäufchen)
        {
            Häufchen _aktHäufchen;
            Karte karte = _aktPlayer.GetCard(kartenquelle, index);
            if (IsAss(karte))
            {
                _häufchen.Add(new Häufchen());
                _aktHäufchen = _häufchen[_häufchen.Count - 1];
            }
            else
            {
                if (_häufchen.Count == 0)
                {
                    MessageBox.Show("Diese Karte kann nicht gelegt werden!");
                    return Aktion.Unpassend;
                }
                if (indexHäufchen >= _häufchen.Count)
                    indexHäufchen = 0;
                _aktHäufchen = _häufchen[indexHäufchen];
            }
            Aktion aktion = _aktHäufchen.AddKarte(karte);
            switch (aktion)
            {
                // Neuer Stapel
                case Aktion.NeuerStapel:
                    _aktPlayer.RemoveCard(kartenquelle, index);
                    //NächsterSpieler();
                    break;
                // Karte Passt
                case Aktion.Passend:
                    _aktPlayer.RemoveCard(kartenquelle, index);
                    //NächsterSpieler();
                    break;
                // Karte Passt nicht
                case Aktion.Unpassend:
                    MessageBox.Show("Diese Karte kann nicht auf diesen Stapel gelegt werden!");
                    break;
                // Voller Stapel
                case Aktion.Voll:
                    foreach (var item in _aktHäufchen.Karten)
                        _karten.KarteEinfügen(item);
                    _häufchen.RemoveAt(indexHäufchen);
                    MessageBox.Show("Der Stapel ist voll. Er wurde nun entfernt und eingemischt.");
                    //NächsterSpieler();
                    break;
            }
            return aktion;
        }
       
        public bool InAblageLegen(int index)
        {
            return _aktPlayer.InsertCard(index, _karten);
        }
    }
}