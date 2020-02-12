/*
 * Created by SharpDevelop.
 * User: PC
 * Date: 14/09/2018
 * Time: 15:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace LeninMovimento
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox fundo;
		private System.Windows.Forms.PictureBox lenin;
		private System.Windows.Forms.Button btn1;
		private System.Windows.Forms.Button btn2;
		
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
			this.fundo = new System.Windows.Forms.PictureBox();
			this.lenin = new System.Windows.Forms.PictureBox();
			this.btn1 = new System.Windows.Forms.Button();
			this.btn2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.fundo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lenin)).BeginInit();
			this.SuspendLayout();
			// 
			// fundo
			// 
			this.fundo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.fundo.Image = ((System.Drawing.Image)(resources.GetObject("fundo.Image")));
			this.fundo.Location = new System.Drawing.Point(106, 1);
			this.fundo.Name = "fundo";
			this.fundo.Size = new System.Drawing.Size(700, 500);
			this.fundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.fundo.TabIndex = 0;
			this.fundo.TabStop = false;
			// 
			// lenin
			// 
			this.lenin.BackColor = System.Drawing.Color.Transparent;
			this.lenin.Image = ((System.Drawing.Image)(resources.GetObject("lenin.Image")));
			this.lenin.Location = new System.Drawing.Point(556, 201);
			this.lenin.Name = "lenin";
			this.lenin.Size = new System.Drawing.Size(250, 300);
			this.lenin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.lenin.TabIndex = 1;
			this.lenin.TabStop = false;
			// 
			// btn1
			// 
			this.btn1.BackColor = System.Drawing.Color.Transparent;
			this.btn1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn1.BackgroundImage")));
			this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btn1.Location = new System.Drawing.Point(286, 529);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(120, 50);
			this.btn1.TabIndex = 2;
			this.btn1.UseVisualStyleBackColor = false;
			this.btn1.Click += new System.EventHandler(this.Btn1Click);
			// 
			// btn2
			// 
			this.btn2.BackColor = System.Drawing.Color.Transparent;
			this.btn2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn2.BackgroundImage")));
			this.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btn2.Location = new System.Drawing.Point(462, 529);
			this.btn2.Name = "btn2";
			this.btn2.Size = new System.Drawing.Size(120, 50);
			this.btn2.TabIndex = 3;
			this.btn2.UseVisualStyleBackColor = false;
			this.btn2.Click += new System.EventHandler(this.Btn2Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(884, 661);
			this.Controls.Add(this.btn2);
			this.Controls.Add(this.btn1);
			this.Controls.Add(this.lenin);
			this.Controls.Add(this.fundo);
			this.Name = "MainForm";
			this.Text = "LeninMovimento";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.fundo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lenin)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
