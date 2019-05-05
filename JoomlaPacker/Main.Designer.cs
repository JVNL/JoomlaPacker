namespace JoomlaPacker
{
	partial class Main
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.btnStart = new System.Windows.Forms.Button();
			this.tbLog = new System.Windows.Forms.TextBox();
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.toolStripDropDownEditor = new System.Windows.Forms.ToolStripDropDownButton();
			this.workflowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.variablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripDropDownLog = new System.Windows.Forms.ToolStripDropDownButton();
			this.clearLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripDropDownInfo = new System.Windows.Forms.ToolStripDropDownButton();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnStart
			// 
			this.btnStart.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnStart.Location = new System.Drawing.Point(12, 451);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "&Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
			// 
			// tbLog
			// 
			this.tbLog.Dock = System.Windows.Forms.DockStyle.Top;
			this.tbLog.Location = new System.Drawing.Point(0, 25);
			this.tbLog.MaxLength = 600000;
			this.tbLog.Multiline = true;
			this.tbLog.Name = "tbLog";
			this.tbLog.ReadOnly = true;
			this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbLog.Size = new System.Drawing.Size(604, 420);
			this.tbLog.TabIndex = 2;
			// 
			// toolStrip
			// 
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownEditor,
            this.toolStripDropDownLog,
            this.toolStripDropDownInfo});
			this.toolStrip.Location = new System.Drawing.Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new System.Drawing.Size(604, 25);
			this.toolStrip.TabIndex = 1;
			this.toolStrip.Text = "toolStrip";
			// 
			// toolStripDropDownEditor
			// 
			this.toolStripDropDownEditor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownEditor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.workflowToolStripMenuItem,
            this.variablesToolStripMenuItem});
			this.toolStripDropDownEditor.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownEditor.Image")));
			this.toolStripDropDownEditor.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownEditor.Name = "toolStripDropDownEditor";
			this.toolStripDropDownEditor.Size = new System.Drawing.Size(51, 22);
			this.toolStripDropDownEditor.Text = "&Editor";
			// 
			// workflowToolStripMenuItem
			// 
			this.workflowToolStripMenuItem.Name = "workflowToolStripMenuItem";
			this.workflowToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.workflowToolStripMenuItem.Text = "&Workflow";
			this.workflowToolStripMenuItem.Click += new System.EventHandler(this.WorkflowToolStripMenuItem_Click);
			// 
			// variablesToolStripMenuItem
			// 
			this.variablesToolStripMenuItem.Name = "variablesToolStripMenuItem";
			this.variablesToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.variablesToolStripMenuItem.Text = "&Variables";
			this.variablesToolStripMenuItem.Click += new System.EventHandler(this.VariablesToolStripMenuItem_Click);
			// 
			// toolStripDropDownLog
			// 
			this.toolStripDropDownLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownLog.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearLogToolStripMenuItem});
			this.toolStripDropDownLog.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownLog.Image")));
			this.toolStripDropDownLog.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownLog.Name = "toolStripDropDownLog";
			this.toolStripDropDownLog.Size = new System.Drawing.Size(40, 22);
			this.toolStripDropDownLog.Text = "&Log";
			// 
			// clearLogToolStripMenuItem
			// 
			this.clearLogToolStripMenuItem.Name = "clearLogToolStripMenuItem";
			this.clearLogToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.clearLogToolStripMenuItem.Text = "&Clear log";
			this.clearLogToolStripMenuItem.Click += new System.EventHandler(this.ClearLogToolStripMenuItem_Click);
			// 
			// toolStripDropDownInfo
			// 
			this.toolStripDropDownInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.toolStripDropDownInfo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownInfo.Image")));
			this.toolStripDropDownInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownInfo.Name = "toolStripDropDownInfo";
			this.toolStripDropDownInfo.Size = new System.Drawing.Size(41, 22);
			this.toolStripDropDownInfo.Text = "&Info";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.aboutToolStripMenuItem.Text = "&About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(604, 486);
			this.Controls.Add(this.tbLog);
			this.Controls.Add(this.toolStrip);
			this.Controls.Add(this.btnStart);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Main";
			this.Text = "Joomla Packer - Joomla!NL";
			this.Load += new System.EventHandler(this.Main_Load);
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.TextBox tbLog;
		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownEditor;
		private System.Windows.Forms.ToolStripMenuItem workflowToolStripMenuItem;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownLog;
		private System.Windows.Forms.ToolStripMenuItem clearLogToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem variablesToolStripMenuItem;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownInfo;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
	}
}

