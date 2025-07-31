using CommonUtilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
			UpdateStatusLabel();
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

			mainTextBox.Lines = lines.ToArray();
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

			mainTextBox.Lines = lines;
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

			mainTextBox.Lines = lines;
		}

		private string CompareToolPath
		{
			get
			{
				return @"C:\Program Files\Beyond Compare 4\BCompare.exe";
			}
		}

		private string TempDirPath
		{
			get
			{
				string tempDirectory = Path.Combine(Path.GetTempPath(), "DevToolbox");
				return tempDirectory;
			}
		}

		private string CreateTempTextFile(string filename)
		{
			if (!Directory.Exists(TempDirPath))
			{
				Directory.CreateDirectory(TempDirPath);
			}

			string tempFilePath = Path.Combine(TempDirPath, filename + "_" + Guid.NewGuid().ToString() + ".txt");
			return tempFilePath;
		}

		private void compareToPreviousToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var currFile = CreateTempTextFile("Current");
			File.WriteAllText(currFile, mainTextBox.Text);

			var prevFile = CreateTempTextFile("Previous");
			File.WriteAllText(prevFile, string.Join(Environment.NewLine, m_history[1]));

			Process.Start(CompareToolPath, $"{prevFile} {currFile} /lefttitle=\"Previous_Version\" /righttitle=\"Current_Version\"");
		}

		private void mainTextBox_TextChanged(object sender, EventArgs e)
		{
			if (m_history.Count == 0)
			{
				m_history.Add(mainTextBox.Lines);
			}
			else if (!mainTextBox.Lines.SequenceEqual(m_history[0]))
			{
				m_history.Insert(0, mainTextBox.Lines);
			}

			UpdateStatusLabel();
		}

		private void UpdateStatusLabel()
		{
			string space = "               ";
			toolStripStatusLabel.Text = $"Length: {mainTextBox.Text.Length}{space}Lines: {mainTextBox.Lines.Length}{space}History: {m_history.Count()}";
		}
	}
}
