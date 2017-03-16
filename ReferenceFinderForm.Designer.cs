namespace ReferenceFinder
{
	partial class ReferenceFinderForm
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
			this.load_btn = new System.Windows.Forms.Button();
			this.folder_name_ln = new System.Windows.Forms.TextBox();
			this.process_btn = new System.Windows.Forms.Button();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.search_ln = new System.Windows.Forms.TextBox();
			this.search_btn = new System.Windows.Forms.Button();
			this.flowLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// load_btn
			// 
			this.load_btn.Location = new System.Drawing.Point(3, 3);
			this.load_btn.Name = "load_btn";
			this.load_btn.Size = new System.Drawing.Size(75, 23);
			this.load_btn.TabIndex = 0;
			this.load_btn.Text = "Load Folder";
			this.load_btn.UseVisualStyleBackColor = true;
			this.load_btn.Click += new System.EventHandler(this.Load_btn_Click);
			// 
			// folder_name_ln
			// 
			this.folder_name_ln.Location = new System.Drawing.Point(84, 3);
			this.folder_name_ln.Name = "folder_name_ln";
			this.folder_name_ln.Size = new System.Drawing.Size(549, 20);
			this.folder_name_ln.TabIndex = 1;
			// 
			// process_btn
			// 
			this.process_btn.Location = new System.Drawing.Point(639, 3);
			this.process_btn.Name = "process_btn";
			this.process_btn.Size = new System.Drawing.Size(75, 23);
			this.process_btn.TabIndex = 2;
			this.process_btn.Text = "Process";
			this.process_btn.UseVisualStyleBackColor = true;
			this.process_btn.Click += new System.EventHandler(this.Process_btn_Click);
			// 
			// treeView1
			// 
			this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView1.Location = new System.Drawing.Point(0, 35);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(735, 340);
			this.treeView1.TabIndex = 3;
			this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.load_btn);
			this.flowLayoutPanel1.Controls.Add(this.folder_name_ln);
			this.flowLayoutPanel1.Controls.Add(this.process_btn);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(735, 30);
			this.flowLayoutPanel1.TabIndex = 4;
			// 
			// flowLayoutPanel3
			// 
			this.flowLayoutPanel3.Controls.Add(this.search_ln);
			this.flowLayoutPanel3.Controls.Add(this.search_btn);
			this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel3.Name = "flowLayoutPanel3";
			this.flowLayoutPanel3.Size = new System.Drawing.Size(735, 35);
			this.flowLayoutPanel3.TabIndex = 4;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.treeView1);
			this.panel1.Controls.Add(this.flowLayoutPanel3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 30);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(735, 375);
			this.panel1.TabIndex = 6;
			// 
			// search_ln
			// 
			this.search_ln.Location = new System.Drawing.Point(3, 3);
			this.search_ln.Name = "search_ln";
			this.search_ln.Size = new System.Drawing.Size(630, 20);
			this.search_ln.TabIndex = 0;
			this.search_ln.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.search_ln_KeyPress);
			// 
			// search_btn
			// 
			this.search_btn.Location = new System.Drawing.Point(639, 3);
			this.search_btn.Name = "search_btn";
			this.search_btn.Size = new System.Drawing.Size(75, 23);
			this.search_btn.TabIndex = 1;
			this.search_btn.Text = "Search dll";
			this.search_btn.UseVisualStyleBackColor = true;
			this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
			// 
			// ReferenceFinderForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(735, 405);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "ReferenceFinderForm";
			this.Text = "Reference Finder";
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.flowLayoutPanel3.ResumeLayout(false);
			this.flowLayoutPanel3.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button load_btn;
		private System.Windows.Forms.TextBox folder_name_ln;
		private System.Windows.Forms.Button process_btn;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
		private System.Windows.Forms.TextBox search_ln;
		private System.Windows.Forms.Button search_btn;
		private System.Windows.Forms.Panel panel1;
	}
}

