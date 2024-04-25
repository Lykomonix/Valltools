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
            MenuMap menuMap = new MenuMap(Text + "/Map");
            menuMap.ShowDialog();
        }

        private void btnAgent_Click(object sender, EventArgs e)
        {
            MenuAgent menuAgent = new MenuAgent(Text + "/Agent");
            menuAgent.ShowDialog();
        }
    }
}
