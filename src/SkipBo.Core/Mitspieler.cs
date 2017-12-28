using System;
using System.Collections.Generic;
using System.Text;

namespace SkipBo.Core
{
    public class Mitspieler
    {
        // Reihnfolge is wichtig, da bei KI erst auf home, dann auf Hand und dann ablage geprüft werden muss
        // 0=Home, 1=Hand, 2=Ablage 
        public string name;
        public bool IsPC { get; set; }

        public List<string> Bezeichnungen { get { return new List<string>() { "Häufchen (" + Cards[0].Count + ")", "Hand", "Ablage" }; } }
        //internal List<List<Karten>> _cards = new List<List<Karten>>() { new List<Karten>(), new List<Karten>(), new List<Karten>() };
        public List<List<Karten>> Cards { get; internal set; }
        public Mitspieler(bool pc)
        {
            IsPC = pc;
            Cards = new List<List<Karten>>() { new List<Karten>(), new List<Karten>(), new List<Karten>() };
        }

        //public List<Karten> _hand = new List<Karten>();
        //public List<Karten> _ablage = new List<Karten>();
        //public List<Karten> _home = new List<Karten>();
    }
}
