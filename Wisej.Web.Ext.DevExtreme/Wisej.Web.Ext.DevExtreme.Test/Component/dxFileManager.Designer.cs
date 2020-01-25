namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	partial class dxFileManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dxFileManager));
            this.dxFileManager1 = new Wisej.Web.Ext.DevExtreme.dxFileManager();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/File_Manager/Getting_Starte" +
    "d_with_File_Manager/";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxFileManager/";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.dxFileManager1);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/FileManager/Overview/jQuery/L" +
    "ight/";
            // 
            // dxFileManager1
            // 
            this.dxFileManager1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.dxFileManager1.Location = new System.Drawing.Point(15, 14);
            this.dxFileManager1.Name = "dxFileManager1";
            this.dxFileManager1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("dxFileManager1.Options"))));
            this.dxFileManager1.Size = new System.Drawing.Size(423, 284);
            this.dxFileManager1.Text = "dxFileManager1";
            // 
            // dxFileManager
            // 
            this.Name = "dxFileManager";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private DevExtreme.dxFileManager dxFileManager1;
	}
}
