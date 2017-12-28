using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        SpielfeldHäufchen spiel = new SpielfeldHäufchen();
        List<RadioButton> comboBoxListAblage = new List<RadioButton>();
        int _handIndex = 0;

        public Form1()
        {
            InitializeComponent();
            //  ShowInfos();
        }

        private void AddComboBox(string text, int i)
        {
            RadioButton combo = new RadioButton();
            combo.Text = text;
            combo.Width = 400;
            combo.Tag = 6 + i;
            combo.CheckedChanged += new EventHandler(combo_CheckedChanged);
            int anz = comboBoxListAblage.Count;
            combo.Location = new Point(0, 0 + 27 * i);
            panel1.Controls.Add(combo);
            comboBoxListAblage.Add(combo);
            Refresh();
        }
        private void combo_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                _handIndex = (int)((RadioButton)sender).Tag;
            label2.Text = _handIndex.ToString();
        }
        private void SetTextCombo(int index, string text)
        {
            switch (index)
            {
                case 0:
                    Karte1.Text = text;
                    break;
                case 1:
                    Karte2.Text = text;
                    break;
                case 2:
                    Karte3.Text = text;
                    break;
                case 3:
                    Karte4.Text = text;
                    break;
                case 4:
                    Karte5.Text = text;
                    break;
            }
        }
        private void ShowInfos()
        {
            for (int i = 0; i < spiel.AktuellerSpieler.Hand.Count; i++)
                SetTextCombo(i, spiel.AktuellerSpieler.Hand[i].ToString().Replace('_', ' '));
            label7.Text = "Stapel: " + spiel.Kartenstapel.Count.ToString() + " Karten";
            if (spiel.Häufchen.Count > 0)
            {
                label2.Text = "Häufchen 1:\n       \\|/\n";
                foreach (var s in spiel.Häufchen[0].Karten)
                    label2.Text += s.ToString().Replace('_', ' ') + "\n";
            }
            panel1.Controls.Clear();
            for (int i = 0; i < spiel.AktuellerSpieler.Ablage.Count; i++)
                AddComboBox(spiel.AktuellerSpieler.Ablage[i].ToString().Replace('_', ' '), i);
            label1.Text = "";
            if (spiel.AktuellerSpieler.Home.Count > 0)
                radioButton1.Text = spiel.AktuellerSpieler.Home[spiel.AktuellerSpieler.Home.Count - 1].ToString().Replace('_', ' ') + " (noch " + (spiel.AktuellerSpieler.Home.Count) + ")";
            else
                MessageBox.Show("Sie haben gewonnen!");
            Karte1.Checked = true;
            _handIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            spiel.Kartenstapel.Mischen();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (_handIndex >= 6) spiel.KarteAblegen(Kartenquelle.Ablage, _handIndex - 6, 0);
            else if (_handIndex == 5) spiel.KarteAblegen(Kartenquelle.Home, spiel.AktuellerSpieler.Home.Count - 1, 0);
            else spiel.KarteAblegen(Kartenquelle.Hand, _handIndex, 0);
            ShowInfos();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            spiel.InAblageLegen(_handIndex);
            ShowInfos();
        }

        #region karte Checked Change
        private void Karte1_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                _handIndex = 0;
        }

        private void Karte2_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                _handIndex = 1;
        }

        private void Karte3_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                _handIndex = 2;
        }

        private void Karte4_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                _handIndex = 3;
        }

        private void Karte5_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                _handIndex = 4;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<SpielerN> l = new List<SpielerN>();
            l.Add(new SpielerN("A"));
            l.Add(new SpielerN("B"));
            l.Add(new SpielerN("C"));
            l.Add(new SpielerN("D"));
            Game g = new Game(l);
            g.SpielerChanged += new Action<SpielerN>(g_SpielerChanged);
            g.StartGame();
        }

        void g_SpielerChanged(SpielerN obj)
        {
            if (MessageBox.Show("Weiter " + obj.Name + "?") == System.Windows.Forms.DialogResult.OK)
                obj.Fertig();
        }

        //private void radioButton1_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (((RadioButton)sender).Checked)
        //        _handIndex = 5;
        //}
        #endregion    }
    }
}