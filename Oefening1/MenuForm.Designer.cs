namespace Oefening1
{
    partial class MenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBarItemForeColour = new System.Windows.Forms.ToolStripMenuItem();
            this.msi_changeToRed = new System.Windows.Forms.ToolStripMenuItem();
            this.msi_changeToGreen = new System.Windows.Forms.ToolStripMenuItem();
            this.msi_changeToBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBarBackColour = new System.Windows.Forms.ToolStripMenuItem();
            this.BackgroundColourRed = new System.Windows.Forms.ToolStripMenuItem();
            this.BackgroundColourGreen = new System.Windows.Forms.ToolStripMenuItem();
            this.BackgroundColourBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontToSmall = new System.Windows.Forms.ToolStripMenuItem();
            this.FontToNormal = new System.Windows.Forms.ToolStripMenuItem();
            this.FontToLarge = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetAllSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.TextField = new System.Windows.Forms.TextBox();
            this.MenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBar
            // 
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.formatToolStripMenuItem});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(370, 24);
            this.MenuBar.TabIndex = 0;
            this.MenuBar.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitMenuBar_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuBarItemForeColour,
            this.MenuBarBackColour,
            this.fontToolStripMenuItem,
            this.ResetAllSettings});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // MenuBarItemForeColour
            // 
            this.MenuBarItemForeColour.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msi_changeToRed,
            this.msi_changeToGreen,
            this.msi_changeToBlue});
            this.MenuBarItemForeColour.Name = "MenuBarItemForeColour";
            this.MenuBarItemForeColour.Size = new System.Drawing.Size(237, 22);
            this.MenuBarItemForeColour.Text = "Colour";
            // 
            // msi_changeToRed
            // 
            this.msi_changeToRed.Name = "msi_changeToRed";
            this.msi_changeToRed.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.msi_changeToRed.Size = new System.Drawing.Size(147, 22);
            this.msi_changeToRed.Text = "Red";
            this.msi_changeToRed.Click += new System.EventHandler(this.msi_changeColourToRedClick);
            // 
            // msi_changeToGreen
            // 
            this.msi_changeToGreen.Name = "msi_changeToGreen";
            this.msi_changeToGreen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.msi_changeToGreen.Size = new System.Drawing.Size(147, 22);
            this.msi_changeToGreen.Text = "Green";
            this.msi_changeToGreen.Click += new System.EventHandler(this.msi_changeColourToGreen_Click);
            // 
            // msi_changeToBlue
            // 
            this.msi_changeToBlue.Name = "msi_changeToBlue";
            this.msi_changeToBlue.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.msi_changeToBlue.Size = new System.Drawing.Size(147, 22);
            this.msi_changeToBlue.Text = "Blue";
            this.msi_changeToBlue.Click += new System.EventHandler(this.msi_changeColourToBlue_Click);
            // 
            // MenuBarBackColour
            // 
            this.MenuBarBackColour.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MenuBarBackColour.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackgroundColourRed,
            this.BackgroundColourGreen,
            this.BackgroundColourBlue});
            this.MenuBarBackColour.Name = "MenuBarBackColour";
            this.MenuBarBackColour.Size = new System.Drawing.Size(237, 22);
            this.MenuBarBackColour.Text = "Background Colour";
            // 
            // BackgroundColourRed
            // 
            this.BackgroundColourRed.Name = "BackgroundColourRed";
            this.BackgroundColourRed.Size = new System.Drawing.Size(105, 22);
            this.BackgroundColourRed.Text = "Red";
            this.BackgroundColourRed.Click += new System.EventHandler(this.BackgroundColourRed_Click);
            // 
            // BackgroundColourGreen
            // 
            this.BackgroundColourGreen.Name = "BackgroundColourGreen";
            this.BackgroundColourGreen.Size = new System.Drawing.Size(105, 22);
            this.BackgroundColourGreen.Text = "Green";
            this.BackgroundColourGreen.Click += new System.EventHandler(this.BackgroundColourGreen_Click);
            // 
            // BackgroundColourBlue
            // 
            this.BackgroundColourBlue.Name = "BackgroundColourBlue";
            this.BackgroundColourBlue.Size = new System.Drawing.Size(105, 22);
            this.BackgroundColourBlue.Text = "Blue";
            this.BackgroundColourBlue.Click += new System.EventHandler(this.BackgroundColourBlue_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.AccessibleDescription = "MenuBarItemFont";
            this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontToSmall,
            this.FontToNormal,
            this.FontToLarge});
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // FontToSmall
            // 
            this.FontToSmall.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FontToSmall.Name = "FontToSmall";
            this.FontToSmall.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.FontToSmall.Size = new System.Drawing.Size(193, 32);
            this.FontToSmall.Text = "Small";
            this.FontToSmall.Click += new System.EventHandler(this.FontToSmall_Click);
            // 
            // FontToNormal
            // 
            this.FontToNormal.Name = "FontToNormal";
            this.FontToNormal.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.FontToNormal.Size = new System.Drawing.Size(193, 32);
            this.FontToNormal.Text = "Normal";
            this.FontToNormal.Click += new System.EventHandler(this.FontToNormal_Click);
            // 
            // FontToLarge
            // 
            this.FontToLarge.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FontToLarge.Name = "FontToLarge";
            this.FontToLarge.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.FontToLarge.Size = new System.Drawing.Size(193, 32);
            this.FontToLarge.Text = "Large";
            this.FontToLarge.Click += new System.EventHandler(this.FontToLarge_Click);
            // 
            // ResetAllSettings
            // 
            this.ResetAllSettings.Name = "ResetAllSettings";
            this.ResetAllSettings.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.ResetAllSettings.Size = new System.Drawing.Size(237, 22);
            this.ResetAllSettings.Text = "Reset All Settings";
            this.ResetAllSettings.Click += new System.EventHandler(this.ResetAllSettings_Click);
            // 
            // TextField
            // 
            this.TextField.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextField.Location = new System.Drawing.Point(0, 24);
            this.TextField.Multiline = true;
            this.TextField.Name = "TextField";
            this.TextField.Size = new System.Drawing.Size(370, 277);
            this.TextField.TabIndex = 1;
            this.TextField.Text = "How sharper than a serpent\'s tooth it is to have a buggy program!";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 300);
            this.Controls.Add(this.TextField);
            this.Controls.Add(this.MenuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MenuForm";
            this.Text = "Menus";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip MenuBar;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem MenuBarItemForeColour;
        private TextBox TextField;
        private ToolStripMenuItem msi_changeToRed;
        private ToolStripMenuItem msi_changeToGreen;
        private ToolStripMenuItem msi_changeToBlue;
        private ToolStripMenuItem msi_changeToDefault;
        private ToolStripMenuItem MenuBarBackColour;
        private ToolStripMenuItem BackgroundColourRed;
        private ToolStripMenuItem BackgroundColourGreen;
        private ToolStripMenuItem BackgroundColourBlue;
        private ToolStripMenuItem BackgroundColourDefault;
        private ToolStripMenuItem fontSizeToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem FontToSmall;
        private ToolStripMenuItem FontToNormal;
        private ToolStripMenuItem FontToLarge;
        private ToolStripMenuItem ResetAllSettings;
    }
}