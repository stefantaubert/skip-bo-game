using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SkipBo.Core
{
    public static class Controller
    {
        public const int AnzZiehenHand = 5, AnzZiehenHome = 10, IndHome = 0, IndHand = 1, IndAblage = 2;
        static int _aktInd = 0;
        const string WrongCardMessage = "Falsche Karte!";
        static public List<Mitspieler> _mitspieler = new List<Mitspieler>();
        static public Mitspieler aktuellerSpieler { get { return _mitspieler.Count == 0 ? null : _mitspieler[_aktInd]; } set { if (_mitspieler.Count != 0) _mitspieler[_aktInd] = value; } }
        static public event Action<int> SpielerChanged;

        public static void AddMitspieler(string name, bool computer)
        {
            _mitspieler.Add(new Mitspieler(computer) { name = name });
            _aktInd = _mitspieler.Count - 1;
            FülleHome();
        }

        public static void StartGame()
        {
            _aktInd = -1;
            //if (_mitspieler.Count < 2) return;
            NächsterSpieler();
        }

        private static void NächsterSpieler()
        {
            _aktInd++;
            if (_aktInd == _mitspieler.Count) _aktInd = 0;
            FülleHand();
            if (SpielerChanged != null) SpielerChanged(_aktInd);
            if (aktuellerSpieler.IsPC)
            {
                KI.DoWork();
            }
        }

        static public void Ini() // Kommt dann weg
        {
            FülleHome();
            FülleHand();
        }
        // Davor muss der Index gesetzt werden
        static private void FülleHand()
        {
            aktuellerSpieler.Cards[IndHand].AddRange(Kartenverwaltung.GetKarten(AnzZiehenHand - aktuellerSpieler.Cards[IndHand].Count));
        }
        // Davor muss der Index gesetzt werden
        static private void FülleHome()
        {
            aktuellerSpieler.Cards[IndHome].AddRange(Kartenverwaltung.GetKarten(AnzZiehenHome - aktuellerSpieler.Cards[IndHome].Count));
        }

        static public void LegeAb(int group, int index, bool inAblage)
        {
            try
            {
                switch (group)
                {
                    case IndAblage:
                        LegeAb(index);
                        break;
                    case IndHand:
                        LegeAb(index, inAblage);
                        break;
                    case IndHome:
                        LegeAb();
                        break;
                    default: break;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        //von Ablage
        static private void LegeAb(int ablageIndex)
        {
            if (Kartenverwaltung.AddToStapel(aktuellerSpieler.Cards[IndAblage][ablageIndex]))
            {
                aktuellerSpieler.Cards[IndAblage].RemoveAt(ablageIndex);
            }
            else throw new Exception(WrongCardMessage);
            // event auslösen immer wenn LegeAb
        }

        //von Hand
        static private void LegeAb(int handIndex, bool inAblage)
        {
            if (inAblage)
            {
                aktuellerSpieler.Cards[IndAblage].Add(aktuellerSpieler.Cards[IndHand][handIndex]);
                aktuellerSpieler.Cards[IndHand].RemoveAt(handIndex);
                NächsterSpieler();
            }
            else if (Kartenverwaltung.AddToStapel(aktuellerSpieler.Cards[IndHand][handIndex]))
            {
                aktuellerSpieler.Cards[IndHand].RemoveAt(handIndex);
                if (aktuellerSpieler.Cards[IndHand].Count == 0)
                    FülleHand();
            }
            else
                throw new Exception(WrongCardMessage);

            //if (!inAblage && aktuellerSpieler.Cards[IndHand].Count == 0)
            //    FülleHand();
            //NächsterSpieler();
        }
        //von Home
        static private void LegeAb()
        {//aktuellerSpieler.Cards[IndHome].Count - 1
            if (Kartenverwaltung.AddToStapel(aktuellerSpieler.Cards[IndHome][0]))
            {
                aktuellerSpieler.Cards[IndHome].RemoveAt(0);
                if (aktuellerSpieler.Cards[IndHome].Count == 0) { } // gewonnen
            }
            else throw new Exception(WrongCardMessage);
        }
    }
}