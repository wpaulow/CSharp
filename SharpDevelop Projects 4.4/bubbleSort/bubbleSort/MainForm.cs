/*
 * Created by SharpDevelop.
 * User: aluno.etec
 * Date: 13/03/2019
 * Time: 19:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace bubbleSort
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			string [] s= {"Bruno", "Carlos", "Alvaro", "Gabriel", "Raquel", "Julia", "Pedro", "Beatriz", "Aline", "Monica"};
			
			for (int j=0; j<9; j++)
				for (int i=0; i<9; i++)
				{
					string aux="";
					if (s[i].CompareTo(s[i+1])>=0)
					{
						aux=s[i];
						s[i]=s[i+1];
						s[i+1]=aux;
					}
				}
			
			listBox1.Items.Clear();
			for (int i=0; i<10; i++)
				listBox1.Items.Add(s[i]);
		}
	}
}
