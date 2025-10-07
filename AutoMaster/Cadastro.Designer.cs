/*
 * Created by SharpDevelop.
 * User: Tadashi
 * Date: 06/10/2025
 * Time: 21:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AutoMaster
{
	partial class Cadastro
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox nomeText;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox cpfText;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox telText;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cargoComboBox;
		private System.Windows.Forms.ComboBox TurnoComboBox;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button cadastrarUsuario;
		private System.Windows.Forms.Button button1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.nomeText = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cpfText = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.telText = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.cargoComboBox = new System.Windows.Forms.ComboBox();
			this.TurnoComboBox = new System.Windows.Forms.ComboBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.cadastrarUsuario = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
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
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 241);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(353, 37);
			this.label1.TabIndex = 3;
			this.label1.Text = "Cadastro de usuários:";
			// 
			// nomeText
			// 
			this.nomeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nomeText.Location = new System.Drawing.Point(133, 301);
			this.nomeText.Name = "nomeText";
			this.nomeText.Size = new System.Drawing.Size(296, 26);
			this.nomeText.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(17, 301);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 29);
			this.label2.TabIndex = 5;
			this.label2.Text = "Nome:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(17, 350);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 29);
			this.label3.TabIndex = 7;
			this.label3.Text = "CPF:";
			// 
			// cpfText
			// 
			this.cpfText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cpfText.Location = new System.Drawing.Point(133, 350);
			this.cpfText.Name = "cpfText";
			this.cpfText.Size = new System.Drawing.Size(296, 26);
			this.cpfText.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(17, 409);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(116, 29);
			this.label4.TabIndex = 9;
			this.label4.Text = "Telefone:";
			// 
			// telText
			// 
			this.telText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.telText.Location = new System.Drawing.Point(133, 409);
			this.telText.Name = "telText";
			this.telText.Size = new System.Drawing.Size(296, 26);
			this.telText.TabIndex = 8;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(17, 516);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(83, 29);
			this.label6.TabIndex = 13;
			this.label6.Text = "Turno:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(17, 466);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(85, 29);
			this.label7.TabIndex = 11;
			this.label7.Text = "Cargo:";
			// 
			// cargoComboBox
			// 
			this.cargoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cargoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.cargoComboBox.FormattingEnabled = true;
			this.cargoComboBox.Items.AddRange(new object[] {
			"Cliente",
			"Gerente",
			"Mecânico",
			"Atendente"});
			this.cargoComboBox.Location = new System.Drawing.Point(133, 467);
			this.cargoComboBox.Name = "cargoComboBox";
			this.cargoComboBox.Size = new System.Drawing.Size(296, 28);
			this.cargoComboBox.TabIndex = 14;
			this.cargoComboBox.SelectedValueChanged += new System.EventHandler(this.ComboBox1SelectedValueChanged);
			// 
			// TurnoComboBox
			// 
			this.TurnoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.TurnoComboBox.Enabled = false;
			this.TurnoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.TurnoComboBox.FormattingEnabled = true;
			this.TurnoComboBox.Items.AddRange(new object[] {
			"",
			"Manhã",
			"Tarde"});
			this.TurnoComboBox.Location = new System.Drawing.Point(133, 517);
			this.TurnoComboBox.Name = "TurnoComboBox";
			this.TurnoComboBox.Size = new System.Drawing.Size(296, 28);
			this.TurnoComboBox.TabIndex = 15;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(570, 12);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(407, 237);
			this.richTextBox1.TabIndex = 16;
			this.richTextBox1.Text = "";
			// 
			// cadastrarUsuario
			// 
			this.cadastrarUsuario.BackColor = System.Drawing.Color.MintCream;
			this.cadastrarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.cadastrarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
			this.cadastrarUsuario.FlatAppearance.BorderSize = 5;
			this.cadastrarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
			this.cadastrarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
			this.cadastrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cadastrarUsuario.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cadastrarUsuario.Location = new System.Drawing.Point(23, 570);
			this.cadastrarUsuario.Name = "cadastrarUsuario";
			this.cadastrarUsuario.Size = new System.Drawing.Size(139, 53);
			this.cadastrarUsuario.TabIndex = 18;
			this.cadastrarUsuario.Text = "Cadastrar";
			this.cadastrarUsuario.UseVisualStyleBackColor = false;
			this.cadastrarUsuario.Click += new System.EventHandler(this.CadastrarUsuarioClick);
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
			this.button1.Location = new System.Drawing.Point(290, 570);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(139, 53);
			this.button1.TabIndex = 19;
			this.button1.Text = "Voltar";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// Cadastro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(989, 680);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.cadastrarUsuario);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.TurnoComboBox);
			this.Controls.Add(this.cargoComboBox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.telText);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cpfText);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.nomeText);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Cadastro";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CadastroFormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadastroFormClosed);
			this.Load += new System.EventHandler(this.CadastroLoad);
			this.Shown += new System.EventHandler(this.CadastroLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
