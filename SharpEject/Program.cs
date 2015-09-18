#region description
/*
 * SharpEject app entry point
 * Copyright (C) 2011-2015, Petros Kyladitis
 * 
 * This is free software distributed under the GNU GPL 3, for license details see at license.txt 
 * file, distributed with this program source, or see at <http://www.gnu.org/licenses/>
 */
 #endregion
 
using System;
using System.Windows.Forms;

namespace SharpEject{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args){
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
