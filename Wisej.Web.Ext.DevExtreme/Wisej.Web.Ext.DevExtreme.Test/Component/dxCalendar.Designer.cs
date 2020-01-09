namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	partial class dxCalendar
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
            this.dxCalendar1 = new Wisej.Web.Ext.DevExtreme.dxCalendar();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/Calendar/Overview/";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxCalendar/";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.dxCalendar1);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/Calendar/Overview/";
            // 
            // dxCalendar1
            // 
            this.dxCalendar1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.dxCalendar1.Location = new System.Drawing.Point(27, 20);
            this.dxCalendar1.Name = "dxCalendar1";
            this.dxCalendar1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"value\":\"2020-01-01\",\"disabled\":false,\"firstDayOfWeek\":0,\"zoomLevel\":\"month\"}")));
            this.dxCalendar1.Size = new System.Drawing.Size(399, 273);
            this.dxCalendar1.Text = "dxCalendar1";
            // 
            // dxCalendar
            // 
            this.Name = "dxCalendar";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private DevExtreme.dxCalendar dxCalendar1;
	}
}
