/*
 * Created by SharpDevelop.
 * User: Tadashi
 * Date: 06/10/2025
 * Time: 23:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AutoMaster
{
	partial class Carros
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox placaText;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox modeloText;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox corText;
		private System.Windows.Forms.Button CadastrarCarro;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.RichTextBox usuariosLoad;
		private System.Windows.Forms.ComboBox donoComboBox;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carros));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.placaText = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.modeloText = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.corText = new System.Windows.Forms.TextBox();
			this.CadastrarCarro = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.donoComboBox = new System.Windows.Forms.ComboBox();
			this.usuariosLoad = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(23, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(406, 204);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(28, 464);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(58, 29);
			this.label7.TabIndex = 23;
			this.label7.Text = "Cor:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(28, 407);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(79, 29);
			this.label4.TabIndex = 22;
			this.label4.Text = "Placa:";
			// 
			// placaText
			// 
			this.placaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.placaText.Location = new System.Drawing.Point(144, 407);
			this.placaText.Name = "placaText";
			this.placaText.Size = new System.Drawing.Size(296, 26);
			this.placaText.TabIndex = 21;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(28, 348);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 29);
			this.label3.TabIndex = 20;
			this.label3.Text = "Dono:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(28, 299);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(101, 29);
			this.label2.TabIndex = 18;
			this.label2.Text = "Modelo:";
			// 
			// modeloText
			// 
			this.modeloText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.modeloText.Location = new System.Drawing.Point(144, 299);
			this.modeloText.Name = "modeloText";
			this.modeloText.Size = new System.Drawing.Size(296, 26);
			this.modeloText.TabIndex = 17;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(23, 239);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(319, 37);
			this.label1.TabIndex = 16;
			this.label1.Text = "Cadastro de carros:";
			// 
			// corText
			// 
			this.corText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.corText.Location = new System.Drawing.Point(144, 467);
			this.corText.Name = "corText";
			this.corText.Size = new System.Drawing.Size(296, 26);
			this.corText.TabIndex = 27;
			// 
			// CadastrarCarro
			// 
			this.CadastrarCarro.BackColor = System.Drawing.Color.MintCream;
			this.CadastrarCarro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.CadastrarCarro.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
			this.CadastrarCarro.FlatAppearance.BorderSize = 5;
			this.CadastrarCarro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
			this.CadastrarCarro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
			this.CadastrarCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CadastrarCarro.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CadastrarCarro.Location = new System.Drawing.Point(28, 517);
			this.CadastrarCarro.Name = "CadastrarCarro";
			this.CadastrarCarro.Size = new System.Drawing.Size(139, 65);
			this.CadastrarCarro.TabIndex = 28;
			this.CadastrarCarro.Text = "Cadastrar Carro";
			this.CadastrarCarro.UseVisualStyleBackColor = false;
			this.CadastrarCarro.Click += new System.EventHandler(this.CadastrarCarroClick);
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
			this.button1.Location = new System.Drawing.Point(301, 517);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(139, 65);
			this.button1.TabIndex = 29;
			this.button1.Text = "Voltar";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(620, 39);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(407, 237);
			this.richTextBox1.TabIndex = 30;
			this.richTextBox1.Text = "";
			// 
			// donoComboBox
			// 
			this.donoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.donoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.donoComboBox.FormattingEnabled = true;
			this.donoComboBox.Location = new System.Drawing.Point(144, 349);
			this.donoComboBox.Name = "donoComboBox";
			this.donoComboBox.Size = new System.Drawing.Size(296, 28);
			this.donoComboBox.TabIndex = 31;
			// 
			// usuariosLoad
			// 
			this.usuariosLoad.Location = new System.Drawing.Point(620, 345);
			this.usuariosLoad.Name = "usuariosLoad";
			this.usuariosLoad.Size = new System.Drawing.Size(407, 237);
			this.usuariosLoad.TabIndex = 32;
			this.usuariosLoad.Text = "";
			// 
			// Carros
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1078, 611);
			this.Controls.Add(this.usuariosLoad);
			this.Controls.Add(this.donoComboBox);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.CadastrarCarro);
			this.Controls.Add(this.corText);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.placaText);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.modeloText);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Carros";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Carros";
			this.Load += new System.EventHandler(this.CarrosLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
