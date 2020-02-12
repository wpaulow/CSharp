/*
 * Created by SharpDevelop.
 * User: aluno.etec
 * Date: 13/02/2019
 * Time: 22:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace vetores
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			int [] n = new int [10];
			n[0] = 5;
			n[1] = 0;
			n[2] = 2;
			n[3] = 7;
			n[4] = 10;
			n[5] = 3;
			n[6] = -1;
			n[7] = -10;
			n[8] = 1;
			n[9] = 4;
			
			textBox1.Text=n[0].ToString();
			textBox2.Text=n[1].ToString();
			textBox3.Text=n[2].ToString();
			textBox4.Text=n[3].ToString();
			textBox5.Text=n[4].ToString();
			textBox6.Text=n[5].ToString();
			textBox7.Text=n[6].ToString();
			textBox8.Text=n[7].ToString();
			textBox9.Text=n[8].ToString();
			textBox10.Text=n[9].ToString();
		}
		void Button2Click(object sender, EventArgs e)
		{
			int [] n = new int [10];
			n[0] = 5;
			n[1] = 0;
			n[2] = 2;
			n[3] = 7;
			n[4] = 10;
			n[5] = 3;
			n[6] = -1;
			n[7] = -10;
			n[8] = 1;
			n[9] = 4;
			
			int a = n [3] + n[4];
			textBox11.Text = a.ToString();
		}
		void Button3Click(object sender, EventArgs e)
		{
			int [] n = new int [10];
			n[0] = 5;
			n[1] = 0;
			n[2] = 2;
			n[3] = 7;
			n[4] = 10;
			n[5] = 3;
			n[6] = -1;
			n[7] = -10;
			n[8] = 1;
			n[9] = 4;
			
			int b = n [3+4];
			textBox12.Text = b.ToString();
		}
		void Button4Click(object sender, EventArgs e)
		{
			int [] n = new int [10];
			n[0] = 5;
			n[1] = 0;
			n[2] = 2;
			n[3] = 7;
			n[4] = 10;
			n[5] = 3;
			n[6] = -1;
			n[7] = -10;
			n[8] = 1;
			n[9] = 4;
			
			int c = n[2] * n[6+3];
			textBox13.Text = c.ToString();
		}
		void Button5Click(object sender, EventArgs e)
		{
			int [] n = new int [10];
			n[0] = 5;
			n[1] = 0;
			n[2] = 2;
			n[3] = 7;
			n[4] = 10;
			n[5] = 3;
			n[6] = -1;
			n[7] = -10;
			n[8] = 1;
			n[9] = 4;
			
			int d = n[4] * n[5] - n[7];
			textBox14.Text = d.ToString();
		}
		void Button6Click(object sender, EventArgs e)
		{
			int [] n = new int [10];
			n[0] = 5;
			n[1] = 0;
			n[2] = 2;
			n[3] = 7;
			n[4] = 10;
			n[5] = 3;
			n[6] = -1;
			n[7] = -10;
			n[8] = 1;
			n[9] = 4;
			
			int e1 = n[n[5]] + n[n[0]];
			textBox15.Text = e1.ToString();
		}
		void Button7Click(object sender, EventArgs e)
		{
			int [] n = new int [10];
			n[0] = 5;
			n[1] = 0;
			n[2] = 2;
			n[3] = 7;
			n[4] = 10;
			n[5] = 3;
			n[6] = -1;
			n[7] = -10;
			n[8] = 1;
			n[9] = 4;
			
			int f = n[n[1]] * n[n[4]-n[9]];
			textBox16.Text = f.ToString();
		}
		void Button8Click(object sender, EventArgs e)
		{
			int [] n = new int [10];
			n[0] = 5;
			n[1] = 0;
			n[2] = 2;
			n[3] = 7;
			n[4] = 10;
			n[5] = 3;
			n[6] = -1;
			n[7] = -10;
			n[8] = 1;
			n[9] = 4;
			
			int g = (n[n[3+2]]+n[n[2]])/n[n[4]+n[6]];
			textBox17.Text = g.ToString();
		}
		void Button9Click(object sender, EventArgs e)
		{
			int [] n = new int [10];
			n[0] = 5;
			n[1] = 0;
			n[2] = 2;
			n[3] = 7;
			n[4] = 10;
			n[5] = 3;
			n[6] = -1;
			n[7] = -10;
			n[8] = 1;
			n[9] = 4;
			
			int h = n[n[n[1]]]+n[n[n[5]]];
			textBox18.Text = h.ToString();
	
		}
		void Button10Click(object sender, EventArgs e)
		{
			int [] n = new int [10];
			n[0] = 5;
			n[1] = 0;
			n[2] = 2;
			n[3] = 7;
			n[4] = 10;
			n[5] = 3;
			n[6] = -1;
			n[7] = -10;
			n[8] = 1;
			n[9] = 4;
			
			int i = n[n[n[1]]]+n[n[n[5]]];
			textBox19.Text = i.ToString();
		}
		
		
	}
}
