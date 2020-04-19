namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	partial class dxTileView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dxTileView));
			Wisej.Web.Ext.DevExtreme.dxBase.WidgetFunction widgetFunction1 = new Wisej.Web.Ext.DevExtreme.dxBase.WidgetFunction();
			this.dxTileView1 = new Wisej.Web.Ext.DevExtreme.dxTileView();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/TileView/Overview/";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxTileView/";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.dxTileView1);
			this.panel.Size = new System.Drawing.Size(787, 538);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/TileView/Basics/jQuery/Light/" +
    "";
			// 
			// dxTileView1
			// 
			this.dxTileView1.Anchor = Wisej.Web.AnchorStyles.None;
			this.dxTileView1.CssStyle = ".img { width: 500px; }";
			this.dxTileView1.Location = new System.Drawing.Point(21, 20);
			this.dxTileView1.Name = "dxTileView1";
			this.dxTileView1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("dxTileView1.Options"))));
			this.dxTileView1.Size = new System.Drawing.Size(742, 495);
			this.dxTileView1.TabIndex = 0;
			this.dxTileView1.Text = "dxTileView1";
			widgetFunction1.Name = "initFunc";
			widgetFunction1.Source = resources.GetString("widgetFunction1.Source");
			this.dxTileView1.WidgetFunctions = new Wisej.Web.Ext.DevExtreme.dxBase.WidgetFunction[] {
        widgetFunction1};
			this.dxTileView1.WidgetTemplates = new Wisej.Web.Ext.DevExtreme.dxBase.WidgetTemplate[0];
			// 
			// dxTileView
			// 
			this.Name = "dxTileView";
			this.Size = new System.Drawing.Size(1196, 728);
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExtreme.dxTileView dxTileView1;
	}
}
