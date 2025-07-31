using CommonUtilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DevToolbox
{
	public partial class MainWindow : Form
	{
		private List<string[]> m_history;

		public MainWindow()
		{
			InitializeComponent();
			m_history = new List<string[]>();
		}

		private void lineEndingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form = new EditLineEndings.LineEditorForm(mainTextBox.Lines);
			form.ShowDialog();
			SetNewLines(form.CurrentLines);
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
			SetNewLines(form.CurrentLines);
		}

		private void closeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void emptyLinesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var currLines = mainTextBox.Lines.ToList();
			SetNewLines(currLines.Where(x => !string.IsNullOrEmpty(x)).ToArray());
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

			SetNewLines(lines);
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

			SetNewLines(lines);
		}

		private void removeLastWordToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var lines = mainTextBox.Lines;

			for (int i = 0; i < lines.Length; i++)
			{
				var ln = lines[i];

				if (string.IsNullOrEmpty(ln))
				{
					continue;
				}

				var lnWords = Utils.GetWords(ln);

				if (lnWords.Length > 0)
				{
					ln = Utils.ReplaceLastOccurrence(ln, lnWords[lnWords.Length - 1], string.Empty);
				}

				lines[i] = ln;
			}

			SetNewLines(lines);
		}

		private void removeFirstWordToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var lines = mainTextBox.Lines;

			for (int i = 0; i < lines.Length; i++)
			{
				var ln = lines[i];

				if (string.IsNullOrEmpty(ln))
				{
					continue;
				}

				var lnWords = Utils.GetWords(ln);

				if (lnWords.Length > 0)
				{
					ln = Utils.ReplaceFirstOccurrence(ln, lnWords[0], string.Empty);
				}

				lines[i] = ln;
			}

			SetNewLines(lines);
		}


		private void SetNewLines(string[] newLines)
		{
			if (!newLines.SequenceEqual(m_history[0]))
			{
				m_history.Insert(0, newLines);
				mainTextBox.Lines = newLines;
			}
		}





		// "C:\Program Files\Beyond Compare 4\BCompare.exe"
		// System.Diagnostics.Process.Start("C:\Program Files\Beyond Compare 3\bcomp.exe", "file1.txt file2.txt /lefttitle=\"foo\" /righttitle=\"bar\"")



		private string CreateTempTextFile(string filename)
		{

			string tempFilePath = Path.GetTempFileName();
			string tempDirectory = Path.Combine(Path.GetTempPath(), "DevToolbox");

			if (!Directory.Exists(tempDirectory))
			{
				//Directory.CreateDirectory(tempDirectory);
			}

			string fileName = System.IO.Path.GetTempPath() + filename + "_" + Guid.NewGuid().ToString() + ".txt";

			return tempDirectory;
		}



		private void compareToPreviousToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var ttt = CreateTempTextFile("Current");
		}
	}
}
