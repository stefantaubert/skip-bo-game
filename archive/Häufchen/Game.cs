using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApplication1
{
    class Game
    {
        Queue<Karten> _karten = new Queue<Karten>();
        List<SpielerN> _spielers = new List<SpielerN>();

        int _aktSp;
        //SpielerN _aktSp;
        //public SpielerN AktSpieler { get { return _aktSp; } set { _aktSp = value; } }
        public event Action<SpielerN> SpielerChanged;
        //    public event Action<List<Karten>> StapelChanged; 

        public Game(List<SpielerN> spielers)
        {
            if (spielers.Count < 2) return;
            for (int i = 0; i < 8; i++)
            {
                _karten.Enqueue(Karten.Ass);
                _karten.Enqueue(Karten.Acht);
                _karten.Enqueue(Karten.Bube);
                _karten.Enqueue(Karten.Dame);
                _karten.Enqueue(Karten.Drei);
                _karten.Enqueue(Karten.Fünf);
                _karten.Enqueue(Karten.König);
                _karten.Enqueue(Karten.Neun);
                _karten.Enqueue(Karten.Sechs);
                _karten.Enqueue(Karten.Sieben);
                _karten.Enqueue(Karten.Vier);
                _karten.Enqueue(Karten.Zehn);
                _karten.Enqueue(Karten.Zwei);
            }
            for (int i = 0; i < 6; i++)
                _karten.Enqueue(Karten.Joker);
            Do.Mischen(ref _karten);
            _spielers.AddRange(spielers);
        }
        public void StartGame()
        {
            for (int i = 0; i < _spielers.Count; i++)
            {
                _spielers[i].ZieheHomeKarten(ref _karten);
                _spielers[i].AktionBeendet += new Action<SpielerN>(EventSpielerAktionBeendet);
            }
            _aktSp = 0;
            if (SpielerChanged != null) SpielerChanged(_spielers[_aktSp]);
        }
        private void EventSpielerAktionBeendet(SpielerN obj)
        {
            //  Nächster Spieler
            if (_aktSp < _spielers.Count - 1) _aktSp++;
            else _aktSp = 0;
            if (SpielerChanged != null) SpielerChanged(_spielers[_aktSp]);
        }
    }
}
