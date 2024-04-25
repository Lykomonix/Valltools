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
        private string[] ListRandom;
        public MenuAgent(string url)
        {
            InitializeComponent();
            Text = url;
        }

        private void btnAllAgent_Click(object sender, EventArgs e)
        {
            ListRandom = new string[] { "Astra", "Breach", "Brimstone", "Chamber", "Cypher", "Deadlock", "Fade", "Gekko", "Harbor", "Jett", "Kayo", "Killjoy", "Neon", "Omen", "Pheonix", "Raze", "Reyna", "Sage", "Sova", "Skye", "Viper", "Yoru" };
            var menuRandom = new MenuRandom(Text + "/AllAgent", ListRandom);
            menuRandom.ShowDialog();
        }

        private void btnDuellist_Click(object sender, EventArgs e)
        {
            ListRandom = new string[] { "Jett", "Neon", "Pheonix", "Raze", "Reyna", "Yoru" };
            var menuRandom = new MenuRandom(Text + "/Duellist", ListRandom);
            menuRandom.ShowDialog();
        }

        private void btnSentinelle_Click(object sender, EventArgs e)
        {
            ListRandom = new string[] { "Chamber", "Cypher", "Deadlock",  "Killjoy", "Sage" };
            var menuRandom = new MenuRandom(Text + "/Sentinelle", ListRandom);
            menuRandom.ShowDialog();
        }

        private void btnInitiateur_Click(object sender, EventArgs e)
        {
            ListRandom = new string[] { "Breach", "Fade", "Gekko", "Kayo", "Sova", "Skye" };
            var menuRandom = new MenuRandom(Text + "/Initiateur", ListRandom);
            menuRandom.ShowDialog();
        }

        private void btnSmoker_Click(object sender, EventArgs e)
        {
            ListRandom = new string[] { "Astra", "Brimstone", "Harbor", "Omen", "Viper" };
            var menuRandom = new MenuRandom(Text + "/Smoker", ListRandom);
            menuRandom.ShowDialog();
        }

        private void btnFilteredAgent_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WIP : Filtered Agent");
        }
    }
}
