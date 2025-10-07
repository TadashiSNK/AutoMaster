using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AutoMaster
{

	public partial class MainForm : Form
	{
		public MainForm()
		{

			InitializeComponent();
			

		}
		
			Cadastro cadastro = new Cadastro();
		
		void MainFormLoad(object sender, EventArgs e)
		{

		}
		void UserbtnClick(object sender, EventArgs e)
		{
			this.Hide();
			
			cadastro.ShowDialog();
		}
		
		

	}
}
