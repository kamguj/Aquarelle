
namespace Aquarelle
{
    partial class MainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scanFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reFormattingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.convertPDFInTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.verificationsToolStripMenuItem,
            this.reFormattingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(947, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem1,
            this.logoutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.fileToolStripMenuItem.Text = "User";
            // 
            // changePasswordToolStripMenuItem1
            // 
            this.changePasswordToolStripMenuItem1.Name = "changePasswordToolStripMenuItem1";
            this.changePasswordToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem1.Text = "Change Password";
            this.changePasswordToolStripMenuItem1.Click += new System.EventHandler(this.changePasswordToolStripMenuItem1_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // verificationsToolStripMenuItem
            // 
            this.verificationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scanFolderToolStripMenuItem});
            this.verificationsToolStripMenuItem.Name = "verificationsToolStripMenuItem";
            this.verificationsToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.verificationsToolStripMenuItem.Text = "Verifications";
            // 
            // scanFolderToolStripMenuItem
            // 
            this.scanFolderToolStripMenuItem.Name = "scanFolderToolStripMenuItem";
            this.scanFolderToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.scanFolderToolStripMenuItem.Text = "Scan Folder";
            this.scanFolderToolStripMenuItem.Click += new System.EventHandler(this.scanFolderToolStripMenuItem_Click);
            // 
            // reFormattingToolStripMenuItem
            // 
            this.reFormattingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convertPDFInTextToolStripMenuItem});
            this.reFormattingToolStripMenuItem.Name = "reFormattingToolStripMenuItem";
            this.reFormattingToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.reFormattingToolStripMenuItem.Text = "Re-Formatting";
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 423);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1,
            this.statusBarPanel2});
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(947, 27);
            this.statusBar1.TabIndex = 2;
            this.statusBar1.Text = "statusBar1";
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Text = "statusBarPanel1";
            this.statusBarPanel1.Width = 300;
            // 
            // statusBarPanel2
            // 
            this.statusBarPanel2.Name = "statusBarPanel2";
            this.statusBarPanel2.Text = "statusBarPanel2";
            this.statusBarPanel2.Width = 300;
            // 
            // convertPDFInTextToolStripMenuItem
            // 
            this.convertPDFInTextToolStripMenuItem.Name = "convertPDFInTextToolStripMenuItem";
            this.convertPDFInTextToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.convertPDFInTextToolStripMenuItem.Text = "Convert PDF in Text";
            this.convertPDFInTextToolStripMenuItem.Click += new System.EventHandler(this.convertPDFInTextToolStripMenuItem_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 450);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reFormattingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scanFolderToolStripMenuItem;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.StatusBarPanel statusBarPanel1;
        private System.Windows.Forms.StatusBarPanel statusBarPanel2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertPDFInTextToolStripMenuItem;
    }
}