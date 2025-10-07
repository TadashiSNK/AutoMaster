/*
 * Created by SharpDevelop.
 * User: Tadashi
 * Date: 06/10/2025
 * Time: 23:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AutoMaster
{
	partial class OrdemDeServico
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.ComboBox carroComboBox;
		private System.Windows.Forms.ComboBox clienteComboBox;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.RichTextBox carros;
		private System.Windows.Forms.RichTextBox clientes;
		private System.Windows.Forms.RichTextBox carrosFilter;
		private System.Windows.Forms.RichTextBox clientesFilter;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RichTextBox htmlbox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox precoText;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdemDeServico));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.precoText = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.carroComboBox = new System.Windows.Forms.ComboBox();
			this.clienteComboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.carros = new System.Windows.Forms.RichTextBox();
			this.clientes = new System.Windows.Forms.RichTextBox();
			this.carrosFilter = new System.Windows.Forms.RichTextBox();
			this.clientesFilter = new System.Windows.Forms.RichTextBox();
			this.htmlbox = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(27, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(406, 204);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.precoText);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.richTextBox1);
			this.panel1.Controls.Add(this.carroComboBox);
			this.panel1.Controls.Add(this.clienteComboBox);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(27, 229);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(405, 421);
			this.panel1.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(61, 170);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(81, 16);
			this.label5.TabIndex = 41;
			this.label5.Text = "Total (R$):";
			// 
			// precoText
			// 
			this.precoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.precoText.Location = new System.Drawing.Point(153, 164);
			this.precoText.Name = "precoText";
			this.precoText.Size = new System.Drawing.Size(193, 26);
			this.precoText.TabIndex = 40;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(61, 119);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 16);
			this.label4.TabIndex = 39;
			this.label4.Text = "Carro";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(61, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 16);
			this.label3.TabIndex = 38;
			this.label3.Text = "Cliente";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.MintCream;
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button2.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
			this.button2.FlatAppearance.BorderSize = 5;
			this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
			this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(50, 353);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(134, 44);
			this.button2.TabIndex = 37;
			this.button2.Text = "Gerar OS";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.MintCream;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
			this.button1.FlatAppearance.BorderSize = 5;
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(212, 353);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(134, 44);
			this.button1.TabIndex = 36;
			this.button1.Text = "Voltar";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(50, 197);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 16);
			this.label2.TabIndex = 35;
			this.label2.Text = "Anotações:";
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(50, 216);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(296, 131);
			this.richTextBox1.TabIndex = 34;
			this.richTextBox1.Text = "";
			// 
			// carroComboBox
			// 
			this.carroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.carroComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.carroComboBox.FormattingEnabled = true;
			this.carroComboBox.Location = new System.Drawing.Point(153, 113);
			this.carroComboBox.Name = "carroComboBox";
			this.carroComboBox.Size = new System.Drawing.Size(193, 28);
			this.carroComboBox.TabIndex = 33;
			// 
			// clienteComboBox
			// 
			this.clienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.clienteComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.clienteComboBox.FormattingEnabled = true;
			this.clienteComboBox.Location = new System.Drawing.Point(153, 56);
			this.clienteComboBox.Name = "clienteComboBox";
			this.clienteComboBox.Size = new System.Drawing.Size(193, 28);
			this.clienteComboBox.TabIndex = 32;
			this.clienteComboBox.DropDown += new System.EventHandler(this.ClienteComboBoxDropDown);
			this.clienteComboBox.DropDownClosed += new System.EventHandler(this.ClienteComboBoxDropDownClosed);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(50, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(289, 37);
			this.label1.TabIndex = 4;
			this.label1.Text = "Ordem de Serviço";
			// 
			// carros
			// 
			this.carros.Location = new System.Drawing.Point(534, 71);
			this.carros.Name = "carros";
			this.carros.Size = new System.Drawing.Size(296, 131);
			this.carros.TabIndex = 38;
			this.carros.Text = "";
			// 
			// clientes
			// 
			this.clientes.Location = new System.Drawing.Point(576, 426);
			this.clientes.Name = "clientes";
			this.clientes.Size = new System.Drawing.Size(296, 131);
			this.clientes.TabIndex = 39;
			this.clientes.Text = "";
			// 
			// carrosFilter
			// 
			this.carrosFilter.Location = new System.Drawing.Point(849, 71);
			this.carrosFilter.Name = "carrosFilter";
			this.carrosFilter.Size = new System.Drawing.Size(296, 131);
			this.carrosFilter.TabIndex = 40;
			this.carrosFilter.Text = "";
			// 
			// clientesFilter
			// 
			this.clientesFilter.Location = new System.Drawing.Point(878, 425);
			this.clientesFilter.Name = "clientesFilter";
			this.clientesFilter.Size = new System.Drawing.Size(296, 131);
			this.clientesFilter.TabIndex = 41;
			this.clientesFilter.Text = "";
			// 
			// htmlbox
			// 
			this.htmlbox.Location = new System.Drawing.Point(585, 245);
			this.htmlbox.Name = "htmlbox";
			this.htmlbox.Size = new System.Drawing.Size(296, 131);
			this.htmlbox.TabIndex = 42;
			this.htmlbox.Text = "";
			// 
			// OrdemDeServico
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1157, 680);
			this.Controls.Add(this.htmlbox);
			this.Controls.Add(this.clientesFilter);
			this.Controls.Add(this.carrosFilter);
			this.Controls.Add(this.clientes);
			this.Controls.Add(this.carros);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "OrdemDeServico";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "OrdemDeServico";
			this.Load += new System.EventHandler(this.OrdemDeServicoLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
