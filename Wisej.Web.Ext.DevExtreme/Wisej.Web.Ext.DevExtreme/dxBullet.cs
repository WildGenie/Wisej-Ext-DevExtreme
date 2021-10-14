﻿///////////////////////////////////////////////////////////////////////////////
//
// (C) 2019 ICE TEA GROUP LLC - ALL RIGHTS RESERVED
//
// 
//
// ALL INFORMATION CONTAINED HEREIN IS, AND REMAINS
// THE PROPERTY OF ICE TEA GROUP LLC AND ITS SUPPLIERS, IF ANY.
// THE INTELLECTUAL PROPERTY AND TECHNICAL CONCEPTS CONTAINED
// HEREIN ARE PROPRIETARY TO ICE TEA GROUP LLC AND ITS SUPPLIERS
// AND MAY BE COVERED BY U.S. AND FOREIGN PATENTS, PATENT IN PROCESS, AND
// ARE PROTECTED BY TRADE SECRET OR COPYRIGHT LAW.
//
// DISSEMINATION OF THIS INFORMATION OR REPRODUCTION OF THIS MATERIAL
// IS STRICTLY FORBIDDEN UNLESS PRIOR WRITTEN PERMISSION IS OBTAINED
// FROM ICE TEA GROUP LLC.
//
///////////////////////////////////////////////////////////////////////////////

namespace Wisej.Web.Ext.DevExtreme
{
	/// <summary>
	/// A bullet bar is a horizontal bar that indicates a bullet chart's primary value.
	/// The Bullet widget is useful when you need to compare a single measure to a target value.
	/// </summary>
	public class dxBullet : dxBase
	{
		/// <summary>
		/// Constructs a new instance of the <see cref="dxBullet"/> class.
		/// </summary>
		public dxBullet() : this(null)
		{
		}

		/// <summary>
		/// Constructs a new instance of the <see cref="dxBullet"/> class.
		/// </summary>
		/// <param name="options">Initial set of options.</param>
		public dxBullet(object options) : base("dxBullet", options)
		{
			this.WiredEvents = new[] {
				"drawn",
				"exported",
				"exporting",
				"fileSaving",
				"optionChanged"
			};
		}
	}
}
