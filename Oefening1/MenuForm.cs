namespace Oefening1
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            string DefaultFont = "Segou UI";
            TextField.Font = new Font(DefaultFont, 9);
        }

        private void ExitMenuBar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void msi_changeColourToRedClick(object sender, EventArgs e)
        {
            TextField.ForeColor = Color.Red;
        }

        private void msi_changeColourToGreen_Click(object sender, EventArgs e)
        {
            TextField.ForeColor= Color.Green;
        }

        private void msi_changeColourToBlue_Click(object sender, EventArgs e)
        {
            TextField.ForeColor = Color.Blue;
        }

        private void msi_changeColourToDefault_Click(object sender, EventArgs e)
        {
            TextField.ForeColor = Color.Black;
        }

        private void BackgroundColourRed_Click(object sender, EventArgs e)
        {
            TextField.BackColor = Color.Red;
        }

        private void BackgroundColourGreen_Click(object sender, EventArgs e)
        {
            TextField.BackColor = Color.Green;
        }

        private void BackgroundColourBlue_Click(object sender, EventArgs e)
        {
            TextField.BackColor = Color.Blue;
        }

        private void BackgroundColourDefault_Click(object sender, EventArgs e)
        {
            TextField.BackColor = Color.White;
        }

        private void FontToSmall_Click(object sender, EventArgs e)
        {
            TextField.Font = new Font("Segou UI", 6);
        }

        private void FontToNormal_Click(object sender, EventArgs e)
        {
            TextField.Font = new Font("Segou IU", 9);
        }

        private void FontToLarge_Click(object sender, EventArgs e)
        {
            TextField.Font = new Font("Segou UI", 15);
        }

        private void ResetAllSettings_Click(object sender, EventArgs e)
        {
            TextField.ForeColor = Color.Black;
            TextField.BackColor = Color.White;
            TextField.Font = new Font("Segou UI", 9);
        }
    }
}