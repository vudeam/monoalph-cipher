using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;

namespace Monoalphabet
{
	public class StartForm : Form
	{
		private System.ComponentModel.Container components = null;

		public StartForm()
		{
			InitializeComponent();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose();
		}

		#region Windows Form Designer generated code
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.Size = new System.Drawing.Size(1024, 576);
			this.Text = "Monoalphabet Cipher Implementation";
		}
		#endregion

		[STAThread]
		public static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new StartForm());

			return;
		}

	}
}