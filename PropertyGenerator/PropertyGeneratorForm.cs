using CommonUtilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyGenerator
{
	public partial class PropertyGeneratorForm : Form
	{
		public string[] CurrentLines { get; set; }

		public string ResultText { get; private set; }

		private Dictionary<string, string> m_baseTypes;

		public PropertyGeneratorForm()
		{
			InitializeComponent();
		}

		public PropertyGeneratorForm(string[] lines)
		{
			InitializeComponent();
			CurrentLines = lines;

			InitGrid();
		}

		private void InitGrid()
		{
			propGridView.Rows.Clear();

			m_baseTypes = new Dictionary<string, string>()
			{
				{ "sbyte", "sbyte : 8-bit signed integer" },
				{ "short", "short : 16-bit signed integer" },
				{ "int", "int : 32-bit signed integer" },
				{ "long", "long : 64-bit signed integer" },
				{ "byte", "byte : 8-bit unsigned integer" },
				{ "ushort", "ushort : 16-bit unsigned integer" },
				{ "uint", "uint : 32-bit unsigned integer" },
				{ "ulong", "ulong : 64-bit unsigned integer" },
				{ "float", "float : 32-bit single-precision floating-point number" },
				{ "double", "double : 64-bit double-precision floating-point number" },
				{ "decimal", "decimal : 128-bit decimal type" },
				{ "bool", "bool : Boolean value (true or false)" },
				{ "char", "char : Single Unicode character" },
				{ "string", "string : Sequence of Unicode characters" },
				{ "object", "object : The root of the entire C# type hierarchy" }
			};

			for (int i = 0; i < CurrentLines.Count(); i++)
			{
				var words = Utils.GetLines(CurrentLines[i]);

				if (words.Length == 0)
				{
					continue;
				}

				int RowIndex = propGridView.Rows.Add();
				DataGridViewRow NewRow = propGridView.Rows[RowIndex];
				//NewRow.Cells[0].Value = "string";
				NewRow.Cells[1].Value = words[0];
				NewRow.Cells[2].Value = false;
			}

			int defIdx = m_baseTypes.Keys.Count - 2;

			for (int i = 0; i < propGridView.Rows.Count; i++)
			{
				DataGridViewComboBoxCell typeCell = propGridView.Rows[i].Cells[0] as DataGridViewComboBoxCell;
				typeCell.DataSource = m_baseTypes.Keys.ToArray();
				typeCell.Value = m_baseTypes.Keys.ToArray()[defIdx];

				DataGridViewCheckBoxCell rdCell = propGridView.Rows[i].Cells[2] as DataGridViewCheckBoxCell;
				rdCell.Value = true;
				rdCell.Value = false;
			}

			propGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None; // Set other columns to fixed size
			propGridView.Columns[0].Width = 100;
			propGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			propGridView.Columns[2].Width = 80;
		}

		private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ResultText = null;
			Close();
		}

		private void generatePropertiesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			StringBuilder sbVariables = new StringBuilder();
			StringBuilder sbProperties = new StringBuilder();

			foreach (DataGridViewRow item in propGridView.Rows)
			{
				if (string.IsNullOrEmpty((string)item.Cells[1].Value))
				{
					continue;
				}

				string typeStr = item.Cells[0].Value.ToString();
				string nameStr = item.Cells[1].Value.ToString();

				DataGridViewCheckBoxCell chkReadonlyCell = item.Cells[2] as DataGridViewCheckBoxCell;
				bool isReadonly = Convert.ToBoolean(chkReadonlyCell.EditedFormattedValue);

				sbVariables.AppendLine($"private {typeStr} m_{nameStr};");

				string sum = $"Gets or sets the value {nameStr}";

				if (isReadonly)
				{
					sum = $"Gets the value {nameStr}";
				}

				sbProperties.AppendLine("/// <summary>");
				sbProperties.AppendLine($"/// {sum}");
				sbProperties.AppendLine("/// </summary>");
				sbProperties.AppendLine($"public {typeStr} {nameStr}");
				sbProperties.AppendLine("{");
				sbProperties.AppendLine("\tget");
				sbProperties.AppendLine("\t{");
				sbProperties.AppendLine($"\t\treturn m_{nameStr};");
				sbProperties.AppendLine("\t}");

				if (!isReadonly)
				{
					sbProperties.AppendLine();
					sbProperties.AppendLine("\tset");
					sbProperties.AppendLine("\t{");
					sbProperties.AppendLine($"\t\tif (m_{nameStr} != value)");
					sbProperties.AppendLine("\t\t{");
					sbProperties.AppendLine($"\t\t\tm_{nameStr} = value;");
					sbProperties.AppendLine("\t\t}");
					sbProperties.AppendLine("\t}");
				}

				sbProperties.AppendLine("}");
				sbProperties.AppendLine();
			}

			sbVariables.AppendLine();
			sbProperties.Length = sbProperties.Length - 4;

			string result = sbVariables.ToString() + sbProperties.ToString();
			ResultText = result;
			Close();
		}

		private void propGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (propGridView.IsCurrentCellDirty)
			{
				// Check if the current cell is a DataGridViewCheckBoxCell
				if (propGridView.CurrentCell is DataGridViewCheckBoxCell)
				{
					// Commit the edit immediately
					propGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
				}
			}
		}
	}
}
