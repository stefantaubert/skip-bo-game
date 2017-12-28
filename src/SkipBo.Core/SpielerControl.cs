using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SkipBo;

namespace SkipBo.Core
{
    public partial class SpielerControl : UserControl
    {
        Mitspieler _ms;
        public SpielerControl()
        {
            InitializeComponent();
            splitContainer1_SizeChanged(null, null);
        }
        public void SpielerZuweisen(Mitspieler ms, bool amZug)
        {
            _ms = ms;
            listView1.Columns[0].Text = _ms.name + (amZug ? " [am Zug]" : "");
            splitContainer1.Visible = listView1.Enabled = !_ms.IsPC;
            listView1.Size = _ms.IsPC ? Size : listView1.Size;
            Aktualisieren();
        }

        private void Aktualisieren()
        {
            listView1.Groups.Clear();
            listView1.Items.Clear();
            for (int i = 0; i < _ms.Bezeichnungen.Count; i++)
            {
                listView1.Groups.Add(new ListViewGroup(_ms.Bezeichnungen[i]));
                if (_ms.IsPC && i == Controller.IndHand)
                    continue;
                for (int j = 0; j < _ms.Cards[i].Count; j++)
                {//_ms.Cards[i].Count - 1 -
                    int ind = j; // warum von oben?
                    ListViewItem li = new ListViewItem(_ms.Cards[i][ind].ToString());
                    li.Tag = ind;
                    li.Group = listView1.Groups[i];
                    listView1.Items.Add(li);
                    if (i == Controller.IndHome) break; // stoppt bei Der Home ausgabe nach dem obersten Item 
                }
            }
            listView1_ItemSelectionChanged(null, null);
        }

        private void button_Click(object sender, EventArgs e)
        {
            Controller.LegeAb(listView1.Groups.IndexOf(listView1.SelectedItems[0].Group), (int)listView1.SelectedItems[0].Tag, ((Button)sender) == button1);
            Aktualisieren();
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e == null) { button1.Enabled = button2.Enabled = false; return; }
            button1.Enabled = !_ms.IsPC && (e.IsSelected && e.Item.Group == listView1.Groups[Controller.IndHand]);
            button2.Enabled = !_ms.IsPC && e.IsSelected;
            //if ((int)e.Item.Tag
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    int ind = listView1.Groups.IndexOf(listView1.SelectedItems[0].Group);
        //    Controller.LegeAb(ind, (int)listView1.SelectedItems[0].Tag, ((Button)sender) == button1);
        //    //   Controller.LegeAb((int)listView1.SelectedItems[0].Tag, true);
        //    //if (ind == 0)
        //    //    Controller.LegeAb();
        //    //else if (ind == 1)
        //    //    Controller.LegeAb((int)listView1.SelectedItems[0].Tag, false);
        //    //else if (ind == 2)
        //    //    Controller.LegeAb((int)listView1.SelectedItems[0].Tag);
        //    Aktualisieren();
        //}

        private void splitContainer1_SizeChanged(object sender, EventArgs e)
        {
            listView1.Columns[0].Width = listView1.Width - 25;
            splitContainer1.SplitterDistance = splitContainer1.Width / 2;
        }
    }
}
