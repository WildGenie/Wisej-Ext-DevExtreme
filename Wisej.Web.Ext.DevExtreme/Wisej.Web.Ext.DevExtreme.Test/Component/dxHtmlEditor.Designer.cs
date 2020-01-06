namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	partial class dxHtmlEditor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dxHtmlEditor));
			this.dxHtmlEditor1 = new Wisej.Web.Ext.DevExtreme.dxHtmlEditor();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/HtmlEditor/Overview/";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxHtmlEditor/";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.dxHtmlEditor1);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/HtmlEditor/Overview/jQuery/Li" +
    "ght/";
			// 
			// dxHtmlEditor1
			// 
			this.dxHtmlEditor1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.dxHtmlEditor1.Location = new System.Drawing.Point(26, 25);
			this.dxHtmlEditor1.Name = "dxHtmlEditor1";
			this.dxHtmlEditor1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("dxHtmlEditor1.Options"))));
			this.dxHtmlEditor1.Size = new System.Drawing.Size(401, 262);
			this.dxHtmlEditor1.Text = "dxHtmlEditor1";
			// 
			// dxHtmlEditor
			// 
			this.Name = "dxHtmlEditor";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExtreme.dxHtmlEditor dxHtmlEditor1;
	}
}
