namespace JoomlaPacker
{
	partial class EditorWorkflow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorWorkflow));
			this.dataGrid = new System.Windows.Forms.DataGridView();
			this.Action = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.Arguments = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnUp = new System.Windows.Forms.Button();
			this.btnDown = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnDuplicate = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGrid
			// 
			this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Action,
            this.Arguments});
			this.dataGrid.Dock = System.Windows.Forms.DockStyle.Top;
			this.dataGrid.Location = new System.Drawing.Point(0, 0);
			this.dataGrid.Name = "dataGrid";
			this.dataGrid.Size = new System.Drawing.Size(814, 395);
			this.dataGrid.TabIndex = 0;
			this.dataGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_RowEnter);
			this.dataGrid.Validating += new System.ComponentModel.CancelEventHandler(this.DataGrid_Validating);
			// 
			// Action
			// 
			this.Action.HeaderText = "Action";
			this.Action.Name = "Action";
			this.Action.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.Action.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.Action.Width = 150;
			// 
			// Arguments
			// 
			this.Arguments.HeaderText = "Arguments";
			this.Arguments.Name = "Arguments";
			this.Arguments.Width = 600;
			// 
			// btnUp
			// 
			this.btnUp.Location = new System.Drawing.Point(12, 415);
			this.btnUp.Name = "btnUp";
			this.btnUp.Size = new System.Drawing.Size(75, 23);
			this.btnUp.TabIndex = 1;
			this.btnUp.Text = "&Up";
			this.btnUp.UseVisualStyleBackColor = true;
			this.btnUp.Click += new System.EventHandler(this.BtnUp_Click);
			// 
			// btnDown
			// 
			this.btnDown.Location = new System.Drawing.Point(93, 415);
			this.btnDown.Name = "btnDown";
			this.btnDown.Size = new System.Drawing.Size(75, 23);
			this.btnDown.TabIndex = 2;
			this.btnDown.Text = "D&own";
			this.btnDown.UseVisualStyleBackColor = true;
			this.btnDown.Click += new System.EventHandler(this.BtnDown_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(707, 415);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 3;
			this.btnSave.Text = "&Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
			this.statusStrip1.Location = new System.Drawing.Point(0, 454);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(814, 22);
			this.statusStrip1.TabIndex = 4;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel
			// 
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
			// 
			// btnRemove
			// 
			this.btnRemove.Location = new System.Drawing.Point(255, 415);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(75, 23);
			this.btnRemove.TabIndex = 13;
			this.btnRemove.Text = "&Remove";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
			// 
			// btnDuplicate
			// 
			this.btnDuplicate.Location = new System.Drawing.Point(174, 415);
			this.btnDuplicate.Name = "btnDuplicate";
			this.btnDuplicate.Size = new System.Drawing.Size(75, 23);
			this.btnDuplicate.TabIndex = 12;
			this.btnDuplicate.Text = "&Duplicate";
			this.btnDuplicate.UseVisualStyleBackColor = true;
			this.btnDuplicate.Click += new System.EventHandler(this.BtnDuplicate_Click);
			// 
			// EditorWorkflow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(814, 476);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.btnDuplicate);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnDown);
			this.Controls.Add(this.btnUp);
			this.Controls.Add(this.dataGrid);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EditorWorkflow";
			this.Text = "Joomla Packer - Workflow";
			this.Load += new System.EventHandler(this.EditorWorkflow_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGrid;
		private System.Windows.Forms.DataGridViewComboBoxColumn Action;
		private System.Windows.Forms.DataGridViewTextBoxColumn Arguments;
		private System.Windows.Forms.Button btnUp;
		private System.Windows.Forms.Button btnDown;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.Button btnDuplicate;
	}
}