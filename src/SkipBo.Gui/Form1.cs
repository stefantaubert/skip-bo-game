using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SkipBo;
using SkipBo.Core;

namespace SkipBo.Gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Controller.SpielerChanged += new Action<int>(Controller_SpielerChanged);
            Controller.AddMitspieler("Spieler 1", false);
            Controller.AddMitspieler("Computer", true);
            Controller.StartGame();
            // spielerControl1.SpielerZuweisen(Controller.aktuellerSpieler);
        }

        void Controller_SpielerChanged(int obj)
        {
            spielerControl1.SpielerZuweisen(Controller._mitspieler[0], obj == 0);
            spielerControl2.SpielerZuweisen(Controller._mitspieler[1], obj == 1);
        }
    }
}