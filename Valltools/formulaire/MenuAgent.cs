using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Valltools.formulaire
{
    public partial class MenuAgent : Form
    {
        public MenuAgent(string url)
        {
            InitializeComponent();
            Text = url;
        }

        private void btnAllAgent_Click(object sender, EventArgs e)
        {
            var menuRandom = new MenuRandom(Text + "/AllAgent");
            menuRandom.ShowDialog();
        }

        private void btnDuellist_Click(object sender, EventArgs e)
        {
            var menuRandom = new MenuRandom(Text + "/Duellist");
            menuRandom.ShowDialog();
        }

        private void btnSentinelle_Click(object sender, EventArgs e)
        {
            var menuRandom = new MenuRandom(Text + "/Sentinelle");
            menuRandom.ShowDialog();
        }

        private void btnInitiateur_Click(object sender, EventArgs e)
        {
            var menuRandom = new MenuRandom(Text + "/Initiateur");
            menuRandom.ShowDialog();
        }

        private void btnSmoker_Click(object sender, EventArgs e)
        {
            var menuRandom = new MenuRandom(Text + "/Smoker");
            menuRandom.ShowDialog();
        }

        private void btnFilteredAgent_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WIP : Filtered Agent");
        }
    }
}
