namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	partial class dxTreeView
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

		#region Wisej Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dxTreeView));
            this.dxTreeView1 = new Wisej.Web.Ext.DevExtreme.dxTreeView();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/TreeView/Overview/";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxTreeView/";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.dxTreeView1);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/TreeView/HierarchicalDataStru" +
    "cture/jQuery/Light/";
            // 
            // dxTreeView1
            // 
            this.dxTreeView1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left)));
            this.dxTreeView1.Location = new System.Drawing.Point(19, 19);
            this.dxTreeView1.Name = "dxTreeView1";
            this.dxTreeView1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("dxTreeView1.Options"))));
            this.dxTreeView1.Size = new System.Drawing.Size(190, 274);
            this.dxTreeView1.Text = "dxTreeView1";
            // 
            // dxTreeView
            // 
            this.Name = "dxTreeView";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private DevExtreme.dxTreeView dxTreeView1;
	}
}
