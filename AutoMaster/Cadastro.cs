/*
 * Created by SharpDevelop.
 * User: Tadashi
 * Date: 06/10/2025
 * Time: 21:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AutoMaster
{
	/// <summary>
	/// Description of Cadastro.
	/// </summary>
	public partial class Cadastro : Form
	{
		public Cadastro()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void ComboBox1SelectedValueChanged(object sender, EventArgs e)
		{
			if (cargoComboBox.Text != "Cliente")
			{
				TurnoComboBox.Enabled = true;
			}
			else
			{
				TurnoComboBox.SelectedItem = null;
				TurnoComboBox.Enabled = false;
			}
			
//			if (comboBox1.Text == "Cliente"){
//				this.Size = new Size(947, 719);
//			}
//			else
//			{
//				this.Size = new Size(479, 719);
//			}
		}
		void CadastroLoad(object sender, EventArgs e)
		{
			this.Size = new Size(479, 719);
		}
		void CadastrarUsuarioClick(object sender, EventArgs e)
		{
			string nome = nomeText.Text.ToString();
			string cpf = cpfText.Text.ToString();
			string telefone = telText.Text.ToString();
			string cargo = cargoComboBox.Text.ToString();
			string turno = TurnoComboBox.Text.ToString();
			
			richTextBox1.Text += nome + "\t" + cpf + "\t" + telefone + "\t" + cargo + "\t" + turno + "\n";
		}
	}
}
