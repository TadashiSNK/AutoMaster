using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace AutoMaster
{

	public partial class OrdemDeServico : Form
	{
		public OrdemDeServico()
		{
			InitializeComponent();
			
		}
		
		
		
		
		
		void Button1Click(object sender, EventArgs e)
		{
			this.Close();
		}
		void OrdemDeServicoLoad(object sender, EventArgs e)
		{
			carros.LoadFile("Carros.txt", RichTextBoxStreamType.PlainText);
			clientes.LoadFile("Usuarios.txt", RichTextBoxStreamType.PlainText);
			getCarros(carros);
			getClientes(clientes);
			this.Size = new Size(479, 719);
			
			
		}
		
		
		
		
		
		
		
		void getCarros(RichTextBox users)
		{
			
			carrosFilter.Text = "";
			for(int i = 0; i<users.Lines.Length -1 ; i++)
			{
				string[] dados = users.Lines[i].Split('&');
				string modelo = dados[0];
				string dono = dados[1];
				carrosFilter.Text += modelo + "\t" + dono + "\n";

			}
		}
		
		
		void getClientes(RichTextBox users)
		{
			clienteComboBox.Items.Clear();
			clientesFilter.Text = "";
			for(int i = 0; i<users.Lines.Length -1 ; i++)
			{
				string[] dados = users.Lines[i].Split('&');
				string cliente = dados[0];
				string carro = dados[1];
				clientesFilter.Text += cliente + "\t" + carro + "\n";
				clienteComboBox.Items.Add(cliente);

			}
		}
		
		
		void ClienteComboBoxDropDown(object sender, EventArgs e)
		{
			
		}
		void ClienteComboBoxDropDownClosed(object sender, EventArgs e)
		{
			carroComboBox.Items.Clear();
			for(int i = 0; i<carrosFilter.Lines.Length -1 ; i++)
			{
				string[] dados = carrosFilter.Lines[i].Split('\t');
				if (dados[1] == clienteComboBox.Text)
				{
					carroComboBox.Items.Add(dados[0]);
				}
			}
		}
		void Button2Click(object sender, EventArgs e)
		{
			string anotacoesHtml = richTextBox1.Text.Replace("\n", "<br>");
			
			htmlbox.Text = 
"<!DOCTYPE html>" +
"<html lang=\"en\">" +
"<head>" +
"<meta charset=\"UTF-8\">" +
"<meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">" +
"<link rel=\"stylesheet\" href=\"./template.css\">" +
"<title>Ordem de Serviço</title>" +
"</head>" +
"<body class=\"flex-center\">" +
"<div class=\"container border flex-center\">" +
"<img class=\"logo\" src=\"./logo.png\">" +
"<p class=\"lineBreak border\"></p>" +
"<div class=\"block\">" +
"<p class=\"bold\">Cliente: " + clienteComboBox.Text + "</p>" +
"<p class=\"bold\">Carro: " + carroComboBox.Text + "</p>" +
"<p class=\"bold\">Anotacoes: " + anotacoesHtml + "</p>" +
"<p class=\"bold\">Preco R$: " + precoText.Text + ".00" + "</p>" +
"</div></div></body></html>";
			htmlbox.SaveFile("OS.html", RichTextBoxStreamType.PlainText);
		}
		
	}
}
