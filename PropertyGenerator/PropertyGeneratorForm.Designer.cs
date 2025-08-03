namespace PropertyGenerator
{
	partial class PropertyGeneratorForm
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
			this.propGridView = new System.Windows.Forms.DataGridView();
			this.propGridContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.generatePropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Column1_Type = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.Column2_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3_IsReadonly = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.propGridView)).BeginInit();
			this.propGridContextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// propGridView
			// 
			this.propGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.propGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.propGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1_Type,
            this.Column2_Name,
            this.Column3_IsReadonly});
			this.propGridView.ContextMenuStrip = this.propGridContextMenuStrip;
			this.propGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.propGridView.Location = new System.Drawing.Point(0, 0);
			this.propGridView.Name = "propGridView";
			this.propGridView.Size = new System.Drawing.Size(584, 361);
			this.propGridView.TabIndex = 0;
			this.propGridView.CurrentCellDirtyStateChanged += new System.EventHandler(this.propGridView_CurrentCellDirtyStateChanged);
			// 
			// propGridContextMenuStrip
			// 
			this.propGridContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generatePropertiesToolStripMenuItem,
            this.cancelToolStripMenuItem});
			this.propGridContextMenuStrip.Name = "propGridContextMenuStrip";
			this.propGridContextMenuStrip.Size = new System.Drawing.Size(122, 48);
			// 
			// generatePropertiesToolStripMenuItem
			// 
			this.generatePropertiesToolStripMenuItem.Name = "generatePropertiesToolStripMenuItem";
			this.generatePropertiesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.generatePropertiesToolStripMenuItem.Text = "Generate";
			this.generatePropertiesToolStripMenuItem.Click += new System.EventHandler(this.generatePropertiesToolStripMenuItem_Click);
			// 
			// cancelToolStripMenuItem
			// 
			this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
			this.cancelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.cancelToolStripMenuItem.Text = "Cancel";
			this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
			// 
			// Column1_Type
			// 
			this.Column1_Type.HeaderText = "Type";
			this.Column1_Type.Name = "Column1_Type";
			this.Column1_Type.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// Column2_Name
			// 
			this.Column2_Name.HeaderText = "Name";
			this.Column2_Name.Name = "Column2_Name";
			// 
			// Column3_IsReadonly
			// 
			this.Column3_IsReadonly.FalseValue = "True";
			this.Column3_IsReadonly.HeaderText = "Readonly";
			this.Column3_IsReadonly.Name = "Column3_IsReadonly";
			this.Column3_IsReadonly.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column3_IsReadonly.TrueValue = "False";
			// 
			// PropertyGeneratorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 361);
			this.Controls.Add(this.propGridView);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MinimumSize = new System.Drawing.Size(600, 400);
			this.Name = "PropertyGeneratorForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Property Generator Editor";
			((System.ComponentModel.ISupportInitialize)(this.propGridView)).EndInit();
			this.propGridContextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView propGridView;
		private System.Windows.Forms.ContextMenuStrip propGridContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem generatePropertiesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
		private System.Windows.Forms.DataGridViewComboBoxColumn Column1_Type;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2_Name;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Column3_IsReadonly;
	}
}

