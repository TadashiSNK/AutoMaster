/*
 * Created by SharpDevelop.
 * User: Tadashi
 * Date: 06/10/2025
 * Time: 21:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AutoMaster
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button userbtn;
		private System.Windows.Forms.Button cadastrarCarro;
		private System.Windows.Forms.Button ordemServico;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.userbtn = new System.Windows.Forms.Button();
			this.cadastrarCarro = new System.Windows.Forms.Button();
			this.ordemServico = new System.Windows.Forms.Button();
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
			this.pictureBox1.Size = new System.Drawing.Size(208, 204);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// userbtn
			// 
			this.userbtn.BackColor = System.Drawing.Color.MintCream;
			this.userbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.userbtn.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
			this.userbtn.FlatAppearance.BorderSize = 5;
			this.userbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
			this.userbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
			this.userbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.userbtn.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.userbtn.Location = new System.Drawing.Point(23, 222);
			this.userbtn.Name = "userbtn";
			this.userbtn.Size = new System.Drawing.Size(208, 71);
			this.userbtn.TabIndex = 2;
			this.userbtn.Text = "Cadastrar usuários";
			this.userbtn.UseVisualStyleBackColor = false;
			this.userbtn.Click += new System.EventHandler(this.UserbtnClick);
			// 
			// cadastrarCarro
			// 
			this.cadastrarCarro.BackColor = System.Drawing.Color.MintCream;
			this.cadastrarCarro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.cadastrarCarro.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
			this.cadastrarCarro.FlatAppearance.BorderSize = 5;
			this.cadastrarCarro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
			this.cadastrarCarro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
			this.cadastrarCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cadastrarCarro.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cadastrarCarro.Location = new System.Drawing.Point(23, 299);
			this.cadastrarCarro.Name = "cadastrarCarro";
			this.cadastrarCarro.Size = new System.Drawing.Size(208, 71);
			this.cadastrarCarro.TabIndex = 3;
			this.cadastrarCarro.Text = "Cadastrar carro";
			this.cadastrarCarro.UseVisualStyleBackColor = false;
			this.cadastrarCarro.Click += new System.EventHandler(this.CadastrarCarroClick);
			// 
			// ordemServico
			// 
			this.ordemServico.BackColor = System.Drawing.Color.MintCream;
			this.ordemServico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ordemServico.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
			this.ordemServico.FlatAppearance.BorderSize = 5;
			this.ordemServico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
			this.ordemServico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
			this.ordemServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ordemServico.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ordemServico.Location = new System.Drawing.Point(23, 376);
			this.ordemServico.Name = "ordemServico";
			this.ordemServico.Size = new System.Drawing.Size(208, 71);
			this.ordemServico.TabIndex = 4;
			this.ordemServico.Text = "Emitir ordem de Serviço";
			this.ordemServico.UseVisualStyleBackColor = false;
			this.ordemServico.Click += new System.EventHandler(this.OrdemServicoClick);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Coral;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
			this.button1.FlatAppearance.BorderSize = 5;
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(23, 516);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(208, 71);
			this.button1.TabIndex = 5;
			this.button1.Text = "Sair";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(259, 599);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.ordemServico);
			this.Controls.Add(this.cadastrarCarro);
			this.Controls.Add(this.userbtn);
			this.Controls.Add(this.pictureBox1);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AutoMaster";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
