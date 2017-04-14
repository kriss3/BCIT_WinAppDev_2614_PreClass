using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCIT_WinAppDev_2614_PreClass
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Helper hp = new Helper();
			hp.CloseApp(this);
		}

		private void tbOpacity_Scroll(object sender, EventArgs e)
		{
			this.Opacity = (double)tbOpacity.Value / 100;
		}
	}
}
