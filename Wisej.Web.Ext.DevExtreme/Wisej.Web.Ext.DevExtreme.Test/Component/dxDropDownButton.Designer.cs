namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	partial class dxDropDownButton
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dxDropDownButton));
			Wisej.Web.Ext.DevExtreme.dxBase.WidgetFunction widgetFunction1 = new Wisej.Web.Ext.DevExtreme.dxBase.WidgetFunction();
			Wisej.Web.Ext.DevExtreme.dxBase.WidgetFunction widgetFunction2 = new Wisej.Web.Ext.DevExtreme.dxBase.WidgetFunction();
			this.dxDropDownButton1 = new Wisej.Web.Ext.DevExtreme.dxDropDownButton();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/DropDownButton/Getting_Star" +
    "ted_with_DropDownButton/";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxDropDownButton/" +
    "Configuration/";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.dxDropDownButton1);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/DropDownButton/Overview/jQuer" +
    "y/Light/";
			// 
			// dxDropDownButton1
			// 
			this.dxDropDownButton1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.dxDropDownButton1.Location = new System.Drawing.Point(126, 141);
			this.dxDropDownButton1.Name = "dxDropDownButton1";
			this.dxDropDownButton1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("dxDropDownButton1.Options"))));
			this.dxDropDownButton1.Size = new System.Drawing.Size(200, 30);
			widgetFunction1.Name = "notify";
			widgetFunction1.Source = "var item = arguments[0];\r\n\r\nDevExpress.ui.notify(item.itemData.name, \"success\", 6" +
    "00);";
			widgetFunction2.Name = "notifyProfile";
			widgetFunction2.Source = "var item = arguments[0];\r\n\r\nDevExpress.ui.notify(\"Go to \" + item.component.option" +
    "(\"text\") + \"\'s profile\", \"success\", 600);";
			this.dxDropDownButton1.WidgetFunctions = new Wisej.Web.Ext.DevExtreme.dxBase.WidgetFunction[] {
        widgetFunction1,
        widgetFunction2};
			// 
			// dxDropDownButton
			// 
			this.Name = "dxDropDownButton";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExtreme.dxDropDownButton dxDropDownButton1;
	}
}
