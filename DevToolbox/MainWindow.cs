using CommonUtilities;
using System;
using System.Linq;
using System.Text.RegularExpressions;
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

		private void emptyLinesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var currLines = mainTextBox.Lines.ToList();
			mainTextBox.Lines = currLines.Where(x => !string.IsNullOrEmpty(x)).ToArray();
		}

		private void extraWhitespaceToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var lines = mainTextBox.Lines;

			for (int i = 0; i < lines.Length; i++)
			{
				var ln = lines[i];

				if (string.IsNullOrEmpty(ln))
				{
					continue;
				}

				var newLn = ln.TrimExtra();
				lines[i] = newLn.Trim();
			}

			mainTextBox.Lines = lines;
		}

		private void commentsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var lines = mainTextBox.Lines;

			string pattern = @"(//.*?$)|(/\*.*?\*/)";

			for (int i = 0; i < lines.Length; i++)
			{
				var ln = lines[i];

				if (string.IsNullOrEmpty(ln))
				{
					continue;
				}

				var newLn = Regex.Replace(ln, pattern, string.Empty, RegexOptions.Singleline | RegexOptions.Multiline);
				lines[i] = newLn;
			}

			mainTextBox.Lines = lines;
		}
	}
}
