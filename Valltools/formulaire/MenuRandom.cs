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
        public MenuRandom(string url)
        {
            InitializeComponent();
            Text = url;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WIP : Generate");
        }
    }
}
