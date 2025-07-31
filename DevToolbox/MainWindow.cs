using System;
using System.Windows.Forms;

namespace DevToolbox
{
	public partial class MainWindow : Form
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void lineEndingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form = new EditLineEndings.LineEditorForm(mainTextBox.Lines);
			form.ShowDialog();
			mainTextBox.Lines = form.CurrentLines;
		}

		private void copyAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(mainTextBox.Text);
		}

		private void clearToolStripMenuItem_Click(object sender, EventArgs e)
		{
			mainTextBox.Clear();
		}

		private void selectWordToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form = new WordSelector.WordSelectorForm(mainTextBox.Lines);
			form.ShowDialog();
			mainTextBox.Lines = form.CurrentLines;
		}

		private void closeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
