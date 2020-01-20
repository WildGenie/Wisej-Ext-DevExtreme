namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	partial class dxFunnel
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dxFunnel));
			Wisej.Web.Ext.DevExtreme.dxBase.WidgetFunction widgetFunction1 = new Wisej.Web.Ext.DevExtreme.dxBase.WidgetFunction();
			this.dxFunnel1 = new Wisej.Web.Ext.DevExtreme.dxFunnel();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/Funnel/Overview/";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://js.devexpress.com/Documentation/ApiReference/Data_Visualization_Widgets/d" +
    "xFunnel/";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.dxFunnel1);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/Charts/FunnelChart/jQuery/Lig" +
    "ht/";
			// 
			// dxFunnel1
			// 
			this.dxFunnel1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.dxFunnel1.Location = new System.Drawing.Point(44, 46);
			this.dxFunnel1.Name = "dxFunnel1";
			this.dxFunnel1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("dxFunnel1.Options"))));
			this.dxFunnel1.Size = new System.Drawing.Size(364, 221);
			this.dxFunnel1.Text = "dxFunnel1";
			widgetFunction1.Name = "customizeText";
			widgetFunction1.Source = "return \"<span style=\'font-size: 28px\'>\" +\r\n                    arguments[0].perce" +
    "ntText +\r\n                    \"</span><br/>\" +\r\n                    arguments[0]" +
    ".item.argument;";
			this.dxFunnel1.WidgetFunctions = new Wisej.Web.Ext.DevExtreme.dxBase.WidgetFunction[] {
        widgetFunction1};
			// 
			// dxFunnel
			// 
			this.Name = "dxFunnel";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExtreme.dxFunnel dxFunnel1;
	}
}
