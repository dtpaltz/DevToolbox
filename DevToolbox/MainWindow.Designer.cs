namespace DevToolbox
{
	partial class MainWindow
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
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.selectWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.commentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.emptyLinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.extraWhitespaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.firstWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lastWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.compareToPreviousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.mainTextBox = new System.Windows.Forms.TextBox();
			this.joinSelectedLinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lineEndingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.operationsToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(584, 25);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyAllToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.closeToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// copyAllToolStripMenuItem
			// 
			this.copyAllToolStripMenuItem.Name = "copyAllToolStripMenuItem";
			this.copyAllToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.copyAllToolStripMenuItem.Text = "Copy All";
			this.copyAllToolStripMenuItem.Click += new System.EventHandler(this.copyAllToolStripMenuItem_Click);
			// 
			// clearToolStripMenuItem
			// 
			this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
			this.clearToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.clearToolStripMenuItem.Text = "Clear";
			this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
			this.closeToolStripMenuItem.Text = "Close";
			this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
			// 
			// operationsToolStripMenuItem
			// 
			this.operationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectWordToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.compareToPreviousToolStripMenuItem,
            this.joinSelectedLinesToolStripMenuItem,
            this.lineEndingsToolStripMenuItem});
			this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
			this.operationsToolStripMenuItem.Size = new System.Drawing.Size(85, 21);
			this.operationsToolStripMenuItem.Text = "Operations";
			// 
			// selectWordToolStripMenuItem
			// 
			this.selectWordToolStripMenuItem.Name = "selectWordToolStripMenuItem";
			this.selectWordToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
			this.selectWordToolStripMenuItem.Text = "Select Words";
			this.selectWordToolStripMenuItem.Click += new System.EventHandler(this.selectWordToolStripMenuItem_Click);
			// 
			// removeToolStripMenuItem
			// 
			this.removeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commentsToolStripMenuItem,
            this.emptyLinesToolStripMenuItem,
            this.extraWhitespaceToolStripMenuItem,
            this.firstWordToolStripMenuItem,
            this.lastWordToolStripMenuItem});
			this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
			this.removeToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
			this.removeToolStripMenuItem.Text = "Remove";
			// 
			// commentsToolStripMenuItem
			// 
			this.commentsToolStripMenuItem.Name = "commentsToolStripMenuItem";
			this.commentsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.commentsToolStripMenuItem.Text = "Comments";
			this.commentsToolStripMenuItem.Click += new System.EventHandler(this.commentsToolStripMenuItem_Click);
			// 
			// emptyLinesToolStripMenuItem
			// 
			this.emptyLinesToolStripMenuItem.Name = "emptyLinesToolStripMenuItem";
			this.emptyLinesToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.emptyLinesToolStripMenuItem.Text = "Empty Lines";
			this.emptyLinesToolStripMenuItem.Click += new System.EventHandler(this.emptyLinesToolStripMenuItem_Click);
			// 
			// extraWhitespaceToolStripMenuItem
			// 
			this.extraWhitespaceToolStripMenuItem.Name = "extraWhitespaceToolStripMenuItem";
			this.extraWhitespaceToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.extraWhitespaceToolStripMenuItem.Text = "Extra Whitespace";
			this.extraWhitespaceToolStripMenuItem.Click += new System.EventHandler(this.extraWhitespaceToolStripMenuItem_Click);
			// 
			// firstWordToolStripMenuItem
			// 
			this.firstWordToolStripMenuItem.Name = "firstWordToolStripMenuItem";
			this.firstWordToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.firstWordToolStripMenuItem.Text = "First Word";
			this.firstWordToolStripMenuItem.Click += new System.EventHandler(this.removeFirstWordToolStripMenuItem_Click);
			// 
			// lastWordToolStripMenuItem
			// 
			this.lastWordToolStripMenuItem.Name = "lastWordToolStripMenuItem";
			this.lastWordToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.lastWordToolStripMenuItem.Text = "Last Word";
			this.lastWordToolStripMenuItem.Click += new System.EventHandler(this.removeLastWordToolStripMenuItem_Click);
			// 
			// compareToPreviousToolStripMenuItem
			// 
			this.compareToPreviousToolStripMenuItem.Name = "compareToPreviousToolStripMenuItem";
			this.compareToPreviousToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
			this.compareToPreviousToolStripMenuItem.Text = "Compare to Previous";
			this.compareToPreviousToolStripMenuItem.Click += new System.EventHandler(this.compareToPreviousToolStripMenuItem_Click);
			// 
			// statusStrip
			// 
			this.statusStrip.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
			this.statusStrip.Location = new System.Drawing.Point(0, 239);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(584, 22);
			this.statusStrip.TabIndex = 1;
			this.statusStrip.Text = "statusStrip1";
			// 
			// toolStripStatusLabel
			// 
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			this.toolStripStatusLabel.Size = new System.Drawing.Size(66, 17);
			this.toolStripStatusLabel.Text = "No status...";
			// 
			// mainTextBox
			// 
			this.mainTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainTextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mainTextBox.Location = new System.Drawing.Point(0, 25);
			this.mainTextBox.Multiline = true;
			this.mainTextBox.Name = "mainTextBox";
			this.mainTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.mainTextBox.Size = new System.Drawing.Size(584, 214);
			this.mainTextBox.TabIndex = 3;
			this.mainTextBox.WordWrap = false;
			this.mainTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mainTextBox_MouseClick);
			this.mainTextBox.TextChanged += new System.EventHandler(this.mainTextBox_TextChanged);
			// 
			// joinSelectedLinesToolStripMenuItem
			// 
			this.joinSelectedLinesToolStripMenuItem.Name = "joinSelectedLinesToolStripMenuItem";
			this.joinSelectedLinesToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
			this.joinSelectedLinesToolStripMenuItem.Text = "Join Selected Lines";
			this.joinSelectedLinesToolStripMenuItem.Click += new System.EventHandler(this.joinSelectedLinesToolStripMenuItem_Click);
			// 
			// lineEndingsToolStripMenuItem
			// 
			this.lineEndingsToolStripMenuItem.Name = "lineEndingsToolStripMenuItem";
			this.lineEndingsToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
			this.lineEndingsToolStripMenuItem.Text = "Edit Line Endings";
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 261);
			this.Controls.Add(this.mainTextBox);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.menuStrip);
			this.MainMenuStrip = this.menuStrip;
			this.MinimumSize = new System.Drawing.Size(600, 300);
			this.Name = "MainWindow";
			this.Text = "Dev Toolbox";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
		private System.Windows.Forms.TextBox mainTextBox;
		private System.Windows.Forms.ToolStripMenuItem copyAllToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem selectWordToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem emptyLinesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem extraWhitespaceToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem commentsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lastWordToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem firstWordToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem compareToPreviousToolStripMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
		private System.Windows.Forms.ToolStripMenuItem joinSelectedLinesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lineEndingsToolStripMenuItem;
	}
}

