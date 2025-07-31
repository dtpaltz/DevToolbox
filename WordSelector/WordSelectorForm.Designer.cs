namespace WordSelector
{
	partial class WordSelectorForm
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
			this.components = new System.ComponentModel.Container();
			this.wordGridView = new System.Windows.Forms.DataGridView();
			this.gridContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.copyColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.selectColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.wordGridView)).BeginInit();
			this.gridContextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// wordGridView
			// 
			this.wordGridView.AllowUserToAddRows = false;
			this.wordGridView.AllowUserToDeleteRows = false;
			this.wordGridView.AllowUserToResizeRows = false;
			this.wordGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.wordGridView.ColumnHeadersVisible = false;
			this.wordGridView.ContextMenuStrip = this.gridContextMenuStrip;
			this.wordGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wordGridView.Location = new System.Drawing.Point(0, 0);
			this.wordGridView.MultiSelect = false;
			this.wordGridView.Name = "wordGridView";
			this.wordGridView.ReadOnly = true;
			this.wordGridView.RowHeadersVisible = false;
			this.wordGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullColumnSelect;
			this.wordGridView.ShowCellErrors = false;
			this.wordGridView.ShowCellToolTips = false;
			this.wordGridView.ShowEditingIcon = false;
			this.wordGridView.ShowRowErrors = false;
			this.wordGridView.Size = new System.Drawing.Size(784, 461);
			this.wordGridView.TabIndex = 0;
			this.wordGridView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.wordGridView_KeyPress);
			// 
			// gridContextMenuStrip
			// 
			this.gridContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyColumnToolStripMenuItem,
            this.selectColumnToolStripMenuItem,
            this.toolStripSeparator1,
            this.cancelToolStripMenuItem});
			this.gridContextMenuStrip.Name = "gridContextMenuStrip";
			this.gridContextMenuStrip.Size = new System.Drawing.Size(152, 76);
			// 
			// copyColumnToolStripMenuItem
			// 
			this.copyColumnToolStripMenuItem.Name = "copyColumnToolStripMenuItem";
			this.copyColumnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.copyColumnToolStripMenuItem.Text = "Copy Column";
			this.copyColumnToolStripMenuItem.Click += new System.EventHandler(this.copyColumnToolStripMenuItem_Click);
			// 
			// selectColumnToolStripMenuItem
			// 
			this.selectColumnToolStripMenuItem.Name = "selectColumnToolStripMenuItem";
			this.selectColumnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.selectColumnToolStripMenuItem.Text = "Select Column";
			this.selectColumnToolStripMenuItem.Click += new System.EventHandler(this.selectColumnToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
			// 
			// cancelToolStripMenuItem
			// 
			this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
			this.cancelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.cancelToolStripMenuItem.Text = "Cancel";
			this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
			// 
			// WordSelectorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 461);
			this.Controls.Add(this.wordGridView);
			this.MinimumSize = new System.Drawing.Size(800, 500);
			this.Name = "WordSelectorForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Word Selector";
			((System.ComponentModel.ISupportInitialize)(this.wordGridView)).EndInit();
			this.gridContextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView wordGridView;
		private System.Windows.Forms.ContextMenuStrip gridContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem copyColumnToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem selectColumnToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
	}
}

