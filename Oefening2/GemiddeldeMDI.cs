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
using static System.Windows.Forms.DataFormats;

namespace Oefening2
{
    public partial class GemiddeldeMDI : Form
    {
        public GemiddeldeMDI()
        { 
            InitializeComponent();
            
        }

        private void GemiddeldeMDI_Load(object sender, EventArgs e)
        {
            ChildForm childForm = new ChildForm();

            childForm.MdiParent = this;
            childForm.Location = new Point(250, 150);
            childForm.Show();
            //DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

        }
    }
}
