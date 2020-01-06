namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	partial class dxChart
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dxChart));
			this.dxChart1 = new Wisej.Web.Ext.DevExtreme.dxChart();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/Chart/Overview/";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://js.devexpress.com/Documentation/ApiReference/Data_Visualization_Widgets/" +
    "xChart/";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.dxChart1);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/Charts/Overview/jQuery/Light/" +
    "";
			// 
			// dxChart1
			// 
			this.dxChart1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.dxChart1.Location = new System.Drawing.Point(59, 46);
			this.dxChart1.Name = "dxChart1";
			this.dxChart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("dxChart1.Options"))));
			this.dxChart1.Size = new System.Drawing.Size(335, 220);
			this.dxChart1.Text = "dxChart1";
			this.dxChart1.WidgetEvent += new Wisej.Web.WidgetEventHandler(this.dxChart1_WidgetEvent);
			// 
			// dxChart
			// 
			this.Name = "dxChart";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExtreme.dxChart dxChart1;
	}
}
