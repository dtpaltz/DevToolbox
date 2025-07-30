using CommonUtilities;
using System;

namespace EditLineEndings
{
	public partial class LineEditorForm : System.Windows.Forms.Form
	{
		private const string EDIT_BOX_DEFAUALT_TEXT = "<LINE>";

		public string[] CurrentLines { get; set; }

		public LineEditorForm()
		{
			InitializeComponent();
			ResetForm();
		}

		public LineEditorForm(string[] lines)
		{
			InitializeComponent();
			CurrentLines = lines;
			ResetForm();
		}

		private void editBox_TextChanged(object sender, EventArgs e)
		{
			applyButton.Enabled = false;

			if (string.IsNullOrEmpty(editBox.Text) || 
				editBox.Text.TrimAll().Equals(EDIT_BOX_DEFAUALT_TEXT) || 
				!editBox.Text.Contains(EDIT_BOX_DEFAUALT_TEXT))
			{
				return;
			}

			applyButton.Enabled = true;
		}

		private void resetButton_Click(object sender, EventArgs e)
		{
			ResetForm();
		}

		public void ResetForm()
		{
			editBox.Text = EDIT_BOX_DEFAUALT_TEXT;
			numericUpDownStartN.Value = numericUpDownStartN.Minimum;
		}

		private void applyButton_Click(object sender, EventArgs e)
		{
			var lineIdx = editBox.Text.IndexOf(EDIT_BOX_DEFAUALT_TEXT);
			string prependText = editBox.Text.Substring(0, lineIdx);
			string appendText = editBox.Text.Substring(lineIdx + EDIT_BOX_DEFAUALT_TEXT.Length);

			int nVar = (int)numericUpDownStartN.Value;

			for (int i = 0; i < CurrentLines.Length; i++)
			{
				var currLine = CurrentLines[i];

				if (string.IsNullOrEmpty(currLine))
				{
					continue;
				}

				currLine = prependText + currLine + appendText;
				currLine = currLine.Replace("{n}", nVar + "");
				CurrentLines[i] = currLine;
				nVar++;
			}

			Close();
		}
	}
}
