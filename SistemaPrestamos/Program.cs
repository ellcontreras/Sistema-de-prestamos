/*
 * ${res:XML.StandardHeader.CreatedBy} luisg
 * User: luisg
 * Date: 22/10/2017
 * Time: 07:48 p. m.
 * 
 * 
 */
using System;
using System.Windows.Forms;

namespace SistemaPrestamos
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
