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
    public partial class MenuMap : Form
    {
        private string[] ListRandom;
        public MenuMap(string url)
        {
            InitializeComponent();
            Text = url;
        }

        private void btnRanked_Click(object sender, EventArgs e)
        {
            ListRandom = new string[] { "Ascent", "Bind", "Breeze","Icebox", "Lotus", "Split", "Sunset" };
            var menuRandom = new MenuRandom(Text + "/RankedMapPool", ListRandom);
            menuRandom.ShowDialog();
        }

        private void btnAllMap_Click(object sender, EventArgs e)
        {
            ListRandom = new string[] { "Ascent", "Bind", "Breeze", "Fracture", "Haven", "Icebox", "Lotus", "Pearl", "Split", "Sunset" };
            var menuRandom = new MenuRandom(Text + "/AllMapPool", ListRandom);
            menuRandom.ShowDialog();
        }

        private void btnFilteredMap_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WIP : Filtered Map Pool");
        }
    }
}
