using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Valltools.Utils;

namespace Valltools.formulaire
{
    public partial class MenuRandom : Form
    {
        private RandomReturn randomReturn; 
        public MenuRandom(string url, string[] listRandom)
        {
            InitializeComponent();
            Text = url;
            randomReturn = new RandomReturn(listRandom);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var Result = randomReturn.getOne();
            lblName.Text = Result.ToString();
        }
    }
}
