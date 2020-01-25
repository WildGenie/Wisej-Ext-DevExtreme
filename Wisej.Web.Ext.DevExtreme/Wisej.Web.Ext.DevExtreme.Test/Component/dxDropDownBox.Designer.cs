namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	partial class dxDropDownBox
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
			Wisej.Web.JavaScript.ClientEvent clientEvent1 = new Wisej.Web.JavaScript.ClientEvent();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dxDropDownBox));
			Wisej.Web.Ext.DevExtreme.dxBase.WidgetFunction widgetFunction1 = new Wisej.Web.Ext.DevExtreme.dxBase.WidgetFunction();
			Wisej.Web.Ext.DevExtreme.dxBase.WidgetFunction widgetFunction2 = new Wisej.Web.Ext.DevExtreme.dxBase.WidgetFunction();
			this.dxDropDownBox1 = new Wisej.Web.Ext.DevExtreme.dxDropDownBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/DropDownBox/Overview/";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxDropDownBox/";
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.dxDropDownBox1);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/DropDownBox/SingleSelection/j" +
    "Query/Light/";
			// 
			// dxDropDownBox1
			// 
			this.dxDropDownBox1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			clientEvent1.Event = "appear";
			clientEvent1.JavaScript = resources.GetString("clientEvent1.JavaScript");
			this.dxDropDownBox1.ClientEvents.Add(clientEvent1);
			this.dxDropDownBox1.Location = new System.Drawing.Point(126, 141);
			this.dxDropDownBox1.Name = "dxDropDownBox1";
			this.dxDropDownBox1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"valueExpr\":\"ID\",\"deferRendering\":false,\"placeholder\":\"Select a value...\",\"displ" +
        "ayExpr\":\"displayExpr\",\"contentTemplate\":\"contentTemp\"}")));
			this.dxDropDownBox1.Size = new System.Drawing.Size(200, 30);
			widgetFunction1.Name = "displayExpr";
			widgetFunction1.Source = "var item = arguments[0];\r\nreturn item && item.CompanyName + \" <\" + item.Phone + \"" +
    ">\";\r\n";
			widgetFunction2.Name = "contentTemp";
			widgetFunction2.Source = resources.GetString("widgetFunction2.Source");
			this.dxDropDownBox1.WidgetFunctions = new Wisej.Web.Ext.DevExtreme.dxBase.WidgetFunction[] {
        widgetFunction1,
        widgetFunction2};
			// 
			// dxDropDownBox
			// 
			this.Name = "dxDropDownBox";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExtreme.dxDropDownBox dxDropDownBox1;
	}
}
