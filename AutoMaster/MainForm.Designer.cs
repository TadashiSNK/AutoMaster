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
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		
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
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
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
			this.button2.Location = new System.Drawing.Point(23, 299);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(208, 71);
			this.button2.TabIndex = 3;
			this.button2.Text = "Cadastrar carro";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.MintCream;
			this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button3.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
			this.button3.FlatAppearance.BorderSize = 5;
			this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
			this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(23, 376);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(208, 71);
			this.button3.TabIndex = 4;
			this.button3.Text = "Emitir ordem de Serviço";
			this.button3.UseVisualStyleBackColor = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(904, 599);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.userbtn);
			this.Controls.Add(this.pictureBox1);
			this.Name = "MainForm";
			this.Text = "AutoMaster";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
