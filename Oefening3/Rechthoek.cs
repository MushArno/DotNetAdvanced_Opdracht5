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
    public partial class Rechthoek : Form
    {
        public Rechthoek()
        {
            InitializeComponent();
        }

        private void Rechthoek_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void Rechthoek_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
