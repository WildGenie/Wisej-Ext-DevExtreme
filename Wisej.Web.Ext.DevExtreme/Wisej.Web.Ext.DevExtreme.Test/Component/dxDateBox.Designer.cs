namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	partial class dxDateBox
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
			this.dxDateBox1 = new Wisej.Web.Ext.DevExtreme.dxDateBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/DateBox/Overview/";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxDateBox/";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.dxDateBox1);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/DateBox/Overview/jQuery/Light" +
    "/";
			// 
			// dxDateBox1
			// 
			this.dxDateBox1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.dxDateBox1.Location = new System.Drawing.Point(126, 141);
			this.dxDateBox1.Name = "dxDateBox1";
			this.dxDateBox1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"type\":\"date\"}")));
			this.dxDateBox1.Size = new System.Drawing.Size(200, 30);
			// 
			// dxDateBox
			// 
			this.Name = "dxDateBox";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExtreme.dxDateBox dxDateBox1;
	}
}
