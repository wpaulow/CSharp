/*
 * Created by SharpDevelop.
 * User: aluno.etec
 * Date: 27/02/2019
 * Time: 20:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace vetores2
{
	partial class MainForm
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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.listBox3 = new System.Windows.Forms.ListBox();
			this.button3 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.listBox4 = new System.Windows.Forms.ListBox();
			this.button4 = new System.Windows.Forms.Button();
			this.listBox5 = new System.Windows.Forms.ListBox();
			this.button5 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(32, 72);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(75, 290);
			this.listBox1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Black;
			this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button1.Location = new System.Drawing.Point(32, 382);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 48);
			this.button1.TabIndex = 1;
			this.button1.Text = "LISTAR 1";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Black;
			this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button2.Location = new System.Drawing.Point(131, 382);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 48);
			this.button2.TabIndex = 2;
			this.button2.Text = "LISTAR 2";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// listBox2
			// 
			this.listBox2.FormattingEnabled = true;
			this.listBox2.Location = new System.Drawing.Point(131, 72);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(75, 290);
			this.listBox2.TabIndex = 3;
			// 
			// listBox3
			// 
			this.listBox3.FormattingEnabled = true;
			this.listBox3.Location = new System.Drawing.Point(225, 72);
			this.listBox3.Name = "listBox3";
			this.listBox3.Size = new System.Drawing.Size(75, 290);
			this.listBox3.TabIndex = 4;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Black;
			this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button3.Location = new System.Drawing.Point(225, 382);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 48);
			this.button3.TabIndex = 5;
			this.button3.Text = "LISTAR 3";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(225, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(389, 46);
			this.label1.TabIndex = 6;
			this.label1.Text = "VETORES e INDEXAÇÃO";
			// 
			// listBox4
			// 
			this.listBox4.FormattingEnabled = true;
			this.listBox4.Location = new System.Drawing.Point(320, 72);
			this.listBox4.Name = "listBox4";
			this.listBox4.Size = new System.Drawing.Size(75, 290);
			this.listBox4.TabIndex = 7;
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Black;
			this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button4.Location = new System.Drawing.Point(320, 382);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 48);
			this.button4.TabIndex = 8;
			this.button4.Text = "LISTAR 4";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// listBox5
			// 
			this.listBox5.FormattingEnabled = true;
			this.listBox5.Location = new System.Drawing.Point(425, 72);
			this.listBox5.Name = "listBox5";
			this.listBox5.Size = new System.Drawing.Size(126, 290);
			this.listBox5.TabIndex = 9;
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.Black;
			this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button5.Location = new System.Drawing.Point(451, 382);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 48);
			this.button5.TabIndex = 10;
			this.button5.Text = "STRINGAR";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Ivory;
			this.ClientSize = new System.Drawing.Size(811, 460);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.listBox5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.listBox4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.listBox3);
			this.Controls.Add(this.listBox2);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.listBox1);
			this.Name = "MainForm";
			this.Text = "vetores2";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.ListBox listBox5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.ListBox listBox4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.ListBox listBox3;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ListBox listBox1;
	}
}
