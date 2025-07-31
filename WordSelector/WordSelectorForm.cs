using CommonUtilities;
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
			if (wordGridView.SelectedColumns.Count == 1)
			{
				var selectedColumn = (DataGridViewTextBoxColumn)wordGridView.SelectedColumns[0];
				List<string> selectedLinesCollection = new List<string>();

				if (e.KeyChar == (char)13)
				{
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

				CurrentLines = selectedLinesCollection.ToArray();
				Close();
			}

		}
	}
}
