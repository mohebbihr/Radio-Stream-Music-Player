/*
 * Creato da Alberto Scozzari.
 * Utente: User
 * Data: 02/10/2012
 * Ora: 16.42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;

namespace RadioStreamMusicPlayer
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
			Application.Run(new RadioStreamMusicPlayer());
		}
		
	}
}
