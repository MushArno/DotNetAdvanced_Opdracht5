namespace Oefening2
{
    partial class ChildForm
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
            this.Gemiddelde = new System.Windows.Forms.ListBox();
            this.label_gemiddelde = new System.Windows.Forms.Label();
            this.tb_output_gemiddelde = new System.Windows.Forms.TextBox();
            this.btn_nieuw_getal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Gemiddelde
            // 
            this.Gemiddelde.FormattingEnabled = true;
            this.Gemiddelde.ItemHeight = 15;
            this.Gemiddelde.Location = new System.Drawing.Point(12, 12);
            this.Gemiddelde.Name = "Gemiddelde";
            this.Gemiddelde.Size = new System.Drawing.Size(528, 169);
            this.Gemiddelde.TabIndex = 0;
            // 
            // label_gemiddelde
            // 
            this.label_gemiddelde.AutoSize = true;
            this.label_gemiddelde.Location = new System.Drawing.Point(12, 235);
            this.label_gemiddelde.Name = "label_gemiddelde";
            this.label_gemiddelde.Size = new System.Drawing.Size(71, 15);
            this.label_gemiddelde.TabIndex = 1;
            this.label_gemiddelde.Text = "Gemiddelde";
            // 
            // tb_output_gemiddelde
            // 
            this.tb_output_gemiddelde.Location = new System.Drawing.Point(12, 253);
            this.tb_output_gemiddelde.Name = "tb_output_gemiddelde";
            this.tb_output_gemiddelde.ReadOnly = true;
            this.tb_output_gemiddelde.Size = new System.Drawing.Size(528, 23);
            this.tb_output_gemiddelde.TabIndex = 2;
            // 
            // btn_nieuw_getal
            // 
            this.btn_nieuw_getal.Location = new System.Drawing.Point(12, 187);
            this.btn_nieuw_getal.Name = "btn_nieuw_getal";
            this.btn_nieuw_getal.Size = new System.Drawing.Size(120, 23);
            this.btn_nieuw_getal.TabIndex = 3;
            this.btn_nieuw_getal.Text = "Nieuw Getal";
            this.btn_nieuw_getal.UseVisualStyleBackColor = true;
            this.btn_nieuw_getal.Click += new System.EventHandler(this.btn_nieuw_getal_Click);
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 295);
            this.Controls.Add(this.btn_nieuw_getal);
            this.Controls.Add(this.tb_output_gemiddelde);
            this.Controls.Add(this.label_gemiddelde);
            this.Controls.Add(this.Gemiddelde);
            this.Name = "ChildForm";
            this.Text = "ChildForm";
            this.Load += new System.EventHandler(this.ChildForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox Gemiddelde;
        private Label label_gemiddelde;
        private TextBox tb_output_gemiddelde;
        private Button btn_nieuw_getal;
    }
}