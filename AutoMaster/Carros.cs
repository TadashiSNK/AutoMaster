using System;
using System.Drawing;
using System.Windows.Forms;

namespace AutoMaster
{

	public partial class Carros : Form
	{
		public Carros()
		{
			InitializeComponent();
		}
		
		void CarrosLoad(object sender, EventArgs e)
		{
			this.Size = new Size(479, 719);
			usuariosLoad.LoadFile("Usuarios.txt", RichTextBoxStreamType.PlainText);
			richTextBox1.LoadFile("Carros.txt", RichTextBoxStreamType.PlainText);
			splitUsers(usuariosLoad);
		}
		
		
		void Button1Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		
		
		void CadastrarCarroClick(object sender, EventArgs e)
		{
			string modelo = modeloText.Text;
			string dono = donoComboBox.Text;
			string placa = placaText.Text;
			string cor = corText.Text;
			
			richTextBox1.Text += modelo + "&" + dono + "&" + placa + "&" + cor + "\n";
			richTextBox1.SaveFile("Carros.txt", RichTextBoxStreamType.PlainText);
			
		}

		
		void splitUsers(RichTextBox users)
		{
			for(int i = 0; i<users.Lines.Length; i++)
			{
				string[] dados = users.Lines[i].Split('&');
				donoComboBox.Items.Add(dados[0]);
				
				
				
			}
		}
		
		
		
	}
}
