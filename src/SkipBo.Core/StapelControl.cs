using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SkipBo;

namespace SkipBo.Core
{
    public partial class StapelControl : UserControl
    {
        public StapelControl()
        {
            InitializeComponent();
            StapelControl_SizeChanged(null, null);
            listView1.Items.Clear();
            listView1.Items.Add(new ListViewItem(Karten.Keine.ToString()));
            listView1.Items[0].Group = listView1.Groups[0];
            Kartenverwaltung.OberstekarteChanged += new Action<Karten>(Kartenverwaltung_OberstekarteChanged);
        }

        private void Kartenverwaltung_OberstekarteChanged(Karten obj)
        {
            listView1.Items[0].Text = obj.ToString();
        }

        private void StapelControl_SizeChanged(object sender, EventArgs e)
        {
            listView1.Columns[0].Width = listView1.Width - 25;
        }
    }
}
