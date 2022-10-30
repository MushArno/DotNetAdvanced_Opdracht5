namespace Oefening3
{
    partial class ColourDialogue
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
            this.ud_alpha = new System.Windows.Forms.NumericUpDown();
            this.ud_red = new System.Windows.Forms.NumericUpDown();
            this.ud_green = new System.Windows.Forms.NumericUpDown();
            this.ud_blue = new System.Windows.Forms.NumericUpDown();
            this.label_alpha = new System.Windows.Forms.Label();
            this.label_red = new System.Windows.Forms.Label();
            this.label_green = new System.Windows.Forms.Label();
            this.label_blue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ud_alpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_blue)).BeginInit();
            this.SuspendLayout();
            // 
            // ud_alpha
            // 
            this.ud_alpha.Location = new System.Drawing.Point(58, 12);
            this.ud_alpha.Name = "ud_alpha";
            this.ud_alpha.Size = new System.Drawing.Size(120, 23);
            this.ud_alpha.TabIndex = 0;
            // 
            // ud_red
            // 
            this.ud_red.Location = new System.Drawing.Point(58, 41);
            this.ud_red.Name = "ud_red";
            this.ud_red.Size = new System.Drawing.Size(120, 23);
            this.ud_red.TabIndex = 1;
            // 
            // ud_green
            // 
            this.ud_green.Location = new System.Drawing.Point(58, 70);
            this.ud_green.Name = "ud_green";
            this.ud_green.Size = new System.Drawing.Size(120, 23);
            this.ud_green.TabIndex = 2;
            // 
            // ud_blue
            // 
            this.ud_blue.Location = new System.Drawing.Point(58, 99);
            this.ud_blue.Name = "ud_blue";
            this.ud_blue.Size = new System.Drawing.Size(120, 23);
            this.ud_blue.TabIndex = 3;
            // 
            // label_alpha
            // 
            this.label_alpha.AutoSize = true;
            this.label_alpha.Location = new System.Drawing.Point(14, 14);
            this.label_alpha.Name = "label_alpha";
            this.label_alpha.Size = new System.Drawing.Size(38, 15);
            this.label_alpha.TabIndex = 4;
            this.label_alpha.Text = "Alpha";
            // 
            // label_red
            // 
            this.label_red.AutoSize = true;
            this.label_red.Location = new System.Drawing.Point(14, 43);
            this.label_red.Name = "label_red";
            this.label_red.Size = new System.Drawing.Size(27, 15);
            this.label_red.TabIndex = 5;
            this.label_red.Text = "Red";
            // 
            // label_green
            // 
            this.label_green.AutoSize = true;
            this.label_green.Location = new System.Drawing.Point(14, 72);
            this.label_green.Name = "label_green";
            this.label_green.Size = new System.Drawing.Size(38, 15);
            this.label_green.TabIndex = 6;
            this.label_green.Text = "Green";
            // 
            // label_blue
            // 
            this.label_blue.AutoSize = true;
            this.label_blue.Location = new System.Drawing.Point(14, 101);
            this.label_blue.Name = "label_blue";
            this.label_blue.Size = new System.Drawing.Size(30, 15);
            this.label_blue.TabIndex = 7;
            this.label_blue.Text = "Blue";
            // 
            // ColourDialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(199, 134);
            this.ControlBox = false;
            this.Controls.Add(this.label_blue);
            this.Controls.Add(this.label_green);
            this.Controls.Add(this.label_red);
            this.Controls.Add(this.label_alpha);
            this.Controls.Add(this.ud_blue);
            this.Controls.Add(this.ud_green);
            this.Controls.Add(this.ud_red);
            this.Controls.Add(this.ud_alpha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ColourDialogue";
            ((System.ComponentModel.ISupportInitialize)(this.ud_alpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ud_blue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown ud_alpha;
        private NumericUpDown ud_red;
        private NumericUpDown ud_green;
        private NumericUpDown ud_blue;
        private Label label_alpha;
        private Label label_red;
        private Label label_green;
        private Label label_blue;
    }
}