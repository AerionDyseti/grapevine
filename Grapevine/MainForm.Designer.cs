namespace Grapevine
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGameAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grapevineMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.charactersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.worldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chronicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sheetsReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.gameToolStripMenuItem,
            this.playersToolStripMenuItem,
            this.charactersToolStripMenuItem,
            this.worldToolStripMenuItem,
            this.chronicleToolStripMenuItem,
            this.sheetsReportsToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.openGameToolStripMenuItem,
            this.saveGameToolStripMenuItem,
            this.saveGameAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.NewGameToolStripMenuItem_Click);
            // 
            // openGameToolStripMenuItem
            // 
            this.openGameToolStripMenuItem.Name = "openGameToolStripMenuItem";
            this.openGameToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.openGameToolStripMenuItem.Text = "Open Game...";
            // 
            // saveGameToolStripMenuItem
            // 
            this.saveGameToolStripMenuItem.Enabled = false;
            this.saveGameToolStripMenuItem.Name = "saveGameToolStripMenuItem";
            this.saveGameToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.saveGameToolStripMenuItem.Text = "Save Game";
            this.saveGameToolStripMenuItem.Click += new System.EventHandler(this.SaveGameToolStripMenuItem_Click);
            // 
            // saveGameAsToolStripMenuItem
            // 
            this.saveGameAsToolStripMenuItem.Enabled = false;
            this.saveGameAsToolStripMenuItem.Name = "saveGameAsToolStripMenuItem";
            this.saveGameAsToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.saveGameAsToolStripMenuItem.Text = "Save Game As...";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.grapevineMenuToolStripMenuItem});
            this.gameToolStripMenuItem.Enabled = false;
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Enabled = false;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.settingsToolStripMenuItem.Text = "Settings...";
            // 
            // grapevineMenuToolStripMenuItem
            // 
            this.grapevineMenuToolStripMenuItem.Enabled = false;
            this.grapevineMenuToolStripMenuItem.Name = "grapevineMenuToolStripMenuItem";
            this.grapevineMenuToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.grapevineMenuToolStripMenuItem.Text = "Grapevine Menu...";
            // 
            // playersToolStripMenuItem
            // 
            this.playersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerInformationToolStripMenuItem,
            this.playerPointsToolStripMenuItem});
            this.playersToolStripMenuItem.Enabled = false;
            this.playersToolStripMenuItem.Name = "playersToolStripMenuItem";
            this.playersToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.playersToolStripMenuItem.Text = "Players";
            // 
            // playerInformationToolStripMenuItem
            // 
            this.playerInformationToolStripMenuItem.Enabled = false;
            this.playerInformationToolStripMenuItem.Name = "playerInformationToolStripMenuItem";
            this.playerInformationToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.playerInformationToolStripMenuItem.Text = "Player Information";
            // 
            // playerPointsToolStripMenuItem
            // 
            this.playerPointsToolStripMenuItem.Enabled = false;
            this.playerPointsToolStripMenuItem.Name = "playerPointsToolStripMenuItem";
            this.playerPointsToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.playerPointsToolStripMenuItem.Text = "Player Points";
            // 
            // charactersToolStripMenuItem
            // 
            this.charactersToolStripMenuItem.Enabled = false;
            this.charactersToolStripMenuItem.Name = "charactersToolStripMenuItem";
            this.charactersToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.charactersToolStripMenuItem.Text = "Characters";
            // 
            // worldToolStripMenuItem
            // 
            this.worldToolStripMenuItem.Enabled = false;
            this.worldToolStripMenuItem.Name = "worldToolStripMenuItem";
            this.worldToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.worldToolStripMenuItem.Text = "World";
            // 
            // chronicleToolStripMenuItem
            // 
            this.chronicleToolStripMenuItem.Enabled = false;
            this.chronicleToolStripMenuItem.Name = "chronicleToolStripMenuItem";
            this.chronicleToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.chronicleToolStripMenuItem.Text = "Chronicle";
            // 
            // sheetsReportsToolStripMenuItem
            // 
            this.sheetsReportsToolStripMenuItem.Enabled = false;
            this.sheetsReportsToolStripMenuItem.Name = "sheetsReportsToolStripMenuItem";
            this.sheetsReportsToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.sheetsReportsToolStripMenuItem.Text = "Sheets & Reports";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Grapevine 4.0";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGameAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem charactersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem worldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chronicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sheetsReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grapevineMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerPointsToolStripMenuItem;
    }
}

