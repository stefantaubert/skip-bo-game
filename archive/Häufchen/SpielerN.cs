using System;
using System.Collections.Generic;
using System.Text;

class SpielerN
{
    public event Action<SpielerN> AktionBeendet;
    Queue<Karten> _hand = new Queue<Karten>();
    public Queue<Karten> Hand { get { return _hand; } }
    Queue<Karten> _ablage = new Queue<Karten>();
    public Queue<Karten> Ablage { get { return _ablage; } }
    Queue<Karten> _home = new Queue<Karten>();
    public Queue<Karten> Home { get { return _home; } }

    string _name;
    public string Name { get { return _name; } set { _name = value; } }

    public SpielerN(string name)
    {
        _name = name;
    }

    public void ZieheKarten(ref Queue<Karten> haufen)
    {
        Do.GetKarten(ref haufen, ref _hand, 5);
    }

    public void ZieheHomeKarten(ref Queue<Karten> haufen)
    {
        Do.GetKarten(ref haufen, ref _home, 10);
    }

    public void KarteAblegen(ref Queue<Karten> haufen)
    {
        if (_hand.Count == 0) { }
        else if (_home.Count == 0) { }
        else if (_ablage.Count == 0) { }
    }

    public void Fertig()
    {
        if (AktionBeendet != null) AktionBeendet(this);
    }
}
