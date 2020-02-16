using JoomlaFunctions;
using JoomlaFunctions.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace JoomlaPacker
{
	public partial class EditorVariables : Form
	{
		public EditorVariables()
		{
			InitializeComponent();
			dataGrid.AutoGenerateColumns = false;

			var varManager = new VariableManager();
			var vars = varManager.GetVars();

			foreach (var item in vars.Variables)
			{
				dataGrid.Rows.Add(item.Var, item.Value);
			}
		}

		private void EditorVariables_Load(object sender, EventArgs e)
		{

		}

		private void BtnUp_Click(object sender, EventArgs e)
		{
			DataGridView dgv = dataGrid;
			try
			{
				int totalRows = dgv.Rows.Count;
				// get index of the row for the selected cell
				int rowIndex = dgv.SelectedCells[0].OwningRow.Index;
				if (rowIndex == 0)
					return;
				// get index of the column for the selected cell
				int colIndex = dgv.SelectedCells[0].OwningColumn.Index;
				DataGridViewRow selectedRow = dgv.Rows[rowIndex];
				dgv.Rows.Remove(selectedRow);
				dgv.Rows.Insert(rowIndex - 1, selectedRow);
				dgv.ClearSelection();
				dgv.Rows[rowIndex - 1].Cells[colIndex].Selected = true;
			}
			catch
			{
				// ignore
			}
		}

		private void BtnDown_Click(object sender, EventArgs e)
		{
			DataGridView dgv = dataGrid;
			try
			{
				int totalRows = dgv.Rows.Count;
				// get index of the row for the selected cell
				int rowIndex = dgv.SelectedCells[0].OwningRow.Index;
				if (rowIndex == totalRows - 1)
					return;
				// get index of the column for the selected cell
				int colIndex = dgv.SelectedCells[0].OwningColumn.Index;
				DataGridViewRow selectedRow = dgv.Rows[rowIndex];
				dgv.Rows.Remove(selectedRow);
				dgv.Rows.Insert(rowIndex + 1, selectedRow);
				dgv.ClearSelection();
				dgv.Rows[rowIndex + 1].Cells[colIndex].Selected = true;
			}
			catch
			{
				// ignore
			}
		}

		private void BtnSave_Click(object sender, EventArgs e)
		{
			var rows = dataGrid.Rows;
			var items = new List<VariableItem>();
			foreach (DataGridViewRow item in rows)
			{
				var row = item.Cells;
				if (string.IsNullOrWhiteSpace(row[1].Value as string))
					continue;

				items.Add(new VariableItem()
				{
					Var = row[0].Value as string,
					Value = row[1].Value as string
				});
			}
			new VariableManager().SaveVars(new Variable { Variables = items });
			toolStripStatusLabel.Text = "Saved";
		}

		private void DataGrid_Validating(object sender, System.ComponentModel.CancelEventArgs e) => ClearStatus();

		private void DataGrid_RowEnter(object sender, DataGridViewCellEventArgs e) => ClearStatus();

		private void ClearStatus() => toolStripStatusLabel.Text = string.Empty;

		private void BtnDuplicate_Click(object sender, EventArgs e)
		{
			DataGridView dgv = dataGrid;
			try
			{
				int rowIndex = dgv.SelectedCells[0].OwningRow.Index;
				int colIndex = dgv.SelectedCells[0].OwningColumn.Index;
				DataGridViewRow selectedRow = dgv.Rows[rowIndex];
				dgv.Rows.InsertCopy(rowIndex, rowIndex + 1);
				dgv.Rows[rowIndex + 1].SetValues(selectedRow.Cells[0].Value, selectedRow.Cells[1].Value);
				dgv.ClearSelection();
				dgv.Rows[rowIndex + 1].Cells[colIndex].Selected = true;
			}
			catch
			{
				// ignore
			}
		}

		private void BtnRemove_Click(object sender, EventArgs e)
		{
			DataGridView dgv = dataGrid;
			try
			{
				int rowIndex = dgv.SelectedCells[0].OwningRow.Index;
				DataGridViewRow selectedRow = dgv.Rows[rowIndex];
				dgv.Rows.Remove(selectedRow);
				dgv.ClearSelection();
			}
			catch
			{
				// ignore
			}
		}
	}
}
