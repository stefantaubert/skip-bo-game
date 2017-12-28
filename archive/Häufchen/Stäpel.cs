using System;
using System.Collections.Generic;
using System.Text;

class Stapel
{
    public enum Aktion
    {
        Voll,
        Unpassend,
        Passend,
        NeuerStapel
    }

    List<Karte> stapel = new List<Karte>();
    public List<Karte> StapelProperty { get { return stapel; } set { stapel = value; } }

    private Karte GetLastKarte()
    {
        return stapel[stapel.Count - 1];
    }
    private Karte GetPreLastKarte()
    {
        return stapel[stapel.Count - 2];
    }

    private string GetRang(Karte karte)
    {
        return karte.ToString().Substring(karte.ToString().IndexOf("_") + 1, karte.ToString().Length - karte.ToString().IndexOf("_") - 1);
    }
    private List<string> ConvertToList(string[] array)
    {
        List<string> ausg = new List<string>();
        for (int i = 0; i < array.Length; i++)
            ausg.Add(array[i]);
        return ausg;
    }

    private bool IstNachfolger(Karte karte)
    {
        string[] rangordnung = new string[] { "Ass", "Zwei", "Drei", "Vier", "Fünf", "Sechs", "Sieben", "Acht", "Neun", "Zehn", "Junge", "Dame", "König" };
        string letztekarteRang = GetRang(GetLastKarte());

        // wenn ein Joker gelegt wird
        if (GetRang(karte).Contains("Joker") && !GetRang(GetLastKarte()).Contains("Joker"))
            return true;
        else if (GetRang(karte).Contains("Joker") && GetRang(GetLastKarte()).Contains("Joker"))
            return false;
        // wenn ein Joker liegt
        else if (GetRang(GetLastKarte()).Contains("Joker") && !GetRang(karte).Contains("Joker"))
        {
            // Wenn ein Joker liegt der nicht als Ass gilt
            if (stapel.Count > 2 && GetPreLastKarte().ToString() == rangordnung[ConvertToList(rangordnung).IndexOf(GetRang(karte)) - 2])
                return true;
            // Wenn ein Joker als Ass liegt
            else if (stapel.Count == 1 && GetRang(karte) == "Zwei")
                return true;
            else
                return false;
        }
        // normaler Nachfolger
        else if (letztekarteRang == rangordnung[ConvertToList(rangordnung).IndexOf(GetRang(karte)) - 1])
            return true;
        else
            return false;
    }

    public Aktion AddKarte(Karte karte)
    {
        int lenght = stapel.Count;

        // Ein leerer Stapel und es wird keine gültige karte gelegt
        if (stapel.Count == 0 && karte != Karte.Herz_Ass && karte != Karte.Karo_Ass && karte != Karte.Pik_Ass && karte != Karte.Kreuz_Ass && !GetRang(karte).Contains("Joker"))
            return Aktion.Unpassend;
        // Wenn Ein Ass gelegt wird
        else if (karte == Karte.Herz_Ass || karte == Karte.Pik_Ass || karte == Karte.Karo_Ass || karte == Karte.Kreuz_Ass || (GetRang(karte).Contains("Joker") && stapel.Count == 0))
        {
            stapel.Add(karte);
            return Aktion.NeuerStapel;
        }
        // Wenn es die letzte Karte von einem Stapel ist
        else if (karte == Karte.Kreuz_König || karte == Karte.Karo_König || karte == Karte.Pik_König || karte == Karte.Herz_König || (karte == Karte.Joker1 && lenght == 12) || (karte == Karte.Joker2 && lenght == 12) || (karte == Karte.Joker3 && lenght == 12) || (karte == Karte.Joker4 && lenght == 12) || (karte == Karte.Joker5 && lenght == 12) || (karte == Karte.Joker6 && lenght == 12))
        {
            stapel.Add(karte);
            return Aktion.Voll;
        }
        else if (GetRang(karte).Contains("Joker") && stapel.Count == 12)
        {
            stapel.Add(karte);
            return Aktion.Voll;
        }
        else
        {
            if (karte != Karte.Leer && IstNachfolger(karte))
            {
                stapel.Add(karte);
                return Aktion.Passend;
            }
            else
                return Aktion.Unpassend;
        }
    }
}