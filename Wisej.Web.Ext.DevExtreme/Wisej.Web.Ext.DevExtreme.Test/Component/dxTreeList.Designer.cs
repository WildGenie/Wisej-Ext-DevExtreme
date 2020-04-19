namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	partial class dxTreeList
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dxTreeList));
			this.dxTreeList1 = new Wisej.Web.Ext.DevExtreme.dxTreeList();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/TreeList/Overview/";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxTreeList/";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.dxTreeList1);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/TreeList/Overview/jQuery/Ligh" +
    "t/";
			// 
			// dxTreeList1
			// 
			this.dxTreeList1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.dxTreeList1.Location = new System.Drawing.Point(17, 15);
			this.dxTreeList1.Name = "dxTreeList1";
			this.dxTreeList1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("dxTreeList1.Options"))));
			this.dxTreeList1.Size = new System.Drawing.Size(419, 282);
			this.dxTreeList1.TabIndex = 0;
			this.dxTreeList1.Text = "dxTreeList1";
			// 
			// dxTreeList
			// 
			this.Name = "dxTreeList";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExtreme.dxTreeList dxTreeList1;
	}
}
