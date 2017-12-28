using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApplication1
{
    class Stapel
    {
        List<Karten> _stapelTmp = new List<Karten>();
        List<Karten> _stapel = new List<Karten>();
        public List<Karten> Cards { get { return _stapel; } set { _stapel = value; } }

        public event Action<List<Karten>> StapelKomplett;
        public event Action<Karten> FalscheKarte;

        public void Add(Karten k)
        {
            List<Karten> rangordnung = new List<Karten>() { Karten.Ass, Karten.Zwei, Karten.Drei, Karten.Vier, Karten.Fünf, Karten.Sechs, Karten.Sieben, Karten.Acht, Karten.Neun, Karten.Zehn, Karten.Bube, Karten.Dame, Karten.König, Karten.Keine };
            Karten ka = k;
            if (ka == Karten.Joker)
            {
                _stapelTmp.Add(rangordnung[_stapel.Count]);
            }
            else
            {
                int ind = -1;
                for (int i = 0; i < rangordnung.Count; i++)
                    if (rangordnung[i].ToString() == _stapelTmp[_stapelTmp.Count - 1].ToString())
                    { ind = i; break; }
                if (ka == rangordnung[ind + 1])
                {
                    _stapelTmp.Add(ka);
                }
                else
                {
                    if (FalscheKarte != null) { FalscheKarte(k); return; }
                }
            }
            _stapel.Add(ka);
            if (_stapel.Count >= rangordnung.Count && StapelKomplett != null)
            {
                StapelKomplett(_stapel);
                _stapel.Clear();
                _stapelTmp.Clear();
            }
        }
    }
}
