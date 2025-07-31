using CommonUtilities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WordSelector
{
	public partial class WordSelectorForm : Form
	{
		public string[] CurrentLines { get; set; }

		private int m_maxWordCount = 1;

		public WordSelectorForm()
		{
			InitializeComponent();
		}

		public WordSelectorForm(string[] lines)
		{
			InitializeComponent();
			CurrentLines = lines;

			InitWordGrid();
		}

		private void InitWordGrid()
		{
			wordGridView.Rows.Clear();
			CountMaxWords();

			for (int i = 0; i < m_maxWordCount; i++)
			{
				var newCol = new DataGridViewTextBoxColumn()
				{
					SortMode = DataGridViewColumnSortMode.NotSortable,
					Name = $"Column{i}",
					HeaderText = $"Word {i + 1}",
					AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
					MinimumWidth = 30
				};

				wordGridView.Columns.Add(newCol);
			}

			foreach (var ln in CurrentLines)
			{
				var thisWords = Utils.GetWords(ln);

				if (thisWords.Length == 0)
				{
					continue;
				}

				wordGridView.Rows.Add(thisWords);
			}

			wordGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None; // Set other columns to fixed size
			wordGridView.Columns[wordGridView.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Last column fills remaining space
		}

		private void CountMaxWords()
		{
			int max = 0;

			foreach (var ln in CurrentLines)
			{
				if (string.IsNullOrEmpty(ln))
				{
					continue;
				}

				int thisN = Utils.GetWords(ln).Length;

				if (thisN > max)
				{
					max = thisN;
				}
			}

			m_maxWordCount = max;
		}

		private void wordGridView_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13)
			{
				CurrentLines = GetSelectedColumnWords();
				Close();
			}
		}

		private string[] GetSelectedColumnWords()
		{
			List<string> selectedLinesCollection = new List<string>();

			if (wordGridView.SelectedColumns.Count == 1)
			{
				var selectedColumn = (DataGridViewTextBoxColumn)wordGridView.SelectedColumns[0];

				foreach (DataGridViewRow row in wordGridView.Rows)
				{
					string data = (string)row.Cells[selectedColumn.Index].Value;

					if (string.IsNullOrEmpty(data))
					{
						data = string.Empty;
					}

					selectedLinesCollection.Add(data);
				}
			}
				
			return selectedLinesCollection.ToArray();
		}

		private void cancelToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void copyColumnToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			string words = string.Join(Environment.NewLine, GetSelectedColumnWords());
			Clipboard.SetText(words);
			Close();
		}

		private void selectColumnToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CurrentLines = GetSelectedColumnWords();
			Close();
		}
	}
}
