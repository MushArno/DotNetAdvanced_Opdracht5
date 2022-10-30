using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening2
{
    
    public partial class ChildForm : Form
    {
        public decimal gemiddelde = 0;
        public ChildForm()
        {
            InitializeComponent();
        }

        private void ChildForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_nieuw_getal_Click(object sender, EventArgs e)
        {
            int input = int.Parse(Interaction.InputBox("Waarde: "));
            Gemiddelde.Items.Add(input);

            int amount = Gemiddelde.Items.Count;
            gemiddelde = 0;
            for (int i = 0; i < amount; i++) {
                gemiddelde += Convert.ToInt16(Gemiddelde.Items[i]);
                
            }
            
            gemiddelde = gemiddelde / amount;
            tb_output_gemiddelde.Text = gemiddelde.ToString();
        }
    }
}
