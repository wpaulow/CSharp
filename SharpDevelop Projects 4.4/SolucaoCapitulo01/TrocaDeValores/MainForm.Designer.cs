/*
 * Created by SharpDevelop.
 * User: wesley
 * Date: 03/04/2019
 * Time: 16:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TrocaDeValores
{
	partial class frmTrocaDeValores
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtPrimeiroValor = new System.Windows.Forms.TextBox();
			this.txtSegundoValor = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(25, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Valor 1:";
			// 
			// txtPrimeiroValor
			// 
			this.txtPrimeiroValor.Location = new System.Drawing.Point(12, 43);
			this.txtPrimeiroValor.Name = "txtPrimeiroValor";
			this.txtPrimeiroValor.Size = new System.Drawing.Size(70, 20);
			this.txtPrimeiroValor.TabIndex = 1;
			// 
			// txtSegundoValor
			// 
			this.txtSegundoValor.Location = new System.Drawing.Point(177, 43);
			this.txtSegundoValor.Name = "txtSegundoValor";
			this.txtSegundoValor.Size = new System.Drawing.Size(70, 20);
			this.txtSegundoValor.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(84, 71);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(91, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "Trocar Valores";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(188, 27);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Valor 2:";
			// 
			// frmTrocaDeValores
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(259, 106);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtSegundoValor);
			this.Controls.Add(this.txtPrimeiroValor);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "frmTrocaDeValores";
			this.Text = "Troca de Valores";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtSegundoValor;
		private System.Windows.Forms.TextBox txtPrimeiroValor;
		private System.Windows.Forms.Label label1;
		
		
		
		void Button1Click(object sender, System.EventArgs e)
		{
						
		}
	}
}
