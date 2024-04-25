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
        public MenuMap(string url)
        {
            InitializeComponent();
            Text = url;
        }

        private void btnRanked_Click(object sender, EventArgs e)
        {
            var menuRandom = new MenuRandom(Text + "/RankedMapPool");
            menuRandom.ShowDialog();
        }

        private void btnAllMap_Click(object sender, EventArgs e)
        {
            var menuRandom = new MenuRandom(Text + "/AllMapPool");
            menuRandom.ShowDialog();
        }

        private void btnFilteredMap_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WIP : Filtered Map Pool");
        }
    }
}
