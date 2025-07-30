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
	}
}
