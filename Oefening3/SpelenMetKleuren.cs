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


        public static List<Rechthoek> rechthoeken = new List<Rechthoek>();
        
        
       
        public SpelenMetKleuren()
        {
            InitializeComponent();
        }

        private void btn_rechthoek_toevoegen_Click(object sender, EventArgs e)
        {
            Rechthoek rechthoek = new Rechthoek();
            rechthoek.MdiParent = this;
            rechthoeken.Add(rechthoek);
            rechthoeken[rechthoeken.Count-1].Show();
        }

        private void btn_rechthoek_verwijderen_Click(object sender, EventArgs e)
        {
            if (rechthoeken.Count != 0)
            {
                rechthoeken[rechthoeken.Count - 1].Close();
                rechthoeken.RemoveAt(rechthoeken.Count - 1);
            }
            else {
                MessageBox.Show("Er zijn geen rechthoeken meer!");
            }
            
        }
    }
}
