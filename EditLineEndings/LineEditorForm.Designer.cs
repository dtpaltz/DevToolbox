namespace EditLineEndings
{
	partial class LineEditorForm
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
			this.numericUpDownStartN = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.cancelButton = new System.Windows.Forms.Button();
			this.resetButton = new System.Windows.Forms.Button();
			this.applyButton = new System.Windows.Forms.Button();
			this.editBox = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartN)).BeginInit();
			this.SuspendLayout();
			// 
			// numericUpDownStartN
			// 
			this.numericUpDownStartN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numericUpDownStartN.Location = new System.Drawing.Point(148, 49);
			this.numericUpDownStartN.Name = "numericUpDownStartN";
			this.numericUpDownStartN.Size = new System.Drawing.Size(109, 20);
			this.numericUpDownStartN.TabIndex = 11;
			this.numericUpDownStartN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(130, 16);
			this.label1.TabIndex = 10;
			this.label1.Text = "Variable {n} starts at:";
			// 
			// cancelButton
			// 
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cancelButton.Location = new System.Drawing.Point(296, 88);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(126, 28);
			this.cancelButton.TabIndex = 9;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			// 
			// resetButton
			// 
			this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resetButton.Location = new System.Drawing.Point(160, 88);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(130, 28);
			this.resetButton.TabIndex = 8;
			this.resetButton.Text = "Reset";
			this.resetButton.UseVisualStyleBackColor = true;
			this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
			// 
			// applyButton
			// 
			this.applyButton.Enabled = false;
			this.applyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.applyButton.Location = new System.Drawing.Point(12, 88);
			this.applyButton.Name = "applyButton";
			this.applyButton.Size = new System.Drawing.Size(142, 28);
			this.applyButton.TabIndex = 7;
			this.applyButton.Text = "Apply";
			this.applyButton.UseVisualStyleBackColor = true;
			this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
			// 
			// editBox
			// 
			this.editBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.editBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.editBox.Location = new System.Drawing.Point(12, 12);
			this.editBox.Name = "editBox";
			this.editBox.Size = new System.Drawing.Size(410, 22);
			this.editBox.TabIndex = 6;
			this.editBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.editBox.TextChanged += new System.EventHandler(this.editBox_TextChanged);
			// 
			// Form
			// 
			this.AcceptButton = this.applyButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(438, 126);
			this.Controls.Add(this.numericUpDownStartN);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.resetButton);
			this.Controls.Add(this.applyButton);
			this.Controls.Add(this.editBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Form";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Line Editor";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartN)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown numericUpDownStartN;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button resetButton;
		private System.Windows.Forms.Button applyButton;
		private System.Windows.Forms.TextBox editBox;
	}
}

