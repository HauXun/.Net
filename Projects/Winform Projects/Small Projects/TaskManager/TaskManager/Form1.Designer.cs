
namespace TaskManager
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.listView1 = new System.Windows.Forms.ListView();
			this.clProcessName = new System.Windows.Forms.ColumnHeader();
			this.clInfo = new System.Windows.Forms.ColumnHeader();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.endTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clProcessName,
            this.clInfo});
			this.listView1.FullRowSelect = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(12, 12);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(776, 426);
			this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
			// 
			// clProcessName
			// 
			this.clProcessName.Text = "ProcessName";
			this.clProcessName.Width = 100;
			// 
			// clInfo
			// 
			this.clInfo.Text = "Info";
			this.clInfo.Width = 80;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.endTaskToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(120, 26);
			// 
			// endTaskToolStripMenuItem
			// 
			this.endTaskToolStripMenuItem.Name = "endTaskToolStripMenuItem";
			this.endTaskToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.endTaskToolStripMenuItem.Text = "End Task";
			this.endTaskToolStripMenuItem.Click += new System.EventHandler(this.endTaskToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.listView1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader clProcessName;
		private System.Windows.Forms.ColumnHeader clInfo;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem endTaskToolStripMenuItem;
	}
}

