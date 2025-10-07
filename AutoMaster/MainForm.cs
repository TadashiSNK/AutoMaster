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
			Carros cadastroCarros = new Carros();
			OrdemDeServico osGen = new OrdemDeServico();
		
		void MainFormLoad(object sender, EventArgs e)
		{

		}
		void UserbtnClick(object sender, EventArgs e)
		{
			//Abre a aba Cadastro de usuarios
			this.Hide();
			cadastro.ShowDialog();
			this.Show();
		}
		void CadastrarCarroClick(object sender, EventArgs e)
		{
			//Abre a aba Cadastro de carro
			this.Hide();
			cadastroCarros.ShowDialog();
			this.Show();
		}
		void OrdemServicoClick(object sender, EventArgs e)
		{
			//Abre a aba de geração de Ordem de Serviço
			this.Hide();
			osGen.ShowDialog();
			this.Show();	
		}
		void Button1Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		
		

	}
}
