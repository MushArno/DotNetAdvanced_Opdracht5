namespace Oefening3
{
    partial class SpelenMetKleuren
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_rechthoek_toevoegen = new System.Windows.Forms.Button();
            this.btn_rechthoek_verwijderen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_rechthoek_toevoegen
            // 
            this.btn_rechthoek_toevoegen.Location = new System.Drawing.Point(12, 12);
            this.btn_rechthoek_toevoegen.Name = "btn_rechthoek_toevoegen";
            this.btn_rechthoek_toevoegen.Size = new System.Drawing.Size(150, 23);
            this.btn_rechthoek_toevoegen.TabIndex = 1;
            this.btn_rechthoek_toevoegen.Text = "Rechthoek Toevoegen";
            this.btn_rechthoek_toevoegen.UseVisualStyleBackColor = true;
            this.btn_rechthoek_toevoegen.Click += new System.EventHandler(this.btn_rechthoek_toevoegen_Click);
            // 
            // btn_rechthoek_verwijderen
            // 
            this.btn_rechthoek_verwijderen.Location = new System.Drawing.Point(168, 12);
            this.btn_rechthoek_verwijderen.Name = "btn_rechthoek_verwijderen";
            this.btn_rechthoek_verwijderen.Size = new System.Drawing.Size(150, 23);
            this.btn_rechthoek_verwijderen.TabIndex = 2;
            this.btn_rechthoek_verwijderen.Text = "Rechthoek Verwijderen";
            this.btn_rechthoek_verwijderen.UseVisualStyleBackColor = true;
            // 
            // SpelenMetKleuren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_rechthoek_verwijderen);
            this.Controls.Add(this.btn_rechthoek_toevoegen);
            this.IsMdiContainer = true;
            this.Name = "SpelenMetKleuren";
            this.Text = "SpelenMetKleuren";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_rechthoek_toevoegen;
        private Button btn_rechthoek_verwijderen;
    }
}