using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Valltools.formulaire;

namespace Valltools
{
    public partial class MenuHome : Form
    {
        public MenuHome()
        {
            InitializeComponent();
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WIP : Map");
            MenuMap menuMap = new MenuMap();
            menuMap.ShowDialog();
        }

        private void btnAgent_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WIP : Agent");
            MenuAgent menuAgent = new MenuAgent();
            menuAgent.ShowDialog();
        }
    }
}
