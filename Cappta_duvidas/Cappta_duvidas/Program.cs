using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Cappta_duvidas
{
	static class Program
	{
		/// <summary>
		/// Ponto de entrada principal para o aplicativo.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			HandleConfig config = new HandleConfig();
			if (config.ConfigExists() == false)
			{
				Application.Run(new Frm_cadastro());
				return;
			}
			Application.Run( new Frm_principal());
		}
	}
}
