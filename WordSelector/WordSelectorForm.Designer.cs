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
			this.wordGridView = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.wordGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// wordGridView
			// 
			this.wordGridView.AllowUserToAddRows = false;
			this.wordGridView.AllowUserToDeleteRows = false;
			this.wordGridView.AllowUserToResizeRows = false;
			this.wordGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.wordGridView.ColumnHeadersVisible = false;
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
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView wordGridView;
	}
}

