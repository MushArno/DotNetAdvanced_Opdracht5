using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening3
{
    public partial class SpelenMetKleuren : Form
    {
        public SpelenMetKleuren()
        {
            InitializeComponent();
        }

        private void btn_rechthoek_toevoegen_Click(object sender, EventArgs e)
        {
            Rechthoek rechthoek = new Rechthoek();
            rechthoek.MdiParent = this;
            rechthoek.Show();
        }
    }
}
