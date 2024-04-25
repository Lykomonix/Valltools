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
    public partial class MenuRandom : Form
    {
        private string[] ListRandom; 
        public MenuRandom(string url, string[] listRandom)
        {
            InitializeComponent();
            Text = url;
            ListRandom = listRandom;
            string liste = "";
            foreach(string str in listRandom)
            {
                liste += str + " ";
            }
            lblName.Text = liste;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WIP : Generate");
        }
    }
}
