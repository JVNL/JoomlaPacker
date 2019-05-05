using JoomlaFunctions;
using System;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace JoomlaPacker
{
	public partial class Main : Form
	{
		public Main() => InitializeComponent();

		private void Main_Load(object sender, EventArgs e) => AddToLog("Joomla Packer - Joomla!NL\r\n");

		private void Execution()
		{
			btnStart.Enabled = false;
			Cursor = Cursors.WaitCursor;

			var workflowManager = new WorkflowManager();
			var workflow = workflowManager.GetWorkflow();
			var items = workflow.WorkflowItems;

			var varManager = new VariableManager();
			var vars = varManager.GetVars(true);

			foreach (var item in items)
			{
				AddToLog($"Actie: {item.Action}");
				var arguments = item.Arguments;
				if (arguments.Contains("%"))
				{
					foreach (var i in vars.Variables)
					{
						if (arguments.Contains(i.Var))
							arguments = arguments.Replace(i.Var, i.Value);
					}
				}
				var args = arguments.Split('|');
				for (int i = 0; i < args.Length; i++)
				{
					string arg = args[i];
					AddToLog($"Argument {i}: {arg}");
				}

				AddToLog(string.Empty);

				// Tegen vastlopen op aparte thread uitvoeren, wachten tot gereed.
				Task.WaitAll(Task.Run(() => workflowManager.ExecuteWorkflowAction(item.Action, arguments)));
			}
			AddToLog("Klaar!");

			Cursor = Cursors.Default;
			btnStart.Enabled = true;
		}

		private void BtnStart_Click(object sender, EventArgs e) => Execution();

		private void AddToLog(string message) => tbLog.AppendText($"{message}\r\n");

		private void ClearLogToolStripMenuItem_Click(object sender, EventArgs e) => tbLog.Clear();

		private void WorkflowToolStripMenuItem_Click(object sender, EventArgs e) => new EditorWorkflow().Show();

		private void VariablesToolStripMenuItem_Click(object sender, EventArgs e) => new EditorVariables().Show();

		private void AboutToolStripMenuItem_Click(object sender, EventArgs e) => new InfoAbout().Show();
	}
}
