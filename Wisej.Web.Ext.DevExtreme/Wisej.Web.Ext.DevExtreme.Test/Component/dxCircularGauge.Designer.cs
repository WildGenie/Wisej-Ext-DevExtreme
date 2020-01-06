namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	partial class dxCircularGauge
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dxCircularGauge));
			this.checkBox1 = new Wisej.Web.CheckBox();
			this.trackBar1 = new Wisej.Web.TrackBar();
			this.numericUpDown1 = new Wisej.Web.NumericUpDown();
			this.dxCircularGauge1 = new Wisej.Web.Ext.DevExtreme.dxCircularGauge();
			this.label4 = new Wisej.Web.Label();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/CircularGauge";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://js.devexpress.com/Documentation/ApiReference/Data_Visualization_Widgets/d" +
    "xCircularGauge/";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.trackBar1);
			this.groupBox1.Controls.Add(this.numericUpDown1);
			this.groupBox1.Size = new System.Drawing.Size(250, 397);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.numericUpDown1, 0);
			this.groupBox1.Controls.SetChildIndex(this.trackBar1, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
			this.groupBox1.Controls.SetChildIndex(this.label4, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 316);
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.dxCircularGauge1);
			this.panel.Size = new System.Drawing.Size(455, 397);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/Gauges/PaletteForRanges/jQuer" +
    "y/Light/";
			// 
			// checkBox1
			// 
			this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBox1.AutoSize = false;
			this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = Wisej.Web.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(28, 207);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(195, 38);
			this.checkBox1.TabIndex = 10;
			this.checkBox1.Text = "Show Labels";
			// 
			// trackBar1
			// 
			this.trackBar1.Location = new System.Drawing.Point(28, 147);
			this.trackBar1.Maximum = 30;
			this.trackBar1.Minimum = 5;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(195, 34);
			this.trackBar1.SmallChange = 5;
			this.trackBar1.TabIndex = 8;
			this.trackBar1.Value = 10;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.AutoSize = false;
			this.numericUpDown1.Label.Size = 50;
			this.numericUpDown1.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.numericUpDown1.Label.Text = "Value";
			this.numericUpDown1.Location = new System.Drawing.Point(28, 42);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(195, 60);
			this.numericUpDown1.TabIndex = 7;
			this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// dxCircularGauge1
			// 
			this.dxCircularGauge1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.dxCircularGauge1.Location = new System.Drawing.Point(66, 72);
			this.dxCircularGauge1.Name = "dxCircularGauge1";
			this.dxCircularGauge1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("dxCircularGauge1.Options"))));
			this.dxCircularGauge1.Size = new System.Drawing.Size(320, 250);
			this.dxCircularGauge1.Text = "dxCircularGauge1";
			this.dxCircularGauge1.Value = 100;
			this.dxCircularGauge1.WidgetEvent += new Wisej.Web.WidgetEventHandler(this.dxCircularGauge1_WidgetEvent);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(28, 125);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 16);
			this.label4.TabIndex = 11;
			this.label4.Text = "Tick Interval";
			// 
			// dxCircularGauge
			// 
			this.Name = "dxCircularGauge";
			this.Size = new System.Drawing.Size(864, 587);
			this.Load += new System.EventHandler(this.dxCircularGauge_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private CheckBox checkBox1;
		private TrackBar trackBar1;
		private NumericUpDown numericUpDown1;
		private DevExtreme.dxCircularGauge dxCircularGauge1;
		private Label label4;
	}
}
