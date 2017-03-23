using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReferenceFinder.Exceptions;
using ReferenceFinder.Helpers;

namespace ReferenceFinder
{
	public partial class ReferenceFinderForm : Form
	{
		private readonly IExceptionHandler _exceptionHandler;
		private readonly SearchAssembliesHelper _searchAssembliesHelper;

		public ReferenceFinderForm()
		{
			InitializeComponent();
			_exceptionHandler = new ExceptionNotifierForWinForm();
			_searchAssembliesHelper = new SearchAssembliesHelper(_exceptionHandler);
		}

		private void Load_btn_Click(object sender, EventArgs e)
		{
			var folderName = BrowseFolderName();
			folder_name_ln.Text = folderName;
		}

		private string BrowseFolderName()
		{
			using (var fbd = new FolderBrowserDialog())
			{
				var result = fbd.ShowDialog();
				var folderName = fbd.SelectedPath;
				return result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderName) ? folderName : string.Empty;
			}
		}

		private void Process_btn_Click(object sender, EventArgs e)
		{
			new TaskFactory().StartNew(ProcessFolder, TaskCreationOptions.LongRunning);
		}

		private void ProcessFolder()
		{
			try
			{
				var folderName = folder_name_ln.Text;
				var referenceFinder = new Engine.ReferenceFinder(_searchAssembliesHelper, _exceptionHandler);
				var result = referenceFinder.ProcessFolderName(folderName);

				treeView1.Invoke(new Action(() =>
				{
					treeView1.Nodes.Clear();
					treeView1.Nodes.AddRange(
						result.Select(
								referenceHolder =>
									new TreeNode(referenceHolder.Dll, referenceHolder.References.Select(i => new TreeNode(i.FullName)).ToArray()))
							.ToArray());
				}));
			}
			catch (Exception ex)
			{
				_exceptionHandler.Handle(ex);
			}
		}

		private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{

		}

		private void search_btn_Click(object sender, EventArgs e)
		{
			SearchInTreeView();
		}

		private void SearchInTreeView()
		{
			try
			{
				ProcessTreeView(treeView1, search_ln.Text);
			}
			catch (Exception ex)
			{
				_exceptionHandler.Handle(ex);
			}
		}

		private void ResetTree()
		{
			foreach (TreeNode treeNode in treeView1.Nodes)
			{
				treeNode.Collapse();
				ResetTreeNodeRecursive(treeNode);
			}
		}

		private void ResetTreeNodeRecursive(TreeNode node)
		{
			foreach (TreeNode n in node.Nodes)
			{
				n.ForeColor = treeView1.ForeColor;
				n.BackColor = treeView1.BackColor;

				n.Collapse();

				ResetTreeNodeRecursive(n);
			}
		}

		private void ProcessTreeView(TreeView treeView, string findText)
		{
			ResetTree();

			var matchingNodes = new List<TreeNode>();

			foreach (TreeNode n in treeView.Nodes)
			{
				if (n.Text.Contains(findText))
					matchingNodes.Add(n);

				ProcessRecursive(n, findText, matchingNodes);
			}

			foreach (var matchingNode in matchingNodes)
			{
				matchingNode.BackColor = Color.Blue;
				matchingNode.ForeColor = Color.White;
			}
		}

		private void ProcessRecursive(TreeNode treeNode, string findText, List<TreeNode> matchingNodes)
		{
			foreach (TreeNode n in treeNode.Nodes)
			{
				if (n.Text.ToLowerInvariant().Contains(findText.ToLowerInvariant()))
				{
					matchingNodes.Add(n);
					n.Parent?.Expand();
				}

				ProcessRecursive(n, findText, matchingNodes);
			}
		}

		private void search_ln_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				SearchInTreeView();
			}
		}
	}
}
