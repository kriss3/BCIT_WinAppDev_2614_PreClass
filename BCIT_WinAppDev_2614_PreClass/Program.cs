using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCIT_WinAppDev_2614_PreClass
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		/// 
		private static Form1 myForm;

		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			myForm = new Form1();
			Application.Run(myForm);
			Run();
		}

		public static void Run()
		{
			Helper hp = new Helper();
			hp.CloseApp(myForm);
		}
	}
}
